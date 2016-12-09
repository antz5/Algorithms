
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class AlternatingCharacters
    {
        /// <summary>
        /// Shashank likes strings in which consecutive characters are different. For example, he likes ABABA, while he doesn't like ABAA. 
        /// Given a string containing characters  and  only, he wants to change it into a string he likes. To do this, he is allowed to delete
        /// the characters in the string. Your task is to find the minimum number of required deletions.
        /// </summary>        
        /// <param name="input">Contains string separated with a space each</param>
        /// <returns>Number of deletions required to change it into a string shashank likes</returns>
        public int DeletionsRequired(string input)
        {            
            int deletionsReqd = 0;
            int i = 0;
            while (i + 1 < input.Length)
            {
                if (input[i] == input[i + 1])
                {
                    deletionsReqd += 1;
                }
                i++;
            }
            return deletionsReqd;
        }
    }
}
