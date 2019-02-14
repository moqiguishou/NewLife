using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace NewLife {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn_test_Click(object sender, EventArgs e) {
            string worksheetname = string.Empty;

            //导入本地文件  
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "文档(*.xls)|*.xlsx";
            if (file.ShowDialog() == DialogResult.OK) {
                txt_test.Text = file.FileName;
            }
            //判断有没有文件导入  
            if (file.FileName.Length == 0) {
                MessageBox.Show("请选择要导入的文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //======================================//
            Excel.Application excel = new Excel.Application();
            Excel.Workbook wb = null;
            wb = excel.Workbooks.Open(file.FileName);
            Excel.Worksheet ws = wb.Worksheets[1];
            int nRow = 0;
            int nColum = 0;
            string otxt_test = "";
            try {
                nRow = ws.UsedRange.Rows.Count;
                nColum = ws.UsedRange.Columns.Count;
                MessageBox.Show(nRow.ToString(),"", MessageBoxButtons.OK,MessageBoxIcon.Information);

                string ordernum = string.Empty;
                string count = string.Empty;
                //循环行
                for (int i = 1; i <= nRow; i++)//
                {
                    for (int j = 1; j <= nColum; j++) {
                        if (ws.Cells[i,j] != null) {
                            otxt_test = otxt_test + ws.Cells[i, j].Text;
                        }
                    }
                }
                txt_test.Text = otxt_test;
                
            } catch (Exception) {

                throw;
            }
           
        }

        private void txt_test_TextChanged(object sender, EventArgs e) {
            txt_2.Text = "hello";
        }
    }
}
