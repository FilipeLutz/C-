using LotteryApp.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryApp.concrete
{
    public class IrishLotto : LotteryGenerator
    {
        List<int> lotto = new List<int>();
        public override List<int> GenerateLotteryNumbers()
        {
            Random rnd = new Random();
            for (int i = 0; i < LotteryConstants.TOTAL_LOTTERY_NUMBERS; i++)
            {
                int currentNumber = rnd.Next(1, LotteryConstants.MAX_RANGE);

                while (lotto.Contains(currentNumber))
                {
                    currentNumber = rnd.Next(1, LotteryConstants.MAX_RANGE);
                }

                lotto.Add(currentNumber);
            }

            lotto.Sort();

            return lotto;
        }
    }
}
