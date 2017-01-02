namespace DailyCallingRecord
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.textBoxEID = new System.Windows.Forms.TextBox();
            this.textBoxExt = new System.Windows.Forms.TextBox();
            this.textBoxEndEventTime = new System.Windows.Forms.TextBox();
            this.textBoxForwordToPartnet = new System.Windows.Forms.TextBox();
            this.GetEventTime = new System.Windows.Forms.Button();
            this.textBoxGetEventTime = new System.Windows.Forms.TextBox();
            this.ForwardToPartner = new System.Windows.Forms.Button();
            this.textBoxEventDescription = new System.Windows.Forms.TextBox();
            this.comboBoxAppMenu = new System.Windows.Forms.ComboBox();
            this.EventEndTime = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "員工編號";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "*分機號碼";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "問題描述";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "系統(程式)分類";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 308);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(604, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // textBoxEID
            // 
            this.textBoxEID.Location = new System.Drawing.Point(101, 63);
            this.textBoxEID.Name = "textBoxEID";
            this.textBoxEID.Size = new System.Drawing.Size(100, 22);
            this.textBoxEID.TabIndex = 10;
            // 
            // textBoxExt
            // 
            this.textBoxExt.Location = new System.Drawing.Point(101, 112);
            this.textBoxExt.Name = "textBoxExt";
            this.textBoxExt.Size = new System.Drawing.Size(100, 22);
            this.textBoxExt.TabIndex = 11;
            // 
            // textBoxEndEventTime
            // 
            this.textBoxEndEventTime.Location = new System.Drawing.Point(101, 189);
            this.textBoxEndEventTime.Name = "textBoxEndEventTime";
            this.textBoxEndEventTime.Size = new System.Drawing.Size(100, 22);
            this.textBoxEndEventTime.TabIndex = 13;
            // 
            // textBoxForwordToPartnet
            // 
            this.textBoxForwordToPartnet.Location = new System.Drawing.Point(101, 229);
            this.textBoxForwordToPartnet.Name = "textBoxForwordToPartnet";
            this.textBoxForwordToPartnet.Size = new System.Drawing.Size(100, 22);
            this.textBoxForwordToPartnet.TabIndex = 14;
            // 
            // GetEventTime
            // 
            this.GetEventTime.Location = new System.Drawing.Point(12, 12);
            this.GetEventTime.Name = "GetEventTime";
            this.GetEventTime.Size = new System.Drawing.Size(75, 23);
            this.GetEventTime.TabIndex = 17;
            this.GetEventTime.Text = "報修時間";
            this.GetEventTime.UseVisualStyleBackColor = true;
            this.GetEventTime.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxGetEventTime
            // 
            this.textBoxGetEventTime.Location = new System.Drawing.Point(101, 12);
            this.textBoxGetEventTime.Name = "textBoxGetEventTime";
            this.textBoxGetEventTime.Size = new System.Drawing.Size(100, 22);
            this.textBoxGetEventTime.TabIndex = 18;
            // 
            // ForwardToPartner
            // 
            this.ForwardToPartner.Location = new System.Drawing.Point(12, 229);
            this.ForwardToPartner.Name = "ForwardToPartner";
            this.ForwardToPartner.Size = new System.Drawing.Size(75, 23);
            this.ForwardToPartner.TabIndex = 19;
            this.ForwardToPartner.Text = "轉二線時間";
            this.ForwardToPartner.UseVisualStyleBackColor = true;
            this.ForwardToPartner.Click += new System.EventHandler(this.ForwardToPartner_Click);
            // 
            // textBoxEventDescription
            // 
            this.textBoxEventDescription.Location = new System.Drawing.Point(227, 27);
            this.textBoxEventDescription.Multiline = true;
            this.textBoxEventDescription.Name = "textBoxEventDescription";
            this.textBoxEventDescription.Size = new System.Drawing.Size(365, 224);
            this.textBoxEventDescription.TabIndex = 20;
            // 
            // comboBoxAppMenu
            // 
            this.comboBoxAppMenu.FormattingEnabled = true;
            this.comboBoxAppMenu.Items.AddRange(new object[] {
            "護理系統",
            "護囑系統",
            "病歷查詢",
            "門診醫囑",
            "急診醫囑",
            "住院醫囑",
            "檢查室",
            "放射科報告系統",
            "放射科報到系統",
            "放射科報告分派",
            "PACS"});
            this.comboBoxAppMenu.Location = new System.Drawing.Point(101, 154);
            this.comboBoxAppMenu.Name = "comboBoxAppMenu";
            this.comboBoxAppMenu.Size = new System.Drawing.Size(121, 20);
            this.comboBoxAppMenu.TabIndex = 21;
//            this.comboBoxAppMenu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // EventEndTime
            // 
            this.EventEndTime.Location = new System.Drawing.Point(12, 189);
            this.EventEndTime.Name = "EventEndTime";
            this.EventEndTime.Size = new System.Drawing.Size(75, 23);
            this.EventEndTime.TabIndex = 22;
            this.EventEndTime.Text = "結案時間";
            this.EventEndTime.UseVisualStyleBackColor = true;
            this.EventEndTime.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(483, 257);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(109, 37);
            this.buttonSend.TabIndex = 23;
            this.buttonSend.Text = "送   出";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "Ready.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 330);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.EventEndTime);
            this.Controls.Add(this.comboBoxAppMenu);
            this.Controls.Add(this.textBoxEventDescription);
            this.Controls.Add(this.ForwardToPartner);
            this.Controls.Add(this.textBoxGetEventTime);
            this.Controls.Add(this.GetEventTime);
            this.Controls.Add(this.textBoxForwordToPartnet);
            this.Controls.Add(this.textBoxEndEventTime);
            this.Controls.Add(this.textBoxExt);
            this.Controls.Add(this.textBoxEID);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Diary";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox textBoxEID;
        private System.Windows.Forms.TextBox textBoxExt;
        private System.Windows.Forms.TextBox textBoxEndEventTime;
        private System.Windows.Forms.TextBox textBoxForwordToPartnet;
        private System.Windows.Forms.Button GetEventTime;
        private System.Windows.Forms.TextBox textBoxGetEventTime;
        private System.Windows.Forms.Button ForwardToPartner;
        private System.Windows.Forms.TextBox textBoxEventDescription;
        private System.Windows.Forms.ComboBox comboBoxAppMenu;
        private System.Windows.Forms.Button EventEndTime;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

