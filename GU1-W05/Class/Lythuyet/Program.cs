using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lythuyet
{
    internal class Program
    {
        static public int FindMax(int num1, int num2) /// Hàm tìm số to nhất trong 2 chữ số.
        {
            return (num1 > num2) ? num1 : num2;
        }
        static public void Swap(ref int num1, ref int num2) /// Hoán vị
        {
            int bientam;
            bientam = num1;
            num1 = num2;
            num2 = bientam;
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //FindMax Test
            //int a;
            //int b;
            //Console.WriteLine("Input a: ");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input b: ");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Số to nhất là: " + FindMax(a, b));

            //Swap Test
            int a, b;
            Console.WriteLine("Input a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input b: ");
            b = int.Parse(Console.ReadLine());
            Swap(ref a,ref b);
            Console.WriteLine("Sau khi swap là ");
            Console.WriteLine("Giá trị số thứ nhất là {0}, Giá trị số thứ hai là {1}", a, b);
            Console.ReadKey();
        }
    }
}
