using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2D_P3D
{
    public class Point3D : Point2D
    {
        private double z;
        public Point3D(double x = 0, double y = 0, double z = 0) : base(x, y)
        {
            this.z = z;
        }
        public double Z { get => z; set => z = value; }

        public void SetXYZ(double x, double y, double z = 0.0)
        {
            base.SetXY(x, y);
            this.z = z;
        }
        public List<double> GetXYZ()
        {
            List<double> result = new List<double>();
            result = base.GetXY();
            result.Add(z);
            return result;
        }
        public override string ToString()
        {
            return string.Format("(x = {0},y = {1},z = {2})", X, Y, this.z);
        }
    }
}
