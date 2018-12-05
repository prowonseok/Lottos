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
    public partial class LottoMenu8 : Form
    {
        List<Lotto> RealLottoList = new List<Lotto>();
        public LottoMenu8(List<Lotto> lottoList)
        {
            InitializeComponent();
            this.RealLottoList = lottoList;
        }
        List<int> lottoList;
        private void LottoMenu8_Load(object sender, EventArgs e)
        {
            this.Text = "로또를 맞춰보자 ^-^";
            foreach (Control item in Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.ComboBox")
                {
                    if (item.Name == "cbbCount")
                    {
                        for (int j = 0; j < RealLottoList.Count; j++)
                        {
                            ((ComboBox)item).Items.Add(RealLottoList.Count - j);
                            item.Text = RealLottoList.Count.ToString();
                        }
                    }
                    else
                    {
                        for (int i = 1; i < 46; i++)
                        {
                            ((ComboBox)item).Items.Add(i);
                        }
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lottoList = new List<int>();
            bool first = true;
            foreach (Control item in Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.ComboBox" && item.Name != "cbbCount")
                {
                    if (string.IsNullOrEmpty(item.Text))
                    {
                        MessageBox.Show("번호는 공백일 수 없습니다. 번호를 입력해주세요!");
                        item.Focus();
                        break;
                    }
                    else if (Int32.Parse(item.Text) < 1 || Int32.Parse(item.Text) > 45)
                    {
                        MessageBox.Show("번호는 1부터 45 사이의 값을 입력해주세요!");
                        item.Focus();
                        break;
                    }
                    else
                    {
                        if (first)
                        {
                            lottoList.Add(Int32.Parse(item.Text));
                            first = false;
                        }
                        else
                        {
                            foreach (var item2 in lottoList)
                            {
                                if (Int32.Parse(item.Text) == item2)
                                {
                                    item.Focus();
                                    MessageBox.Show("번호는 중복 될 수 없습니다.");
                                    lottoList.RemoveAt(0);
                                    break;

                                }
                                else
                                {
                                    lottoList.Add(Int32.Parse(item.Text));
                                    break;
                                }
                            }
                        }

                    }
                }
            }
            lottoList.Sort();
            int num = RealLottoList.Count - Int32.Parse(cbbCount.Text);
            int count = 0;
            bool bonus = false;
            int rank = 0;
            foreach (var item in lottoList)
            {
                if (item == RealLottoList[num].LottoNo1 || item == RealLottoList[num].LottoNo2 || item == RealLottoList[num].LottoNo3 || item == RealLottoList[num].LottoNo4 || item == RealLottoList[num].LottoNo5 || item == RealLottoList[num].LottoNo6)
                {
                    count++;
                }
                if (item == RealLottoList[num].LottoBonusNo)
                {
                    bonus = true;
                }
            }
            if (count == 6)
            {
                rank = 1;
            }
            else if (count == 5)
            {
                if (bonus)
                {
                    rank = 2;
                }
                else
                {
                    rank = 3;
                }
            }
            else if (count == 4)
            {
                rank = 4;
            }
            else if (count == 3)
            {
                rank = 5;
            }
            else
            {
                rank = 0;
            }

            if (rank != 0)
            {
                MessageBox.Show(cbbCount.Text + "회에는 " + count + "개의 공을 맞춰서 " + rank + "등입니다.");

            }
            else
            {
                MessageBox.Show("꽝입니다!");
            }
        }
    }
}
