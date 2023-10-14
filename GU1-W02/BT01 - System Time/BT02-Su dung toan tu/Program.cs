using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02_Su_dung_toan_tu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khai báo các biến chiều cao và chiều rộng
            float width;
            float height;
            // Lấy dữ liệu người dùng
            Console.Write("Enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());
            // Tính diện tích của hình chữ nhật và hiển thị ra màn hình
            float area = width * height;
            Console.WriteLine("Area is: " + area);

        }
    }
}
