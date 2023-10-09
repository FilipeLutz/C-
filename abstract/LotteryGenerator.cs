using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryApp
{
    public abstract class LotteryGenerator
    {
        public abstract List<int> GenerateLotteryNumbers();
    }
}
