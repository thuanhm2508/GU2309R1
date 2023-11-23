﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Square : Rectangle
    {
        public Square()
        {
        }

        public Square(double side) : base(side, side)
        {
        }

        public Square(double side, String color, bool filled) : base(side, side, color, filled)
        {
        }

        public double getSide()
        {
            return GetWidth();
        }

        public void SetSide(double side)
        {
            SetWidth(side);
            SetLength(side);
        }

        public override void SetWidth(double width)
        {
            SetSide(width);
        }

        public override void SetLength(double length)
        {
            SetSide(length);
        }


        public override String ToString()
        {
            return "A Square with side="
                    + getSide()
                    + ", which is a subclass of "
                    + base.ToString();
        }
    }
}