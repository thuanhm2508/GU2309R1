using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BT07_TH01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            nhapvaoMNinrasochan();
        }
        private static void nhapvaoMNinrasochan()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int m;
            int n;
            int dem = 4;
            Console.WriteLine("Chương trình in ra số chẵn trong khoảng 2 số nhập vào");
            Console.WriteLine("Input M: ");
            m = int.TryParse(Console.ReadLine(), out m);
            Console.WriteLine("Input N: ");
            n = int.TryParse(Console.ReadLine(), out n);
            if (m > n)
            {
                Console.WriteLine("Cac so chan la: ");
                
            }
        }
    }
}
