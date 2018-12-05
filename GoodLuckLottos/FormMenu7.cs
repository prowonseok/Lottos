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
    public partial class FormMenu7 : Form
    {
        List<Lotto> lottoList = new List<Lotto>();
        public FormMenu7(List<Lotto> lottoList)
        {
            this.lottoList = lottoList;
            InitializeComponent();
        }

        private void FrmMenu7_Load(object sender, EventArgs e)
        {
            this.Text = "패턴 분석표";
            for (int i = 0; i < lottoList.Count; i++)
            {
                cbbSearch.Items.Add(lottoList.Count - i);
            }
            cbbSearch.Text = lottoList[0].WinningDateNo.ToString();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DataTable lottoTable = new DataTable();

            lottoTable.Columns.Add("1");
            lottoTable.Columns.Add("2");
            lottoTable.Columns.Add("3");
            lottoTable.Columns.Add("4");
            lottoTable.Columns.Add("5");
            lottoTable.Columns.Add("6");
            lottoTable.Columns.Add("7");


            DataRow row = lottoTable.NewRow();
            for (int i = 1; i < 46; i++)
            {
                switch (i % 7)
                {
                    case 1:
                        row["1"] = i;
                        break;
                    case 2:
                        row["2"] = i;
                        break;
                    case 3:
                        row["3"] = i;
                        if (i == 45)
                        {
                            lottoTable.Rows.Add(row);
                            row = lottoTable.NewRow();
                        }
                        break;
                    case 4:
                        row["4"] = i;
                        break;
                    case 5:
                        row["5"] = i;
                        break;
                    case 6:
                        row["6"] = i;
                        break;
                    case 0:
                        row["7"] = i;
                        lottoTable.Rows.Add(row);
                        row = lottoTable.NewRow();
                        break;
                    default:
                        break;
                }
            }

            this.dataGridView1.DataSource = lottoTable;
            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Columns[i].Width = 25;
            }

            #region 색칠
            int date = lottoList.Count - Int32.Parse(this.cbbSearch.Text);
            if (lottoList[date].LottoNo1 % 7 == 0)
            {
                dataGridView1.Rows[lottoList[date].LottoNo1 / 7 - 1].Cells[6].Style.BackColor = Color.Red;
            }
            else
            {
                dataGridView1.Rows[lottoList[date].LottoNo1 / 7].Cells[lottoList[date].LottoNo1 % 7 - 1].Style.BackColor = Color.Red;
            }
            if (lottoList[date].LottoNo2 % 7 == 0)
            {
                dataGridView1.Rows[lottoList[date].LottoNo2 / 7 - 1].Cells[6].Style.BackColor = Color.Red;
            }
            else
            {
                dataGridView1.Rows[lottoList[date].LottoNo2 / 7].Cells[lottoList[date].LottoNo2 % 7 - 1].Style.BackColor = Color.Red;
            }
            if (lottoList[date].LottoNo3 % 7 == 0)
            {
                dataGridView1.Rows[lottoList[date].LottoNo3 / 7 - 1].Cells[6].Style.BackColor = Color.Red;
            }
            else
            {
                dataGridView1.Rows[lottoList[date].LottoNo3 / 7].Cells[lottoList[date].LottoNo3 % 7 - 1].Style.BackColor = Color.Red;
            }
            if (lottoList[date].LottoNo4 % 7 == 0)
            {
                dataGridView1.Rows[lottoList[date].LottoNo4 / 7 - 1].Cells[6].Style.BackColor = Color.Red;
            }
            else
            {
                dataGridView1.Rows[lottoList[date].LottoNo4 / 7].Cells[lottoList[date].LottoNo4 % 7 - 1].Style.BackColor = Color.Red;
            }
            if (lottoList[date].LottoNo5 % 7 == 0)
            {
                dataGridView1.Rows[lottoList[date].LottoNo5 / 7 - 1].Cells[6].Style.BackColor = Color.Red;
            }
            else
            {
                dataGridView1.Rows[lottoList[date].LottoNo5 / 7].Cells[lottoList[date].LottoNo5 % 7 - 1].Style.BackColor = Color.Red;
            }
            if (lottoList[date].LottoNo6 % 7 == 0)
            {
                dataGridView1.Rows[lottoList[date].LottoNo6 / 7 - 1].Cells[6].Style.BackColor = Color.Red;
            }
            else
            {
                dataGridView1.Rows[lottoList[date].LottoNo6 / 7].Cells[lottoList[date].LottoNo6 % 7 - 1].Style.BackColor = Color.Red;
            } 
            #endregion
            


        }
    }
}
