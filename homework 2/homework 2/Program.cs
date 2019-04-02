using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp5
{
    class Program
    {
        static public int[] BubletSort(int[] array)
        {
            int temp;
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
        }

        public static void MergeSort(int[] array)
        {

            if (array.Length <= 1)
            {
                return;
            }
            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];
            for (int i = 0; i < mid; i++)
            {
                left[i] = array[i];
            }
            for (int i = mid; i < array.Length; i++)
            {
                right[array.Length - i - 1] = array[i];
            }
            MergeSort(left);
            MergeSort(right);
            Merge(left, right, array);
        }
        private static void Merge(int[] left, int[] right, int[] array)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    array[k] = left[i];
                    i++;
                }
                else
                {
                    array[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < left.Length)
            {
                array[k] = left[i];
                i++;
                k++;
            }
            while (j < right.Length)
            {
                array[k] = right[j];
                j++;
                k++;
            }
        }
        static public int[] selectionSort(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;

        }
        static public int[] insertionSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j] < array[j - 1])
                {
                    temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    j = j - 1;
                }
            }
            return array;
        }
            public static void quickSort(int[] array)
        {
            quickSort(array, 0, array.Length - 1);
        }

        public static void quickSort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int num = array[start];
            int i = start;
            int j = end;
            while (i < j)
            {
                while (i < j && array[j] > num)
                {
                    j--;
                }
                array[i] = array[j];
                while (i < j && array[j] < num)
                {
                    i++;
                }
                array[j] = array[i];
            }
            array[i] = num;

            quickSort(array, start, i - 1);
            quickSort(array, i + 1, end);

        }

        static void Main(string[] args)

        {
            DateTime starttime = DateTime.Now;
            Console.WriteLine("Please enter the size of an array that you want to sort:");
            int count = int.Parse(Console.ReadLine());
            int[] myArray = new int[count];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Select which algorithm you want to perform:");
            Console.WriteLine("1. Insertion sort");
            Console.WriteLine("2. Bubble sort");
            Console.WriteLine("3. Merge sort");
            Console.WriteLine("4. Quick sort");
            Console.WriteLine("5. Heap sort");
            Console.WriteLine("6. All");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine("Insertion sort");
                        insertionSort(myArray);
                        foreach (int p in myArray)
                        Console.Write(p + " ");
                        Console.WriteLine();
                        Console.Read();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Bubble sort");
                        BubletSort(myArray);
                        foreach (int p in myArray)
                        Console.Write(p + " ");
                        Console.WriteLine();
                        Console.Read();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Merge sort");
                        MergeSort(myArray);
                        foreach (int p in myArray)
                        Console.Write(p + " ");
                        Console.WriteLine();
                        Console.Read();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Quick sort");
                        quickSort(myArray);
                        foreach (int p in myArray)
                        Console.Write(p + " ");
                        Console.WriteLine();
                        Console.Read();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("All");
                        BubletSort(myArray);
                        MergeSort(myArray);
                        insertionSort(myArray);
                        foreach (int p in myArray)
                        Console.Write(p + " ");
                        Console.WriteLine();
                        Console.Read();
                        break;
                    }

            }
        }
    }
}


