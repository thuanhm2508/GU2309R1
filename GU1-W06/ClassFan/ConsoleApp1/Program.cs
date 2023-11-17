using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng Fan 1
            Fan fan1 = new Fan();
            fan1.Speed = Fan.FAST;
            fan1.Radius = 10;
            fan1.Color = "yellow";
            fan1.On = true;

            // Tạo đối tượng Fan 2
            Fan fan2 = new Fan();
            fan2.Speed = Fan.MEDIUM;
            fan2.Radius = 5;
            fan2.Color = "blue";
            fan2.On = false;

            // Hiển thị thông tin đối tượng
            Console.WriteLine("Fan 1: " + fan1.ToString());
            Console.WriteLine("Fan 2: " + fan2.ToString());
        }
    }
}
