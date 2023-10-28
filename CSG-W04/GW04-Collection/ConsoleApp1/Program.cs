using System;
using System.Collections.Generic;
using System.Linq;                              //Linq: 
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //baitest();
            baitestlinq();

        }
        private static void baitest()
        {
            ArrayList no_lst = new ArrayList();
            no_lst.Add(1);
            no_lst.Add("A B C");
            no_lst.Add(true);

            foreach (var item in no_lst)            //Sử dụng biến var và object khi không xác định kiểu dữ liệu.
            {
                Console.WriteLine(item + " ");

            }
            Console.ReadKey();
        }
        private static void baitestlinq()
        {
            List<int> lst = new List<int>();
            int n = 10;
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                lst.Add(i);
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (int item in lst)
            {
                if (item % 2 == 1)
                    Console.Write(item * 2 + " ");
                else Console.Write(item + " ");
            }
            Console.WriteLine();
            




        }
    }
}
