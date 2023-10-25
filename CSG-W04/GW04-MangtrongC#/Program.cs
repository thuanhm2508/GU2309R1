using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GW04_MangtrongC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //note();
            //BH01();
        }
        private static void note()
        {
            int[] a = { 23, 20, 19, 10 };
            //int[] b = new int[4] { 23, 20, 19, 10 };
            //Console.WriteLine(a.Last());        // Lấy giá trị cuối
            //Console.WriteLine(b.First());       // Lấy giá trị đầu
            //Console.WriteLine(a.Length);        // Kiểm tra có bao nhiêu giá trị 
            //Console.WriteLine(a.Average());     // Tính trung bình
            //Console.WriteLine(a.Min());         // Lấy giá trị bé nhất trong mảng
            //Console.WriteLine(a.Max());         // Lấy giá trị lớn nhất trong mảng

            for (int i = 0; i < a.Length; i++)          // for cho biết vị trí ký tự
            {
                Console.Write(a[i] + " ");

            }
            Console.WriteLine(" ");
            foreach (int item in a)                     // for không biết vị trí
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");
            Console.Write(string.Join(" ", a));     //string.Join("",a); để xuất chuỗi ra. trong đó (ký tự phân cách, mảng
            Console.ReadKey();
        }
        private static void BH01()
        {


            int n = 10;
            int[] a = new int [n];
            int dem_cp = 0;
            foreach (int item in a)
            {
                //Xy ly so nguyen to
                if (item > 1)
                {
                    if (item == 2 || item == 3)
                        Console.Write(item + " ");
                    else
                    {
                        if (item%2 !=0)
                        {
                            bool flag = true;
                            for (int i = 3; i <= Math.Sqrt(item); i = i + 3)
                            {
                                if (item % i == 0)
                                {
                                    flag = false; break;
                                }
                            }
                            if (flag) Console.Write(item + " ");
                        }
                    }
                }

                //Xy ly so chinh phuong
                int b = (int) Math.Sqrt(item);
                    if (b * b == item) dem_cp++;
            }

        }
    }

}
