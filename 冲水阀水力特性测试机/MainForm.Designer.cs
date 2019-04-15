namespace 冲水阀水力特性测试机
{
    using HslCommunication;
    using HslControls;
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.hslButton1 = new HslControls.HslButton();
            this.hslButton2 = new HslControls.HslButton();
            this.instantAiCtrl1 = new Automation.BDaq.InstantAiCtrl(this.components);
            this.instantDoCtrl1 = new Automation.BDaq.InstantDoCtrl(this.components);
            this.instantDiCtrl1 = new Automation.BDaq.InstantDiCtrl(this.components);
            this.m_instantAoCtrl = new Automation.BDaq.InstantAoCtrl(this.components);
            this.waveformAiCtrl1 = new Automation.BDaq.WaveformAiCtrl(this.components);
            this.hslButton3 = new HslControls.HslButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hslButton4 = new HslControls.HslButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hslButton1
            // 
            this.hslButton1.CustomerInformation = null;
            this.hslButton1.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslButton1.ForeColor = System.Drawing.Color.Black;
            this.hslButton1.Location = new System.Drawing.Point(49, 42);
            this.hslButton1.Name = "hslButton1";
            this.hslButton1.Size = new System.Drawing.Size(175, 90);
            this.hslButton1.TabIndex = 0;
            this.hslButton1.Text = "压力特性测试";
            this.hslButton1.Click += new System.EventHandler(this.hslButton1_Click);
            // 
            // hslButton2
            // 
            this.hslButton2.CustomerInformation = null;
            this.hslButton2.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hslButton2.ForeColor = System.Drawing.Color.Black;
            this.hslButton2.Location = new System.Drawing.Point(310, 42);
            this.hslButton2.Name = "hslButton2";
            this.hslButton2.Size = new System.Drawing.Size(175, 90);
            this.hslButton2.TabIndex = 1;
            this.hslButton2.Text = "流量特性测试";
            this.hslButton2.Click += new System.EventHandler(this.hslButton2_Click);
            // 
            // instantAiCtrl1
            // 
            this.instantAiCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantAiCtrl1._StateStream")));
            // 
            // instantDoCtrl1
            // 
            this.instantDoCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantDoCtrl1._StateStream")));
            // 
            // instantDiCtrl1
            // 
            this.instantDiCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantDiCtrl1._StateStream")));
            // 
            // m_instantAoCtrl
            // 
            this.m_instantAoCtrl._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("m_instantAoCtrl._StateStream")));
            // 
            // waveformAiCtrl1
            // 
            this.waveformAiCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("waveformAiCtrl1._StateStream")));
            // 
            // hslButton3
            // 
            this.hslButton3.CustomerInformation = null;
            this.hslButton3.Location = new System.Drawing.Point(72, 138);
            this.hslButton3.Name = "hslButton3";
            this.hslButton3.Size = new System.Drawing.Size(142, 46);
            this.hslButton3.TabIndex = 2;
            this.hslButton3.Text = "打开串口11连接测试";
            this.hslButton3.Visible = false;
            this.hslButton3.Click += new System.EventHandler(this.hslButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "发送指令";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "接收数据";
            this.label2.Visible = false;
            // 
            // hslButton4
            // 
            this.hslButton4.CustomerInformation = null;
            this.hslButton4.Location = new System.Drawing.Point(349, 138);
            this.hslButton4.Name = "hslButton4";
            this.hslButton4.Size = new System.Drawing.Size(111, 46);
            this.hslButton4.TabIndex = 5;
            this.hslButton4.Text = "读取数据测试";
            this.hslButton4.Visible = false;
            this.hslButton4.Click += new System.EventHandler(this.hslButton4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "数据";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "数据";
            this.label4.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 170);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hslButton4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hslButton3);
            this.Controls.Add(this.hslButton2);
            this.Controls.Add(this.hslButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HslControls.HslButton hslButton1;
        private HslControls.HslButton hslButton2;
        private Automation.BDaq.InstantAiCtrl instantAiCtrl1;
        private Automation.BDaq.InstantDoCtrl instantDoCtrl1;
        private Automation.BDaq.InstantDiCtrl instantDiCtrl1;
        private Automation.BDaq.InstantAoCtrl m_instantAoCtrl;
        private Automation.BDaq.WaveformAiCtrl waveformAiCtrl1;
        private HslButton hslButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private HslButton hslButton4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}