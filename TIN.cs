using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RookieMap
{
    public class TIN_Edge
    {
        public int Line_id;
        public int tri1;
        public int tri2;
        public int pt1_id;
        public int pt2_id;

        public TIN_Edge(int id, int tri1=-1, int tri2=-1, int pt1_id=-1, int pt2_id = -2)
        {
            this.Line_id = id;
            this.tri1 = tri1;
            this.tri2 = tri2;
            this.pt1_id = pt1_id;
            this.pt2_id = pt2_id;
        }
    }

    public class TIN_Triangle
    {
        public int Tin_flag_id;
        public int pt1_id;
        public int pt2_id;
        public int pt3_id;

        public TIN_Triangle(int id, int pt1_id, int pt2_id, int pt3_id)
        {
            this.Tin_flag_id = id;
            this.pt1_id = pt1_id;
            this.pt2_id = pt2_id;
            this.pt3_id = pt3_id;
        }

        public bool ContainPoint(int pt_id)
        {
            if (pt_id == pt1_id || pt_id == pt2_id || pt_id == pt3_id)
                return true;
            return false;
        }

        public int GetThirdPoint(int pt1, int pt2)
        {
            List<int> pts = new List<int>();
            pts.Add(this.pt1_id);
            pts.Add(this.pt2_id);
            pts.Add(this.pt3_id);
            if (pts.Contains(pt1))
                pts.Remove(pt1);
            if (pts.Contains(pt2))
                pts.Remove(pt2);
            return pts[0];
        }
    }

    public class TIN
    {

        private MyPoint[] source;
        private double[] bbox;
        private List<TIN_Triangle> triangles;
        private List<TIN_Edge> edges;

        public MyPoint[] Source { get => source; set => source = value; }
        public double[] Bbox { get => bbox; set => bbox = value; }
        public List<TIN_Triangle> Triangles { get => triangles; set => triangles = value; }
        public List<TIN_Edge> Edges { get => edges; set => edges = value; }

        public TIN()
        {
            this.bbox = new double[4];
            this.triangles = new List<TIN_Triangle>();
            this.edges = new List<TIN_Edge>();
        }

        public int GenerateTIN()
        {
            this.triangles.Clear();
            int i = 0, j = 0;
            int edge_id = 0;
            double min_dis = double.MaxValue;
            int[] idx = new int[2];

            // 寻找最短边作为开始
            for (i = 0; i < this.source.Length; i++)
            {
                for (j = i+1; j < this.source.Length; j++)
                {
                    double tmp_dis = Math.Pow(this.source[i].X - this.source[j].X, 2) + Math.Pow(this.source[i].Y - this.source[j].Y, 2);
                    if (tmp_dis < min_dis)
                    {
                        idx[0] = i;
                        idx[1] = j;
                        min_dis = tmp_dis;
                    }
                }
            }

            List<TIN_Edge> cur_edges = new List<TIN_Edge>();
            List<TIN_Edge> Generated_line = new List<TIN_Edge>();
            TIN_Edge frist_edge = new TIN_Edge(edge_id++, pt1_id:idx[0], pt2_id:idx[1]);
            cur_edges.Add(frist_edge);
            Generated_line.Add(frist_edge);

            //循环生长生成TIN
            bool flag = true;
            while (flag)
            {
                flag = false;
                List<TIN_Edge> tmp_lines = new List<TIN_Edge>();
                List<TIN_Edge> ext_lines = new List<TIN_Edge>();
                int ext_pt = -1;

                //获得当前边中可扩展的边（只有一个相邻的三角形）
                for (i = 0; i < cur_edges.Count; i++)
                {
                    int cnt = 0;
                    TIN_Edge line = (TIN_Edge)cur_edges[i];
                    foreach (TIN_Triangle tri in this.triangles)
                    {
                        if (tri.ContainPoint(line.pt1_id) && tri.ContainPoint(line.pt2_id))
                        {
                            cnt++;
                        }
                    }
                    if (cnt < 2) //边只有一个相邻三角形
                    {
                        ext_lines.Add(line);
                    }
                }

                cur_edges = ext_lines;
                //尝试对每条扩展边进行生长
                foreach (TIN_Edge line in cur_edges)
                {
                    double cos = 1;
                    MyPoint point1 = (MyPoint)this.source[line.pt1_id];
                    MyPoint point2 = (MyPoint)this.source[line.pt2_id];

                    //避免生成重复三角形
                    int point3_tri = -1;
                    foreach (TIN_Triangle tri2 in this.triangles)
                    {
                        if (tri2.ContainPoint(line.pt1_id) && tri2.ContainPoint(line.pt2_id))
                        {
                            point3_tri = tri2.GetThirdPoint(line.pt1_id, line.pt2_id);
                        }
                    }

                    //确保扩展边与当前存在的边不相交(端点处不计)
                    for (i = 0; i < this.source.Length; i++)
                    {
                        if (i == point3_tri)
                        {
                            continue;
                        }
                        MyPoint point3 = (MyPoint)this.source[i];
                        bool intersect_flag = false;
                        foreach (TIN_Edge tmp_line in Generated_line)
                        {
                            MyPoint p1 = new MyPoint();
                            MyPoint p2 = new MyPoint();
                            p1 = (MyPoint)this.source[tmp_line.pt1_id];
                            p2 = (MyPoint)this.source[tmp_line.pt2_id];
                            if(utils.LineIntersect(p1, p2, point3, point1) || utils.LineIntersect(p1, p2, point3, point2)){
                                intersect_flag = true;
                                break;
                            }
                        }

                        //角度最大准则，选取下一个扩展点
                        if (!intersect_flag)
                        {
                            double tmp_cos = utils.CalCos(point1, point2, point3);
                            if (tmp_cos < cos)
                            {
                                cos = tmp_cos;
                                ext_pt = i;
                            }
                        }
                    }

                    //判断扩展点是否可用（生长是否结束）
                    if (ext_pt != -1)
                    {
                        TIN_Triangle tri = new TIN_Triangle(this.triangles.Count, line.pt1_id, line.pt2_id, ext_pt);

                        bool stop_flag = false;

                        //判断是否出现重复三角形
                        foreach (TIN_Triangle tri2 in this.triangles)
                        {
                            if (tri.ContainPoint(tri2.pt1_id) && tri.ContainPoint(tri2.pt2_id) && tri.ContainPoint(tri2.pt3_id))
                            {
                                stop_flag = true;
                                break;
                            }
                        }

                        //判断是否存在点位于三角形内部
                        foreach (MyPoint p in this.source)
                        {
                            if (!tri.ContainPoint(p.Id))
                            {
                                bool in_flag = true;
                                for (i = 0; i < 3; i++)
                                {
                                    if (!utils.PointInTriangle(p, this.source[tri.pt1_id], this.source[tri.pt2_id], this.source[tri.pt3_id]))
                                        in_flag = false;
                                }
                                if (in_flag)
                                {
                                    stop_flag = true;
                                }
                            }
                        }

                        //将生长的边和三角形加入TIN中
                        if (!stop_flag)
                        {
                            this.triangles.Add(tri);
                            TIN_Edge l1 = new TIN_Edge(edge_id++, tri1: tri.Tin_flag_id, pt1_id: line.pt1_id, pt2_id: ext_pt);
                            TIN_Edge l2 = new TIN_Edge(edge_id++, tri1: tri.Tin_flag_id, pt1_id: line.pt2_id, pt2_id: ext_pt);
                            l1.pt1_id = line.pt1_id;
                            l1.pt2_id = ext_pt;
                            l2.pt1_id = line.pt2_id;
                            l2.pt2_id = ext_pt;
                            tmp_lines.Add(l1);
                            tmp_lines.Add(l2);
                            Generated_line.Add(l1);
                            Generated_line.Add(l2);
                            flag = true;
                        }
                        ext_pt = -1;
                    }
                }
                cur_edges = tmp_lines;
            }
            this.edges = Generated_line;
            return 0;
        }
    }


}
