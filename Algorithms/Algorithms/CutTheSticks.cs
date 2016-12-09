using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /*
    https://www.hackerrank.com/challenges/cut-the-sticks 
    */
    public class CutTheSticks
    {
        public List<int> Sticks(int numberOfSticks, int[] lengthOfSticks)
        {
            
            List<int> arr = new List<int>(numberOfSticks);
            List<int> result = new List<int>();

            for (int k = 0; k < lengthOfSticks.Length; k++)
            {
                arr.Add(Int32.Parse(lengthOfSticks[k].ToString()));
            }
            while (arr.Count > 0)
            {
                int sticksCut = 0;
                int lengthOfCut = SelectionSort(arr);
                for (int i = 0; i < arr.Count; i++)
                {
                    arr[i] -= lengthOfCut;
                    sticksCut += 1;
                }
                if (sticksCut > 0)
                   result.Add(sticksCut);
            }
            return result;
        }

        private static int SelectionSort(List<int> arr)
        {
            int smallest = -1;
            int temp = 0;
            for (int i = 0; i < arr.Count; i++)
            {

                if (arr[i] > 0)
                {
                    temp = arr[i];
                    for (int j = i; j < arr.Count; j++)
                    {
                        if (arr[j] < temp)
                        {
                            temp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = temp;
                        }
                    }
                }
                else
                {
                    arr.RemoveAt(i);
                    i--;
                }

            }
            if (arr.Count > 0)
                smallest = arr[0];
            else
                smallest = 0;
            return smallest;
        }
    }
}
