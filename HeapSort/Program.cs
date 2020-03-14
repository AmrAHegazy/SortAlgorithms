using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Program
    {
        public static void MaxHeap(int[] arr, int i, int n)
        {
            int left = 2 * i;
            int right = (2 * i) + 1;
            int largest = i;
            if (left < n)
            {
                if (arr[left] > arr[i])
                {
                    largest = left;
                }
                else
                {
                    largest = i;
                }
            }

            if (right < n)
            {
                if (arr[right] > arr[largest])
                {
                    largest = right;
                }
            }


            if (largest != i)
            {
                swap(arr, i, largest);
                MaxHeap(arr, largest, n);
            }
        }

        private static void swap(int[] arr, int v1, int v2)
        {

            int temp = arr[v1];
            arr[v1] = arr[v2];
            arr[v2] = temp;
        }

        public static void BuildHeap(int[] arr, int len)
        {
            for (int i = len / 2; i >= 1; i--)
            {
                MaxHeap(arr, i, len);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 0, 5, 3, 6, 1, 4, 9, 2, 7, 1, 88, 66, 54, 78, 0, 111 };
            HeapSort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        private static void HeapSort(int[] arr)
        {
            BuildHeap(arr, arr.Length);
            int heapSize = arr.Length;
            for (int i = 1; i < heapSize;)
            {
                swap(arr, heapSize - 1, i);
                heapSize--;
                BuildHeap(arr, heapSize);
            }
        }
    }
}
