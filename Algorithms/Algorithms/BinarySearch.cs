using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /*
        Binary Search: 
        Search a sorted array by repeatedly dividing the search interval in half.
        Begin with an interval covering the whole array. If the value of the search key is less than
        the item in the middle of the interval, narrow the interval to the lower half. Otherwise narrow 
        it to the upper half. Repeatedly check until the value is found or the interval is empty.

        Design:
        [X] create a Search method accepting parameters such as a sorted input array and the key
        [X] Compute the mid position of the array using mid = left + right/2
        [X] Check if the key is found at the mid position
        [X] if not then check if the key is greater than mid, if yes, start comparing from the right
        [X] else compare from the left
        [X] return the index/position of the key found
     */
    public class BinarySearchIterativeApproach
    {
        public int Search(int[] items, int key)
        {
            int left = 0;
            int right = items.Length - 1;
            int mid = left + right / 2;

            if (items[mid] == key)
                return mid;
            else if (key > items[mid])
            {
                while (mid <= right)
                {
                    if (items[mid] == key)
                        return mid;
                    mid += 1;
                }
            }
            else
            {
                while (mid >= left)
                {
                    if (items[mid] == key)
                        return mid;
                    mid -= 1;
                }
            }
            return -1;
        }
    }
}
