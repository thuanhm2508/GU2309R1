using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vietptdem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bước 1: Khai báo một chuỗi và gán giá trị
            string chuoi = "console.writeline";

            // Bước 2: Khai báo một biến ký tự và nhập giá trị từ bàn phím
            Console.Write("Nhap mot ky tu: ");
            char kyTuNhap = char.Parse(Console.ReadLine());

            // Bước 3: Khai báo biến count và gán giá trị 0
            int count = 0;

            // Bước 4: Duyệt từng ký tự trong chuỗi và tăng biến đếm khi gặp ký tự cần tìm
            for (int i = 0; i < chuoi.Length; i++)
            {
                if (chuoi[i] == kyTuNhap)
                {
                    count++;
                }
            }

            // Bước 5: In ra giá trị biến đếm
            Console.WriteLine($"So lan xuat hien cua ky tu '{kyTuNhap}' trong chuoi la: {count}");
        }
    }
}
