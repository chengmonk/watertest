namespace 冲水阀水力特性测试机
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.waterFlow = new System.Windows.Forms.ToolStripStatusLabel();
            this.waterTemperature = new System.Windows.Forms.ToolStripStatusLabel();
            this.maxWaterFlow = new System.Windows.Forms.ToolStripStatusLabel();
            this.instantDoCtrl1 = new Automation.BDaq.InstantDoCtrl(this.components);
            this.m_instantAoCtrl = new Automation.BDaq.InstantAoCtrl(this.components);
            this.instantDiCtrl1 = new Automation.BDaq.InstantDiCtrl(this.components);
            this.instantAiCtrl1 = new Automation.BDaq.InstantAiCtrl(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hslSwitch1 = new HslControls.HslSwitch();
            this.hslBlower1 = new HslControls.HslBlower();
            this.bpqreturn = new System.Windows.Forms.Label();
            this.sbzt = new System.Windows.Forms.Label();
            this.bpqzt = new System.Windows.Forms.Label();
            this.bpqfh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sbyali = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.open = new HslControls.HslButton();
            this.workName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hslSwitch2 = new HslControls.HslSwitch();
            this.qdfstatus = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hslPlay1 = new HslControls.HslPlay();
            this.hslButton5 = new HslControls.HslButton();
            this.hslButton2 = new HslControls.HslButton();
            this.hslButton4 = new HslControls.HslButton();
            this.hslCurve1 = new HslControls.HslCurve();
            this.systemInfo = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sbyali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.waterFlow,
            this.waterTemperature,
            this.maxWaterFlow});
            this.statusStrip1.Location = new System.Drawing.Point(0, 609);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1092, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // waterFlow
            // 
            this.waterFlow.Name = "waterFlow";
            this.waterFlow.Size = new System.Drawing.Size(69, 20);
            this.waterFlow.Text = "当前流量";
            // 
            // waterTemperature
            // 
            this.waterTemperature.Name = "waterTemperature";
            this.waterTemperature.Size = new System.Drawing.Size(39, 20);
            this.waterTemperature.Text = "温度";
            // 
            // maxWaterFlow
            // 
            this.maxWaterFlow.Name = "maxWaterFlow";
            this.maxWaterFlow.Size = new System.Drawing.Size(69, 20);
            this.maxWaterFlow.Text = "最大流量";
            // 
            // instantDoCtrl1
            // 
            this.instantDoCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantDoCtrl1._StateStream")));
            // 
            // m_instantAoCtrl
            // 
            this.m_instantAoCtrl._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("m_instantAoCtrl._StateStream")));
            // 
            // instantDiCtrl1
            // 
            this.instantDiCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantDiCtrl1._StateStream")));
            // 
            // instantAiCtrl1
            // 
            this.instantAiCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantAiCtrl1._StateStream")));
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.hslSwitch1);
            this.groupBox1.Controls.Add(this.hslBlower1);
            this.groupBox1.Controls.Add(this.bpqreturn);
            this.groupBox1.Controls.Add(this.sbzt);
            this.groupBox1.Controls.Add(this.bpqzt);
            this.groupBox1.Controls.Add(this.bpqfh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sbyali);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.open);
            this.groupBox1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(672, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(407, 403);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "水泵控制";
            // 
            // hslSwitch1
            // 
            this.hslSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hslSwitch1.Location = new System.Drawing.Point(268, 20);
            this.hslSwitch1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hslSwitch1.Name = "hslSwitch1";
            this.hslSwitch1.Size = new System.Drawing.Size(128, 146);
            this.hslSwitch1.SwitchForeground = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.hslSwitch1.SwitchStatusDescription = "变频;定频";
            this.hslSwitch1.TabIndex = 20;
            this.hslSwitch1.Text = "定变频选择";
            this.hslSwitch1.OnSwitchChanged += new System.Action<object, bool>(this.hslSwitch1_OnSwitchChanged);
            // 
            // hslBlower1
            // 
            this.hslBlower1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.hslBlower1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.hslBlower1.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(220)))));
            this.hslBlower1.Color4 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(160)))), ((int)(((byte)(169)))));
            this.hslBlower1.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.hslBlower1.Color6 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(114)))), ((int)(((byte)(121)))));
            this.hslBlower1.Color7 = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.hslBlower1.Color8 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(182)))), ((int)(((byte)(189)))));
            this.hslBlower1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hslBlower1.Location = new System.Drawing.Point(145, 191);
            this.hslBlower1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hslBlower1.Name = "hslBlower1";
            this.hslBlower1.Size = new System.Drawing.Size(141, 157);
            this.hslBlower1.TabIndex = 19;
            this.hslBlower1.Text = "关闭";
            this.hslBlower1.Load += new System.EventHandler(this.hslBlower1_Load);
            this.hslBlower1.Click += new System.EventHandler(this.hslButton4_Click);
            // 
            // bpqreturn
            // 
            this.bpqreturn.AutoSize = true;
            this.bpqreturn.Location = new System.Drawing.Point(141, 119);
            this.bpqreturn.Name = "bpqreturn";
            this.bpqreturn.Size = new System.Drawing.Size(31, 15);
            this.bpqreturn.TabIndex = 18;
            this.bpqreturn.Text = "0.0";
            // 
            // sbzt
            // 
            this.sbzt.AutoSize = true;
            this.sbzt.Location = new System.Drawing.Point(8, 191);
            this.sbzt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sbzt.Name = "sbzt";
            this.sbzt.Size = new System.Drawing.Size(119, 15);
            this.sbzt.TabIndex = 16;
            this.sbzt.Text = "水泵当前状态：";
            // 
            // bpqzt
            // 
            this.bpqzt.AutoSize = true;
            this.bpqzt.Location = new System.Drawing.Point(8, 156);
            this.bpqzt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bpqzt.Name = "bpqzt";
            this.bpqzt.Size = new System.Drawing.Size(135, 15);
            this.bpqzt.TabIndex = 15;
            this.bpqzt.Text = "变频器当前状态：";
            // 
            // bpqfh
            // 
            this.bpqfh.AutoSize = true;
            this.bpqfh.Location = new System.Drawing.Point(8, 119);
            this.bpqfh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bpqfh.Name = "bpqfh";
            this.bpqfh.Size = new System.Drawing.Size(135, 15);
            this.bpqfh.TabIndex = 14;
            this.bpqfh.Text = "变频器返回数值：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bar";
            // 
            // sbyali
            // 
            this.sbyali.DecimalPlaces = 1;
            this.sbyali.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.sbyali.Location = new System.Drawing.Point(87, 76);
            this.sbyali.Margin = new System.Windows.Forms.Padding(4);
            this.sbyali.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sbyali.Name = "sbyali";
            this.sbyali.ReadOnly = true;
            this.sbyali.Size = new System.Drawing.Size(119, 25);
            this.sbyali.TabIndex = 12;
            this.sbyali.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sbyali.ThousandsSeparator = true;
            this.sbyali.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.sbyali.ValueChanged += new System.EventHandler(this.sbyali_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "水泵压力：";
            // 
            // open
            // 
            this.open.CustomerInformation = null;
            this.open.Location = new System.Drawing.Point(8, 25);
            this.open.Margin = new System.Windows.Forms.Padding(4);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(197, 44);
            this.open.TabIndex = 10;
            this.open.Text = "打开水泵";
            this.open.Click += new System.EventHandler(this.hslButton4_Click);
            // 
            // workName
            // 
            this.workName.Location = new System.Drawing.Point(124, 76);
            this.workName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.workName.Multiline = true;
            this.workName.Name = "workName";
            this.workName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.workName.Size = new System.Drawing.Size(163, 46);
            this.workName.TabIndex = 24;
            this.workName.Text = "冲水阀";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "工件名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "秒";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(124, 32);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(119, 25);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "工件保持时间：";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.hslSwitch2);
            this.groupBox2.Controls.Add(this.qdfstatus);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.workName);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(672, 422);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(408, 182);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "工件属性";
            // 
            // hslSwitch2
            // 
            this.hslSwitch2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hslSwitch2.Location = new System.Drawing.Point(296, 35);
            this.hslSwitch2.Name = "hslSwitch2";
            this.hslSwitch2.Size = new System.Drawing.Size(101, 109);
            this.hslSwitch2.SwitchForeground = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.hslSwitch2.SwitchStatusDescription = "抬起;按下";
            this.hslSwitch2.TabIndex = 29;
            this.hslSwitch2.Text = "工件控制器";
            this.hslSwitch2.OnSwitchChanged += new System.Action<object, bool>(this.hslSwitch2_OnSwitchChanged);
            // 
            // qdfstatus
            // 
            this.qdfstatus.AutoSize = true;
            this.qdfstatus.Location = new System.Drawing.Point(9, 152);
            this.qdfstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qdfstatus.Name = "qdfstatus";
            this.qdfstatus.Size = new System.Drawing.Size(135, 15);
            this.qdfstatus.TabIndex = 25;
            this.qdfstatus.Text = "气动阀当前状态：";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.hslPlay1);
            this.groupBox3.Controls.Add(this.hslButton5);
            this.groupBox3.Controls.Add(this.hslButton2);
            this.groupBox3.Controls.Add(this.hslButton4);
            this.groupBox3.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(12, 422);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(491, 132);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作区";
            // 
            // hslPlay1
            // 
            this.hslPlay1.ActiveColor = System.Drawing.Color.Red;
            this.hslPlay1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hslPlay1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.hslPlay1.Location = new System.Drawing.Point(16, 20);
            this.hslPlay1.Name = "hslPlay1";
            this.hslPlay1.Size = new System.Drawing.Size(79, 94);
            this.hslPlay1.TabIndex = 27;
            this.hslPlay1.Text = "自动运行";
            this.hslPlay1.OnPlayChanged += new System.Action<object, bool>(this.hslPlay1_OnPlayChanged);
            // 
            // hslButton5
            // 
            this.hslButton5.CustomerInformation = null;
            this.hslButton5.Location = new System.Drawing.Point(315, 72);
            this.hslButton5.Margin = new System.Windows.Forms.Padding(4);
            this.hslButton5.Name = "hslButton5";
            this.hslButton5.Size = new System.Drawing.Size(159, 38);
            this.hslButton5.TabIndex = 5;
            this.hslButton5.Text = "绘制流量曲线统计图";
            this.hslButton5.Click += new System.EventHandler(this.hslButton5_Click);
            // 
            // hslButton2
            // 
            this.hslButton2.CustomerInformation = null;
            this.hslButton2.Location = new System.Drawing.Point(155, 72);
            this.hslButton2.Margin = new System.Windows.Forms.Padding(4);
            this.hslButton2.Name = "hslButton2";
            this.hslButton2.Size = new System.Drawing.Size(115, 38);
            this.hslButton2.TabIndex = 3;
            this.hslButton2.Text = "误差修正";
            this.hslButton2.Click += new System.EventHandler(this.hslButton2_Click);
            // 
            // hslButton4
            // 
            this.hslButton4.CustomerInformation = null;
            this.hslButton4.Location = new System.Drawing.Point(155, 22);
            this.hslButton4.Margin = new System.Windows.Forms.Padding(4);
            this.hslButton4.Name = "hslButton4";
            this.hslButton4.Size = new System.Drawing.Size(115, 38);
            this.hslButton4.TabIndex = 26;
            this.hslButton4.Text = "保存数据";
            this.hslButton4.Click += new System.EventHandler(this.hslButton4_Click_1);
            // 
            // hslCurve1
            // 
            this.hslCurve1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hslCurve1.AutoScroll = true;
            this.hslCurve1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.hslCurve1.ColorDashLines = System.Drawing.Color.DimGray;
            this.hslCurve1.ColorLinesAndText = System.Drawing.Color.Silver;
            this.hslCurve1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.hslCurve1.Location = new System.Drawing.Point(12, 4);
            this.hslCurve1.Margin = new System.Windows.Forms.Padding(4);
            this.hslCurve1.Name = "hslCurve1";
            this.hslCurve1.Size = new System.Drawing.Size(652, 412);
            this.hslCurve1.TabIndex = 2;
            this.hslCurve1.ValueMaxLeft = 10F;
            this.hslCurve1.ValueMaxRight = 10F;
            this.hslCurve1.ValueSegment = 20;
            // 
            // systemInfo
            // 
            this.systemInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.systemInfo.AutoSize = true;
            this.systemInfo.Location = new System.Drawing.Point(13, 562);
            this.systemInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.systemInfo.Name = "systemInfo";
            this.systemInfo.Size = new System.Drawing.Size(87, 15);
            this.systemInfo.TabIndex = 28;
            this.systemInfo.Text = "系统信息：";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 634);
            this.Controls.Add(this.systemInfo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hslCurve1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "流量特性测试";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sbyali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel waterFlow;
        private System.Windows.Forms.ToolStripStatusLabel waterTemperature;
        private HslControls.HslCurve hslCurve1;
        private HslControls.HslButton hslButton2;
        private Automation.BDaq.InstantDoCtrl instantDoCtrl1;
        private Automation.BDaq.InstantAoCtrl m_instantAoCtrl;
        private Automation.BDaq.InstantDiCtrl instantDiCtrl1;
        private Automation.BDaq.InstantAiCtrl instantAiCtrl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sbzt;
        private System.Windows.Forms.Label bpqzt;
        private System.Windows.Forms.Label bpqfh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sbyali;
        private System.Windows.Forms.Label label1;
        private HslControls.HslButton open;
        private System.Windows.Forms.TextBox workName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label qdfstatus;
        private HslControls.HslButton hslButton4;
        private System.Windows.Forms.Label bpqreturn;
        private System.Windows.Forms.GroupBox groupBox3;
        private HslControls.HslButton hslButton5;
        private HslControls.HslBlower hslBlower1;
        private HslControls.HslSwitch hslSwitch1;
        private System.Windows.Forms.ToolStripStatusLabel maxWaterFlow;
        private System.Windows.Forms.Label systemInfo;
        private HslControls.HslSwitch hslSwitch2;
        private HslControls.HslPlay hslPlay1;
    }
}