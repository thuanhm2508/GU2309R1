using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaiphuongtrinhbacnhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buoc 1 : Thông báo về chắc năng của chương trình
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");

            // Buoc 2 : Nhận giá trị của các hệ số
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            // Buoc 3 : Tìm nghiệm của phương trình khi a != 0
            if (a != 0)
            {
                double solution = -b / a;
                Console.WriteLine("The solution is: {0}!", solution);

            }
            // Buoc 4 : Tìm nghiệm của phương trình khi a == 0
            else
            {
                if (b == 0)
                {
                    Console.Write("The solution is all x!");
                }
                else
                {
                    Console.Write("Nod solution!");
                }
            }


        }
    }
}
