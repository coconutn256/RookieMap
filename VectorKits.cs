using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookieMap
{
    public class VectorKits
    {
        /// <summary>
        /// 叉乘(P1P2 x P1P3)
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <returns></returns>
        public static double Cross(PointD p1, PointD p2, PointD p3)
        {
            return (p2.X - p1.X) * (p3.Y - p1.Y) - (p2.Y - p1.Y) * (p3.X - p1.X);
        }


        /// <summary>
        /// 两个向量的点乘
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static double Dot(PointD p1, PointD p2)
        {
            return p1.X*p2.X + p1.Y*p2.Y;
        }
    }
}
