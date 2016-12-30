using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//參考M$內建Excel
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
//參考Open Source元件
using NPOI;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
//Using Class
using JobDiary;

namespace DailyCallingRecord
{
    public partial class MainForm : Form
    {        
        public MainForm()
        {
            InitializeComponent();
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxGetEventTime.Text = 
                DateTime.Now.ToString("yyyy-MM-dd") +" "+ DateTime.Now.ToString("HH:mm");
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            textBoxEndEventTime.Text = 
                DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH:mm");
        }

        private void ForwardToPartner_Click(object sender, EventArgs e)
        {
            textBoxForwordToPartnet.Text = 
                DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH:mm");
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            /*           
            ISheet ws ;
            DataTable table = new DataTable(); ;            
            if (newfile < 1)
            {
                ws = wb.CreateSheet("Job Diary");                
                string[] columnTitle = { "報修時間", "員工編號", "分機號碼", "系統分類", "問題敘述", "結案時間", "二線支援" };
                ws.CreateRow(0);
                for (int i = 0; i <= 6; i++)
                {
                    ws.GetRow(0).CreateCell(i).SetCellValue(columnTitle[i]);
                }
                newfile += 1;
            }
            ws = wb.GetSheet("Job Diary");
                       
            //計算並呈現資料列數            
            //MessageBox.Show("New Row = "+getNewRow(ws).ToString());
            //資料寫入新列
            int newRow = ws.LastRowNum + 1;
            if (newRow > 0) {                
                ws.CreateRow(newRow); 
                for (int i = 0; i <= 6; i++)
                {
                    ws.GetRow(newRow).CreateCell(i).SetCellValue(columnTitle[i]);
                }
            }
            資料寫入DataTable
            MakeDataTableAndDisplay(table,
                                    textBoxGetEventTime.Text,
                                    textBoxEID.Text,
                                    textBoxExt.Text, 
                                    comboBoxAppMenu.Text,
                                    textBoxEventDescription.Text,
                                    textBoxEndEventTime.Text,
                                    textBoxForwordToPartnet.Text
                                    );*/

            /*DataTable寫入Excel檔案
            DataTableToExcelFile(table,ws);*/

            /*寫入檔案            
            wb.Write(file);
            file.Close();*/
            SaveToFile sf = new SaveToFile();
            sf.SetData(textBoxGetEventTime.Text,
                       textBoxEID.Text,
                       textBoxExt.Text,
                       comboBoxAppMenu.Text,
                       textBoxEventDescription.Text,
                       textBoxEndEventTime.Text,
                       textBoxForwordToPartnet.Text);
            sf.WriteToFile();            
            /*呈現資料                        
             * DisplayData dd = new DisplayData();
            /*狀態列敘述改變*/
            toolStripStatusLabel1.Text = "Done.";
        }

        /*private int getNewRow(ISheet sheet)
        {
            int count = sheet.LastRowNum;
            count += 1;            
            int NewRow = count + 1;
            return NewRow;            
        }*/                

        private void button1_Click_2(object sender, EventArgs e)
        {                        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {            

        }
    }
}
