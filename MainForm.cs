using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RookieMap
{
    public partial class fmMain : Form
    {
        //输入的原始数据
        List<MyPoint> data;
        double[] boundary;

        //控制要素可视化
        bool blShowPoints;
        bool blShowGrid;
        bool blShowTIN;
        bool blShowContour;
        bool blShowPolygon;

        //显示用变量
        bool scrollbox;
        double scale, scale_back;
        double offsetX, offsetY;
        double offsetX_back, offsetY_back;
        PointD center;
        int mouse_ops;
        int click_ops;
        int selected_row;
        int selected_col;
        int selected_pol;
        int grid_step;

        Point mouseLocation, mouseLocation2;
        Rectangle box;

        //鼠标操作控制
        enum MouseOperations : int
        {
            Null,
            ScrollBox,
            Roam,
        }

        enum MouseClickOps: int
        {
            Null,
            SelectGrid,
            SelectPolygon
        }

        //子窗体
        fmAddGrid fmaddgrid;
        fmAddContour fmaddcontour;
        fmDenseGrid fmdensegrid;

        //衍生数据
        Grid grid = new Grid();

        public fmMain()
        {
            InitializeComponent();
            data = new List<MyPoint>();
            boundary = new double[4] { double.MaxValue, double.MaxValue, double.MinValue, double.MinValue };
            this.pbMain.MouseWheel += new MouseEventHandler(pbMain_MouseWheel);
            blShowGrid = false;
            blShowTIN = false;
            blShowContour = false;
            blShowPolygon = false;

            scrollbox = false;
            scale = 1.0;
            scale_back = 1.0;
            offsetX = 0;
            offsetX_back = 0;
            offsetY = 0;
            offsetY_back = 0;
            center = new PointD();
            mouseLocation = new Point();
            mouse_ops = (int)MouseOperations.Null;
            click_ops = (int)MouseClickOps.Null;
            selected_col = -1;
            selected_row = -1;
            selected_pol = -1;
            grid_step = 0;
            center = DisplaytoReal(new PointD(pbMain.Width / 2, pbMain.Height / 2));

            fmaddgrid = new fmAddGrid();
            fmaddgrid.Owner = this;

            fmaddcontour = new fmAddContour();
            fmaddcontour.Owner = this;

            fmdensegrid = new fmDenseGrid();
            fmdensegrid.Owner = this;
        }

        #region 屏幕坐标转换
        private Point PointD2Point(PointD PointD)
        {
            int x = (int)PointD.X;
            int y = (int)PointD.Y;
            return new Point(x, y);
        }
        private PointD RealtoDisplay(PointD point)
        {
            return new PointD((double)((point.X - offsetX) * scale), (double)(pbMain.Height - (point.Y - offsetY) * scale));
        }
        private PointD RealtoDisplay(double x, double y)
        {
            return new PointD((double)((x - offsetX) * scale), (double)(pbMain.Height - (y - offsetY) * scale));
        }

        private PointD DisplaytoReal(PointD point)
        {
            return new PointD((double)(point.X / scale + offsetX), (double)((pbMain.Height - point.Y) / scale + offsetY));
        }

        private List<PointD> RealtoDisplay(List<PointD> points)
        {
            List<PointD> result = new List<PointD>(points.Count);
            foreach (PointD point in points)
            {
                result.Add(RealtoDisplay(point));
            }
            return result;
        }

        /// <summary>
        /// 判断点是否在矩形内
        /// </summary>
        /// <param name="point">真实数据点</param>
        /// <param name="rect">屏幕坐标下的选择框</param>
        /// <returns></returns>
        public bool PointInRectangle(MyPoint point, Rectangle rect)
        {
            bool ret = false;
            Point pt = PointD2Point(RealtoDisplay(point.Pointd));
            ret = rect.Contains(pt);
            return false;
        }
        #endregion

        #region PaintBox触发事件（显示内容调整和框选）
        /// <summary>
        /// 鼠标按下事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMain_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(e.X, e.Y);
            if (scrollbox)
            {
                if (e.Button == MouseButtons.Left)
                {
                    mouse_ops = (int)MouseOperations.ScrollBox;
                }
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    mouse_ops = (int)MouseOperations.Roam;
                    this.Cursor = Cursors.SizeAll;
                }
            }

            PointD pt = new PointD(e.Location.X, e.Location.Y);
            pt = DisplaytoReal(pt);
            if (e.Button == MouseButtons.Left)
            {
                switch (click_ops)
                {
                    case (int)MouseClickOps.SelectGrid:
                        if (blShowGrid)
                        {
                            if (grid_step == 0)
                            {
                                selected_col = -1;
                                selected_row = grid.GetNearestLine(pt, grid_step);
                                grid_step = 1;
                            }
                            else if (grid_step == 1)
                            {
                                selected_col = grid.GetNearestLine(pt, grid_step);
                                grid_step = 0;
                                MyPoint mpt = grid.Points[selected_row, selected_col];
                                lbGridX.Text = "X: " + mpt.X.ToString("0.#####");
                                lbGridY.Text = "Y: " + mpt.Y.ToString("0.#####");
                                lbGridZ.Text = "Z: " + mpt.Z.ToString("0.#####");
                            }
                            pbMain.Refresh();
                        }
                        break;
                    case (int)MouseClickOps.SelectPolygon:
                        if (blShowPolygon)
                        {

                        }
                        break;
                }
            }
        }

        /// <summary>
        /// 松开数据事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (mouse_ops)
                {
                    case (int)MouseOperations.Roam:
                        this.Cursor = Cursors.Default;
                        break;
                    case (int)MouseOperations.ScrollBox:
                        if (box.Height > box.Width)
                        {
                            offsetX += (box.X + box.Width - (box.Height * pbMain.Width / pbMain.Height)) / scale;
                            offsetY += (pbMain.Height - box.Y - box.Height) / scale;
                            scale = scale / (box.Height * pbMain.Width / pbMain.Height) * pbMain.Width;

                        }
                        else
                        {
                            offsetX += box.X / scale;
                            offsetY += (pbMain.Height - box.Y - (box.Width * pbMain.Height / pbMain.Width)) / scale;
                            scale = scale / (box.Width * pbMain.Height / pbMain.Width) * pbMain.Height;
                        }
                        scrollbox = false;
                        pbMain.Refresh();
                        break;
                }
                mouse_ops = (int)MouseOperations.Null;
            }
        }

        /// <summary>
        /// 将显示区域调回中心
        /// </summary>
        private void MoveToCenter()
        {
            offsetX = (boundary[2] + boundary[0]) / 2 - center.X / scale;
            offsetY = (boundary[1] + boundary[3]) / 2 - center.Y / scale;
        }

        /// <summary>
        /// 鼠标移动触发事件，调整坐标显示，当鼠标处于按下状态时执行漫游
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMain_MouseMove(object sender, MouseEventArgs e)
        {
            PointD location = DisplaytoReal(new PointD(e.Location.X, e.Location.Y));
            lbX.Text = "X: " + location.X.ToString("0.###");
            lbY.Text = "Y: " + location.Y.ToString("0.###");
            switch (mouse_ops)
            {
                case (int)MouseOperations.Roam:
                    offsetX -= (e.X - mouseLocation.X) / scale;
                    offsetY += (e.Y - mouseLocation.Y) / scale;
                    mouseLocation = e.Location;
                    pbMain.Refresh();
                    break;
                case (int)MouseOperations.ScrollBox:
                    mouseLocation2 = e.Location;
                    box = new Rectangle(Math.Min(mouseLocation.X, mouseLocation2.X),
                        Math.Min(mouseLocation.Y, mouseLocation2.Y),
                        Math.Abs(mouseLocation.X - mouseLocation2.X),
                        Math.Abs(mouseLocation.Y - mouseLocation2.Y));
                    pbMain.Refresh();
                    break;
            }
        }

        /// <summary>
        /// 滚轮缩放地图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMain_MouseWheel(object sender, MouseEventArgs e)
        {
            if (!pbMain.ClientRectangle.Contains(e.Location))
                return;
            double delta = e.Delta / SystemInformation.MouseWheelScrollDelta;
            offsetX += pbMain.Width * (delta / 15) / 2 / scale;
            offsetY += pbMain.Height * (delta / 15) / 2 / scale;
            scale *= 1 + (delta / 15);
            pbMain.Refresh();
        }

        private void DrawEdge(Edge edge, Graphics g, Pen pen)
        {
            Point p1 = PointD2Point(RealtoDisplay(edge.point1));
            Point p2 = PointD2Point(RealtoDisplay(edge.point2));
            g.DrawLine(pen, p1, p2);
        }

        /// <summary>
        /// 内容绘制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p1 = new Pen(Color.Black, 1f);
            Pen p2 = new Pen(Color.Purple, 1.5f);
            Pen p3 = new Pen(Color.Cyan, 2f);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            if (blShowGrid)
            {
                if (grid.Points != null && grid.Points.Length != 0)
                {
                    foreach(Edge edge in grid.X_lines)
                    {
                        DrawEdge(edge, g, p2);
                    }
                    foreach (Edge edge in grid.Y_lines)
                    {
                        DrawEdge(edge, g, p2);
                    }
                    if (selected_row != -1)
                    {
                        DrawEdge(grid.X_lines[selected_row], g, p3);
                    }
                    if (selected_col != -1)
                    {
                        DrawEdge(grid.Y_lines[selected_col], g, p3);
                    }
                }
            }

            if (blShowPoints)
            {
                foreach(MyPoint point in data)
                {
                    PointD pt = RealtoDisplay(point.Pointd);
                    g.FillEllipse(Brushes.Blue, (float)pt.X, (float)pt.Y, 3, 3);
                }
            }

            if (blShowTIN)
            {

            }

            if (blShowContour)
            {

            }

            if (blShowPolygon)
            {

            }
        }
        #endregion

        #region 按钮事件响应
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "C:\\Workspace\\作业\\毛";
            if (file.ShowDialog() == DialogResult.OK)
            {
                data = new List<MyPoint>();
                StreamReader sr = File.OpenText(file.FileName);
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] sArrays = line.Split(',');
                    if (sArrays.Length == 5)
                    {
                        int id = -1; 
                        string name; 
                        double x = 0, y = 0, z = 0;
                        bool isvalid = false;

                        int.TryParse(sArrays[0], out id);
                        name = sArrays[1];
                        isvalid = double.TryParse(sArrays[2], out x) &
                                    double.TryParse(sArrays[3], out y) &
                                    double.TryParse(sArrays[4], out z);


                        if (isvalid)
                        {
                            MyPoint tmp = new MyPoint(id, name, new PointD(x, y), z);
                            data.Add(tmp);

                            if (boundary[0] > x)
                                boundary[0] = x;
                            if (boundary[1] > y)
                                boundary[1] = y;
                            if (boundary[2] < x)
                                boundary[2] = x;
                            if (boundary[3] < y)
                                boundary[3] = y;
                        }
                    }
                }
                scale = Math.Min(pbMain.Width / (boundary[2] - boundary[0]), pbMain.Height / (boundary[3] - boundary[1])) / 1.05;
                blShowPoints = true;
                offsetX = boundary[0];
                offsetY = boundary[1];
                MoveToCenter();
                scale_back = scale;
                offsetX_back = offsetX;
                offsetY_back = offsetY;
                pbMain.Refresh();
            }
        }

        #region 数据可视化调整
        private void btnShowPoints_Click(object sender, EventArgs e)
        {
            blShowPoints = !blShowPoints;
            pbMain.Refresh();
        }

        private void btnShowGrid_Click(object sender, EventArgs e)
        {
            blShowGrid = !blShowGrid;
            pbMain.Refresh();
        }


        private void btnShowTIN_Click(object sender, EventArgs e)
        {
            blShowTIN = !blShowTIN;
            pbMain.Refresh();
        }

        private void btnShowContour_Click(object sender, EventArgs e)
        {
            blShowContour = !blShowContour;
            pbMain.Refresh();
        }

        private void btnShowPolygon_Click(object sender, EventArgs e)
        {
            blShowPolygon = !blShowPolygon;
            pbMain.Refresh();
        }
        
        private void btnResetView_Click(object sender, EventArgs e)
        {
            offsetX = offsetX_back;
            offsetY = offsetY_back;
            scale = scale_back;
            pbMain.Refresh();
        }
        #endregion
        #region 数据生成
        private void btnAddGrid_Click(object sender, EventArgs e)
        {
            fmaddgrid.Show();
        }



        private void btnDenseGrid_Click(object sender, EventArgs e)
        {
            fmdensegrid.Show();
        }

        private void btnAddTIN_Click(object sender, EventArgs e)
        {
            
        }


        private void btnAddContour_Click(object sender, EventArgs e)
        {
            fmaddcontour.Show();
        }
        public void AddGrid()
        {
            grid.X_num = fmaddgrid.x;
            grid.Y_num = fmaddgrid.y;
            grid.N = fmaddgrid.n;
            grid.Method = fmaddgrid.method;
            grid.Bbox = boundary;
            grid.Source = data.ToArray();
            grid.GenerateGrid();
            blShowGrid = true;
            pbMain.Refresh();
        }
        #endregion
        #endregion

        #region 鼠标模式
        private void btnSelectGrid_Click(object sender, EventArgs e)
        {
            if (click_ops == (int)MouseClickOps.SelectGrid)
            {
                selected_col = -1;
                selected_row = -1;
                selected_pol = -1;
                click_ops = (int)MouseClickOps.Null;
            }
            else
            {
                selected_col = -1;
                selected_row = -1;
                selected_pol = -1;
                grid_step = 0;
                click_ops = (int)MouseClickOps.SelectGrid;
            }
        }

        private void btnSelectPolygon_Click(object sender, EventArgs e)
        {
            if (click_ops == (int)MouseClickOps.SelectPolygon)
            {
                selected_col = -1;
                selected_row = -1;
                selected_pol = -1;
                grid_step = 0;
                click_ops = (int)MouseClickOps.Null;
            }
            else
            {
                selected_col = -1;
                selected_row = -1;
                selected_pol = -1;
                grid_step = 0;
                click_ops = (int)MouseClickOps.SelectPolygon;
            }
        }

        private void pbMain_MouseClick(object sender, MouseEventArgs e)
        {

        }
        #endregion
    }
}