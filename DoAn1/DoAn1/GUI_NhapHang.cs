using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace DoAn1
{
    public partial class GUI_NhapHang : Form
    {
        public GUI_NhapHang()
        {
            InitializeComponent();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvsp);
        }
        private void ExportToExcel(DataGridView dgv)
        {
            // Tạo đối tượng Excel Application
            Excel.Application excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            // Tạo một workbook mới
            Excel.Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);
            Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];
            excelWorksheet.Name = "ExportedFromDatGridView";

            // Xuất tiêu đề cột
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                excelWorksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }

            // Xuất dữ liệu hàng
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    excelWorksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString();
                }
            }

            // Hiển thị ứng dụng Excel
            excelApp.Visible = true;

            // Giải phóng tài nguyên
            releaseObject(excelWorksheet);
            releaseObject(excelWorkbook);
            releaseObject(excelApp);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
