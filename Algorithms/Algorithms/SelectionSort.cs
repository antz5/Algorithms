using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /*
        Selection Sort:
        The selection sort algorithm sorts an array by repeatedly finding the minimum element (considering ascending order) 
        from unsorted part and putting it at the beginning. The algorithm maintains two subarrays in a given array.
            1) The subarray which is already sorted.
            2) Remaining subarray which is unsorted.
        In every iteration of selection sort, the minimum element (considering ascending order) from the unsorted subarray
        is picked and moved to the sorted subarray. 

        Design:
       [X] create a method SelectionSorted accepting a parameter of type int array
       [X] create a loop to maintain a sorted sub-array
       [X] create a loop to maintain an unsorted sub-array
       [X] maintain a minimum index variable to track the minimum element in the unsorted sub array
       [X] Assume the minimun index to be i and check if the items[min_index] > items[j], if true then assign min_index = j
       [X] After iterating through the unsorted sub-array, swap the items[min_index] at the ith location in the sorted sub-array
    */
    public class SelectionSort
    {
        public int[] SelectionSorted(int[] items)
        {
            int n = items.Length;
            int j = 0;
            for (int i = 0; i < n-1; i++)
            {
                int min_index = i; 
                for (j = i; j < n; j++)
                {
                    if (items[min_index] > items[j])
                    {
                        min_index = j;
                    }
                }
                int temp = items[i];
                items[i] = items[min_index];
                items[min_index] = temp;
            }
            return items;
        }
    }
}
