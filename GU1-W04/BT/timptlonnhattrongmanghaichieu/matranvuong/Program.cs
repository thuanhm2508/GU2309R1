using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matranvuong
{
    class Program
    {
        static void Main()
        {
            Console.Write("Nhap kich thuoc cua ma tran vuong: ");
            int kichThuoc = int.Parse(Console.ReadLine());

            // Khai báo ma trận vuông
            double[,] maTran = new double[kichThuoc, kichThuoc];

            // Nhập giá trị cho ma trận
            NhapMaTran(maTran);

            // Hiển thị ma trận
            Console.WriteLine("Ma tran vua nhap la:");
            HienThiMaTran(maTran);

            // Tính tổng đường chéo chính
            double tongDuongCheoChinh = TinhTongDuongCheoChinh(maTran);

            // Hiển thị kết quả
            Console.WriteLine($"Tong cac phan tu tren duong cheo chinh la: {tongDuongCheoChinh}");
        }

        static void NhapMaTran(double[,] maTran)
        {
            int kichThuoc = maTran.GetLength(0);

            for (int i = 0; i < kichThuoc; i++)
            {
                for (int j = 0; j < kichThuoc; j++)
                {
                    Console.Write($"Nhap gia tri tai hang {i + 1}, cot {j + 1}: ");
                    maTran[i, j] = double.Parse(Console.ReadLine());
                }
            }
        }

        static void HienThiMaTran(double[,] maTran)
        {
            int kichThuoc = maTran.GetLength(0);

            for (int i = 0; i < kichThuoc; i++)
            {
                for (int j = 0; j < kichThuoc; j++)
                {
                    Console.Write($"{maTran[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        static double TinhTongDuongCheoChinh(double[,] maTran)
        {
            int kichThuoc = maTran.GetLength(0);
            double tong = 0;

            for (int i = 0; i < kichThuoc; i++)
            {
                tong += maTran[i, i];
            }

            return tong;
        }
    }
}
