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
using HtmlAgilityPack;

namespace GoodLuckLottos
{
    public partial class Form1 : Form
    {
        #region Form1의 Load 이벤트, DB연결, 저장(갱신)버튼이벤트, 전체출력 이벤트.
        FormColorStatistics formColorStatistics;
        SqlDbConnection sqlDbConnection;
        SqlConnection connection;
        SqlDataReader sdr;
        List<Lotto> lottoList = new List<Lotto>();
        private int winningDateNumber = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayAll();
        }

        //SqlDbConnection 클래스에서 싱글톤 객체를 받아와 DB를 Open 하는 메서드
        private void ConnectDb()
        {
            sqlDbConnection = SqlDbConnection.GetInstance();
            connection = sqlDbConnection.Connect;
            sqlDbConnection.DBConnect();
        }

        //Lotto 홈페이지의 회차, 번호를 저장(갱신)하는 이벤트 메서드.
        private void btnSave_Click(object sender, EventArgs e)
        {
            ConnectDb();
            bool check = false;
            SqlCommand comm = ConnectProcedure();
            comm.CommandText = "selectRecentDate";
            try
            {
                sdr = comm.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        winningDateNumber = Convert.ToInt32(sdr["WinDateNo"].ToString()) + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("다시DB를 연결 해 주세요!\n" + ex.Message);
            }
            sdr.Close();
            while (!check)
            {
                string html = "http://nlotto.co.kr/gameResult.do?method=byWin&drwNo=" + winningDateNumber;
                HtmlAgilityPack.HtmlWeb htmlWeb = new HtmlAgilityPack.HtmlWeb();
                HtmlAgilityPack.HtmlDocument htmlDoc = htmlWeb.Load(html);
                HtmlNode body = htmlDoc.DocumentNode.SelectSingleNode("//body");
                //1회~835회까지 읽어온다
                //만약 다음회차가 없으면 회차가 없음을 출력.
                //있으면 다음회차 읽어와 DB에 저장
                //1회차만 읽어와 클래스에 저장. 
                foreach (var item in body.SelectNodes("//div")/*htmlDoc.DocumentNode.SelectNodes("//div")*/)
                {
                    if (item.GetAttributeValue("class", "Not Found") == "lotto_win_number mt12")
                    {
                        if (string.IsNullOrEmpty(item.ChildNodes["p"].SelectSingleNode("img").GetAttributeValue("alt", "not found")))
                        {
                            check = true;
                        }
                        else
                        {
                            Lotto lotto = new Lotto(Convert.ToInt32(item.ChildNodes["h3"].FirstChild.InnerText), Convert.ToInt32(item.ChildNodes["p"].SelectNodes("img")[0].GetAttributeValue("alt", "not found")), Convert.ToInt32(item.ChildNodes["p"].SelectNodes("img")[1].GetAttributeValue("alt", "not found")), Convert.ToInt32(item.ChildNodes["p"].SelectNodes("img")[2].GetAttributeValue("alt", "not found")), Convert.ToInt32(item.ChildNodes["p"].SelectNodes("img")[3].GetAttributeValue("alt", "not found")), Convert.ToInt32(item.ChildNodes["p"].SelectNodes("img")[4].GetAttributeValue("alt", "not found")), Convert.ToInt32(item.ChildNodes["p"].SelectNodes("img")[5].GetAttributeValue("alt", "not found")), Convert.ToInt32(item.ChildNodes["p"].ChildNodes[15].FirstChild.GetAttributeValue("alt", "not found")));


                            SqlCommand command = ConnectProcedure();
                            command.CommandText = "InsertbyLottoNo";

                            command.Parameters.AddWithValue("lottoNo1", lotto.LottoNo1);
                            command.Parameters.AddWithValue("lottoNo2", lotto.LottoNo2);
                            command.Parameters.AddWithValue("lottoNo3", lotto.LottoNo3);
                            command.Parameters.AddWithValue("lottoNo4", lotto.LottoNo4);
                            command.Parameters.AddWithValue("lottoNo5", lotto.LottoNo5);
                            command.Parameters.AddWithValue("lottoNo6", lotto.LottoNo6);
                            command.Parameters.AddWithValue("lottoBonusNo", lotto.LottoBonusNo);
                            int result = 0;
                            try
                            {
                                result = command.ExecuteNonQuery();
                            }
                            catch (InvalidOperationException ex)
                            {
                                MessageBox.Show("연결 실패 \n" + ex.Message);
                            }
                        }
                        break;
                    }
                }
                winningDateNumber++;
            }
            connection.Close();
            lottoGridView.DataSource = lottoList;
        }

        //DB의 저장프로시저의 빈번한 사용을 대비한 저장프로시저 Command 메서드.
        private SqlCommand ConnectProcedure()
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = connection;
            return comm;
        }

        //전체 출력하는 메서드.
        private void DisplayAll()
        {
            ConnectDb();
            lottoList.Clear();
            lottoGridView.DataSource = null;
            SqlCommand command = ConnectProcedure();
            command.CommandText = "selectByLottos";
            try
            {
                sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    lottoList.Add(new Lotto(Convert.ToInt32(sdr["WinDateNo"]), Convert.ToInt32(sdr["LottoNo1"]), Convert.ToInt32(sdr["LottoNo2"]), Convert.ToInt32(sdr["LottoNo3"]), Convert.ToInt32(sdr["LottoNo4"]), Convert.ToInt32(sdr["LottoNo5"]), Convert.ToInt32(sdr["LottoNo6"]), Convert.ToInt32(sdr["LottoBonusNo"])));
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("다시DB를 연결 해 주세요!\n" + ex.Message);
            }
            sdr.Close();
            connection.Close();
            //리스트를 내림차순으로 정렬.(가장 최근의 값부터 출력된다.)
            lottoList.Reverse();
            lottoGridView.DataSource = lottoList;
        }

        //전체 출력하는 메서드.
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            DisplayAll();
        } 
        #endregion

        //차트버튼클릭이벤트 - 예준
        private void btnColorStatistics_Click(object sender, EventArgs e)
        {
            if (!(formColorStatistics == null || !formColorStatistics.Visible))
            {
                formColorStatistics.Focus();
                return;
            }
            formColorStatistics = new FormColorStatistics();
            formColorStatistics.Load += FormColorStatistics_Load;
            formColorStatistics.Show();
            formColorStatistics.chartPie.MouseMove += ChartPie_MouseMove;
        }

        //FormColorStatistics의 로드 이벤트. - 예준
        private void FormColorStatistics_Load(object sender, EventArgs e)
        {
            int[] caseCount = new int[5];
            formColorStatistics.chartPie.Series[0].Name = "Lotto";
            formColorStatistics.chartPie.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            formColorStatistics.chartPie.Series[0].Points.AddXY("1~10", 100);
            
            foreach (var item in lottoList)
            {
                //item의 Lotto1~6까지의 멤버변수에서 1~10까지의 값이 나올때 caseCount ++ 하기
                CountOne(0, item, 0, 11);
                //caseCount[1] = CountOne(item, 10, 21);
                //caseCount[2] = CountOne(item, 20, 31);
                //caseCount[3] = CountOne(item, 30, 41);
                //caseCount[4] = CountOne(item, 40, 51);
            }
            MessageBox.Show(caseCount[0].ToString());

        }

        //로또 리스트에서 카운트하는 메서드 - 예준
        private void CountOne(int caseCount, Lotto item, int start, int end)
        {
            
            if (item.LottoNo1 > start && item.LottoNo1 < end)
            {
                caseCount++;
            }
            if (item.LottoNo2 > start && item.LottoNo2 < end)
            {
                caseCount++;
            }
            if (item.LottoNo3 > start && item.LottoNo3 < end)
            {
                caseCount++;
            }
            if (item.LottoNo4 > start && item.LottoNo4 < end)
            {
                caseCount++;
            }
            if (item.LottoNo5 > start && item.LottoNo5 < end)
            {
                caseCount++;
            }
            if (item.LottoNo6 > start && item.LottoNo6 < end)
            {
                caseCount++;
            }
        }

        //툴팁 - 예준
        ToolTip toolTipChartPie = new ToolTip();

        //FormColorStatistics의 차트 MouseMove 이벤트 - 예준
        private void ChartPie_MouseMove(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnMenu6_Click(object sender, EventArgs e)
        {
            FrmMenu6 fm6 = new FrmMenu6(lottoList);
            fm6.ShowDialog();
        }

        private void btnMenu4_Click(object sender, EventArgs e)
        {
            FrmMenu4 fm4 = new FrmMenu4(lottoList);
            fm4.ShowDialog();
        }

        private void btnMenu7_Click(object sender, EventArgs e)
        {
            FrmMenu7 fm7 = new FrmMenu7(lottoList);
            fm7.ShowDialog();
        }
    }
}
