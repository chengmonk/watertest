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
            this.SuspendLayout();
            // 
            // hslButton1
            // 
            this.hslButton1.CustomerInformation = null;
            this.hslButton1.Location = new System.Drawing.Point(125, 122);
            this.hslButton1.Margin = new System.Windows.Forms.Padding(4);
            this.hslButton1.Name = "hslButton1";
            this.hslButton1.Size = new System.Drawing.Size(152, 58);
            this.hslButton1.TabIndex = 0;
            this.hslButton1.Text = "压力特性测试";
            this.hslButton1.Click += new System.EventHandler(this.hslButton1_Click);
            // 
            // hslButton2
            // 
            this.hslButton2.CustomerInformation = null;
            this.hslButton2.Location = new System.Drawing.Point(498, 122);
            this.hslButton2.Margin = new System.Windows.Forms.Padding(4);
            this.hslButton2.Name = "hslButton2";
            this.hslButton2.Size = new System.Drawing.Size(152, 58);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 291);
            this.Controls.Add(this.hslButton2);
            this.Controls.Add(this.hslButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private HslControls.HslButton hslButton1;
        private HslControls.HslButton hslButton2;
        private Automation.BDaq.InstantAiCtrl instantAiCtrl1;
        private Automation.BDaq.InstantDoCtrl instantDoCtrl1;
        private Automation.BDaq.InstantDiCtrl instantDiCtrl1;
        private Automation.BDaq.InstantAoCtrl m_instantAoCtrl;
        private Automation.BDaq.WaveformAiCtrl waveformAiCtrl1;
    }
}