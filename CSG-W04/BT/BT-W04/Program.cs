using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BT_W04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C1();
            //C2();
        }
        private static void C1()
        {
            int[] numbers = new int[5];
            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 9;
            numbers[3] = 6;
            numbers[4] = 7;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);

            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine(total.ToString());
            Console.ReadKey();
        }
        private static void C2()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<int> lst = new List<int>();
            lst.Add(2);
            lst.Add(5);
            lst.Add(9);
            lst.Add(6);
            lst.Add(7);
            Console.WriteLine("Tổng các phần tử trong chuỗi là: " + lst.Sum());
            Console.ReadKey();
        }
    }

}
