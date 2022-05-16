using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Algorithms
{
    public  class CoinChange
    {
        public int Ways(int n, IList<int> coins)
        {

            return Rec(coins, coins.Count, n);

        }

        public int Rec(IList<int> coins, int m, int n)
        {
            if (n == 0) return 1;

            if (n < 0) return 0;

            if (m <= 0 && n >= 1) return 0;

            return Rec(coins, m-1, n) + Rec(coins, m, n-coins[m-1]);
        }
    }
}
