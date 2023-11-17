using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Program
    {
        static void Main()
        {
            StopWatch stopwatch = new StopWatch();

            int[] arrayToSort = new int[100000];
            Random random = new Random();
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                arrayToSort[i] = random.Next(1, 1000);
            }

            stopwatch.Start();

            for (int i = 0; i < arrayToSort.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arrayToSort.Length; j++)
                {
                    if (arrayToSort[j] < arrayToSort[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arrayToSort[i];
                arrayToSort[i] = arrayToSort[minIndex];
                arrayToSort[minIndex] = temp;
            }

            stopwatch.Stop();

            double elapsedTime = stopwatch.GetElapsedTime();
            Console.WriteLine($"Elapsed Time for Selection Sort: {elapsedTime} milliseconds");
                      
            Console.ReadLine();
        }
    }
}
