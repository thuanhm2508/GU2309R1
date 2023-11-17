using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timPhanTuLonNhatTrongMang
{
    class Program
    {
        static void Main()
        {
            Console.Write("Nhap so hang cua ma tran: ");
            int soHang = int.Parse(Console.ReadLine());

            Console.Write("Nhap so cot cua ma tran: ");
            int soCot = int.Parse(Console.ReadLine());

            // Khai báo ma trận
            double[,] maTran = new double[soHang, soCot];

            // Nhập giá trị cho ma trận
            NhapMaTran(maTran);

            // Hiển thị ma trận
            Console.WriteLine("Ma tran vua nhap la:");
            HienThiMaTran(maTran);

            // Tìm giá trị lớn nhất và tọa độ của nó
            TimGiaTriLonNhat(maTran, out double giaTriLonNhat, out int hang, out int cot);

            // Hiển thị kết quả
            Console.WriteLine($"Gia tri lon nhat la {giaTriLonNhat} tai toa do ({hang}, {cot}).");
        }

        static void NhapMaTran(double[,] maTran)
        {
            int soHang = maTran.GetLength(0);
            int soCot = maTran.GetLength(1);

            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write($"Nhap gia tri tai hang {i + 1}, cot {j + 1}: ");
                    maTran[i, j] = double.Parse(Console.ReadLine());
                }
            }
        }

        static void HienThiMaTran(double[,] maTran)
        {
            int soHang = maTran.GetLength(0);
            int soCot = maTran.GetLength(1);

            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write($"{maTran[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        static void TimGiaTriLonNhat(double[,] maTran, out double giaTriLonNhat, out int hang, out int cot)
        {
            int soHang = maTran.GetLength(0);
            int soCot = maTran.GetLength(1);

            giaTriLonNhat = maTran[0, 0];
            hang = 0;
            cot = 0;

            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    if (maTran[i, j] > giaTriLonNhat)
                    {
                        giaTriLonNhat = maTran[i, j];
                        hang = i;
                        cot = j;
                    }
                }
            }
        }
    }
}
