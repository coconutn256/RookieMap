namespace RookieMap
{
    partial class fmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.stpMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbPolygonLength = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbPolygonArea = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspMain = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnLoadData = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveTopology = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAddGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDenseGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAddTIN = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddContour = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddTopology = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnShowPoints = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowTIN = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowContour = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowPolygon = new System.Windows.Forms.ToolStripMenuItem();
            this.btnResetView = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbGridX = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbGridY = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbGridZ = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbX = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbY = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnSelectGrid = new System.Windows.Forms.ToolStripButton();
            this.btnSelectPolygon = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lbPolygonID = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.stpMain.SuspendLayout();
            this.tspMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMain
            // 
            this.pbMain.Location = new System.Drawing.Point(12, 57);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(1066, 586);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            this.pbMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMain_Paint);
            this.pbMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseClick);
            this.pbMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseDown);
            this.pbMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseMove);
            this.pbMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseUp);
            // 
            // stpMain
            // 
            this.stpMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbPolygonID,
            this.lbPolygonLength,
            this.lbPolygonArea});
            this.stpMain.Location = new System.Drawing.Point(0, 707);
            this.stpMain.Name = "stpMain";
            this.stpMain.Size = new System.Drawing.Size(1090, 26);
            this.stpMain.TabIndex = 1;
            this.stpMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(128, 20);
            this.toolStripStatusLabel1.Text = "选中多边形信息: ";
            // 
            // lbPolygonLength
            // 
            this.lbPolygonLength.AutoSize = false;
            this.lbPolygonLength.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbPolygonLength.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.lbPolygonLength.Name = "lbPolygonLength";
            this.lbPolygonLength.Size = new System.Drawing.Size(130, 20);
            this.lbPolygonLength.Text = "周长: 0";
            this.lbPolygonLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPolygonArea
            // 
            this.lbPolygonArea.AutoSize = false;
            this.lbPolygonArea.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbPolygonArea.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.lbPolygonArea.Name = "lbPolygonArea";
            this.lbPolygonArea.Size = new System.Drawing.Size(130, 20);
            this.lbPolygonArea.Text = "面积: 0";
            this.lbPolygonArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tspMain
            // 
            this.tspMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.btnAddTopology,
            this.toolStripDropDownButton4});
            this.tspMain.Location = new System.Drawing.Point(0, 0);
            this.tspMain.Name = "tspMain";
            this.tspMain.Size = new System.Drawing.Size(1090, 27);
            this.tspMain.TabIndex = 2;
            this.tspMain.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadData,
            this.btnSaveTopology});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(55, 24);
            this.toolStripDropDownButton1.Text = "文件";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(188, 26);
            this.btnLoadData.Text = "打开数据文件";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnSaveTopology
            // 
            this.btnSaveTopology.Name = "btnSaveTopology";
            this.btnSaveTopology.Size = new System.Drawing.Size(188, 26);
            this.btnSaveTopology.Text = "保存拓扑关系";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddGrid,
            this.btnDenseGrid});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(55, 24);
            this.toolStripDropDownButton2.Text = "格网";
            // 
            // btnAddGrid
            // 
            this.btnAddGrid.Name = "btnAddGrid";
            this.btnAddGrid.Size = new System.Drawing.Size(156, 26);
            this.btnAddGrid.Text = "生成格网";
            this.btnAddGrid.Click += new System.EventHandler(this.btnAddGrid_Click);
            // 
            // btnDenseGrid
            // 
            this.btnDenseGrid.Name = "btnDenseGrid";
            this.btnDenseGrid.Size = new System.Drawing.Size(156, 26);
            this.btnDenseGrid.Text = "加密格网";
            this.btnDenseGrid.Click += new System.EventHandler(this.btnDenseGrid_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddTIN,
            this.btnAddContour});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(100, 24);
            this.toolStripDropDownButton3.Text = "TIN/等值线";
            // 
            // btnAddTIN
            // 
            this.btnAddTIN.Name = "btnAddTIN";
            this.btnAddTIN.Size = new System.Drawing.Size(179, 26);
            this.btnAddTIN.Text = "生成TIN模型";
            this.btnAddTIN.Click += new System.EventHandler(this.btnAddTIN_Click);
            // 
            // btnAddContour
            // 
            this.btnAddContour.Name = "btnAddContour";
            this.btnAddContour.Size = new System.Drawing.Size(179, 26);
            this.btnAddContour.Text = "生成等值线";
            this.btnAddContour.Click += new System.EventHandler(this.btnAddContour_Click);
            // 
            // btnAddTopology
            // 
            this.btnAddTopology.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddTopology.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTopology.Image")));
            this.btnAddTopology.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTopology.Name = "btnAddTopology";
            this.btnAddTopology.Size = new System.Drawing.Size(109, 24);
            this.btnAddTopology.Text = "拓扑关系生成";
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowPoints,
            this.btnShowGrid,
            this.btnShowTIN,
            this.btnShowContour,
            this.btnShowPolygon,
            this.btnResetView});
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(87, 24);
            this.toolStripDropDownButton4.Text = "数据显示";
            // 
            // btnShowPoints
            // 
            this.btnShowPoints.Name = "btnShowPoints";
            this.btnShowPoints.Size = new System.Drawing.Size(226, 26);
            this.btnShowPoints.Text = "显示/隐藏原始数据";
            this.btnShowPoints.Click += new System.EventHandler(this.btnShowPoints_Click);
            // 
            // btnShowGrid
            // 
            this.btnShowGrid.Name = "btnShowGrid";
            this.btnShowGrid.Size = new System.Drawing.Size(226, 26);
            this.btnShowGrid.Text = "显示/隐藏格网";
            this.btnShowGrid.Click += new System.EventHandler(this.btnShowGrid_Click);
            // 
            // btnShowTIN
            // 
            this.btnShowTIN.Name = "btnShowTIN";
            this.btnShowTIN.Size = new System.Drawing.Size(226, 26);
            this.btnShowTIN.Text = "显示/隐藏TIN";
            this.btnShowTIN.Click += new System.EventHandler(this.btnShowTIN_Click);
            // 
            // btnShowContour
            // 
            this.btnShowContour.Name = "btnShowContour";
            this.btnShowContour.Size = new System.Drawing.Size(226, 26);
            this.btnShowContour.Text = "显示/隐藏等高线";
            this.btnShowContour.Click += new System.EventHandler(this.btnShowContour_Click);
            // 
            // btnShowPolygon
            // 
            this.btnShowPolygon.Name = "btnShowPolygon";
            this.btnShowPolygon.Size = new System.Drawing.Size(226, 26);
            this.btnShowPolygon.Text = "显示/隐藏多边形";
            this.btnShowPolygon.Click += new System.EventHandler(this.btnShowPolygon_Click);
            // 
            // btnResetView
            // 
            this.btnResetView.Name = "btnResetView";
            this.btnResetView.Size = new System.Drawing.Size(226, 26);
            this.btnResetView.Text = "重置显示视角";
            this.btnResetView.Click += new System.EventHandler(this.btnResetView_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.lbGridX,
            this.lbGridY,
            this.lbGridZ});
            this.statusStrip1.Location = new System.Drawing.Point(0, 681);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1090, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(128, 20);
            this.toolStripStatusLabel2.Text = "选中格网信息:     ";
            // 
            // lbGridX
            // 
            this.lbGridX.AutoSize = false;
            this.lbGridX.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbGridX.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.lbGridX.Name = "lbGridX";
            this.lbGridX.Size = new System.Drawing.Size(130, 20);
            this.lbGridX.Text = "X: 0";
            this.lbGridX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGridY
            // 
            this.lbGridY.AutoSize = false;
            this.lbGridY.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbGridY.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.lbGridY.Name = "lbGridY";
            this.lbGridY.Size = new System.Drawing.Size(130, 20);
            this.lbGridY.Text = "Y: 0";
            this.lbGridY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGridZ
            // 
            this.lbGridZ.AutoSize = false;
            this.lbGridZ.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbGridZ.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.lbGridZ.Name = "lbGridZ";
            this.lbGridZ.Size = new System.Drawing.Size(130, 20);
            this.lbGridZ.Text = "Z: 0";
            this.lbGridZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel5,
            this.lbX,
            this.lbY});
            this.statusStrip2.Location = new System.Drawing.Point(0, 655);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1090, 26);
            this.statusStrip2.TabIndex = 4;
            this.statusStrip2.Text = "statusStrip1";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(128, 20);
            this.toolStripStatusLabel5.Text = "鼠标悬停位置:     ";
            // 
            // lbX
            // 
            this.lbX.AutoSize = false;
            this.lbX.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbX.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(130, 20);
            this.lbX.Text = "X: 0";
            this.lbX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbY
            // 
            this.lbY.AutoSize = false;
            this.lbY.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbY.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(130, 20);
            this.lbY.Text = "Y: 0";
            this.lbY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnSelectGrid,
            this.btnSelectPolygon});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1090, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(89, 24);
            this.toolStripLabel1.Text = "操作类型：";
            // 
            // btnSelectGrid
            // 
            this.btnSelectGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSelectGrid.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectGrid.Image")));
            this.btnSelectGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectGrid.Name = "btnSelectGrid";
            this.btnSelectGrid.Size = new System.Drawing.Size(77, 24);
            this.btnSelectGrid.Text = "格网选择";
            this.btnSelectGrid.Click += new System.EventHandler(this.btnSelectGrid_Click);
            // 
            // btnSelectPolygon
            // 
            this.btnSelectPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSelectPolygon.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectPolygon.Image")));
            this.btnSelectPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectPolygon.Name = "btnSelectPolygon";
            this.btnSelectPolygon.Size = new System.Drawing.Size(93, 24);
            this.btnSelectPolygon.Text = "多边形选择";
            this.btnSelectPolygon.Click += new System.EventHandler(this.btnSelectPolygon_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbPolygonID
            // 
            this.lbPolygonID.AutoSize = false;
            this.lbPolygonID.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbPolygonID.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.lbPolygonID.Name = "lbPolygonID";
            this.lbPolygonID.Size = new System.Drawing.Size(130, 20);
            this.lbPolygonID.Text = "id: -1";
            this.lbPolygonID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 733);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tspMain);
            this.Controls.Add(this.stpMain);
            this.Controls.Add(this.pbMain);
            this.Name = "fmMain";
            this.Text = "RookieMap";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.stpMain.ResumeLayout(false);
            this.stpMain.PerformLayout();
            this.tspMain.ResumeLayout(false);
            this.tspMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.StatusStrip stpMain;
        private System.Windows.Forms.ToolStripStatusLabel lbPolygonLength;
        private System.Windows.Forms.ToolStripStatusLabel lbPolygonArea;
        private System.Windows.Forms.ToolStrip tspMain;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnLoadData;
        private System.Windows.Forms.ToolStripMenuItem btnSaveTopology;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem btnAddGrid;
        private System.Windows.Forms.ToolStripMenuItem btnDenseGrid;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem btnAddTIN;
        private System.Windows.Forms.ToolStripMenuItem btnAddContour;
        private System.Windows.Forms.ToolStripButton btnAddTopology;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem btnShowGrid;
        private System.Windows.Forms.ToolStripMenuItem btnShowTIN;
        private System.Windows.Forms.ToolStripMenuItem btnShowContour;
        private System.Windows.Forms.ToolStripMenuItem btnShowPolygon;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbGridX;
        private System.Windows.Forms.ToolStripStatusLabel lbGridZ;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lbX;
        private System.Windows.Forms.ToolStripStatusLabel lbY;
        private System.Windows.Forms.ToolStripStatusLabel lbGridY;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnSelectGrid;
        private System.Windows.Forms.ToolStripButton btnSelectPolygon;
        private System.Windows.Forms.ToolStripMenuItem btnResetView;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem btnShowPoints;
        private System.Windows.Forms.ToolStripStatusLabel lbPolygonID;
    }
}

