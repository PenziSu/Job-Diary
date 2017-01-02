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
            sf.SetData(textBoxGetEventTime.Text,
                       textBoxEID.Text,
                       textBoxExt.Text,
                       comboBoxAppMenu.Text,
                       textBoxEventDescription.Text,
                       textBoxEndEventTime.Text,
                       textBoxForwordToPartnet.Text);
            sf.WriteToFile(); //txt
            sf.WriteToExcel(); //Excel

            /*狀態列敘述改變*/
            toolStripStatusLabel1.Text = "Done.";
        }              

        private void btnOpenTxtFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "文字檔|*.txt";
            openFileDialog1.Title = "Select a text file";
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
            string[] lines = {textBoxGetEventTime.Text,
                              textBoxEID.Text,
                              textBoxExt.Text,
                              comboBoxAppMenu.Text,
                              textBoxEventDescription.Text,
                              textBoxEndEventTime.Text,
                              textBoxForwordToPartnet.Text
            };
            DataGridViewRowCollection rows = dataGrid1.Rows;
            rows.Add(lines);
        }

        private void dataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOpenXlsFile_Click(object sender, EventArgs e)
        {
            /*開啟Excel檔案*/

        }
    }
}
