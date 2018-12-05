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
        public FormOccurrencesPerSection(List<Lotto> lottoList)
        {
            InitializeComponent();
            this.lottoList = lottoList;
            
        }

        private void FormOccurrencesPerSection_Load(object sender, EventArgs e)
        {
            this.Text = "구간별 출현횟수";
            if (lottoList.Count<1)
            {
                MessageBox.Show("로또를 우선 출력해주세요!");
                this.Close();
                return;
                
            }
            string[] period = { "5주간", "10주간", "15주간" };
            cbxPerid.Items.AddRange(period);
            cbxPerid.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPerid.Text = period[0];
            ViewChart(5, rdoDivBy10.Checked);

        }

        private void ViewChart(int periodNo, bool check)
        {
            CreateChart();
            //caseCount = new int[5];
            if (rdoDivBy10.Checked)
            {
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
            else if(rdoDivBy5.Checked)
            {
                caseCount = new int[9];
                string[] rangeName = { "1-5", "6-10", "11-55", "16-20", "21-25", "26-30", "31-35", "36-40", "41-45" };
                for (int i = 0; i < periodNo; i++)
                {
                    sectionList.Add(lottoList[i]);
                }

                foreach (var item in sectionList)
                {
                    caseCount[0] = form1.Counter(caseCount[0], item, 0, 6, true);
                    caseCount[1] = form1.Counter(caseCount[1], item, 5, 11, true);
                    caseCount[2] = form1.Counter(caseCount[2], item, 10, 16, true);
                    caseCount[3] = form1.Counter(caseCount[3], item, 15, 21, true);
                    caseCount[4] = form1.Counter(caseCount[4], item, 20, 26, true);
                    caseCount[5] = form1.Counter(caseCount[5], item, 25, 31, true);
                    caseCount[6] = form1.Counter(caseCount[6], item, 30, 36, true);
                    caseCount[7] = form1.Counter(caseCount[7], item, 35, 41, true);
                    caseCount[8] = form1.Counter(caseCount[8], item, 40, 46, true);

                }
                chartBar.Series[0].Points.DataBindXY(rangeName, caseCount);
                chartBar.Series[0].Points[0].Color = Color.Orange;
                chartBar.Series[0].Points[1].Color = Color.Orange;
                chartBar.Series[0].Points[2].Color = Color.DeepSkyBlue;
                chartBar.Series[0].Points[3].Color = Color.DeepSkyBlue;
                chartBar.Series[0].Points[4].Color = Color.Red;
                chartBar.Series[0].Points[5].Color = Color.Red;
                chartBar.Series[0].Points[6].Color = Color.Gray;
                chartBar.Series[0].Points[7].Color = Color.Gray;
                chartBar.Series[0].Points[8].Color = Color.LawnGreen;
            }
            
        }
        private void CreateChart()
        {
            sectionList.Clear();
            chartBar.Series.Clear();
            chartBar.Titles.Clear();
            chartBar.Series.Add("LottoChartBar");
            chartBar.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            chartBar.Titles.Add("구간별 출현 횟수");
            chartBar.Titles[0].Font = new Font(new FontFamily(GenericFontFamilies.SansSerif), 20, FontStyle.Bold);
            chartBar.Series[0].IsValueShownAsLabel = true;
            chartBar.Series[0].IsVisibleInLegend = false;
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            CheckPeriod();
        }

        private void CheckPeriod()
        {
            if (rdoDivBy10.Checked == true)
            {
                if (cbxPerid.SelectedIndex == -1)
                {
                    MessageBox.Show("주간을 선택 해주세요.");
                }
                else if (cbxPerid.SelectedIndex == 0)
                {
                    ViewChart(5, rdoDivBy10.Checked);
                }
                else if (cbxPerid.SelectedIndex == 1)
                {
                    ViewChart(10, rdoDivBy10.Checked);
                }
                else
                {
                    ViewChart(15, rdoDivBy10.Checked);
                }
            }
            else
            {
                if (cbxPerid.SelectedIndex == -1)
                {
                    MessageBox.Show("주간을 선택 해주세요.");
                }
                else if (cbxPerid.SelectedIndex == 0)
                {
                    ViewChart(5, rdoDivBy5.Checked);
                }
                else if (cbxPerid.SelectedIndex == 1)
                {
                    ViewChart(10, rdoDivBy5.Checked);
                }
                else
                {
                    ViewChart(15, rdoDivBy5.Checked);
                }
            }
        }

    }
}
