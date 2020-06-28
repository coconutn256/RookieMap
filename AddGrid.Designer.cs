namespace RookieMap
{
    partial class fmAddGrid
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
            this.gbAddGrid = new System.Windows.Forms.GroupBox();
            this.tbN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddGridY = new System.Windows.Forms.TextBox();
            this.tbAddGridX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.btnAddGridOk = new System.Windows.Forms.Button();
            this.btnAddGridCancel = new System.Windows.Forms.Button();
            this.gbAddGrid.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddGrid
            // 
            this.gbAddGrid.Controls.Add(this.tbN);
            this.gbAddGrid.Controls.Add(this.label3);
            this.gbAddGrid.Controls.Add(this.tbAddGridY);
            this.gbAddGrid.Controls.Add(this.tbAddGridX);
            this.gbAddGrid.Controls.Add(this.label2);
            this.gbAddGrid.Controls.Add(this.label1);
            this.gbAddGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddGrid.Location = new System.Drawing.Point(23, 27);
            this.gbAddGrid.Name = "gbAddGrid";
            this.gbAddGrid.Size = new System.Drawing.Size(256, 137);
            this.gbAddGrid.TabIndex = 0;
            this.gbAddGrid.TabStop = false;
            this.gbAddGrid.Text = "格网密度";
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(126, 94);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(100, 24);
            this.tbN.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "点数/划分：";
            // 
            // tbAddGridY
            // 
            this.tbAddGridY.Location = new System.Drawing.Point(126, 59);
            this.tbAddGridY.Name = "tbAddGridY";
            this.tbAddGridY.Size = new System.Drawing.Size(100, 24);
            this.tbAddGridY.TabIndex = 3;
            // 
            // tbAddGridX
            // 
            this.tbAddGridX.Location = new System.Drawing.Point(126, 24);
            this.tbAddGridX.Name = "tbAddGridX";
            this.tbAddGridX.Size = new System.Drawing.Size(100, 24);
            this.tbAddGridX.TabIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "插值方法";
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.Location = new System.Drawing.Point(30, 67);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(150, 27);
            this.rb2.TabIndex = 1;
            this.rb2.Text = "方位加权平均法";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.Location = new System.Drawing.Point(30, 36);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(150, 27);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "距离平方倒数法";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // btnAddGridOk
            // 
            this.btnAddGridOk.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGridOk.Location = new System.Drawing.Point(78, 322);
            this.btnAddGridOk.Name = "btnAddGridOk";
            this.btnAddGridOk.Size = new System.Drawing.Size(86, 33);
            this.btnAddGridOk.TabIndex = 5;
            this.btnAddGridOk.Text = "确定";
            this.btnAddGridOk.UseVisualStyleBackColor = true;
            this.btnAddGridOk.Click += new System.EventHandler(this.btnAddGridOk_Click);
            // 
            // btnAddGridCancel
            // 
            this.btnAddGridCancel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGridCancel.Location = new System.Drawing.Point(193, 322);
            this.btnAddGridCancel.Name = "btnAddGridCancel";
            this.btnAddGridCancel.Size = new System.Drawing.Size(86, 33);
            this.btnAddGridCancel.TabIndex = 6;
            this.btnAddGridCancel.Text = "取消";
            this.btnAddGridCancel.UseVisualStyleBackColor = true;
            this.btnAddGridCancel.Click += new System.EventHandler(this.btnAddGridCancel_Click);
            // 
            // fmAddGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 374);
            this.Controls.Add(this.btnAddGridCancel);
            this.Controls.Add(this.btnAddGridOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAddGrid);
            this.Name = "fmAddGrid";
            this.Text = "生成格网";
            this.gbAddGrid.ResumeLayout(false);
            this.gbAddGrid.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddGrid;
        private System.Windows.Forms.TextBox tbAddGridY;
        private System.Windows.Forms.TextBox tbAddGridX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button btnAddGridOk;
        private System.Windows.Forms.Button btnAddGridCancel;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label label3;
    }
}