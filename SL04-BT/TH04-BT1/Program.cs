using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH04_BT1
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
            TH08();
        }
        private static void TH01()
        {
            // Nhập 2 số và tính tổng. Xuất theo định dạng a + b = tổng
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double a;
            double b;
            Console.WriteLine("Input a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input b: ");
            b = double.Parse(Console.ReadLine());
            double c = a + b;
            Console.WriteLine("Kết quả {0} + {1} = {2}", a, b, c);
        }
        private static void TH02()
        {
            // Nhập 2 số nguyên N và M. Yêu cầu tính tổng chữ số cuối cùng của M và N
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int m;
            int n;
            Console.Write("Input M: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Input N: ");
            n = int.Parse(Console.ReadLine());
            int k = (m % 10) + (n % 10);
            Console.WriteLine("Tổng chữ số cuối cùng của M và N là: {0} + {1} = {2} ", m % 10, n % 10, k);
        }
        private static void TH03()
        {
            //Nhập 2 số a và b. Yêu cầu hoán vị giá trị của a và b, sau đó xuất kết quả ra màn hình.
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a;
            int b;
            Console.WriteLine("Input a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input b: ");
            b = int.Parse(Console.ReadLine());
            int swap = a;
            a = b;
            b = swap;
            Console.WriteLine("Kết quả a là {0}", a);
            Console.WriteLine("Kết quả b là {0}", b);
        }
        private static void TH04()
        {
            //Nhập 1 số có 2 chữ số. Yêu cầu xuất ra tổng các chữ số của nó ra màn hình
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
        nhaplaiso:
            int input;
            Console.Write("Input: ");
            //input = int.Parse(Console.ReadLine());
            if (int.TryParse(Console.ReadLine(), out input) && input >= 100 || input < 10)
            {
                Console.WriteLine("Số hoặc ký tự đã nhập không hợp lệ vui lòng nhập số có 2 chữ số.");
                goto nhaplaiso;
            }
            else
            {
                int donvi = input % 10;
                int nguyen = input / 10;
                Console.WriteLine("Tổng các chữ số của số đã nhập là: {0} + {1} = {2}", nguyen, donvi, nguyen + donvi);
            }
        }
        private static void TH05()
        {
            //Nhập 1 số gồm 3 chữ số, yêu cầu xuất ra tổng các chữ số của nó ra màn hình.
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
        nhaplaiso:
            int input;
            Console.Write("Input: ");
            if (int.TryParse(Console.ReadLine(), out input) && input >= 999 || input <= 100)
            {
                Console.WriteLine("Số hoặc ký tự đã nhập không hợp lệ vui lòng nhập số có 3 chữ số.");
                goto nhaplaiso;
            }
            else
            {
                int donvi = input % 10;
                int chuc = (input % 100) / 10;
                int tram = input / 100;
                Console.WriteLine("Tổng các chữ số của số đã nhập là : {0} + {1} + {2} = {3}", tram, chuc, donvi, tram + chuc + donvi);
            }
        }
        private static void TH06()
        {
            //Nhập vào 1 số gồm 4 chữ số, yêu cầu xuất số đó theo thứ tự ngược lại
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
        nhaplaiso:
            int input;
            Console.Write("Input: ");
            if (int.TryParse(Console.ReadLine(), out input) && input > 9999 || input < 1000)
            {
                Console.WriteLine("Số hoặc ký tự không hợp lệ vui lòng nhập số có 4 chữ số.");
                goto nhaplaiso;
            }
            else
            {
                int nghin = input / 1000;
                int tram = (input / 100) % 10;
                int chuc = (input / 10) % 10;
                int donvi = (input % 10);
                Console.WriteLine("Số đã nhập ngược lại là {0}{1}{2}{3}", donvi, chuc, tram, nghin);


            }

        }
        private static void TH07()
        {
            //Nhập vào 2 ký tự, yêu cầu xuất ra mã ASCII của từng ký tự và tổng giá trị mã ASCII của 2 ký tự.
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            char input1;
            char input2;
            Console.Write("Input: ");
            input1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Input: ");
            input2 = Convert.ToChar(Console.ReadLine());
            byte ascii = (byte)input1;
            byte ascii2 = (byte)input2;
            int x = ascii + ascii2;
            Console.WriteLine("2 Ký tự bạn vừa nhập là {0} và {1} có giá trị theo bảng mã ASCII là {2} và {3}", input1, input2, ascii, ascii2);
            Console.WriteLine("Tổng giá trị mã ASCII của 2 ký tự là: {0} + {1} = {2}", ascii, ascii2, x);
            return;

        }
        private static void TH08()
        {
            //TH08 : Nhập vào 1 số thực. Xuất ra màn hình số lấy chính xác 3 chữ số thập phân từ ban đầu bằng 2 cách
            //Cách 1: Sử dụng làm làm tròn.

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            /*
            double sothuc;
            Console.Write("Input: ");
            sothuc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Số {0} sau khi làm tròn ba chữ số là: {1}", sothuc, Math.Round(sothuc, 3));
            */
            // Cách 2: Sử dụng định dạng xuất
            double sothuc;
            Console.WriteLine("Input: ");
            sothuc = Convert.ToDouble(Console.ReadLine());




            Console.WriteLine("Số {0} sau khi làm tròn ba chữ số là:", sothuc);

        }

    }
}
