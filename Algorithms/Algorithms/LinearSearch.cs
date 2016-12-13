using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /*
     Linear Search:
        Problem: Given an array arr[] of n elements, write a function to search a given element x in arr[].
        A simple approach is to do linear search, i.e
        Start from the leftmost element of arr[] and one by one compare x with each element of arr[]
        If x matches with an element, return the index.
        If x doesn’t match with any of elements, return -1.
     */

        /*
           Design:
           
            [X] create a method which accepts two parameters: array and the key to be searched
            [X] For-Loop through starting from the first index until the last
            [X] If-condition to check if the key is present in the array
            [X] return the position of the array where the key is present else return -1
         */
    public class LinearSearch
    {
        public int Search(int[] items, int key)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == key)
                    return i;
            }
            return -1;
        }
    }
}
