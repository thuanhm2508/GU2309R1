using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinder
{
    class Program
    {
        static void Main()
        {
            // Tạo một đối tượng Circle
            Circle circle = new Circle(5.0, "Red");                 
            Console.WriteLine("Circle Information:");
            Console.WriteLine(circle);
            Console.WriteLine($"Area: {circle.Area}");
            Console.WriteLine();

            // Tạo một đối tượng Cylinder
            Cylinder cylinder = new Cylinder(3.0, "Blue", 8.0);                  
            Console.WriteLine("Cylinder Information:");
            Console.WriteLine(cylinder);
            Console.WriteLine($"Volume: {cylinder.Volume}");
        }
    }
}
