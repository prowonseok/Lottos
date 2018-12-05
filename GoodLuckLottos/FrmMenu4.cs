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
    public partial class FrmMenu4 : Form
    {
        List<Lotto> lottoList = new List<Lotto>();

        //원래 리스트 먹기
        public FrmMenu4(List<Lotto> lottoList)
        {
            
            InitializeComponent();
            this.Text = "기간별 미 출현 번호";
            this.lottoList = lottoList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl1to10.Text = lbl11to20.Text = lbl21to30.Text = lbl31to40.Text = lbl41to45.Text = null;
            int weekNum;
            if (comboBox1.Text == "최근 15주간")
            {
                weekNum = 15;
            }
            else if (comboBox1.Text == "최근 10주간")
            {
                weekNum = 10;
            }
            else
            {
                weekNum = 5;
            }

            //1부터 45 저장 후 여기서 삭제 남는거 출력
            List<string> numList = new List<string>();
            for (int i = 1; i < 46; i++)
            {
                numList.Add(i.ToString());
            }

            List<string> removeList = new List<string>();

            int countNum = lottoList.Count - 1;

             
            while (weekNum > 0)
            {
                string[] listList = new string[]{
                lottoList[countNum].LottoNo1.ToString(),
                lottoList[countNum].LottoNo2.ToString(),
                lottoList[countNum].LottoNo3.ToString(),
                lottoList[countNum].LottoNo4.ToString(),
                lottoList[countNum].LottoNo5.ToString(),
                lottoList[countNum].LottoNo6.ToString() };
                //lottoList[countNum].LottoBonusNo.ToString()};


                for (int i = 0; i < listList.Length; i++)
                {
                    foreach (var item in numList)
                    {
                        if (listList[i] == item)
                        {
                            removeList.Add(item);
                        }
                    }
                }


                foreach (var item2 in removeList)
                {
                    try
                    {
                        numList.Remove(item2);
                    }
                    catch (Exception)
                    {

                        return;
                    }
                }


                weekNum--;
                countNum--;
            }
            foreach (var item in numList)
            {
                switch (Int32.Parse(item) / 10)
                {
                    case 0:
                        lbl1to10.Text += item + "     ";
                        break;
                    case 1:
                        if (Int32.Parse(item) % 10 == 0)
                        {
                            lbl1to10.Text += item + "     ";
                        }
                        else
                        {
                            lbl11to20.Text += item + "     ";
                        }
                        break;
                    case 2:
                        if (Int32.Parse(item) % 10 == 0)
                        {
                            lbl11to20.Text += item + "     ";
                        }
                        else
                        {
                            lbl21to30.Text += item + "     ";
                        }
                        break;
                    case 3:
                        if (Int32.Parse(item) % 10 == 0)
                        {
                            lbl21to30.Text += item + "     ";
                        }
                        else
                        {
                            lbl31to40.Text += item + "     ";
                        }
                        break;
                    case 4:
                        if (Int32.Parse(item) % 10 == 0)
                        {
                            lbl31to40.Text += item + "     ";
                        }
                        else
                        {
                            lbl41to45.Text += item + "     ";
                        }
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
