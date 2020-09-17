using System;

namespace Code_Challenge_Day20__Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int numberOfswaps = 0;

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        numberOfswaps++;
                    }
                }

                if (numberOfswaps == 0)
                {
                    break;
                }


            }
            Console.WriteLine("Array is sorted in " + numberOfswaps + " swaps");
            Console.WriteLine("First Element: " + a[0]);
            Console.WriteLine("Last Element: " + a[n-1]);


        }
    }
}
