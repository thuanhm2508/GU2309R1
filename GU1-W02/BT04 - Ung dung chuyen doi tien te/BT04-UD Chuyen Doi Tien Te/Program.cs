using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT04_UD_Chuyen_Doi_Tien_Te
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int USD;
            Console.Write("Nhap so tien USD: ");
            USD = int.Parse(Console.ReadLine());
            Console.WriteLine("So tien VND la: " + USD * 23000);

        }
    }
}
