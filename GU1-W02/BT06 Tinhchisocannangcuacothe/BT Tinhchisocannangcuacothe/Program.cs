using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Tinhchisocannangcuacothe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // B1: Khai báo biến 
            double height;
            double weight;

            // B2: Nhập dữ liệu
            Console.WriteLine("Please enter a height");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your weight");
            weight = float.Parse(Console.ReadLine());

            // B3: Tính chỉ số theo công thức cho trước
            double bmi = weight / Math.Pow(height, 2);
            bmi = Math.Round(bmi, 1);

            // B4: hiển thị chỉ số và phân loại kết quả
            Console.Write("BMI: " + bmi);

            if (bmi < 18)
                Console.WriteLine(" Underweight");
            else if (bmi < 25.0)
                Console.WriteLine(" Normal");
            else if (bmi < 30.0)
                Console.WriteLine(" Overweight");
            else
                Console.WriteLine(" Obese");
        }

    }
}
