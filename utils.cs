using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookieMap
{
    public class utils
    {
        public static double eps = 1e-8;
        public static double PointsDistance(PointD p1, PointD p2)
        {
            double ret = 0;
            ret = Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
            return ret;
        }

        public static double CalCos(MyPoint pt1, MyPoint pt2, MyPoint pt3)
        {
            double length1 = Math.Sqrt(Math.Pow(pt1.X - pt2.X, 2) + Math.Pow(pt1.Y - pt2.Y, 2));
            double length2 = Math.Sqrt(Math.Pow(pt1.X - pt3.X, 2) + Math.Pow(pt1.Y - pt3.Y, 2));
            double length3 = Math.Sqrt(Math.Pow(pt3.X - pt2.X, 2) + Math.Pow(pt3.Y - pt2.Y, 2));
            double cos = (Math.Pow(length2, 2) + Math.Pow(length3, 2) - Math.Pow(length1, 2)) / (2 * length2 * length3);
            return cos;
        }

        public static bool LineIntersect(MyPoint p1, MyPoint p2, MyPoint q1, MyPoint q2, bool contain_end=false)
        {
            if (p1.Id == q1.Id || p1.Id == q2.Id || p2.Id == q1.Id || p2.Id == q2.Id)
                return contain_end;

            //排斥试验，判断p1p2在q1q2为对角线的矩形区之外
            if (Math.Max(p1.X, p2.X) < Math.Min(q1.X, q2.X))
            {//P1P2中最大的X比Q1Q2中的最小X还要小，说明P1P2在Q1Q2的最左点的左侧，不可能相交。
                return false;
            }

            if (Math.Min(p1.X, p2.X) > Math.Max(q1.X, q2.X))
            {//P1P2中最小的X比Q1Q2中的最大X还要大，说明P1P2在Q1Q2的最右点的右侧，不可能相交。
                return false;
            }

            if (Math.Max(p1.Y, p2.Y) < Math.Min(q1.Y, q2.Y))
            {//P1P2中最大的Y比Q1Q2中的最小Y还要小，说明P1P2在Q1Q2的最低点的下方，不可能相交。
                return false;
            }

            if (Math.Min(p1.Y, p2.Y) > Math.Max(q1.Y, q2.Y))
            {//P1P2中最小的Y比Q1Q2中的最大Y还要大，说明P1P2在Q1Q2的最高点的上方，不可能相交。
                return false;
            }

            //跨立试验
            double A, B;
            if (p1.X != p2.X)
            {
                A = (p2.Y - p1.Y) / (p2.X - p1.X);
                B = (p1.Y * p2.X - p2.Y * p1.X) / (p2.X - p1.X);
                double tmp = (q2.Y - A * q2.X - B);
                if ((q1.Y - A * q1.X - B) * (q2.Y - A * q2.X - B) > 0)
                {
                    return false;
                }
            }
            else
            {
                if ((p1.X - q1.X) * (p1.X - q2.X) > 0)
                {
                    return false;
                }
            }
            if (q1.X != q2.X)
            {
                A = (q2.Y - q1.Y) / (q2.X - q1.X);
                B = (q1.Y * q2.X - q2.Y * q1.X) / (q2.X - q1.X);
                if ((p1.Y - A * p1.X - B) * (p2.Y - A * p2.X - B) > 0)
                {
                    return false;
                }
            }
            else
            {
                if ((q1.X - p1.X) * (q1.X - p2.X) > 0)
                {
                    return false;
                }
            }
            return true;
        }


        public static bool PointInTriangle(MyPoint p, MyPoint a, MyPoint b, MyPoint c)
        {
            double signOfTrig = (b.X - a.X) * (c.Y - a.Y) - (b.Y - a.Y) * (c.X - a.X);

            double signOfAB = (b.X - a.X) * (p.Y - a.Y) - (b.Y - a.Y) * (p.X - a.X);
            double signOfCA = (a.X - c.X) * (p.Y - c.Y) - (a.Y - c.Y) * (p.X - c.X);
            double signOfBC = (c.X - b.X) * (p.Y - c.Y) - (c.Y - b.Y) * (p.X - c.X);


            bool d1 = (signOfAB * signOfTrig > 0);
            bool d2 = (signOfCA * signOfTrig > 0);
            bool d3 = (signOfBC * signOfTrig > 0);
            return d1 && d2 && d3;
        }

        /// <summary>
        /// 判断点是否在多边形内部
        /// </summary>
        /// <param name="polygon"></param>
        /// <param name="pt"></param>
        /// <returns></returns>
        public static bool PointInPolygon(Polygon polygon, PointD pt)
        {
            if (pt.X>polygon.bbox[2] || pt.X<polygon.bbox[0] || pt.Y>polygon.bbox[3] || pt.Y<polygon.bbox[1])
            {
                return false;
            }

            int i, j, c = 0;
            int nvert = polygon.polygon.Count;
            List<PointD> verts = polygon.polygon;
            for (i = 0, j = nvert - 1; i < nvert; j = i++)
            {
                if (((verts[i].Y > pt.Y) != (verts[j].Y > pt.Y)) && (pt.X < (verts[j].X - verts[i].X) * (pt.Y - verts[i].Y) / (verts[j].Y - verts[i].Y) + verts[i].X))
                {
                    c = 1 + c;
                }
            }
            if (c % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
