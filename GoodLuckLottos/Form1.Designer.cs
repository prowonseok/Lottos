namespace GoodLuckLottos
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.lottoGridView = new System.Windows.Forms.DataGridView();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnColorStatistics = new System.Windows.Forms.Button();
            this.btnMenu4 = new System.Windows.Forms.Button();
            this.btnMenu6 = new System.Windows.Forms.Button();
            this.btnOddeorEven = new System.Windows.Forms.Button();
            this.btnMenu7 = new System.Windows.Forms.Button();
            this.btnOcrPerSec = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu8 = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.lottoSaveDlg = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.lottoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(24, 491);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "갱신";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lottoGridView
            // 
            this.lottoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lottoGridView.Location = new System.Drawing.Point(24, 12);
            this.lottoGridView.Name = "lottoGridView";
            this.lottoGridView.RowTemplate.Height = 23;
            this.lottoGridView.Size = new System.Drawing.Size(726, 440);
            this.lottoGridView.TabIndex = 12;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(181, 491);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(78, 23);
            this.btnSelectAll.TabIndex = 13;
            this.btnSelectAll.Text = "출력";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnColorStatistics
            // 
            this.btnColorStatistics.Location = new System.Drawing.Point(1152, 104);
            this.btnColorStatistics.Name = "btnColorStatistics";
            this.btnColorStatistics.Size = new System.Drawing.Size(93, 32);
            this.btnColorStatistics.TabIndex = 14;
            this.btnColorStatistics.Text = "자세히보기";
            this.btnColorStatistics.UseVisualStyleBackColor = true;
            this.btnColorStatistics.Click += new System.EventHandler(this.btnColorStatistics_Click);
            // 
            // btnMenu4
            // 
            this.btnMenu4.Location = new System.Drawing.Point(1152, 263);
            this.btnMenu4.Name = "btnMenu4";
            this.btnMenu4.Size = new System.Drawing.Size(93, 32);
            this.btnMenu4.TabIndex = 15;
            this.btnMenu4.Text = "자세히보기";
            this.btnMenu4.UseVisualStyleBackColor = true;
            this.btnMenu4.Click += new System.EventHandler(this.btnMenu4_Click);
            // 
            // btnMenu6
            // 
            this.btnMenu6.Location = new System.Drawing.Point(793, 420);
            this.btnMenu6.Name = "btnMenu6";
            this.btnMenu6.Size = new System.Drawing.Size(93, 32);
            this.btnMenu6.TabIndex = 16;
            this.btnMenu6.Text = "연속번호출현";
            this.btnMenu6.UseVisualStyleBackColor = true;
            this.btnMenu6.Click += new System.EventHandler(this.btnMenu6_Click);
            // 
            // btnOddeorEven
            // 
            this.btnOddeorEven.Location = new System.Drawing.Point(1152, 420);
            this.btnOddeorEven.Name = "btnOddeorEven";
            this.btnOddeorEven.Size = new System.Drawing.Size(93, 32);
            this.btnOddeorEven.TabIndex = 18;
            this.btnOddeorEven.Text = "자세히보기";
            this.btnOddeorEven.UseVisualStyleBackColor = true;
            this.btnOddeorEven.Click += new System.EventHandler(this.btnOddeorEven_Click);
            // 
            // btnMenu7
            // 
            this.btnMenu7.Location = new System.Drawing.Point(793, 583);
            this.btnMenu7.Name = "btnMenu7";
            this.btnMenu7.Size = new System.Drawing.Size(93, 32);
            this.btnMenu7.TabIndex = 17;
            this.btnMenu7.Text = "자세히보기";
            this.btnMenu7.UseVisualStyleBackColor = true;
            this.btnMenu7.Click += new System.EventHandler(this.btnMenu7_Click);
            // 
            // btnOcrPerSec
            // 
            this.btnOcrPerSec.Location = new System.Drawing.Point(793, 263);
            this.btnOcrPerSec.Name = "btnOcrPerSec";
            this.btnOcrPerSec.Size = new System.Drawing.Size(93, 32);
            this.btnOcrPerSec.TabIndex = 17;
            this.btnOcrPerSec.Text = "자세히보기";
            this.btnOcrPerSec.UseVisualStyleBackColor = true;
            this.btnOcrPerSec.Click += new System.EventHandler(this.btnOcrPerSec_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(793, 104);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(93, 32);
            this.btnStatistics.TabIndex = 19;
            this.btnStatistics.Text = "자세히보기";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoodLuckLottos.Properties.Resources.Menu;
            this.pictureBox1.Location = new System.Drawing.Point(767, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(713, 624);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenu8
            // 
            this.btnMenu8.Location = new System.Drawing.Point(1153, 491);
            this.btnMenu8.Name = "btnMenu8";
            this.btnMenu8.Size = new System.Drawing.Size(92, 23);
            this.btnMenu8.TabIndex = 20;
            this.btnMenu8.Text = "맞춰보기";
            this.btnMenu8.UseVisualStyleBackColor = true;
            this.btnMenu8.Click += new System.EventHandler(this.btnMenu8_Click);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(291, 491);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(123, 23);
            this.btnXml.TabIndex = 20;
            this.btnXml.Text = "Xml변환";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // lottoSaveDlg
            // 
            this.lottoSaveDlg.Filter = "xml 파일|*.xml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 655);
            this.Controls.Add(this.btnMenu8);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnOddeorEven);
            this.Controls.Add(this.btnMenu7);
            this.Controls.Add(this.btnOcrPerSec);
            this.Controls.Add(this.btnMenu6);
            this.Controls.Add(this.btnMenu4);
            this.Controls.Add(this.btnColorStatistics);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.lottoGridView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lottoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView lottoGridView;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnColorStatistics;
        private System.Windows.Forms.Button btnMenu4;
        private System.Windows.Forms.Button btnMenu6;

        private System.Windows.Forms.Button btnOddeorEven;

        private System.Windows.Forms.Button btnMenu7;


        private System.Windows.Forms.Button btnOcrPerSec;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog lottoSaveDlg;

        private System.Windows.Forms.Button btnMenu8;

        private System.Windows.Forms.Button btnXml;

    }
}

