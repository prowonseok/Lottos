using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodLuckLottos
{
    public partial class FormOccurrencesPerSection : Form
    {
        private List<Lotto> lottoList = new List<Lotto>();
        private List<Lotto> sectionList = new List<Lotto>();
        Form1 form1 = new Form1();
        private int[] caseCount;
        private int periodNo = 5;
        public FormOccurrencesPerSection(List<Lotto> lottoList)
        {
            InitializeComponent();
            this.lottoList = lottoList;
            
        }

        private void FormOccurrencesPerSection_Load(object sender, EventArgs e)
        {
            sectionList.Clear();
            chartBar.Titles.Add("구간별 출현 횟수");
            string[] period = { "5주간", "10주간", "15주간" };
            cbxPerid.Items.AddRange(period);
            cbxPerid.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPerid.Text = period[0];
            chartBar.Series[0].Name = "LottoChartBar";
            chartBar.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            chartBar.Titles[0].Font = new Font(new FontFamily(GenericFontFamilies.SansSerif), 20, FontStyle.Bold);
            chartBar.Series[0].IsValueShownAsLabel = true;
            chartBar.Series[0].IsVisibleInLegend = false;
            caseCount = new int[5];
            for (int i = 0; i < periodNo; i++)
            {
                sectionList.Add(lottoList[i]);
            }

            foreach (var item in sectionList)
            {
                caseCount[0] = form1.Counter(caseCount[0], item, 0, 11, true);
                caseCount[1] = form1.Counter(caseCount[1], item, 10, 21, true);
                caseCount[2] = form1.Counter(caseCount[2], item, 20, 31, true);
                caseCount[3] = form1.Counter(caseCount[3], item, 30, 41, true);
                caseCount[4] = form1.Counter(caseCount[4], item, 40, 46, true);
            }
            chartBar.Series[0].Points.DataBindXY(form1.GetRangeName, caseCount);
            chartBar.Series[0].Points[0].Color = Color.Orange;
            chartBar.Series[0].Points[1].Color = Color.DeepSkyBlue;
            chartBar.Series[0].Points[2].Color = Color.Red;
            chartBar.Series[0].Points[3].Color = Color.Gray;
            chartBar.Series[0].Points[4].Color = Color.LawnGreen;

        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            
        }
    }
}
