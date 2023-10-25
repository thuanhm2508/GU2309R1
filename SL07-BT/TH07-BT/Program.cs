using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH07_BT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TH01();
            //TH02();
            //TH03();
            //TH04();
            //TH05();
            //TH06();
            //TH07();
            //TH08();
            //TH09();
            //TH10();
        }
        private static void TH01()
        {
            //Nhập số nguyên A và kiểm tra xem A có phải là số nguyên tố hay không?
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int input;
            Console.WriteLine("Input A:");
            input = int.Parse(Console.ReadLine());
            bool a = true;
            if (input < 2)
            {
                a = false;
                return;
            }
            for (int i = 2; i < input / 2; i++)
            {
                if (i % 2 == 0)
                {
                    a = false;
                    break;
                }
            }
            if (a)
            {
                Console.WriteLine("{0} là số nguyên tố.", input);
            }
            else
            {
                Console.WriteLine("{0} không phải là số nguyên tố", input);
            }

        }
        private static void TH02()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int input1;
            int input2;
            Console.WriteLine("Input M: ");
            input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input N: ");
            input2 = int.Parse(Console.ReadLine());
            if (input1 > input2)
            {
                Console.WriteLine("các số chẵn trong dãy só từ M đến N là: ");
                for (int i = input2; i <= input1; i++)
                { if (i % 2 == 0) Console.Write(i + " "); }
            }
            else
            {
                Console.WriteLine("Các số chẵn trong dãy số từ M đến N là: ");
                for (int i = input1; i <= input2; i++)
                {
                    if (i % 2 == 0) Console.Write(i + " ");
                }
            }
            Console.ReadKey();
            return;

        }
        private static void TH03()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int input;
            Console.Write("Input: ");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine("Số bạn đã nhập là: " + input);
            int total = 1;
            for (int i = 2; i <= input / 2; i++)
            {
                if (input % i == 0)
                {
                    total += i;
                }
            }
            Console.WriteLine("Tổng các ước số chung của {0} là: {1}", input, total);
            if (total == input) Console.WriteLine("Yes");
            else Console.WriteLine("NO");
            Console.ReadKey();

        }
        private static void TH04()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a, b, ucln = 1, c;
            Console.Write("Input a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input b = ");
            b = Convert.ToInt32(Console.ReadLine());
            c = (a < b) ? a : b;
            for (int i = 1; i < c; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    ucln = i;
                }
            }
            Console.WriteLine("USCLN của {0} và {1} là : {2}", a, b, ucln);
            Console.ReadKey();

        }
        private static void TH05()
        {
        nhaplai:
            ulong n;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Input N: ");
            if (ulong.TryParse(Console.ReadLine(), out n) && n >= 0)
            {
                ulong k = 1;
                
                for ( ulong i = 1; i <= n; i++)
                {
                    k = k * i;
                }
                Console.WriteLine("Giai thừa của {0} là {1}", n, k);
                goto nhaplai;

            }
            else
            {
                Console.WriteLine("Không hợp lệ...");

            }
        }
        private static void TH06()
        {
            int input;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Input i: ");
            if (int.TryParse(Console.ReadLine(), out input) && input > 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    int product = input * i;
                    Console.WriteLine("{0} x {1} = {2}", input, i, product);
                }
            }
            else
            {
                Console.WriteLine("Sai định dạng hoặc số không đúng...");
            }
        }
        private static void TH07()
        {
            int n2 = 2;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Bảng cứu chương 2");
            for (int i = 1; i <= 10; i++)
            {
                int k = n2 * i;
                Console.WriteLine("{0} x {1} = {2}", n2, i, k);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Bảng cứu chương 3");
            int n3 = 3;
            for (int i = 1; i <= 10; i++)
            {
                int k = n3 * i;
                Console.WriteLine("{0} x {1} = {2}", n3, i, k);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Bảng cứu chương 4");
            int n4 = 4;
            for (int i = 1; i <= 10; i++)
            {
                int k = n4 * i;
                Console.WriteLine("{0} x {1} = {2}", n4, i, k);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Bảng cứu chương 5");
            int n5 = 5;
            for (int i = 1; i <= 10; i++)
            {
                int k = n5 * i;
                Console.WriteLine("{0} x {1} = {2}", n5, i, k);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Bảng cứu chương 6");
            int n6 = 6;
            for (int i = 1; i <= 10; i++)
            {
                int k = n6 * i;
                Console.WriteLine("{0} x {1} = {2}", n6, i, k);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Bảng cứu chương 7");
            int n7 = 7;
            for (int i = 1; i <= 10; i++)
            {
                int k = n7 * i;
                Console.WriteLine("{0} x {1} = {2}", n7, i, k);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Bảng cứu chương 8");
            int n8 = 8;
            for (int i = 1; i <= 10; i++)
            {
                int k = n8 * i;
                Console.WriteLine("{0} x {1} = {2}", n8, i, k);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Bảng cứu chương 9");
            int n9 = 9;
            for (int i = 1; i <= 10; i++)
            {
                int k = n9 * i;
                Console.WriteLine("{0} x {1} = {2}", n9, i, k);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Bảng cứu chương 10");
            int n10 = 10;
            for (int i = 1; i <= 10; i++)
            {
                int k = n10 * i;
                Console.WriteLine("{0} x {1} = {2}", n10, i, k);
            }

        }
        private static void TH08()
        {
            //            Nhập vào 1 số nguyên n.Xuất ra kết quả phép tính theo công thức sau kết quả lấy 3 chữ số thập phân:
            //1 + 1 / 23 + 1 / 33 + ...+1 / n3
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int n;
            Console.Write("Input N: ");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                double k = 0;
                for (int i = 1; i <= n; i++)
                {
                    double j = Math.Pow(i, 3);
                    k = k + 1 / j;
                }
                Console.WriteLine("Kết quả phép tính là {0}", k);
                Console.WriteLine("Kết quả phép tính sau khi lấy 3 chữ số là {0}", Math.Round(k, 3));
            }
            else
            {
                Console.WriteLine("Nhập vào không hợp lệ");
            }
        }
        private static void TH09()
        {
            int m, n;
            Console.Write("Input N: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Input M: ");
            m = int.Parse(Console.ReadLine());

            if (m > 0 && n > 0 && n > m)
            {
                int uoc = m + 1;
                int P = 1;
                while (n != 0)
                {
                    int kq = n % 10;
                    P = P * kq;
                    n = n / 10;
                }
                for (int i = 2; i <= m / 2; i++)
                {

                    if (m % i == 0)
                    {

                        uoc = uoc + i;
                    }
                }
                if (P == uoc)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }


            }
            else
            {
                Console.WriteLine("Nhập vào không hợp lệ..");
            }

        }
        private static void TH10()
        {
            int m, n, k;
            Console.Write("Input M: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Input N: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Input K: ");
            k = int.Parse(Console.ReadLine());

            if (m > 0 || n > 0 || k > 0)
            {
                int tongn = 0;
                while (n != 0)
                {
                    int a = n % 10;
                    tongn = tongn + a;
                    n = n / 10;

                }
                while (m >= 10)
                {
                    m = m % 10;
                    
                }
                tongn = tongn + n + m;
                if (tongn == k) { Console.WriteLine("Yes"); }
                else Console.WriteLine("No");
                
            }
            else
            {
                Console.WriteLine("Số bạn nhập vào không đúng, nhập lại đê");
            }

        }

    }
}

