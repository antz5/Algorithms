using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class DetermineStringForUniqueCharacters
    {
        public bool CharsInStringUnique(string input)
        {            
            Dictionary<char, char> dictionary = new Dictionary<char, char>();
            for(int i=0;i<input.Length;i++)
            {
                if (dictionary.Keys.Contains(input[i]))
                    return false;
                else
                {
                    if(input[i] != ' ')
                        dictionary.Add(input[i], input[i]);
                }
            }
            return true;
        }
    }
}
