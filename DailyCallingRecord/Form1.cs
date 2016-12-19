using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyCallingRecord
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
            /* 開啟儲存視窗
             * SaveFileDialog saveFileDialog1 = new SaveFileDialog();
             * saveFileDialog1.Filter = "所有檔案 (*.*)|*.*";
             * saveFileDialog1.Title = "儲存檔案";
             * saveFileDialog1.ShowDialog();*/
            /*寫入檔案*/
            //如果有逗點則會斷行寫入
            /*string[] lines = { textBoxGetEventTime.Text+"->"+
                               textBoxEID.Text+','+
                               textBoxExt.Text+','+
                               comboBoxAppMenu.Text+','+
                               textBoxEndEventTime.Text+','+
                               textBoxForwordToPartnet.Text+'.' }; */
            string text = textBoxGetEventTime.Text + "->" +
                         textBoxEID.Text + ',' +
                         textBoxExt.Text + ',' +
                         comboBoxAppMenu.Text + ',' +
                         textBoxEndEventTime.Text + ',' +
                         textBoxForwordToPartnet.Text + ','+
                         textBoxEventDescription.Text+'.';                            
            //System.IO.File.WriteAllText(@"D:\GitHubFolder\Job-Diary\Data\JobDiary.txt",text);
            /*這邊驗證檔案寫入成功與否*/
            using (System.IO.StreamWriter file = 
                new System.IO.StreamWriter(@"D:\GitHubFolder\Job-Diary\Data\JobDiary.txt", true))
            {                
                file.WriteLine(text+"\n");
                
            }
            toolStripStatusLabel1.Text = "SAVE DONE!";

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
