using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chenPhanTuVaoMang
{
    class Program
    {
        static void Main()
        {
            //Viết chữ có dấu và in ra có dấu
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //Khai báo và khởi tạo mảng
            int[] mang = new int[] { 10, 4, 6, 7, 8, 0, 0, 0, 0, 0 };

            //In ra các phần tử của mảng
            Console.Write("Các phần tử của mảng trước khi chèn là: ");
            foreach (int i in mang)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();

            // Nhập giá trị cần thêm vào mảng
            Console.WriteLine("Nhập giá trị X cần chèn vào mảng: ");
            int X = int.Parse(Console.ReadLine());

            //Nhập vị trí cần chèn
            Console.WriteLine("Nhập vị trí cần chèn vào mảng: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index <= mang.Length)
            {
                mang = ChenPhanTu(mang, X, index);
                Console.WriteLine("Mang sau khi chen:");
                HienThiMang(mang);
            }
            else
            {
                Console.WriteLine("Vi tri chen khong hop le.");
            }
        }
        static void HienThiMang(int[] arr)
        {
            foreach (int phanTu in arr)
            {
                Console.Write($"{phanTu} ");
            }
            Console.WriteLine();
        }

        static int[] ChenPhanTu(int[] arr, int phanTu, int index)
        {

            int[] mangMoi = new int[arr.Length + 1];
            for (int i = 0; i < index; i++)
            {
                mangMoi[i] = arr[i];
            }
            mangMoi[index] = phanTu;
            for (int i = index; i < arr.Length; i++)
            {
                mangMoi[i + 1] = arr[i];
            }

            return mangMoi;
        }
    }

}


