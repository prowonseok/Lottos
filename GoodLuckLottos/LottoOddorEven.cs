using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodLuckLottos
{
    public partial class LottoOddorEven : Form
    {
        List<Lotto> lottoList = new List<Lotto>();
        public LottoOddorEven(List<Lotto> lottos)
        {            
            
            this.lottoList = lottos;
            InitializeComponent();
        }

        private void LottoOddorEven_Load(object sender, EventArgs e)
        {                  
            foreach (var item in lottoList) //시작 회차
            {
                this.lottoRotation1.Items.Add(item.WinningDateNo);                
                this.lottoRotation2.Items.Add(item.WinningDateNo);
            }
            button1_Click(null, null);
            
        }
        private DataTable lottoTable;
        private void button1_Click(object sender, EventArgs e)
        {
            if (lottoList[0].WinningDateNo!=1)
            {
                lottoList.Reverse();
            }
            if (Int32.Parse(lottoRotation2.Text) < Int32.Parse(lottoRotation1.Text))
            {
                MessageBox.Show("앞자리 숫자가 뒷자리 숫자보다 클 수 없습니다.");
                return;
            }            

            this.gridLotto.DataSource = null;
            if (Int32.Parse(lottoRotation2.Text) < Int32.Parse(lottoRotation1.Text))
            {
                MessageBox.Show("앞자리 숫자가 뒷자리 숫자보다 클 수 없습니다.");
                return;
            }
            lottoTable = new DataTable();
            lottoTable.Columns.Add("회차");
            lottoTable.Columns.Add("홀수");
            lottoTable.Columns.Add("짝수");
            lottoTable.Columns.Add("번호 합");
            
            string even = "";
            string odd = "";
            
            for (int i = Int32.Parse(this.lottoRotation1.Text); i <= Int32.Parse(this.lottoRotation2.Text); i++)
            {
                even = odd = "";
                DataRow row = lottoTable.NewRow();

                row["회차"] = lottoList[i-1].WinningDateNo;

                if ((lottoList[i-1].LottoNo1 % 2) == 0)
                {
                    even += lottoList[i - 1].LottoNo1.ToString() + ", ";
                }
                else
                {
                    odd += lottoList[i - 1].LottoNo1.ToString() + ", ";
                }

                if ((lottoList[i - 1].LottoNo2 % 2) == 0)
                {
                    even += lottoList[i - 1].LottoNo2.ToString() + ", ";
                }
                else
                {
                    odd += lottoList[i - 1].LottoNo2.ToString() + ", ";
                }

                if ((lottoList[i - 1].LottoNo3 % 2) == 0)
                {
                    even += lottoList[i - 1].LottoNo3.ToString() + ", ";
                }
                else
                {
                    odd += lottoList[i - 1].LottoNo3.ToString() + ", ";
                }

                if ((lottoList[i - 1].LottoNo4 % 2) == 0)
                {
                    even += lottoList[i - 1].LottoNo4.ToString() + ", ";
                }
                else
                {
                    odd += lottoList[i - 1].LottoNo4.ToString() + ", ";
                }

                if ((lottoList[i-1].LottoNo5 % 2) == 0)
                {                    
                    even += lottoList[i - 1].LottoNo5.ToString() + ", ";                   
                }
                else
                {
                    odd += lottoList[i - 1].LottoNo5.ToString() + ", ";
                }

                if ((lottoList[i - 1].LottoNo6 % 2) == 0)
                {
                    even += lottoList[i - 1].LottoNo6.ToString() + ", ";
                }
                else
                {
                    odd += lottoList[i - 1].LottoNo6.ToString() + ", ";
                }

                row["짝수"] = even.Replace(" ", "").TrimEnd(',');
                row["홀수"] = odd.Replace(" ", "").TrimEnd(',');
                row["번호 합"] = lottoList[i - 1].LottoNo1 + lottoList[i - 1].LottoNo2 + lottoList[i - 1].LottoNo3 + lottoList[i - 1].LottoNo4 + lottoList[i - 1].LottoNo5 + lottoList[i - 1].LottoNo6;
                lottoTable.Rows.Add(row);
            }    
            this.gridLotto.DataSource = lottoTable;            
        }
    }
}
