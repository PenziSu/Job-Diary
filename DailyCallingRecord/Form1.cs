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


namespace DailyCallingRecord
{
    public partial class MainForm : Form
    {

        string[] columnTitle = { "報修時間", "員工編號", "分機號碼", "系統分類", "問題敘述", "結案時間", "二線支援" };
        //string xlsFilePath = "C:\Users\Penzi Su\Source\Repos\Job-Diary\Data\JobDiary.xls";
        //string xlsFilePath = "D:\GitHubFolder\Job-Diary\Data\JobDiary.xls";
        

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
            /*變數宣告區*/
            IWorkbook wb = new HSSFWorkbook();
            ISheet ws = wb.CreateSheet("Job Diary");
            string[] columnTitle = { "報修時間", "員工編號", "分機號碼", "系統分類", "問題敘述", "結案時間", "二線支援" } ;            
            // Create new DataTable.
            DataTable table = new DataTable();


            ws.CreateRow(0);
            for (int i = 0; i <= 6; i++)
            {
                ws.GetRow(0).CreateCell(i).SetCellValue(columnTitle[i]);
            }
                        
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
            /*資料寫入DataTable*/
            MakeDataTableAndDisplay(table,
                                    textBoxGetEventTime.Text,
                                    textBoxEID.Text,
                                    textBoxExt.Text, 
                                    comboBoxAppMenu.Text,
                                    textBoxEventDescription.Text,
                                    textBoxEndEventTime.Text,
                                    textBoxForwordToPartnet.Text
                                    );

            /*DataTable寫入Excel檔案*/
            DataTableToExcelFile(table,ws);
            /*寫入檔案*/
            FileStream file = new FileStream(@"C:\Users\Penzi Su\Source\Repos\Job-Diary\Data\JobDiary.xls", FileMode.Create);
            wb.Write(file);
            file.Close();
            /*狀態列敘述改變*/
            toolStripStatusLabel1.Text = "Done.";
        }

        private int getNewRow(ISheet sheet)
        {
            int count = sheet.LastRowNum;
            count += 1;            
            int NewRow = count + 1;
            return NewRow;            
        }

        private void MakeDataTableAndDisplay(DataTable dt,string EventTime, string EID, string ExtNum, 
            string ApplicationType, string IssueDesc, string IssueEndTime, string ForwordToPartner)
        {
            /*目前這個方法只會執行一次，寫入一筆資料而已。*/
            // Create new DataTable.
            //DataTable table = new DataTable();

            // Declare DataColumn and DataRow variables.
            DataColumn column;
            DataRow row;            
            // Create second column.
            for (int i = 0; i <=6; i++)
            {
                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = columnTitle[i];
                dt.Columns.Add(column);
            }

            // Create new DataRow objects and add to DataTable.                
            row = dt.NewRow();
            row["報修時間"] = EventTime;
            row["員工編號"] = EID;
            row["分機號碼"] = ExtNum;
            row["系統分類"] = ApplicationType;
            row["問題敘述"] = IssueDesc;
            row["結案時間"] = IssueEndTime;
            row["二線支援"] = ForwordToPartner;
            dt.Rows.Add(row);            
            
            // Set to DataGrid.DataSource property to the table.
            dataGrid1.DataSource = dt;            
        }

        private void DataTableToExcelFile(DataTable dt,ISheet ws)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ws.CreateRow(i + 1);
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    ws.GetRow(i + 1).CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());
                }
            }            
        }
    }
}
