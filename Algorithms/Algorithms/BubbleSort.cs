using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /*
        Bubble Sort:
        Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping 
        the adjacent elements if they are in wrong order.

        Design: 
        [X] create a method which accepts a parameter which is an array of integers
        [X] outer loop to compare with inner loop elements
        [X] inner loop 
        [X] check if outer element is greater than inner elements
        [X] create a method to swap 2 elements using temporary variable
        [X] return the sorted array
     */
    public class BubbleSort
    {
        public int[] BubbleSorted(int[] items)
        {
            for (int i = 0; i < items.Length-1; i++)
            {
                for (int j = 0; j < items.Length - i- 1; j++)
                {
                    if(items[j] > items[j+1])
                    {
                        int temp = items[j];
                        items[j] = items[j+1];
                        items[j+1] = temp;
                    }
                }
            }
            return items;
        }

       
    }
}
