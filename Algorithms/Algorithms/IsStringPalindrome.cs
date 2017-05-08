using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class IsStringPalindrome
    {
        public bool IsPalindrome(string input)
        {
            Console.WriteLine(input);
            int min = 0;
            int max = input.Length - 1;

            while(max > min)
            {
                if(input[min] != input[max])
                {
                    return false;
                }
                min++;
                max--;
            }
            return true;
        }
    }
}
