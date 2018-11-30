namespace GoodLuckLottos
{
    partial class LottoStatistics
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
            this.lottoChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lottoRotation1 = new System.Windows.Forms.ComboBox();
            this.lottoRotation2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLotto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lottoChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lottoChart
            // 
            chartArea4.Name = "ChartArea1";
            this.lottoChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.lottoChart.Legends.Add(legend4);
            this.lottoChart.Location = new System.Drawing.Point(28, 63);
            this.lottoChart.Name = "lottoChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.lottoChart.Series.Add(series4);
            this.lottoChart.Size = new System.Drawing.Size(813, 518);
            this.lottoChart.TabIndex = 0;
            this.lottoChart.Text = "chart1";
            // 
            // lottoRotation1
            // 
            this.lottoRotation1.FormattingEnabled = true;
            this.lottoRotation1.Location = new System.Drawing.Point(604, 36);
            this.lottoRotation1.Name = "lottoRotation1";
            this.lottoRotation1.Size = new System.Drawing.Size(59, 20);
            this.lottoRotation1.TabIndex = 1;
            this.lottoRotation1.Text = "1";
            // 
            // lottoRotation2
            // 
            this.lottoRotation2.FormattingEnabled = true;
            this.lottoRotation2.Location = new System.Drawing.Point(684, 36);
            this.lottoRotation2.Name = "lottoRotation2";
            this.lottoRotation2.Size = new System.Drawing.Size(72, 20);
            this.lottoRotation2.TabIndex = 2;
            this.lottoRotation2.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "~";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(776, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtLotto
            // 
            this.txtLotto.Location = new System.Drawing.Point(701, 65);
            this.txtLotto.Multiline = true;
            this.txtLotto.Name = "txtLotto";
            this.txtLotto.Size = new System.Drawing.Size(100, 473);
            this.txtLotto.TabIndex = 5;
            // 
            // LottoStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 593);
            this.Controls.Add(this.txtLotto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lottoRotation2);
            this.Controls.Add(this.lottoRotation1);
            this.Controls.Add(this.lottoChart);
            this.Name = "LottoStatistics";
            this.Text = "LottoStatistics";
            this.Load += new System.EventHandler(this.LottoStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lottoChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart lottoChart;
        private System.Windows.Forms.ComboBox lottoRotation1;
        private System.Windows.Forms.ComboBox lottoRotation2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLotto;
    }
}