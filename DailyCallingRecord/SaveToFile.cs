using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//參考Open Source元件
using NPOI;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;

namespace JobDiary
{
    public class SaveToFile
    {
        public string xlsFile;
        public string txtFile;
        /* "報修時間", "員工編號", "分機號碼", "系統分類", "問題敘述", "結案時間", "二線支援"*/
        public string issueTime;
        public string employeeID;
        public string extNumber;
        public string applicationName;
        public string issueDescription;
        public string closeTime;
        public string secLineReceiver;                

        public SaveToFile()
        {
            /*直接執行*/
            xlsFile = "unknow";
        }

        public SaveToFile(string xf)
        {
            /*宣告即執行*/
            xlsFile = xf;
        }

        public void SetData(string GetEventTime,string EID, string Ext,string AppMenu,string EventDescription, string EndEventTime, string ForwardToPartnet)
        {            
            issueTime        = GetEventTime;
            employeeID       = EID;
            extNumber        = Ext;
            applicationName  = AppMenu;
            issueDescription = EventDescription;
            closeTime        = EndEventTime;
            secLineReceiver  = ForwardToPartnet;            
        }
        public void WriteToFile()
        {
            string[] lines = {issueTime,employeeID,extNumber,applicationName,issueDescription,closeTime,secLineReceiver };           
            string issue = issueTime+','+employeeID + ',' + extNumber + ',' + applicationName + ',' + issueDescription + ',' + closeTime + ',' + secLineReceiver;
            if (txtFile == "")
            {
                txtFile = "D:/GitHubFolder/Job-Diary/Data/WriteDataToText.txt";
            }else
            {
                /*txtFile已經有值*/
            }            
            
            using (System.IO.StreamWriter file2 = new System.IO.StreamWriter(txtFile, true))
            {
                file2.WriteLine(issue);
            }
            /*執行檔案寫入
            string[] columnTitle = { "報修時間", "員工編號", "分機號碼", "系統分類", "問題敘述", "結案時間", "二線支援" };
            IWorkbook wb = new HSSFWorkbook();
            HSSFWorkbook oldXlsFile;
            FileStream file = new FileStream(@"D:\GitHubFolder\Job-Diary\Data\JobDiary.xls", FileMode.Create);
            int newfile = 0;
            ISheet ws;
            DataTable table = new DataTable();
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
            if (newRow > 0)
            {
                ws.CreateRow(newRow);
                for (int i = 0; i <= 6; i++)
                {
                    ws.GetRow(newRow).CreateCell(i).SetCellValue(columnTitle[i]);
                }
            }
            /*資料寫入DataTable
            MakeDataTableAndDisplay(table,
                                    textBoxGetEventTime.Text,
                                    textBoxEID.Text,
                                    textBoxExt.Text,
                                    comboBoxAppMenu.Text,
                                    textBoxEventDescription.Text,
                                    textBoxEndEventTime.Text,
                                    textBoxForwordToPartnet.Text
                                    );

            /*DataTable寫入Excel檔案
            DataTableToExcelFile(table, ws);

            /*寫入檔案
            wb.Write(file);
            file.Close();
            */
        }

        private int getNewRow(ISheet sheet)
        {
            /*
            int count = sheet.LastRowNum;
            count += 1;
            int NewRow = count + 1;
            return NewRow;
            */
            return 0;
        }
        /*private void DataTableToExcelFile(DataTable dt, ISheet ws)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ws.CreateRow(i + 1);
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    ws.GetRow(i + 1).CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());
                }
            }
        }*/
        /*private void MakeDataTableAndDisplay(DataTable dt, string EventTime, string EID, string ExtNum,
            string ApplicationType, string IssueDesc, string IssueEndTime, string ForwordToPartner)
        {
            目前這個方法只會執行一次，寫入一筆資料而已。
            // Create new DataTable.
            //DataTable table = new DataTable();

            // Declare DataColumn and DataRow variables.
            DataColumn column;
            DataRow row;
            // Create second column.
            for (int i = 0; i <= 6; i++)
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
        }*/
    }
}
