using System;

namespace HeapSort
{
    class Program
    {
        public static int Parent(int i)
        {
            return 2 * i / 2;

        }

        public static int Left(int i)
        {
            return 2 * i + 1;
        }

        public static int Right(int i)
        {
            return 2 * i + 2;
        }

        public static void MaxHeapify(int[] A, int i,int n)
        {
            int largest;
            int l = Left(i);
            int r = Right(i);
            if (l <= n - 1 && A[l] > A[i])
                largest = l;
            else
                largest = i;
            if (r <= n - 1 && A[r] > A[largest])
                largest = r;
            if (largest != i)
            {
                int temp = A[i];
                A[i] = A[largest];
                A[largest] = temp;
                MaxHeapify(A, largest,n);
            }
        }

        public static void BuildMaxHeap(int[] A,int n)
        {
            int i;
            for (i = n / 2 - 1; i >= 0; i--)
                MaxHeapify(A, i,n);
        }

        public static void HeapSort(int[] A)
        {
            int n = A.Length;
            BuildMaxHeap(A,n);
            for (int i = n - 1; i >= 0; i--)
            {
                int exchange = A[0];
                A[0] = A[i];
                A[i] = exchange;
                n--;
                MaxHeapify(A, 0,n);
            }
        }

        static void Main(string[] args)
        {
           int[] A = { 12, 11, 13, 5, 6, 8, 3, 7, 1, 2 };
           int n = A.Length;
           HeapSort(A);
           for (int i = 0; i < A.Length; i++)
           {
               Console.WriteLine(A[i]);
           }
           Console.ReadLine();
        }
    }
}
