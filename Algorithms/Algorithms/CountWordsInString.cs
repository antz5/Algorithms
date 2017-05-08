using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class CountWordsInString
    {
        public int CountWords(string sentence)
        {
            int numberOfWords = -1;

            sentence = sentence.Trim();

            if (sentence.Contains("  "))
               sentence = sentence.Replace("  ", " ");

            var words = sentence.Split(' ');
            numberOfWords = words.Length;

            return numberOfWords;
        }
    }
}
