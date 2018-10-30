using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Max_Heapify
    {
        public static void MaxHeapify(int []A,int heapsize,int i)
        {
            int parent = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            if (l <= heapsize && A[l] > A[i])
                parent = l;
            else
                parent = i;
            if (r <= heapsize && A[r] > A[parent])
                parent = r;
            if (parent != i)
                A[i] = A[parent];
        }
    }
}
