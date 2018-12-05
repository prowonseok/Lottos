namespace GoodLuckLottos
{
    partial class LottoOddorEven
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
            this.gridLotto = new System.Windows.Forms.DataGridView();
            this.lottoRotation1 = new System.Windows.Forms.ComboBox();
            this.lottoRotation2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridLotto)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLotto
            // 
            this.gridLotto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLotto.Location = new System.Drawing.Point(27, 86);
            this.gridLotto.Name = "gridLotto";
            this.gridLotto.RowTemplate.Height = 23;
            this.gridLotto.Size = new System.Drawing.Size(637, 440);
            this.gridLotto.TabIndex = 0;
            // 
            // lottoRotation1
            // 
            this.lottoRotation1.FormattingEnabled = true;
            this.lottoRotation1.Location = new System.Drawing.Point(432, 54);
            this.lottoRotation1.Name = "lottoRotation1";
            this.lottoRotation1.Size = new System.Drawing.Size(58, 20);
            this.lottoRotation1.TabIndex = 1;
            this.lottoRotation1.Text = "1";
            // 
            // lottoRotation2
            // 
            this.lottoRotation2.FormattingEnabled = true;
            this.lottoRotation2.Location = new System.Drawing.Point(517, 54);
            this.lottoRotation2.Name = "lottoRotation2";
            this.lottoRotation2.Size = new System.Drawing.Size(58, 20);
            this.lottoRotation2.TabIndex = 2;
            this.lottoRotation2.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "~";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "회차";
            // 
            // LottoOddorEven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 547);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lottoRotation2);
            this.Controls.Add(this.lottoRotation1);
            this.Controls.Add(this.gridLotto);
            this.Name = "LottoOddorEven";
            this.Text = "LottoOddorEven";
            this.Load += new System.EventHandler(this.LottoOddorEven_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLotto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLotto;
        private System.Windows.Forms.ComboBox lottoRotation1;
        private System.Windows.Forms.ComboBox lottoRotation2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}