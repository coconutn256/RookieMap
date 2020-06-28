using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RookieMap
{
    public class Polygon
    {
        public int arc_num;
        public double[] bbox;
        public int[,] arcs;
        public List<PointD> polygon;
        public Polygon()
        {

        }
    }
}
