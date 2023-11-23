using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinder
{
    public class Circle
    {
        private double radius;
        private string color;
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public double Area
        {
            get { return Math.PI * radius * radius; }
        }
        public override string ToString()
        {
            return $"Circle [radius={radius}, color={color}]";
        }
    }

    // Lớp Cylinder kế thừa từ lớp Circle
    public class Cylinder : Circle
    {
        private double height;
        public Cylinder(double radius, string color, double height) : base(radius, color)
        {
            this.height = height;
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Volume
        {
            get { return base.Area * height; }
        }
        // Phương thức ToString
        public override string ToString()
        {
            return $"Cylinder [radius={Radius}, color={Color}, height={height}]";
        }
    }

}
