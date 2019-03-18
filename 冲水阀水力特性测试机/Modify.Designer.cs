namespace 冲水阀水力特性测试机
{
    partial class Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modify));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.modifyTemperature = new System.Windows.Forms.NumericUpDown();
            this.modifyFlow = new System.Windows.Forms.NumericUpDown();
            this.modifyHammer = new System.Windows.Forms.NumericUpDown();
            this.modifyPressure = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modifyTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyHammer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyPressure)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "压力：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "冲击力：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "流量：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "温度：";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.modifyTemperature, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.modifyFlow, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.modifyHammer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.modifyPressure, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(48, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.23967F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.76033F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 304);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // modifyTemperature
            // 
            this.modifyTemperature.DecimalPlaces = 1;
            this.modifyTemperature.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modifyTemperature.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.modifyTemperature.Location = new System.Drawing.Point(153, 238);
            this.modifyTemperature.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.modifyTemperature.Name = "modifyTemperature";
            this.modifyTemperature.Size = new System.Drawing.Size(110, 38);
            this.modifyTemperature.TabIndex = 9;
            this.modifyTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modifyTemperature.ValueChanged += new System.EventHandler(this.modifyTemperature_ValueChanged);
            // 
            // modifyFlow
            // 
            this.modifyFlow.DecimalPlaces = 1;
            this.modifyFlow.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modifyFlow.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.modifyFlow.Location = new System.Drawing.Point(153, 167);
            this.modifyFlow.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.modifyFlow.Name = "modifyFlow";
            this.modifyFlow.Size = new System.Drawing.Size(110, 38);
            this.modifyFlow.TabIndex = 8;
            this.modifyFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modifyFlow.ValueChanged += new System.EventHandler(this.modifyFlow_ValueChanged);
            // 
            // modifyHammer
            // 
            this.modifyHammer.DecimalPlaces = 1;
            this.modifyHammer.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modifyHammer.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.modifyHammer.Location = new System.Drawing.Point(153, 87);
            this.modifyHammer.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.modifyHammer.Name = "modifyHammer";
            this.modifyHammer.Size = new System.Drawing.Size(110, 38);
            this.modifyHammer.TabIndex = 7;
            this.modifyHammer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modifyHammer.ValueChanged += new System.EventHandler(this.modifyHammer_ValueChanged);
            // 
            // modifyPressure
            // 
            this.modifyPressure.DecimalPlaces = 1;
            this.modifyPressure.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modifyPressure.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.modifyPressure.Location = new System.Drawing.Point(153, 3);
            this.modifyPressure.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.modifyPressure.Name = "modifyPressure";
            this.modifyPressure.Size = new System.Drawing.Size(110, 38);
            this.modifyPressure.TabIndex = 6;
            this.modifyPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modifyPressure.ValueChanged += new System.EventHandler(this.modifyPressure_ValueChanged);
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 435);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Modify";
            this.Text = "误差调整";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Modify_FormClosed);
            this.Load += new System.EventHandler(this.Modify_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modifyTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyHammer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyPressure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown modifyTemperature;
        private System.Windows.Forms.NumericUpDown modifyFlow;
        private System.Windows.Forms.NumericUpDown modifyHammer;
        private System.Windows.Forms.NumericUpDown modifyPressure;
    }
}