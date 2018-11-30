namespace GoodLuckLottos
{
    partial class FormOccurrencesPerSection
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxPerid = new System.Windows.Forms.ComboBox();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.rdoDivBy10 = new System.Windows.Forms.RadioButton();
            this.rdoDivBy5 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartBar)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBar
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBar.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBar.Legends.Add(legend1);
            this.chartBar.Location = new System.Drawing.Point(12, 67);
            this.chartBar.Name = "chartBar";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBar.Series.Add(series1);
            this.chartBar.Size = new System.Drawing.Size(702, 416);
            this.chartBar.TabIndex = 0;
            this.chartBar.Text = "chart1";
            // 
            // cbxPerid
            // 
            this.cbxPerid.FormattingEnabled = true;
            this.cbxPerid.Location = new System.Drawing.Point(12, 489);
            this.cbxPerid.Name = "cbxPerid";
            this.cbxPerid.Size = new System.Drawing.Size(121, 20);
            this.cbxPerid.TabIndex = 1;
            // 
            // btnPeriod
            // 
            this.btnPeriod.Location = new System.Drawing.Point(152, 489);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(75, 23);
            this.btnPeriod.TabIndex = 2;
            this.btnPeriod.Text = "조회";
            this.btnPeriod.UseVisualStyleBackColor = true;
            this.btnPeriod.Click += new System.EventHandler(this.btnPeriod_Click);
            // 
            // rdoDivBy10
            // 
            this.rdoDivBy10.AutoSize = true;
            this.rdoDivBy10.Checked = true;
            this.rdoDivBy10.Location = new System.Drawing.Point(33, 29);
            this.rdoDivBy10.Name = "rdoDivBy10";
            this.rdoDivBy10.Size = new System.Drawing.Size(59, 16);
            this.rdoDivBy10.TabIndex = 3;
            this.rdoDivBy10.TabStop = true;
            this.rdoDivBy10.Text = "10번대";
            this.rdoDivBy10.UseVisualStyleBackColor = true;
            // 
            // rdoDivBy5
            // 
            this.rdoDivBy5.AutoSize = true;
            this.rdoDivBy5.Location = new System.Drawing.Point(113, 29);
            this.rdoDivBy5.Name = "rdoDivBy5";
            this.rdoDivBy5.Size = new System.Drawing.Size(53, 16);
            this.rdoDivBy5.TabIndex = 4;
            this.rdoDivBy5.Text = "5번대";
            this.rdoDivBy5.UseVisualStyleBackColor = true;
            // 
            // FormOccurrencesPerSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 535);
            this.Controls.Add(this.rdoDivBy5);
            this.Controls.Add(this.rdoDivBy10);
            this.Controls.Add(this.btnPeriod);
            this.Controls.Add(this.cbxPerid);
            this.Controls.Add(this.chartBar);
            this.Name = "FormOccurrencesPerSection";
            this.Text = "FormOccurrencesPerSection";
            this.Load += new System.EventHandler(this.FormOccurrencesPerSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataVisualization.Charting.Chart chartBar;
        private System.Windows.Forms.ComboBox cbxPerid;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.RadioButton rdoDivBy10;
        private System.Windows.Forms.RadioButton rdoDivBy5;
    }
}