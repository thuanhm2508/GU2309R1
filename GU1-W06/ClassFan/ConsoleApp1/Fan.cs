using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Fan
    {
        // Hằng số định nghĩa tốc độ quạt
        public const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int FAST = 3;

        // Trường
        private int speed;
        private bool on;
        private double radius;
        private string color;

        // Getter và setter cho các thuộc tính
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public bool On
        {
            get { return on; }
            set { on = value; }
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

        // Phương thức khởi tạo không tham số
        public Fan()
        {
            speed = SLOW;
            on = false;
            radius = 5;
            color = "blue";
        }

        // Phương thức ToString
        public override string ToString()
        {
            if (on)
            {
                return $"Speed: {speed}, Color: {color}, Radius: {radius} - Fan is on";
            }
            else
            {
                return $"Color: {color}, Radius: {radius} - Fan is off";
            }
        }
    }
}
