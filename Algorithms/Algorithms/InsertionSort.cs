using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class InsertionSort
    {
        public int[] InsertionSorted(int[] items)
        {
            int n = items.Length;
            for (int i = 1; i < n; i++)
            {
                int j = i - 1;
                int value = items[i];
                while (j >= 0)
                {                    
                    if (value < items[j])
                    {                        
                        items[j+1] = items[j];
                        items[j] = value;
                    }
                    j -= 1;
                }                
            }
            return items;
        }
    }
}
