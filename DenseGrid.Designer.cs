namespace RookieMap
{
    partial class fmDenseGrid
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
            this.btnDenseGridCancel = new System.Windows.Forms.Button();
            this.btnDenseGridOk = new System.Windows.Forms.Button();
            this.gbAddGrid = new System.Windows.Forms.GroupBox();
            this.tbDenseGridY = new System.Windows.Forms.TextBox();
            this.tbDenseGridX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAddGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDenseGridCancel
            // 
            this.btnDenseGridCancel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDenseGridCancel.Location = new System.Drawing.Point(182, 134);
            this.btnDenseGridCancel.Name = "btnDenseGridCancel";
            this.btnDenseGridCancel.Size = new System.Drawing.Size(86, 33);
            this.btnDenseGridCancel.TabIndex = 10;
            this.btnDenseGridCancel.Text = "取消";
            this.btnDenseGridCancel.UseVisualStyleBackColor = true;
            this.btnDenseGridCancel.Click += new System.EventHandler(this.btnDenseGridCancel_Click);
            // 
            // btnDenseGridOk
            // 
            this.btnDenseGridOk.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDenseGridOk.Location = new System.Drawing.Point(67, 134);
            this.btnDenseGridOk.Name = "btnDenseGridOk";
            this.btnDenseGridOk.Size = new System.Drawing.Size(86, 33);
            this.btnDenseGridOk.TabIndex = 9;
            this.btnDenseGridOk.Text = "确定";
            this.btnDenseGridOk.UseVisualStyleBackColor = true;
            this.btnDenseGridOk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDenseGridOk_MouseClick);
            // 
            // gbAddGrid
            // 
            this.gbAddGrid.Controls.Add(this.tbDenseGridY);
            this.gbAddGrid.Controls.Add(this.tbDenseGridX);
            this.gbAddGrid.Controls.Add(this.label2);
            this.gbAddGrid.Controls.Add(this.label1);
            this.gbAddGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddGrid.Location = new System.Drawing.Point(12, 12);
            this.gbAddGrid.Name = "gbAddGrid";
            this.gbAddGrid.Size = new System.Drawing.Size(256, 100);
            this.gbAddGrid.TabIndex = 7;
            this.gbAddGrid.TabStop = false;
            this.gbAddGrid.Text = "单个网格等分数";
            // 
            // tbDenseGridY
            // 
            this.tbDenseGridY.Location = new System.Drawing.Point(113, 59);
            this.tbDenseGridY.Name = "tbDenseGridY";
            this.tbDenseGridY.Size = new System.Drawing.Size(100, 24);
            this.tbDenseGridY.TabIndex = 3;
            // 
            // tbDenseGridX
            // 
            this.tbDenseGridX.Location = new System.Drawing.Point(113, 24);
            this.tbDenseGridX.Name = "tbDenseGridX";
            this.tbDenseGridX.Size = new System.Drawing.Size(100, 24);
            this.tbDenseGridX.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y等分数：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "X等分数：";
            // 
            // fmDenseGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 179);
            this.Controls.Add(this.btnDenseGridCancel);
            this.Controls.Add(this.btnDenseGridOk);
            this.Controls.Add(this.gbAddGrid);
            this.Name = "fmDenseGrid";
            this.Text = "加密网格";
            this.gbAddGrid.ResumeLayout(false);
            this.gbAddGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDenseGridCancel;
        private System.Windows.Forms.Button btnDenseGridOk;
        private System.Windows.Forms.GroupBox gbAddGrid;
        private System.Windows.Forms.TextBox tbDenseGridY;
        private System.Windows.Forms.TextBox tbDenseGridX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}