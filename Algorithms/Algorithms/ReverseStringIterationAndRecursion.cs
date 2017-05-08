using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class ReverseStringIterationAndRecursion
    {
        string result = string.Empty;
        int index = -1;
        public string ReverseIteration(string input)
        {
            result = string.Empty;
            for(int i=input.Length-1;i>=0;i--)
            {
                result += input[i];
            }
            return result;
        }

        public string ReverseRecursion(string input, int length)
        {
            index = length -1;
            result += input[index];
            if (input.Length == result.Length)
            {
                return result;                
            }
            ReverseRecursion(input, length - 1);

            return result;
        }
    }
}
