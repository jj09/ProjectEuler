using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinSums
{
    public class CombinationCounter
    {
        int combinationCount = 0;

        int[] coins = new int [] { 1, 2, 5, 10, 20, 50, 100, 200 };

        void CountCombinations(int sum, int lowestCoinIndex)
        {
            if (sum == 0)
            {
                ++combinationCount;
                return;
            }
            if (sum < 0)
            {
                return;
            }
            for (int i = lowestCoinIndex; i < coins.Length; ++i)
            {
                CountCombinations(sum - coins[i], i);
            }
        }

        static void Main(string[] args)
        {
            var cc = new CombinationCounter();
            cc.CountCombinations(200, 0);
            Console.WriteLine(cc.combinationCount);
        }
    }
}
