using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_TH04_tongab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhập hai số và tính tổng. Xuất theo định dạng: a+b=tổng
            int a;
            int b;
            Console.Write("Input a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.Write("Ket qua la: {0} + {1} = {2}", a, b, c);
            Console.ReadLine();

        }

    }
}
