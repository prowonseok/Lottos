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
    public partial class FrmMenu6 : Form
    {
        List<Lotto> lottoList = new List<Lotto>();
        public FrmMenu6(List<Lotto> lottoList)
        {
            this.lottoList = lottoList;
            InitializeComponent();
        }

        private void FrmMenu6_Load(object sender, EventArgs e)
        {
            this.Text = "연속번호 출현";
            for (int i = 0; i < lottoList.Count; i++)
            {
                cbbFront.Items.Add(lottoList.Count - i);
                cbbBack.Items.Add(lottoList.Count - i);
            }
            cbbBack.Text = lottoList[0].WinningDateNo.ToString();
            cbbFront.Text = lottoList[lottoList.Count - 1].WinningDateNo.ToString();

            dataGridView1.DataSource = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable lottosTable = new DataTable();

            lottosTable.Columns.Add("회차");
            lottosTable.Columns.Add("당첨번호");
            lottosTable.Columns.Add("쌍");

            if (Int32.Parse(cbbFront.Text) > Int32.Parse(cbbBack.Text))
            {
                MessageBox.Show("앞자리 숫자가 뒷자리 숫자보다 클 수 없습니다.");
            }
            else
            {
                foreach (var item in lottoList)
                {
                    if (item.WinningDateNo >= Int32.Parse(cbbFront.Text) && item.WinningDateNo <= Int32.Parse(cbbBack.Text))
                    {
                        List<int> numList = new List<int>();
                        string text = null;
                        int count = 0; //쌍


                        numList.Add(item.LottoNo1); numList.Add(item.LottoNo2); numList.Add(item.LottoNo3); numList.Add(item.LottoNo4);
                        numList.Add(item.LottoNo5); numList.Add(item.LottoNo6);

                        numList.Sort();
                        List<string> numList2 = new List<string>();
                        foreach (var item4 in numList)
                        {
                            numList2.Add(item4.ToString());
                        }

                        for (int i = 0; i < numList2.Count - 1; i++)
                        {
                            int num1 = Int32.Parse(numList2[i]);
                            for (int j = i + 1; j < numList2.Count; j++)
                            {
                                int num2 = Int32.Parse(numList2[j]);
                                if (num1 + 1 == num2)
                                {
                                    count++;
                                    if (!numList2[i].Contains("["))
                                    {
                                        numList2[i] = String.Concat("[", numList2[i]);
                                        if (j + 2 <= numList2.Count)
                                        {
                                            if (num1 + 2 == Int32.Parse(numList2[j + 1]))
                                            {
                                                numList2[j + 1] = String.Concat(numList2[j + 1], "]");
                                                i += 2;
                                                j++;
                                                count++;
                                            }
                                            else
                                            {
                                                numList2[j] = String.Concat(numList2[j], "]");
                                                i++;
                                            }
                                        }
                                        else
                                        {
                                            numList2[j] = String.Concat(numList2[j], "]");
                                            i++;
                                        }

                                    }

                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        //List<int> numList = new List<int>();
                        //string text=null;
                        //int count = 0; //쌍

                        //numList.Add(item.LottoNo1);numList.Add(item.LottoNo2);numList.Add(item.LottoNo3);numList.Add(item.LottoNo4);
                        //numList.Add(item.LottoNo5);numList.Add(item.LottoNo6);

                        //numList.Sort();
                        //for (int i = 0; i < numList.Count-1; i++)
                        //{
                        //    for (int j = i+1; j < numList.Count; j++)
                        //    {
                        //        if (numList[i]+1==numList[j])
                        //        {
                        //            count++;
                        //        }
                        //        else
                        //        {
                        //            break;
                        //        }
                        //    }
                        //}

                        foreach (var item2 in numList2)
                        {
                            text += item2.ToString() + "   ";
                        }


                        DataRow row = lottosTable.NewRow();
                        row["회차"] = item.WinningDateNo;

                        row["당첨번호"] = text;

                        row["쌍"] = count + "쌍";

                        lottosTable.Rows.Add(row);
                    }
                }

            }
            dataGridView1.DataSource = lottosTable;
        }
    }
}
