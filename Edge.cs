using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RookieMap
{
    public class Edge
    {
        public int id1, id2;
        public PointD point1;
        public PointD point2;
        public int left_polygon;
        public int right_polygon;
        public Edge()
        {

        }
        public Edge(MyPoint p1, MyPoint p2)
        {
            id1 = p1.Id;
            id2 = p2.Id;
            point1 = p1.Pointd;
            point2 = p2.Pointd;
        }

        public Edge(PointD p1, PointD p2)
        {
            point1 = p1;
            point2 = p2;
        }

        /// <summary>
        /// 点到直线距离
        /// </summary>
        /// <param name="pt"></param>
        /// <returns></returns>
        public double CalDistance(PointD pt)
        {
            double ret = 0.0;
            double a = utils.PointsDistance(point1, point2);
            double b = utils.PointsDistance(point1, pt);
            double c = utils.PointsDistance(point2, pt);
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            ret = 2 * s / a;  
            return ret;
        }
    }
}
