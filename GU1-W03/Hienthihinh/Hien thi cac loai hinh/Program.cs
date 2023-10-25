using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hien_thi_cac_loai_hinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            keep();
            
        }
        private static void keep()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int m = 7;              //Hàng
            int n = 3;              //Cột
            char drawchar = '*';    //Ký tự hoa
            int choice;
            Console.WriteLine("Menu");
            Console.WriteLine("1. Print the rectangle");
            Console.WriteLine("2. Print the square triangle");
            Console.WriteLine("3. Print isosceles triangle");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());
            if (choice == 0)
            {
                Console.WriteLine("Chương Trình Kết Thúc");
                return;
            }
            if (choice == 1)
            {
                Console.WriteLine();
                for (int i = 1; i <= n; i++)                 // Vẽ từ trên xuống dưới
                {
                    for (int j = 1; j <= m; j++)              // Vẽ từ trái sang 
                    {

                        if (i == 1 || j == n || j == 1 || i == m)   //biểu thức : nếu như i = 1 hoặc j = chiều dài hoặc j = 1 hoặc i = chiều rộng
                        {
                            Console.Write(drawchar + " ");                    // nếu đúng thì in ra dấu *
                        }
                        else
                        {
                            Console.Write(drawchar + " ");                    // nếu sai thì in ra dấu *
                        }
                    }
                    Console.WriteLine();

                }
                Console.ReadKey();
            }
            if (choice == 2)
            {
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        Console.Write(drawchar + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine() ;
            }
            if (choice == 3)
            {
                for (int i = 5; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(drawchar + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            if (choice > 3 || choice < 0)
            {
                Console.WriteLine("Nhập vào không hợp lệ");
            }
        }
       
    }
}


