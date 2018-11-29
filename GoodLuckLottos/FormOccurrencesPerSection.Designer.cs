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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxPerid = new System.Windows.Forms.ComboBox();
            this.btnPeriod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartBar)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBar
            // 
            chartArea4.Name = "ChartArea1";
            this.chartBar.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartBar.Legends.Add(legend4);
            this.chartBar.Location = new System.Drawing.Point(12, 12);
            this.chartBar.Name = "chartBar";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartBar.Series.Add(series4);
            this.chartBar.Size = new System.Drawing.Size(702, 416);
            this.chartBar.TabIndex = 0;
            this.chartBar.Text = "chart1";
            // 
            // cbxPerid
            // 
            this.cbxPerid.FormattingEnabled = true;
            this.cbxPerid.Location = new System.Drawing.Point(12, 448);
            this.cbxPerid.Name = "cbxPerid";
            this.cbxPerid.Size = new System.Drawing.Size(121, 20);
            this.cbxPerid.TabIndex = 1;
            // 
            // btnPeriod
            // 
            this.btnPeriod.Location = new System.Drawing.Point(152, 448);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(75, 23);
            this.btnPeriod.TabIndex = 2;
            this.btnPeriod.Text = "조회";
            this.btnPeriod.UseVisualStyleBackColor = true;
            this.btnPeriod.Click += new System.EventHandler(this.btnPeriod_Click);
            // 
            // FormOccurrencesPerSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 480);
            this.Controls.Add(this.btnPeriod);
            this.Controls.Add(this.cbxPerid);
            this.Controls.Add(this.chartBar);
            this.Name = "FormOccurrencesPerSection";
            this.Text = "FormOccurrencesPerSection";
            this.Load += new System.EventHandler(this.FormOccurrencesPerSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataVisualization.Charting.Chart chartBar;
        private System.Windows.Forms.ComboBox cbxPerid;
        private System.Windows.Forms.Button btnPeriod;
    }
}