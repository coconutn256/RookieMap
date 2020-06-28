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
                    c = 1 + c; ;
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
