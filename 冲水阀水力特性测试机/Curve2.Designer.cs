namespace 冲水阀水力特性测试机
{
    partial class Curve2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hslCurveHistory1 = new HslControls.HslCurveHistory();
            this.hslCurveHistory2 = new HslControls.HslCurveHistory();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 535);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hslCurveHistory1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.hslCurveHistory2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // hslCurveHistory1
            // 
            this.hslCurveHistory1.AutoSize = true;
            this.hslCurveHistory1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.hslCurveHistory1.DashCoordinateColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.hslCurveHistory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hslCurveHistory1.Location = new System.Drawing.Point(3, 3);
            this.hslCurveHistory1.MarkTextColor = System.Drawing.Color.Yellow;
            this.hslCurveHistory1.Name = "hslCurveHistory1";
            this.hslCurveHistory1.Size = new System.Drawing.Size(887, 500);
            this.hslCurveHistory1.TabIndex = 0;
            this.hslCurveHistory1.Text = "hslCurveHistory1";
            this.hslCurveHistory1.ValueMaxLeft = 10F;
            this.hslCurveHistory1.ValueMaxRight = 10F;
            this.hslCurveHistory1.ValueSegment = 20;
            // 
            // hslCurveHistory2
            // 
            this.hslCurveHistory2.AutoSize = true;
            this.hslCurveHistory2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.hslCurveHistory2.DashCoordinateColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.hslCurveHistory2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hslCurveHistory2.Location = new System.Drawing.Point(3, 3);
            this.hslCurveHistory2.MarkTextColor = System.Drawing.Color.Yellow;
            this.hslCurveHistory2.Name = "hslCurveHistory2";
            this.hslCurveHistory2.Size = new System.Drawing.Size(887, 500);
            this.hslCurveHistory2.TabIndex = 1;
            this.hslCurveHistory2.Text = "hslCurveHistory2";
            this.hslCurveHistory2.ValueMaxLeft = 10F;
            this.hslCurveHistory2.ValueMaxRight = 10F;
            this.hslCurveHistory2.ValueSegment = 20;
            // 
            // Curve2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 535);
            this.Controls.Add(this.tabControl1);
            this.Name = "Curve2";
            this.Text = "Curve2";
            this.Load += new System.EventHandler(this.Curve2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private HslControls.HslCurveHistory hslCurveHistory1;
        private HslControls.HslCurveHistory hslCurveHistory2;
    }
}