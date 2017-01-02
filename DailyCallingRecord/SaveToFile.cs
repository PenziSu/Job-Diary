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
        private string issueTime;
        private string employeeID;
        private string extNumber;
        private string applicationName;
        private string issueDescription;
        private string closeTime;
        private string secLineReceiver;        

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
                txtFile = Application.StartupPath + @"..\..\..\..\Data\WriteDataToText.txt";
            }
            else
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
            /*宣告Excel變數*/            
            xlsFile = Application.StartupPath+@"..\..\..\..\Data\JobDiary.xls";
            Boolean fileStatus = false;
            string[] cellTitle = { "報修時間", "員工編號", "分機號碼", "系統分類", "問題敘述", "結案時間", "二線支援" };
            string[] cellContent = { "1", "2", "3", "4", "5", "6", "7" };            

            if (!File.Exists(xlsFile))
                fileStatus = false;                
            else            
                fileStatus = true;                                         

            switch (Convert.ToInt16(fileStatus)){
                case 0:
                    {
                        /*建立Excel檔案*/
                        MessageBox.Show(Convert.ToInt16(fileStatus)+": 建立檔案");
                        HSSFWorkbook wb = new HSSFWorkbook();
                        ISheet ws = wb.CreateSheet("Job Diary");
                        ws.CreateRow(0);
                        for (int i = 0; i <= cellTitle.Length -1; i++)
                        {                            
                            ws.GetRow(0).CreateCell(i).SetCellValue(cellTitle[i]);
                        }
                        FileStream file = new FileStream(xlsFile,FileMode.Create);
                        wb.Write(file);
                        //file.Close();
                        file.Dispose();
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
                        //   MessageBox.Show("Last Row:" + Convert.ToString(lastRow + 1));
                        for (int i = 0; i <= cellTitle.Length - 1; i++)
                        {
                            JD.GetRow(lastRow).CreateCell(i).SetCellValue(cellContent[i]);
                        }
                        file = new FileStream(xlsFile, FileMode.OpenOrCreate);
                        wb.Write(file);
                        file.Close();                        
                        break;
                    }
            }                                 
        }                         
    }
}

