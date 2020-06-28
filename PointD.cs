using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookieMap
{
    public class PointD
    {
        public double X;
        public double Y;
        public PointD(double x=0, double y=0)
        {
            this.X = x;
            this.Y = y;
        }

        public static PointD operator +(PointD p1, PointD p2)
        {
            return new PointD(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static PointD operator -(PointD p1, PointD p2)
        {
            return new PointD(p1.X - p2.X, p1.Y - p2.Y);
        }
    }
}
