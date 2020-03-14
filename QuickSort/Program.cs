using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int []arr = { 1, -3, 45, -50, 4, 33, 0, 9, -21, 1 };
            QuickSort(arr,0,arr.Length-1);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            
        }
        private static void QuickSort(int[] arr,int left,int right)
        {
            int i = left;
            int j = right;

            int pivot = arr[(right + left) / 2];

            while(i <= j)
            {
                while (arr[i] < pivot)
                    i++;
                while (arr[j] > pivot)
                    j--;
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuickSort(arr, left, j);

            if (i < right)
                QuickSort(arr, i, right);
        }
    }
}
