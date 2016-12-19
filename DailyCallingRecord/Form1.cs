using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

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
            string text = textBoxGetEventTime.Text + "->" +
                         textBoxEID.Text + ',' +
                         textBoxExt.Text + ',' +
                         comboBoxAppMenu.Text + ',' +
                         textBoxEndEventTime.Text + ',' +
                         textBoxForwordToPartnet.Text + ','+
                         textBoxEventDescription.Text+'.';                                        
            
            
            toolStripStatusLabel1.Text = "SAVE DONE!";
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
