using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RookieMap
{
    public class Grid
    {
        private AddGridMethod method;
        private int x_num;
        private int y_num;
        private MyPoint[,] points;
        private MyPoint[] source;
        private double[] bbox;
        private int n;
        private List<Edge> x_lines;
        private List<Edge> y_lines;

        public AddGridMethod Method { get => method; set => method = value; }
        public int X_num { get => x_num; set => x_num = value; }
        public int Y_num { get => y_num; set => y_num = value; }
        public MyPoint[,] Points { get => points; set => points = value; }
        public double[] Bbox { get => bbox; set => bbox = value; }
        public int N { get => n; set => n = value; }
        public MyPoint[] Source { get => source; set => source = value; }
        public List<Edge> X_lines { get => x_lines; }
        public List<Edge> Y_lines { get => y_lines; }

        public Grid(MyPoint[] source, double[] boundary, int x_num, int y_num, int n, AddGridMethod method)
        {
            this.x_num = x_num;
            this.y_num = y_num;
            this.method = method;
            this.Source = source;
            this.bbox = boundary;
            this.N = n;
            this.points = new MyPoint[this.x_num+1, this.y_num+1];
            this.x_lines = new List<Edge>();
            this.y_lines = new List<Edge>();
        }

        public Grid()
        {
            this.x_num = 0;
            this.y_num = 0;
            this.method = 0;
            this.bbox = new double[4];
            this.N = 0;
            this.points = new MyPoint[this.x_num + 1, this.y_num + 1];
            this.x_lines = new List<Edge>();
            this.y_lines = new List<Edge>();
        }

        public void GenerateGrid()
        {
            GenerateGridLine();
            switch (this.Method)
            {
                case AddGridMethod.IDW:
                    this.IDW();
                    break;
                case AddGridMethod.DPW:
                    this.DPW();
                    break;
            }
        }

        private void GenerateGridLine()
        {
            X_lines.Clear();
            Y_lines.Clear();
            double dx = (this.bbox[2] - this.bbox[0]) / x_num;
            double dy = (this.bbox[3] - this.bbox[1]) / y_num;
            for (int i = 0; i < x_num + 1; i++)
            {
                double cur_X = i * dx + this.bbox[0];
                Edge tmp = new Edge(new PointD(cur_X, this.bbox[1]), new PointD(cur_X, this.bbox[3]));
                Y_lines.Add(tmp);
            }

            for (int i = 0; i < y_num + 1; i++)
            {
                double cur_Y = i * dy + this.bbox[1];
                Edge tmp = new Edge(new PointD(this.bbox[0], cur_Y), new PointD(this.bbox[2], cur_Y));
                X_lines.Add(tmp);
            }
        }

        private void IDW()
        {
            if (source == null || source.Length == 0)
                return;
            points = new MyPoint[this.x_num + 1, this.y_num + 1];
            for (int i = 0; i < this.x_num + 1; i++)
            {
                for (int j = 0; j < this.y_num + 1; j++)
                {
                    double x = this.bbox[0] + (this.bbox[2] - this.bbox[0]) / this.x_num * i;
                    double y = this.bbox[1] + (this.bbox[3] - this.bbox[1]) / this.y_num * j;
                    double weight_total = 0.0;
                    double value = 0;
                    bool flag = false;
                    List<double[]> distances = new List<double[]>(source.Length);
                    foreach (MyPoint raw_point in source)
                    {
                        double distance = Math.Sqrt(Math.Pow(raw_point.X - x, 2) + Math.Pow(raw_point.Y - y, 2));
                        if (distance < utils.eps)
                        {
                            value = raw_point.Z;
                            flag = true;
                            break;
                        }
                        else
                        {
                            distances.Add(new double[2] { distance, raw_point.Z });
                        }
                    }
                    if (!flag)
                    {
                        distances.Sort((x1, y1) => x1[0].CompareTo(y1[0]));
                        for (int k = 0; k < this.N; k++)
                        {
                            value = value + distances[k][1] / distances[k][0];
                            weight_total = weight_total + 1.0 / distances[k][0];
                        }
                        value = value / weight_total;
                    }
                    this.points[i, j] = new MyPoint();
                    this.points[i, j].X = x;
                    this.points[i, j].Y = y;
                    this.points[i, j].Z = value;
                }
            }

        }

        private void DPW()
        {
            if (source == null || source.Length == 0)
                return;
            points = new MyPoint[this.x_num + 1, this.y_num + 1];
            for (int i = 0; i < this.x_num + 1; i++)
            {
                for (int j = 0; j < this.y_num + 1; j++)
                {
                    double x = this.bbox[0] + (this.bbox[2] - this.bbox[0]) / this.x_num * i;
                    double y = this.bbox[1] + (this.bbox[3] - this.bbox[1]) / this.y_num * j;
                    double weight_total = 0.0;
                    double value = 0;
                    bool flag = false;
                    List<double[]> distances = new List<double[]>(source.Length);
                    List<double[]> distances_angle = new List<double[]>(this.N * 4);
                    for (int k = 0; k < this.N * 4; k++)
                    {
                        distances_angle.Add(new double[2] { -1, 0 });
                    }
                    foreach (MyPoint raw_point in this.source)
                    {
                        double distance = Math.Sqrt(Math.Pow(raw_point.X - x, 2) + Math.Pow(raw_point.Y - y, 2));
                        double angle = Math.Atan((raw_point.Y - y) / (raw_point.X - x)) / Math.PI * 180;
                        while (angle >= 360 || angle < 0)
                        {
                            if (angle >= 360)
                            {
                                angle = angle - 360;
                            }
                            if (angle < 0)
                            {
                                angle = angle + 360;
                            }
                        }
                        if (distance < utils.eps)
                        {
                            value = raw_point.Z;
                            flag = true;
                            break;
                        }
                        else
                        {
                            distances.Add(new double[3] { distance, raw_point.Z, angle });
                        }
                    }
                    if (!flag)
                    {
                        for (int k = 0; k < this.source.Length; k++)
                        {
                            int direct = (int)Math.Floor(distances[k][2] / (90.0 / (double)this.N));
                            if (distances_angle[direct][0] == -1 || distances[k][0] < distances_angle[direct][0])
                            {
                                distances_angle[direct][0] = distances[k][0];
                                distances_angle[direct][1] = distances[k][1];
                            }
                        }
                        double d2_multiply = 1;
                        for (int k = 0; k < this.N * 4; k++)
                        {
                            d2_multiply = d2_multiply * Math.Pow(distances_angle[k][0], 2);
                        }
                        for (int k = 0; k < this.N * 4; k++)
                        {
                            if (distances_angle[k][0] != -1)
                            {
                                weight_total = weight_total + d2_multiply / Math.Pow(distances_angle[k][0], 2);
                            }
                        }
                        double sum_d2 = 0.0;
                        for (int k = 0; k < this.N * 4; k++)
                        {
                            double tmp = 1.0;
                            if (distances_angle[k][0] == -1)
                            {
                                continue;
                            }
                            for (int n = 0; n < this.N * 4; n++)
                            {
                                if (distances_angle[n][0] != -1)
                                {
                                    if (k != n)
                                    {
                                        tmp = tmp * Math.Pow(distances_angle[n][0], 2);
                                    }
                                }
                            }
                            sum_d2 = sum_d2 + tmp;
                        }
                        double tj = 0.0;
                        for (int k = 0; k < this.N * 4; k++)
                        {
                            double lcup = 1.0;
                            if (distances_angle[k][0] == -1)
                            {
                                continue;
                            }
                            for (int n = 0; n < this.N * 4; n++)
                            {
                                if (distances_angle[n][0] != -1)
                                {
                                    if (k != n)
                                    {
                                        lcup = lcup * Math.Pow(distances_angle[n][0], 2);
                                    }
                                }
                            }
                            value = value + lcup / sum_d2 * distances_angle[k][1];
                            tj = tj + lcup / sum_d2;
                        }
                    }
                    this.points[i, j] = new MyPoint();
                    this.points[i, j].X = x;
                    this.points[i, j].Y = y;
                    this.points[i, j].Z = value;
                }
            }
        }

        /// <summary>
        /// 加密格网
        /// </summary>
        /// <param name="x_dense"></param>
        /// <param name=""></param>
        public void DenseGrid(int x_dense, int y_dense)
        {
            MyPoint[,] newGrids = new MyPoint[this.x_num*x_dense+1, this.y_num*y_dense+1];
            for(int col = 0; col <= this.x_num; col++)
            {
                for(int row = 0; row <= this.y_num; row++)
                {
                    newGrids[col * x_dense, row * y_dense] = this.points[col, row];
                }
            }

            for (int i = 0; i < this.x_num * x_dense + 1; i++)
            {
                for (int j = 0; j < this.y_num * y_dense + 1; j++)
                {
                    int col = i / x_dense;
                    int col2 = i % x_dense;
                    int row = j / y_dense;
                    int row2 = j % y_dense;

                    if (col2 ==0 && row2 == 0)
                    {
                        continue;
                    }

                    double x = this.bbox[0] + (this.bbox[2] - this.bbox[0]) / (this.x_num * x_dense) * i;
                    double y = this.bbox[1] + (this.bbox[3] - this.bbox[1]) / (this.y_num * y_dense) * j;

                    double z1, z2, z;
                    if (col == this.x_num) //col2==0
                    {
                        z1 = this.points[col, row].Z;
                        z2 = this.points[col, row + 1].Z;
                        z = (z2 - z1) / y_dense * row2 + z1;
                    } else if (row == this.y_num) //row2==0
                    {
                        z = col2 * (this.points[col + 1, row].Z - this.points[col, row].Z) / x_dense + this.points[col, row].Z;
                    } else
                    {
                        z1 = (this.points[col + 1, row].Z - this.points[col, row].Z) / x_dense * col2 + this.points[col, row].Z;
                        z2 = (this.points[col + 1, row + 1].Z - this.points[col, row + 1].Z) / x_dense * col2 + this.points[col, row + 1].Z;
                        z = (z2 - z1) / y_dense * row2 + z1;
                    }

                    MyPoint tmp_pt = new MyPoint();
                    tmp_pt.X = x;
                    tmp_pt.Y = y;
                    tmp_pt.Z = z;
                    newGrids[i, j] = tmp_pt;
                }
            }

            this.x_num *= x_dense;
            this.y_num *= y_dense;
            this.points = newGrids;
            GenerateGridLine();
        }

        /// <summary>
        /// 获取距离点最近的格网线
        /// </summary>
        /// <param name="pt">Point</param>
        /// <param name="axis">0指行，1指列</param>
        /// <returns>返回edge对应的编号</returns>
        public int GetNearestLine(PointD pt, int axis=0)
        {
            int ret = -1;
            double dis = double.MaxValue;
            int cnt = 0;
            List<Edge> edges;
            if (axis == 0)
            {
                edges = this.x_lines;
                foreach (Edge edge in edges)
                {
                    double tmp = Math.Abs(edge.point1.Y - pt.Y);
                    if (dis > tmp)
                    {
                        dis = tmp;
                        ret = cnt;
                    }
                    cnt++;
                }
                return ret;
            }
            else if(axis == 1)
            {
                edges = this.y_lines;
                foreach (Edge edge in edges) 
                {
                    double tmp = Math.Abs(edge.point1.X - pt.X);
                    if (dis > tmp)
                    {
                        dis = tmp;
                        ret = cnt;
                    }
                    cnt++;
                }
                return ret;
            } else
            {
                return -1;
            }
        }
    }

    public enum AddGridMethod
    {
        IDW,
        DPW
    }
}
