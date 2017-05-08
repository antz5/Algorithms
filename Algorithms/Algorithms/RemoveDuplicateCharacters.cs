using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class RemoveDuplicateCharacters
    {
        //Program to remove duplicate characters in a string
        //checks for duplicate characters both upper and lower case letters using ascii values.

        public string Remove(string inputString)
        {
            string result = string.Empty;
            char s='0';
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] >= 97 && inputString[i] <= 122)
                {
                    s = (char)(inputString[i] - 32);
                }
                else if(inputString[i] >= 65 && inputString[i] <= 90)
                {
                    s = (char)(inputString[i] + 32);
                }
                if (result.IndexOf(inputString[i]) == -1)                    
                {
                    if (result.IndexOf(s) == -1)
                        result += inputString[i];
                }
            }
            return result;
        }
    }
}
