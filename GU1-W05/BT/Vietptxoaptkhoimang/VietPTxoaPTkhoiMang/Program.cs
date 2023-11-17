using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietPTxoaPTkhoiMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mang = new int[] { 10, 4, 6, 7, 8, 6, 0, 0, 0, 0 };
            foreach (int item in mang)
            {
                Console.Write(" "+ item);
            }
            Console.WriteLine();
            Console.Write("Nhap phan tu can xoa: ");
            int phanTuCanXoa = int.Parse(Console.ReadLine());

            // Bước 3: Tìm vị trí của X trong mảng
            int index_del = -1;
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] == phanTuCanXoa)
                {
                    index_del = i;
                    break;
                }
            }

            // Bước 4: Thực hiện xoá phần tử X khỏi mảng
            if (index_del != -1)
            {
                for (int i = index_del; i < mang.Length - 1; i++)
                {
                    mang[i] = mang[i + 1];
                }

                // Giảm kích thước của mảng đi 1
                Array.Resize(ref mang, mang.Length - 1);

                Console.WriteLine($"Phan tu {phanTuCanXoa} tai vi tri {index_del + 1} da duoc xoa.");
            }
            else
            {
                Console.WriteLine($"Khong tim thay phan tu {phanTuCanXoa} trong mang.");
            }

            // Bước 5: Kết thúc duyệt mảng. In ra mảng.
            Console.WriteLine("Mang sau khi xoa:");
            HienThiMang(mang);
        }

        static void HienThiMang(int[] arr)
        {
            foreach (int phanTu in arr)
            {
                Console.Write($"{phanTu} ");
            }
            Console.WriteLine();
        }
    }
}

