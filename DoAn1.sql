CREATE DATABASE DoAn1
GO
USE DoAn1

CREATE TABLE phanquyen
(
	Maquyen INT PRIMARY KEY,
	Tenquyen NVARCHAR(100) NOT NULL,
)

CREATE TABLE loaisanpham
(
	Maloai CHAR(10) PRIMARY KEY,
	Tenloai NVARCHAR(100) NOT NULL
)

CREATE TABLE nhacungcap
(
	MaNCC CHAR(10) PRIMARY KEY,
	TenNCC NVARCHAR(MAX) NOT NULL,
	Diachi NVARCHAR(MAX) NOT NULL,
	Sodienthoai CHAR(10) NOT NULL,
	Email VARCHAR(100) NOT NULL
)

CREATE TABLE khachhang
(
	MaKH CHAR(10) PRIMARY KEY,
	TenKH NVARCHAR(100) NOT NULL,
	Gioitinh NVARCHAR(5) NOT NULL,
	Diachi NVARCHAR(MAX) NOT NULL,
	Sdt CHAR(10) NOT NULL
)

CREATE TABLE nhanvien
(
	MaNV CHAR(10) PRIMARY KEY,
	TenNV NVARCHAR(100) NOT NULL,
	GioitinhNV NVARCHAR(5) NOT NULL,
	NgaysinhNV DATE NOT NULL,
	DiachiNV NVARCHAR(MAX) NOT NULL,
	SdtNV CHAR(10) NOT NULL,
	Tenquyen NVARCHAR(100) NOT NULL
)

CREATE TABLE taikhoan
(
	MaNV CHAR(10) PRIMARY KEY,
	FOREIGN KEY (MaNV) REFERENCES nhanvien(MaNV),
	Maquyen INT FOREIGN KEY (Maquyen) REFERENCES phanquyen(Maquyen),
	Tendangnhap VARCHAR(50) NOT NULL,
	Matkhau VARCHAR(30) NOT NULL,
)

CREATE TABLE sanpham
(
	MaSP CHAR(10) PRIMARY KEY,
	TenSP NVARCHAR(MAX) NOT NULL,
	Maloai CHAR(10) NOT NULL,
	MaNCC CHAR(10) NOT NULL,
	Kichthuoc NVARCHAR(100) NOT NULL,
	Xuatxu NVARCHAR(100) NOT NULL,
	Gia FLOAT CHECK (Gia > 0) NOT NULL,
	Soluong INT NOT NULL,
	Mota NVARCHAR (MAX),
	FOREIGN KEY (Maloai) REFERENCES loaisanpham(Maloai),
	FOREIGN KEY (MaNCC) REFERENCES nhacungcap(MaNCC) /*ON DELETE CASCADE ON UPDATE CASCADE*/
)

CREATE TABLE hoadonnhap 
(
	MaHDN CHAR(10) PRIMARY KEY,
	MaNV CHAR(10) FOREIGN KEY (MaNV) REFERENCES nhanvien(MaNV),
	MaNCC CHAR(10)FOREIGN KEY (MaNCC) REFERENCES nhacungcap(MaNCC),
	Tongtien FLOAT CHECK (Tongtien > 0),
	Ngaynhap DATE DEFAULT GETDATE()
)

CREATE TABLE chitiethoadonnhap
(
	MaHDN CHAR(10),
	MaSP CHAR(10),
	Soluongnhap INT CHECK (Soluongnhap > 0) NOT NULL,
	Gianhap FLOAT CHECK (Gianhap > 0) NOT NULL,
	Thanhtien FLOAT CHECK (Thanhtien > 0)NOT NULL,
	PRIMARY KEY (MaHDN, MaSP),
	FOREIGN KEY (MaHDN) REFERENCES hoadonnhap(MaHDN) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (MaSP) REFERENCES sanpham(MaSP) ON DELETE CASCADE ON UPDATE CASCADE
)

CREATE TABLE hoadonban
(
	MaHDB CHAR(10) PRIMARY KEY,
	MaNV CHAR(10) NOT NULL,
	MaKH CHAR(10) NOT NULL,
	Ngaymua DATE DEFAULT GETDATE(),
	Tongtien FLOAT CHECK (Tongtien > 0) NOT NULL,
	FOREIGN KEY (MaNV) REFERENCES nhanvien(MaNV), /*ON DELETE CASCADE ON UPDATE CASCADE*/
	FOREIGN KEY (MaKH) REFERENCES khachhang(MaKH) /*ON DELETE CASCADE ON UPDATE CASCADE*/
)

CREATE TABLE chitiethoadonban
(
	MaHDB CHAR(10),
	MaSP CHAR(10),
	Soluongban INT CHECK (Soluongban > 0) NOT NULL,
	Dongia FLOAT CHECK (Dongia > 0) NOT NULL,
	Thanhtien FLOAT CHECK (Thanhtien > 0) NOT NULL,
	PRIMARY KEY (MaHDB, MaSP),
	FOREIGN KEY (MaHDB) REFERENCES hoadonban(MaHDB)ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (MaSP) REFERENCES sanpham(MaSP) ON DELETE CASCADE ON UPDATE CASCADE
)

CREATE PROCEDURE checkdangnhap
    @Tendangnhap VARCHAR(50),
    @Matkhau VARCHAR(30)
AS
BEGIN
    DECLARE @Maquyen INT;
    DECLARE @Tenquyen NVARCHAR(100);

    -- Kiểm tra thông tin đăng nhập
    SELECT @Maquyen = Maquyen
    FROM taikhoan
    WHERE Tendangnhap = @Tendangnhap AND Matkhau = @Matkhau;

    -- Nếu thông tin đăng nhập không hợp lệ, trả về thông báo lỗi
    IF @Maquyen IS NULL
    BEGIN
        PRINT 'Thông tin đăng nhập không hợp lệ';
        RETURN;
    END

    -- Lấy thông tin quyền từ bảng phanquyen
    SELECT @Tenquyen = Tenquyen
    FROM phanquyen
    WHERE Maquyen = @Maquyen;

    -- Trả về quyền của người dùng
    SELECT @Tenquyen AS Tenquyen;
END;



CREATE TRIGGER trgPreventUpdateMaNV
ON nhanvien
INSTEAD OF UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN deleted d ON i.MaNV = d.MaNV
        WHERE i.MaNV != d.MaNV
    )
    BEGIN
        RAISERROR ('Không thể sửa mã nhân viên.', 16, 1);
        ROLLBACK;
    END
    ELSE
    BEGIN
        UPDATE nhanvien
        SET 
            TenNV = i.TenNV,
            GioitinhNV = i.GioitinhNV,
            NgaysinhNV = i.NgaysinhNV,
            DiachiNV = i.DiachiNV,
            SdtNV = i.SdtNV,
            Tenquyen = i.Tenquyen
        FROM inserted i
        WHERE nhanvien.MaNV = i.MaNV;
    END
END;
GO



INSERT INTO phanquyen(Maquyen, Tenquyen)
VALUES
	('1', N'Admin'),
	('2', N'Nhân viên')

INSERT INTO loaisanpham(Maloai, Tenloai)
VALUES 
	('L01', N'Bếp từ'),
	('L02', N'Bếp nướng không khói'),
	('L03', N'Lò nướng - Lò vi sóng'),
    ('L04', N'Máy hút mùi'),
    ('L05', N'Nồi'),
    ('L06', N'Máy rửa bát'),
	('L07', N'Dao - Thớt')

INSERT INTO nhacungcap(MaNCC, TenNCC, Diachi, Sodienthoai, Email)
VALUES 
	('NCC01', N'Công ty Cổ phần Thương mại HMH Việt Nam', N'167-169 Hoàng Cầu, Quận Đống Đa, THành phố Hà Nội', '0102571041', 'giadung@hmh.com'),
	('NCC02', N'Công ty TNHH thiết bị bếp Thiên Phú', N'58B Phan Bá Vành, Bắc Từ Liêm, Hà Nội', '0942729886', 'bichngoc6616@gmail.com'),
	('NCC03', N'Công ty TNHH FDI Kim Anh', N'Thôn Bình Yên, Xã Nam Thanh, Huyện Nam Trắc, Nam Định', '0914847485', 'doanvanquy668@gmail.com'),
	('NCC04', N'Công ty TNHH thiết bị gia dụng Hưng Thành', N'Thôn Thượng, Xã Thanh Liệt, Huyện Thanh Trì, Thành Phố Hà Nội', '0962621614', 'gdhungthanh@hgmail.com'),
	('NCC05', N'Công ty TNHH Taka Việt Nam', N'Thôn Thủy Hà, Xã Bắc Hưng, Huyện Đông Anh, Hà Nội', '1900558833', 'vietnam.taka@gmail.com')

INSERT INTO khachhang(MaKH, TenKH, Gioitinh, Diachi, Sdt)
VALUES
	('KH001', N'Nguyễn Thị Lan', N'Nữ', N'Hà Nội','0123456789'),
	('KH002', N'Trần Thị Ánh', N'Nữ', N'Hải Phòng','0543456789'),
	('KH003', N'Phạm Văn Tài', N'Nam', N'Quảng Ninh','0123456427'),
	('KH004', N'Vũ Thị Mùi', N'Nữ', N'Hưng Yên','0197356789'),
	('KH005', N'Phạm Văn Tài', N'Nam', N'Quảng Ninh','0123451554'),
	('KH006', N'Nguyễn Tuấn Kiệt', N'Nam', N'Hà Nội','0123456789'),
	('KH007', N'Nguyễn Văn Tùng', N'Nam', N'Bắc Giang','0543456789'),
	('KH008', N'Vũ Trọng Khang', N'Nam', N'Hưng Yên','0123456427'),
	('KH009', N'Nguyễn Nhật Linh', N'Nữ', N'Hưng Yên','0197356789'),
	('KH010', N'Đặng Thu Hiền', N'Nữ', N'Hưng Yên','0985451554'),
	('KH011', N'Nguyễn Văn Nam', N'Nam', N'Hà Nội', '0123456789'),
    ('KH012', N'Trần Thị Bảo', N'Nam', N'Thành phố Hồ Chí Minh', '0987654321'),
    ('KH013', N'Lê Văn Can', N'Nam', N'Đà Nẵng', '0165836789'),
	('KH014', N'Phạm Thị Dung', N'Nữ', N'Hải Phòng', '0987654181'),
    ('KH015', N'Phùng Thị Kim Chi', N'Nữ', N'Thành phố Hồ Chí Minh', '0790654321')

INSERT INTO nhanvien(MaNV, TenNV, GioitinhNV, NgaysinhNV, DiachiNV, SdtNV, Tenquyen)
VALUES
	('NV01', N'Nguyễn Mai Hoa', N'Nữ', '1994-03-12', N'Hưng Yên', '0948276471', N'Admin'),
	('NV02', N'Lương Thu Huyền', N'Nữ','1999-05-14', N'Hải Phòng', '0912763845', N'Nhân viên'),
	('NV03', N'Bùi Thị Duyên', N'Nữ', '2000-08-22', N'Nam Định', '0122987483', N'Nhân viên'),
	('NV04', N'Nguyễn Văn Hùng', N'Nam','1991-05-11', N'Hà Nội', '0987627265', N'Nhân viên'),
	('NV05', N'Nguyễn Thị Văn', N'N?', '2004-10-09', N'Sơn La', '0912327265', N'Nhân viên')

INSERT INTO taikhoan(MaNV, Maquyen, Tendangnhap, Matkhau)
VALUES
	('NV01', 1, 'phamthom', 'thompham'),
	('NV02', 2, 'luongthuhuyen', 'huyen123'),
	('NV03', 2, 'buithiduyen', 'duyen456'),
	('NV04', 2, 'nguyenvanhung', 'hung789'),
	('NV05', 2, 'nguyenthivy', 'vy1012')

INSERT INTO sanpham(MaSP, TenSP, Maloai, MaNCC, Kichthuoc, Xuatxu, Gia, Soluong, Mota)
VALUES
	('SP001', N'Bếp ba từ Bosch PUC631BB2E', 'L01', 'NCC01', '51 x 592 x 522 mm (D x R x C)', N'Tây Ban Nha', '13500000', 10, N'Công suất: 6800W. Điện áp: 220V/50Hzx. Bảo hành: 2 năm'),
	('SP002', N'Bếp ba từ kết hợp hồng ngoại CHIYODA C2', 'L01', 'NCC01', '75 x 43 x 8.5 cm (D x R x C)', N'Nhật Bản', '16800000', 10, N'Điện áp: 180 – 240V/50Hz. Công suất: 300 – 2000W. Bảo hành: 36 tháng.'),
	('SP003', N'Bếp ba từ Bosch PKF645E14E', 'L01', 'NCC02', '572 x 512 mm', N'??c', '17100000', 10, N'Công suất: 7800W. Nguồn điện: 220 – 240V / 50Hz. Bảo hành: 24 tháng.'),
	('SP004', N'Bếp điện từ chefs EH-MIX 554', 'L01', 'NCC01', '810 x 430 x 60 mm (D x R x C)', N'Đức', '16191000', 7,N'Công suất: 5500W. Điện áp: 220V / 50Hz. Bảo hành: 3 năm'),
	('SP005', N'Bếp điện từ ?ôi GERTECH GT-5202B', 'L01', 'NCC01', '730x430x60 mm (D x R x C)', N'Đức', '21000000', 5,N'Công suất: min 400W – max 2.400W. Điện áp: 220VAC/50Hz. Bảo hành: 3 năm'),
	('SP006', N'Bếp điện từ Arber AB 380', 'L01', 'NCC02', '715 x 420 x 100mm (D x R x C)', N'Malaysia', '8613000', 10,N'Công suất: 3400W. Bảo hành: 2 năm'),
	('SP007', N'Bếp từ Arber AB – 390', 'L01', 'NCC02', '720 x 430 x 80 mm (D x R x C)', N'Malaysia', '5950000', 15,N'Công suất: 3600 W. Điện áp: 220V / 50Hz. Bảo hành: 3 năm'),
	('SP008', N'Bếp nướng điện không khói KOCHI', 'L02', 'NCC02', N'30 x 50 cm (Khu vực nướng)', N'Nhật Bản', '850000', 30,N'Công suất 1500W'),
	('SP009', N'Bếp nướng điện không khói KOCHI (MÀU XÁM)', 'L02', 'NCC02', N'30 x 50 cm (Khu vực nướng)', N'Nhật Bản', '880000', 27,N'Công suất 1500W'),
	('SP010', N'Bếp nướng điện Sunhouse SHD4607', 'L02', 'NCC02', '40 x 23 cm', N'Trung Quốc', '470000', 35,N'Công suất: 1500W. Bảo hành: 12 tháng'),
	('SP011', N'Bếp nướng điện không khói ?a n?ng Electric Barbecue Grill', 'L02', 'NCC01', '35 x 48 cm', N'Đài Loan', '268000', 35,N'Công suất: 2000W. Điện áp: 220V / 50 Hz. Bảo hành: 2 năm'),
	('SP012', N'Lò nướng điện thông minh GERTECH GT-688', 'L03', 'NCC01', '590 x 595 x 550 mm (C x D x S)', N'Đức', '13000000', 15,N'Công suất: 3365 W. Điện áp: 220-240V / 50Hz. Bảo hành: 12 tháng'),
	('SP013', N'Lò Nướng kết hợp vi sóng Malloca MW-944TF', 'L03', 'NCC01', '595 x 568 x 455 mm (D x S x C)', N'Trung Quốc', '19500000', 12,N'Điện áp: 220 - 240V/50Hz. Công suất : 1.700W. Dung tích : 44 lít'),
	('SP014', N'Hút mùi Canzy CZ 3470', 'L04', 'NCC04', '700 x 470 x 430 mm (D x R x C)', N'Liên Doanh', '4250000', 20,N'Công suất hút: 1100m3/h. Công suất: 240 W. Điện nguồn: 220V – 50Hz'),
	('SP015', N'Hút mùi kính cong Kocher K8370', 'L04', 'NCC04', '700/900mm', N'Việt Nam', '4125000', 22,N'Công suất hút: 1000m3/h. Công suất: 190W. Điện nguồn: 220V – 50Hz'),
	('SP016', N'Máy hút mùi âm tủ Cata TF 2003 Duralum', 'L04', 'NCC04', '700mm', N'Trung Quốc', '3200000', 25,N'Công suất hút: 600m3/h. Ống thoát: 150/125 mm'),
	('SP017', N'Máy hút Mùi Arber AB-700Q', 'L04', 'NCC04', '700 x 900 mm', N'Trung Quốc', '5650000', 25,N'Công suất tổng: 170W. Điện áp: Công suất hút: 1100m3/h220 x 240V ~ 50Hz. Bảo hành: 2 năm'),
	('SP018', N'Bộ nồi 4 món Fissler Luno Black', 'L05', 'NCC03', N'1 quánh Ø18cm, 1 nồi Ø18cm, 1 nồi Ø20cm, 1 nồi Ø24cm', N'Đức', '11250000', 12,N'Chất liệu: Nhôm đúc quang học'),
	('SP019', N'Bộ nồi Arber 5 chiếc', 'L05', 'NCC03', N'Chảo 24cm, nồi 18-20-24cm, quánh 16cm', N'Đức', '2765000', 20,N'Kiểu thân: Tròn. Chất liệu: Inox 304'),
	('SP020', N'Nồi nấu chân không KOCHI', 'L05', 'NCC03', '395 x 160 x 330 mm (D x R x C)', N'Nhật Bản', '999000', 25,N'Công suất: 1350W. Dung tích: 6L. Điện áp: 220V – 50Hz. Bảo hành: 24 tháng'),
	('SP021', N'Nồi áp suất KYUSHU MODEL LJ 336', 'L05', 'NCC03', '325 x 325 x 410 mm (D x R x C)', N'Nhật Bản', '1250000', 22,N'Dung tích: 6L. Công suất: 1000W. Điện áp: 220V – 50Hz. Khối lượng: 4.6kg. Bảo hành: 24 tháng'),
	('SP022', N'Máy rửa bát âm tủ, BOSCH SERIES 4 SMI4HVS33E (PURE DRY)', 'L06', 'NCC04', '598 x 573 x 815 mm (R x S x C)', N'Đức', '15000000', 13,N'Bảo hành: 36 tháng'),
	('SP023', N'Máy rửa bát, HAFELE HDW-F60G 535.29.590 (PURE DRY)', 'L06', 'NCC04', '598 x 600 x (820-845) mm (R x S x C)', N'Đức', '11200000', 14,N'Bảo hành: 36 tháng'),
	('SP024', N'Máy rửa bát, BOSCH SERIES 2 SMS2IVW01P (PURE DRY)', 'L06', 'NCC04', '600 x 600 x (815-845) mm (R x S x C)', N'Thổ Nhĩ Kỳ', '15174000', 11,N'Bảo hành: 36 tháng'),
	('SP025', N'Máy rửa bát để bàn, HAFELE HDW-T5531B 538.21.350 (PURE DRY)', 'L06', 'NCC01', '550 x 500 x 590mm (R x S x C)', N'Đức', '11628000', 15,N'Bảo hành: 36 tháng'),
	('SP026', N'Dao chặt đúc nguyên khối', 'L07', 'NCC05', '20 cm', N'Thái Lan', '2150000', 18,N'Trọng lượng: 900g. Dùng để chặt xương, sử dụng cho gia đình, nhà hàng'),
	('SP027', N'Bộ dao kép HAMA siêu chắc, không gỉ cao cấp', 'L07', 'NCC05', N'Lưỡi dao 21 cm, cán dao 14 cm', N'Việt Nam', '180000', 34,N'Sản phẩm gồm 1 dao, 1 kéo. Chất liệu thép không gỉ siêu sắc, cao cấp'),
	('SP028', N'Dao chặt bản to siêu chắc, không gỉ', 'L07', 'NCC05', N'Lưỡi 21,5 x 8,5 cm, Cán: 14,5 cm', N'Việt Nam', '250000', 35,N'Cán dao bằng gỗ lâu n?m có tán ?inh ch?c ch?n'),
	('SP029', N'Thớt kính cường lực cao cấp băm chan không vỡ KANDA', 'L07', 'NCC04', N'Dài 32cm x Rộng 27cm x dày 9mm', N'Việt Nam', '399000', 30,N''),
	('SP030', N'Thớt gỗ có tay ầm xà cừ', 'L07', 'NCC05', N'44 x 17 cm (Bao gồm tay cầm)', N'Việt Nam', '198000', 40,N'Chất liệu: Gỗ xà cừ')

INSERT INTO hoadonnhap(MaHDN, MaNV, MaNCC, Tongtien, Ngaynhap)
VALUES
	('HDN001', 'NV01', 'NCC01', '135500000', '2023-08-25'),
	('HDN002', 'NV01', 'NCC05', '21650000', '2023-10-16'),
	('HDN003', 'NV01', 'NCC01', '234400000', '2023-11-16'),
	('HDN004', 'NV01', 'NCC04', '87400000', '2023-12-05'),
	('HDN005', 'NV01', 'NCC03', '44100000', '2023-12-16'),
	('HDN006', 'NV01', 'NCC05', '24500000', '2024-01-03'),
	('HDN007', 'NV01', 'NCC02', '66400000', '2024-01-14'),
	('HDN008', 'NV01', 'NCC01', '163000000', '2024-02-26'),
	('HDN009', 'NV01', 'NCC05', '31500000', '2024-05-30'),
	('HDN010', 'NV01', 'NCC04', '166000000', '2024-06-03')

INSERT INTO chitiethoadonnhap(MaHDN, MaSP, Soluongnhap, Gianhap, Thanhtien)
VALUES
	('HDN001', 'SP001', 6, '13000000', '78000000'),
	('HDN001', 'SP012', 5, '11500000', '57500000'),
	('HDN002', 'SP026', 7, '1700000', '11900000'),
	('HDN002', 'SP029', 15, '300000', '4500000'),
	('HDN002', 'SP027', 20, '150000', '3000000'),
	('HDN002', 'SP030', 15, '150000', '2250000'),
	('HDN003', 'SP001', 5, '13000000', '65000000'),
	('HDN003', 'SP002', 3, '16200000', '48600000'),
	('HDN003', 'SP004', 4, '15700000', '62800000'),
	('HDN003', 'SP025', 5, '11200000', '56000000'),
	('HDN004', 'SP014', 7, '4000000', '28000000'),
	('HDN004', 'SP016', 10, '2700000', '27000000'),
	('HDN004', 'SP023', 3, '10800000', '32400000'),
	('HDN005', 'SP019', 10, '2500000', '25000000'),
	('HDN005', 'SP020', 12, '800000', '9600000'),
	('HDN005', 'SP021', 10, '950000', '9500000'),
	('HDN006', 'SP026', 10, '1750000', '17500000'),
	('HDN006', 'SP028', 20, '200000', '4000000'),
	('HDN006', 'SP030', 20, '150000', '3000000'),
	('HDN007', 'SP007', 8, '5300000', '42400000'),
	('HDN007', 'SP008', 10, '650000', '6500000'),
	('HDN007', 'SP009', 15, '700000', '10500000'),
	('HDN007', 'SP010', 20, '350000', '7000000'),
	('HDN008', 'SP003', 5, '15000000', '75000000'),
	('HDN008', 'SP005', 2, '18500000', '37000000'),
	('HDN008', 'SP013', 3, '17000000', '51000000'),
	('HDN009', 'SP027', 30, '150000', '4500000'),
	('HDN009', 'SP026', 15, '1800000', '27000000'),
	('HDN010', 'SP015', 10, '3700000', '37000000'),
	('HDN010', 'SP022', 5, '13000000', '65000000'),
	('HDN010', 'SP024', 5, '12800000', '64000000')

INSERT INTO hoadonban(MaHDB, MaNV, MaKH, Ngaymua, Tongtien)
VALUES
	('HDB001', 'NV01', 'KH001', '2024-02-19', '25146000'),
	('HDB002', 'NV03', 'KH002', '2024-02-23', '3149000'),
	('HDB003', 'NV03', 'KH003', '2024-03-04', '23510000'),
	('HDB004', 'NV05', 'KH004', '2024-03-08', '13698000'),
	('HDB005', 'NV01', 'KH005', '2024-03-11', '20781000'),
	('HDB006', 'NV02', 'KH006', '2024-03-17', '16800000'),
	('HDB007', 'NV04', 'KH007', '2024-03-17', '23220000'),
	('HDB008', 'NV01', 'KH008', '2024-03-24', '17636000'),
	('HDB009', 'NV05', 'KH009', '2024-04-02', '11200000'),
	('HDB010', 'NV02', 'KH010', '2024-04-04', '21648000'),
	('HDB011', 'NV03', 'KH011', '2024-04-07', '900000'),
	('HDB012', 'NV01', 'KH012', '2024-04-14', '18950000'),
	('HDB013', 'NV01', 'KH013', '2024-04-17', '5113000'),
	('HDB014', 'NV04', 'KH014', '2024-04-21', '20824000')

INSERT INTO chitiethoadonban(MaHDB, MaSP, Soluongban, Dongia, Thanhtien)
VALUES
	('HDB001', 'SP030', 2, '198000', '396000'),
	('HDB001', 'SP001', 1, '13500000', '13500000'),
	('HDB001', 'SP018', 1, '11250000', '11250000'),
	('HDB002', 'SP026', 1, '2150000', '2150000'),
	('HDB002', 'SP020', 1, '999000', '999000'),
	('HDB003', 'SP005', 1, '21000000', '21000000'),
	('HDB003', 'SP026', 1, '2150000', '2150000'),
	('HDB003', 'SP027', 2, '180000', '360000'),
	('HDB004', 'SP030', 1, '198000', '198000'),
	('HDB004', 'SP001', 1, '13500000', '13500000'),
	('HDB005', 'SP006', 1, '8613000', '8613000'),
	('HDB005', 'SP025', 1, '11628000', '11628000'),
	('HDB005', 'SP027', 3, '180000', '540000'),
	('HDB006', 'SP002', 1, '16800000', '16800000'),
	('HDB007', 'SP005', 1, '21000000', '21000000'),
	('HDB007', 'SP010', 1, '470000', '470000'),
	('HDB007', 'SP021', 1, '1250000', '1250000'),
	('HDB007', 'SP028', 2, '250000', '500000'),
	('HDB008', 'SP003', 1, '17100000', '17100000'),
	('HDB008', 'SP011', 2, '268000', '536000'),
	('HDB009', 'SP023', 1, '11200000', '11200000'),
	('HDB010', 'SP026', 3, '2150000', '6450000'),
	('HDB010', 'SP030', 2, '198000', '198000'),
	('HDB010', 'SP022', 1, '15000000', '15000000'),
	('HDB011', 'SP027', 5, '180000', '900000'),
	('HDB012', 'SP007', 1, '5950000', '5950000'),
	('HDB012', 'SP012', 1, '13000000', '13000000'),
	('HDB013', 'SP030', 1, '198000', '198000'),
	('HDB013', 'SP026', 1, '2150000', '2150000'),
	('HDB013', 'SP019', 1, '2765000', '2765000'),
	('HDB014', 'SP017', 1, '5650000', '5650000'),
	('HDB014', 'SP024', 1, '15174000', '15174000')