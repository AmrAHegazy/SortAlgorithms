using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        public static void InsertionSort(int []arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int value = arr[i];
                int j = i;

                while(j>0 && arr[j - 1] > value)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = value;
            }
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i <arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 3, 5, 2, 0, -2 };
            InsertionSort(arr);
            PrintArray(arr);
        }
    }
}
