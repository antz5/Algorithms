using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /*
         Problem statement: https://www.hackerrank.com/challenges/chocolate-feast
    */
    public class ChocolateFeast
    {
        public int NumberOfChocolates(int amount, int costOfChocolate, int chocWrappers)
        {
            int N = amount;
            int C = costOfChocolate;
            int M = chocWrappers;

            int chocolates = N / C;
            int totalWrappers = chocolates;
            while (totalWrappers >= M)
            {
                int extraChoc = totalWrappers / M;
                totalWrappers = totalWrappers % M;
                totalWrappers += extraChoc;
                chocolates += extraChoc;
            }

            return chocolates;
        }
    }
}
