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
        SaveToFile sf = new SaveToFile();        

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
            /*呈現資料*/
            ShowData();
            /*寫入檔案*/
            //sf.SetData(textBoxGetEventTime.Text,
            //           textBoxEID.Text,
            //           textBoxExt.Text,
            //           comboBoxAppMenu.Text,
            //           textBoxEventDescription.Text,
            //           textBoxEndEventTime.Text,
            //           textBoxForwordToPartnet.Text);
            //sf.WriteToFile();

            /*狀態列敘述改變*/
            toolStripStatusLabel1.Text = "Done.";
        }              

        private void OpenSavedFile_click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All|*.*";
            openFileDialog1.Title = "Select a file";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {                
                sf.txtFile = openFileDialog1.FileName;
                toolStripStatusLabel1.Text = "開啟舊檔" + openFileDialog1.FileName;
            }                                       
        }

        private void button1_Click_1(object sender, EventArgs e)
        {            

        }
        private void ShowData()
        {
            /*資料寫入DataTable*/

            //string[] columnTitle = { "報修時間", "員工編號", "分機號碼", "系統分類", "問題敘述", "結案時間", "二線支援" };
            //DataTable dt = new DataTable();
            //DataRow row;
            //DataColumn column = new DataColumn() ;
            //column.DataType = Type.GetType("System.String");            

            //// Create second column.
            //for (int i = 0; i <= 6; i++)
            //{
            //    column = new DataColumn();
            //    column.DataType = Type.GetType("System.String");
            //    column.ColumnName = columnTitle[i];
            //    dt.Columns.Add(column);
            //}
            //// Create new DataRow objects and add to DataTable.                
            //row = dt.NewRow();            
            //row["報修時間"] = textBoxGetEventTime.Text;
            //row["員工編號"] = textBoxEID.Text;
            //row["分機號碼"] = textBoxExt.Text;
            //row["系統分類"] = comboBoxAppMenu.Text;
            //row["問題敘述"] = textBoxEventDescription.Text;
            //row["結案時間"] = textBoxEndEventTime.Text;
            //row["二線支援"] = textBoxForwordToPartnet.Text;
            //dt.Rows.Add(row);
            //// Set to DataGrid.DataSource property to the table.
            //dataGrid1.DataSource = dt;
        }

        private void dataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
