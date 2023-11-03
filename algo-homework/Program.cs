using System;
using System.Diagnostics;

class Program
{
    class ArraySort
    {


        public static void Sort(double[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {

                        double temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public static void Next(double[] arr)
        {
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.NextDouble();
            }

        }
        public static void printArr(double[] arr)
        {

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            ArraySort.Sort(arr);

            stopwatch.Stop();
            Console.WriteLine("Time taken to sort the array: " + stopwatch.Elapsed);

            foreach (double i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }



    static void Main()
    {

        double[] arr1 = new double[10];
        double[] arr2 = new double[100];
        double[] arr3 = new double[1000];

        ArraySort.Next(arr1);
        ArraySort.Next(arr2);
        ArraySort.Next(arr3);

        ArraySort.printArr(arr1);
        ArraySort.printArr(arr2);
        ArraySort.printArr(arr3);

        Console.ReadLine();

    }
}