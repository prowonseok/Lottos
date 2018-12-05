using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodLuckLottos
{
    public partial class LottoStatistics : Form
    {
        List<Lotto> lottoList = new List<Lotto>();
        public LottoStatistics(List<Lotto> lottoList)
        {            
            this.lottoList = lottoList;
            InitializeComponent();
        }

        private void LottoStatistics_Load(object sender, EventArgs e)
        {
            this.Text = "번호별 통계";
            this.txtLotto.Clear();    
            
            foreach (var item in lottoList) //시작 회차
            {
                this.lottoRotation1.Items.Add(item.WinningDateNo);
                this.lottoRotation2.Items.Add(item.WinningDateNo);
            }
            //button1_Click_1(null, null);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            bool bonusCheck = false; //보너스번호 체크판단 
            if (chbBonusCheck.Text=="포함")
            {
                bonusCheck = true;
            }
            if (Int32.Parse(lottoRotation2.Text)< Int32.Parse(lottoRotation1.Text)) //회차구간 예외처리
            {
                MessageBox.Show("앞자리 숫자가 뒷자리 숫자보다 클 수 없습니다.");
                return;
            }
            if (lottoList[0].WinningDateNo != 1)
            {
                lottoList.Reverse();
            }
            int[] lottoNum = new int[46]; //배열에 공별로 값 누적               

            for (int i = Int32.Parse(this.lottoRotation1.Text) - 1; i <= Int32.Parse(this.lottoRotation2.Text) - 1; i++)//~회차부터 ~회차까지 반복
            {
                for (int j = 1; j <= 45; j++) // 당첨번호 누적
                {
                    if (j == lottoList[i].LottoNo1 || j == lottoList[i].LottoNo2 || j == lottoList[i].LottoNo3 || j == lottoList[i].LottoNo4 || j == lottoList[i].LottoNo5 || j == lottoList[i].LottoNo6)
                    {
                        lottoNum[0] = 0;
                        lottoNum[j]++;
                    }
                    if (bonusCheck && j==lottoList[i].LottoBonusNo)
                    {
                        lottoNum[j]++;
                    }
                }
            }
            lottoChart.ChartAreas[0].AxisX.Maximum = 46; //차트에 표시할 최대 x축 값
            lottoChart.ChartAreas[0].AxisX.Minimum = 1; //차트에 표시할 최대 y축 값
            lottoChart.ChartAreas[0].AxisX.Interval = 1; //x축 값 상승간격

            int a = 0; //카운트
            string[] lottoTry = new string[46];
            string[] reverseLottoTry = new string[47];
            lottoTry[1] = "회차";
          
            
            foreach (var item in lottoNum)
            {                
                lottoTry[a] = item.ToString(); //Lines프로퍼티 사용하기위해 스트링배열에 다시 누적               
                lottoChart.Series[0].Points.AddXY(a, Int32.Parse(item.ToString()));//당첨된 공번호 누적값 차트에 표시
                a++;
            }

            a = 1; //카운트 초기화
            int lottotry = lottoTry.Count() - 1;
            reverseLottoTry[0] = "당첨 횟수";

            for (int i = lottotry; i > -1; i--) //당첨공번호 누적값 거꾸로 다시저장
            {
                reverseLottoTry[a] = lottoTry[i];
                a++;
            }
            txtLotto.Lines = reverseLottoTry; // Text박스에 당첨횟수 출력
            lottoChart.DataSource = null;

        }
    }
}
