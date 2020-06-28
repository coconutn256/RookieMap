using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookieMap
{
    public class MyPoint
    {
        private int id;
        private String name;
        private PointD pointd;
        private double z;


        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public PointD Pointd { get => pointd; set => pointd = value; }
        public double X { get => Pointd.X; set => pointd.X = value; }
        public double Y { get => Pointd.Y; set => pointd.Y = value; }
        public double Z { get => z; set => z = value; }

        public MyPoint(int id, String name, PointD pointd, double z)
        {
            this.Id = id;
            this.Name = name;
            this.Pointd = pointd;
            this.Z = z;
        }

        public MyPoint()
        {
            this.id = -1;
            this.name = null;
            this.pointd = new PointD(0, 0);
            this.z = 0;
        }
    }
}
