namespace 冲水阀水力特性测试机
{
    partial class Curve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Curve));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hslButton1 = new HslControls.HslButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hslButton5 = new HslControls.HslButton();
            this.hslButton6 = new HslControls.HslButton();
            this.hslButton2 = new HslControls.HslButton();
            this.hslCurveHistory2 = new HslControls.HslCurveHistory();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.hslCurveHistory1 = new HslControls.HslCurveHistory();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1508, 577);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hslCurveHistory1);
            this.tabPage1.Controls.Add(this.hslButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1500, 548);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "EN 6L流量统计图";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // hslButton1
            // 
            this.hslButton1.ActiveColor = System.Drawing.Color.Cyan;
            this.hslButton1.CustomerInformation = null;
            this.hslButton1.EnableColor = System.Drawing.Color.DodgerBlue;
            this.hslButton1.Location = new System.Drawing.Point(1253, 277);
            this.hslButton1.Margin = new System.Windows.Forms.Padding(4);
            this.hslButton1.Name = "hslButton1";
            this.hslButton1.OriginalColor = System.Drawing.Color.PaleGreen;
            this.hslButton1.Size = new System.Drawing.Size(104, 40);
            this.hslButton1.TabIndex = 1;
            this.hslButton1.Text = "保存图像";
            this.hslButton1.Click += new System.EventHandler(this.hslButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.hslButton5);
            this.tabPage2.Controls.Add(this.hslButton6);
            this.tabPage2.Controls.Add(this.hslButton2);
            this.tabPage2.Controls.Add(this.hslCurveHistory2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1500, 548);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "EN 9L流量统计图";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // hslButton5
            // 
            this.hslButton5.ActiveColor = System.Drawing.Color.Cyan;
            this.hslButton5.CustomerInformation = null;
            this.hslButton5.EnableColor = System.Drawing.Color.DodgerBlue;
            this.hslButton5.Location = new System.Drawing.Point(1157, 6);
            this.hslButton5.Margin = new System.Windows.Forms.Padding(4);
            this.hslButton5.Name = "hslButton5";
            this.hslButton5.OriginalColor = System.Drawing.Color.PaleGreen;
            this.hslButton5.Size = new System.Drawing.Size(104, 40);
            this.hslButton5.TabIndex = 5;
            this.hslButton5.Text = "缩小-";
            this.hslButton5.Click += new System.EventHandler(this.hslButton5_Click);
            // 
            // hslButton6
            // 
            this.hslButton6.ActiveColor = System.Drawing.Color.Cyan;
            this.hslButton6.CustomerInformation = null;
            this.hslButton6.EnableColor = System.Drawing.Color.DodgerBlue;
            this.hslButton6.Location = new System.Drawing.Point(1025, 6);
            this.hslButton6.Margin = new System.Windows.Forms.Padding(4);
            this.hslButton6.Name = "hslButton6";
            this.hslButton6.OriginalColor = System.Drawing.Color.PaleGreen;
            this.hslButton6.Size = new System.Drawing.Size(104, 40);
            this.hslButton6.TabIndex = 4;
            this.hslButton6.Text = "放大+";
            this.hslButton6.Click += new System.EventHandler(this.hslButton6_Click);
            // 
            // hslButton2
            // 
            this.hslButton2.ActiveColor = System.Drawing.Color.Cyan;
            this.hslButton2.CustomerInformation = null;
            this.hslButton2.EnableColor = System.Drawing.Color.DodgerBlue;
            this.hslButton2.Location = new System.Drawing.Point(1380, 6);
            this.hslButton2.Margin = new System.Windows.Forms.Padding(4);
            this.hslButton2.Name = "hslButton2";
            this.hslButton2.OriginalColor = System.Drawing.Color.PaleGreen;
            this.hslButton2.Size = new System.Drawing.Size(104, 40);
            this.hslButton2.TabIndex = 2;
            this.hslButton2.Text = "保存图像";
            this.hslButton2.Click += new System.EventHandler(this.hslButton2_Click);
            // 
            // hslCurveHistory2
            // 
            this.hslCurveHistory2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.hslCurveHistory2.DashCoordinateColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.hslCurveHistory2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hslCurveHistory2.Location = new System.Drawing.Point(3, 2);
            this.hslCurveHistory2.Margin = new System.Windows.Forms.Padding(4);
            this.hslCurveHistory2.MarkTextColor = System.Drawing.Color.Yellow;
            this.hslCurveHistory2.Name = "hslCurveHistory2";
            this.hslCurveHistory2.Size = new System.Drawing.Size(1494, 544);
            this.hslCurveHistory2.TabIndex = 0;
            this.hslCurveHistory2.Text = "累计流量未达到9L，请继续测试...";
            this.hslCurveHistory2.ValueMaxLeft = 10F;
            this.hslCurveHistory2.ValueMaxRight = 10F;
            this.hslCurveHistory2.ValueSegment = 20;
            this.hslCurveHistory2.Load += new System.EventHandler(this.hslCurveHistory2_Load);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(979, 495);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "BSEN 流量统计图";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // hslCurveHistory1
            // 
            this.hslCurveHistory1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.hslCurveHistory1.DashCoordinateColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.hslCurveHistory1.Location = new System.Drawing.Point(6, 0);
            this.hslCurveHistory1.MarkTextColor = System.Drawing.Color.Yellow;
            this.hslCurveHistory1.Name = "hslCurveHistory1";
            this.hslCurveHistory1.Size = new System.Drawing.Size(954, 451);
            this.hslCurveHistory1.TabIndex = 2;
            this.hslCurveHistory1.Text = "hslCurveHistory1";
            // 
            // Curve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1508, 577);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Curve";
            this.Text = "流量曲线统计图";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Curve_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private HslControls.HslCurveHistory hslCurveHistory2;
        private HslControls.HslButton hslButton1;
        private HslControls.HslButton hslButton2;
        private HslControls.HslButton hslButton5;
        private HslControls.HslButton hslButton6;
        private HslControls.HslCurveHistory hslCurveHistory1;
    }
}