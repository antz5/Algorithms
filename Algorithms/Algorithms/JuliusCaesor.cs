using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /*
    Problem statement 
    https://www.hackerrank.com/challenges/caesar-cipher-1
    */
    public class JuliusCaesor
    {
        public string EncryptionCode(string input, int rotateByChars)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "The input is either null or empty";
            }
            
            char[] O = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int AsciiOfA = 'A';
                int AsciiOfa = 'a';
                int AsciiOfZ = 'Z';
                int AsciiOfz = 'z';
                int AsciiOfChar = input[i];

                if (AsciiOfChar >= AsciiOfA && AsciiOfChar <= AsciiOfZ)
                {
                    for (int j = 1; j <= rotateByChars; j++)
                    {
                        AsciiOfChar += 1;
                        if (AsciiOfChar > AsciiOfZ)
                            AsciiOfChar -= 26;
                    }
                    O[i] = Convert.ToChar(AsciiOfChar);
                }
                else if (AsciiOfChar >= AsciiOfa && AsciiOfChar <= AsciiOfz)
                {
                    for (int j = 1; j <= rotateByChars; j++)
                    {
                        AsciiOfChar += 1;
                        if (AsciiOfChar > AsciiOfz)
                            AsciiOfChar -= 26;
                    }
                    O[i] = Convert.ToChar(AsciiOfChar);
                }
                else
                {
                    O[i] = input[i];
                }
            }

           return DisplayString(O);           
        }

        static string DisplayString(char[] chars)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < chars.Length; i++)
            {
              result.Append(chars[i]);
            }
            return result.ToString();
        }
    }
}
