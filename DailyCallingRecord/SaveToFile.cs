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
        /* 依序為："報修時間", "員工編號", "分機號碼", "系統分類", "問題敘述", "結案時間", "二線支援"*/        
        //public string issueTime;
        //public string employeeID;
        //public string extNumber;
        //public string applicationName;
        //public string issueDescription;
        //public string closeTime;
        //public string secLineReceiver;
        private string[] Title = { "報修時間", "員工編號", "分機號碼", "系統分類", "問題敘述", "二線支援" ,"結案時間" };
        string[] issueContent = new string[7];        

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
            issueContent[0] = GetEventTime;
            issueContent[1] = EID;
            issueContent[2] = Ext;
            issueContent[3] = AppMenu;
            issueContent[4] = EventDescription;
            issueContent[5] = ForwardToPartnet;
            issueContent[6] = EndEventTime;                       
        }
        public void WriteToFile()
        {                     
            string issue = issueContent[0] + ','+ issueContent[1] + ',' + issueContent[2] + ',' + issueContent[3] + ',' + issueContent[4] + ',' + issueContent[5] + ',' + issueContent[6];
            if (txtFile == "" || txtFile == null)
            {                                
                txtFile = Application.StartupPath + @"..\..\..\..\Data\WriteDataToText.txt";
            }
            else
            {
                /*txtFile已經有值*/
            }                        
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(txtFile, true))
            {
                file.WriteLine(issue);                
            }            
        }
        public void WriteToExcel()
        {
            /*宣告Excel變數*/                        
            Boolean fileStatus = false;
            string[] cellContent = issueContent;
            /*判斷是否選擇檔案以及預設路徑是否有檔案*/            
            if (xlsFile == "" || xlsFile == null || xlsFile == "unknow")
            {
                xlsFile = Application.StartupPath + @"..\..\..\..\Data\JobDiary.xls";
                if (File.Exists(xlsFile))
                {
                    fileStatus = true;
                }
                else
                {
                    fileStatus = false;
                }                
            }                
            else
            {                
                fileStatus = true;
            }                           

            switch (Convert.ToInt16(fileStatus)){
                case 0:
                    {
                        /*建立Excel檔案*/                                                
                        HSSFWorkbook wb = new HSSFWorkbook();
                        ISheet ws = wb.CreateSheet("Job Diary");
                        ws.CreateRow(0);
                        for (int i = 0; i <= Title.Length -1; i++)
                        {                            
                            ws.GetRow(0).CreateCell(i).SetCellValue(Title[i]);
                        }
                        ws.CreateRow(1);                        
                        for (int i = 0; i <= cellContent.Length - 1; i++)
                        {                            
                            ws.GetRow(1).CreateCell(i).SetCellValue(cellContent[i]);
                        }
                        FileStream file = new FileStream(xlsFile,FileMode.OpenOrCreate);
                        wb.Write(file);
                        file.Close();                        
                        break;
                    }
                case 1:
                    {
                        /*寫入Excel檔案*/                                                                                           
                        FileStream file = new FileStream(xlsFile, FileMode.OpenOrCreate);
                        HSSFWorkbook wb = new HSSFWorkbook(file);                        
                        file.Close();
                        ISheet JD = wb.GetSheet("Job Diary");                        
                        int lastRow = JD.LastRowNum + 1;
                        JD.CreateRow(lastRow);                        
                        for (int i = 0; i <= Title.Length - 1; i++)
                        {
                            JD.GetRow(lastRow).CreateCell(i).SetCellValue(cellContent[i]);
                        }
                        file = new FileStream(xlsFile, FileMode.OpenOrCreate);
                        wb.Write(file);
                        file.Close();                        
                        break;
                    }                
            }
            Array.Clear(issueContent, 0, issueContent.Length);
            Array.Clear(cellContent, 0, cellContent.Length);
        }        
    }
}

