using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesJA
{
    public delegate int Compare(int[] a, int[] b);

    public class Sort
    {
        public static void InsertionSortUp(int[][] arr, Compare compare)
        {

            int i, j;
            for (j = 1; j < arr.Length; j++)
            {

                int[] tempA = arr[j];
                i = j;
                while ((i > 0) && (compare(arr[i - 1], tempA) == 1))
                {
                    arr[i] = arr[i - 1];

                    --i;
                }
                arr[i] = tempA;

            }
        }
        public static void InsertionSortDown(int[][] arr, Compare compare)
        {

            int i, j;
            for (j = 1; j < arr.Length; j++)
            {

                int[] tempA = arr[j];
                i = j;
                while ((i > 0) && (compare(arr[i - 1], tempA) == -1))
                {
                    arr[i] = arr[i - 1];

                    --i;
                }
                arr[i] = tempA;

            }
        }
        
    }
    

}
