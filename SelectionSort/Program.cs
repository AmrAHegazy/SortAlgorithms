using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j  < arr.Length -1; j ++)
                {
                    if (arr[i] > arr[j + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { -3, 4, 0, 1, 5, -12, 55, 342, -90 };
            SelectionSort(arr);
            for (int i = 0; i <arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
