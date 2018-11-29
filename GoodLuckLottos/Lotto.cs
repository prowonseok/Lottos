using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodLuckLottos
{
    public class Lotto
    {
        private int winningDateNo;

        public int WinningDateNo
        {
            get { return winningDateNo; }
            set { winningDateNo = value; }
        }
        private int lottoNo1;

        public int LottoNo1
        {
            get { return lottoNo1; }
            set { lottoNo1 = value; }
        }
        private int lottoNo2;

        public int LottoNo2
        {
            get { return lottoNo2; }
            set { lottoNo2 = value; }
        }
        private int lottoNo3;

        public int LottoNo3
        {
            get { return lottoNo3; }
            set { lottoNo3 = value; }
        }
        private int lottoNo4;

        public int LottoNo4
        {
            get { return lottoNo4; }
            set { lottoNo4 = value; }
        }
        private int lottoNo5;

        public int LottoNo5
        {
            get { return lottoNo5; }
            set { lottoNo5 = value; }
        }
        private int lottoNo6;

        public int LottoNo6
        {
            get { return lottoNo6; }
            set { lottoNo6 = value; }
        }
        private int lottoBonusNo;

        public int LottoBonusNo
        {
            get { return lottoBonusNo; }
            set { lottoBonusNo = value; }
        }

        public Lotto()
        {

        }
        public Lotto(int winningDateNo, int lottoNo1, int lottoNo2, int lottoNo3, int lottoNo4, int lottoNo5, int lottoNo6, int lottoBonusNo)
        {
            this.winningDateNo = winningDateNo;
            this.lottoNo1 = lottoNo1;
            this.lottoNo2 = lottoNo2;
            this.lottoNo3 = lottoNo3;
            this.lottoNo4 = lottoNo4;
            this.lottoNo5 = lottoNo5;
            this.lottoNo6 = lottoNo6;
            this.lottoBonusNo = lottoBonusNo;
        }
    }
}
