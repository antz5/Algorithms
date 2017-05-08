using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Check2StringsAreAnagrams
    {
        //Check if the 2 string provided are anagrams are not

        //Steps:
        /* 
          [X] convert the 2 strings to lower case 
          [X] convert the 2 strings to character array
          [X] sort the 2 char arrays and create 2 new strings
          [X] check if the length of both the strings are equal
          [X] check if the new strings are equal
          [X] return true if both the conditions are met
          [X] return false if either one of the condition fails
         */
        public bool CheckAnagram(string input1, string input2)
        {

            char[] charArray1 = input1.ToLower().ToCharArray();
            char[] charArray2 = input2.ToLower().ToCharArray();

            Array.Sort(charArray1);
            Array.Sort(charArray2);

            string s1 = new string(charArray1);
            string s2 = new string(charArray2);

            if((input1.Length == input2.Length))
            {
                if (!s1.Equals(s2))
                    return false;
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
