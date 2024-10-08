﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnDSAlgorithms
{
    class Sort
    {
        public void mergesort(int[] A, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                mergesort(A, left, mid);
                mergesort(A, mid + 1, right);
                merge(A, left, mid, right);
            }
        }

        public void merge(int[] A, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left;
            int[] B = new int[right + 1];
            while (i <= mid && j <= right)
            {
                if (A[i] < A[j])
                {
                    B[k] = A[i];
                    i = i + 1;
                }
                else
                {
                    B[k] = A[j];
                    j = j + 1;
                }
                k = k + 1;
            }
            while (i <= mid)
            {
                B[k] = A[i];
                i = i + 1;
                k = k + 1;
            }
            while (j <= right)
            {
                B[k] = A[j];
                j = j + 1;
                k = k + 1;
            }
            for (int x = left; x < right + 1; x++)
                A[x] = B[x];
        }

        public void display(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Sort s = new Sort();
            int[] A = {3,5,8,9,6,2};
            Console.WriteLine("Original Array: ");
            s.display(A, 6);
            s.mergesort(A, 0, 5);
            Console.WriteLine("Sorted Array: ");
            s.display(A, 6);
            Console.ReadKey();
        }
    }
}
