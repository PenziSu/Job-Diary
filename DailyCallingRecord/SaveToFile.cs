using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//參考M$內建Excel
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
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
        /*宣告Excel變數*/
        string[] columnTitle = { "報修時間", "員工編號", "分機號碼", "系統分類", "問題敘述", "結案時間", "二線支援" };
        IWorkbook wb = new HSSFWorkbook();

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
            if (txtFile == "" || txtFile == null)
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
            
        }
        public void WriteToExcel()
        {
            /*資料寫入Excel檔案*/                        
            FileStream xlsFile = new FileStream(@"D:\GitHubFolder\Job-Diary\Data\JobDiary.xls", FileMode.Create);
            int newfile = 0;
            ISheet ws;            
            if (newfile < 1)
            {
                ws = wb.CreateSheet("Job Diary");                
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
            /*寫入檔案*/
            wb.Write(xlsFile);
            xlsFile.Close();
        }                         
    }
}

