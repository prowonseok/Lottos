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
            for (int i = 0; i < lottoList.Count; i++)
            {
                cbbFront.Items.Add(lottoList.Count - i);
                cbbBack.Items.Add(lottoList.Count - i);
            }
            cbbFront.Text = lottoList[0].WinningDateNo.ToString();
            cbbBack.Text = lottoList[lottoList.Count - 1].WinningDateNo.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(cbbFront.Text) > Int32.Parse(cbbBack.Text))
            {
                MessageBox.Show("앞자리 숫자가 뒷자리 숫자보다 클 수 없습니다.");
            }
            else
            {
                List<string> newLottoList = new List<string>();
                foreach (var item in lottoList)
                {
                    if (item.WinningDateNo >= Int32.Parse(cbbFront.Text) && item.WinningDateNo <= Int32.Parse(cbbBack.Text))
                    {
                        //newLottoList.Add(item);
                    }
                }
                newLottoList.Reverse();
                dataGridView1.DataSource = newLottoList;
            }
        }
    }
}
