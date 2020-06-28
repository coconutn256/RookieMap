namespace RookieMap
{
    partial class fmAddContour
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbContourTIN = new System.Windows.Forms.RadioButton();
            this.rbContourGrid = new System.Windows.Forms.RadioButton();
            this.tbContour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddGridCancel = new System.Windows.Forms.Button();
            this.btnAddGridOk = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbContourTIN);
            this.groupBox2.Controls.Add(this.rbContourGrid);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(17, 62);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(217, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生成方法";
            // 
            // rbContourTIN
            // 
            this.rbContourTIN.AutoSize = true;
            this.rbContourTIN.Location = new System.Drawing.Point(34, 60);
            this.rbContourTIN.Margin = new System.Windows.Forms.Padding(4);
            this.rbContourTIN.Name = "rbContourTIN";
            this.rbContourTIN.Size = new System.Drawing.Size(130, 24);
            this.rbContourTIN.TabIndex = 1;
            this.rbContourTIN.Text = "TIN生成等高线";
            this.rbContourTIN.UseVisualStyleBackColor = true;
            // 
            // rbContourGrid
            // 
            this.rbContourGrid.AutoSize = true;
            this.rbContourGrid.Checked = true;
            this.rbContourGrid.Location = new System.Drawing.Point(34, 28);
            this.rbContourGrid.Margin = new System.Windows.Forms.Padding(4);
            this.rbContourGrid.Name = "rbContourGrid";
            this.rbContourGrid.Size = new System.Drawing.Size(135, 24);
            this.rbContourGrid.TabIndex = 0;
            this.rbContourGrid.TabStop = true;
            this.rbContourGrid.Text = "格网生成等高线";
            this.rbContourGrid.UseVisualStyleBackColor = true;
            // 
            // tbContour
            // 
            this.tbContour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContour.Location = new System.Drawing.Point(122, 20);
            this.tbContour.Margin = new System.Windows.Forms.Padding(4);
            this.tbContour.Name = "tbContour";
            this.tbContour.Size = new System.Drawing.Size(112, 24);
            this.tbContour.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "等高线间隔：";
            // 
            // btnAddGridCancel
            // 
            this.btnAddGridCancel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGridCancel.Location = new System.Drawing.Point(148, 193);
            this.btnAddGridCancel.Name = "btnAddGridCancel";
            this.btnAddGridCancel.Size = new System.Drawing.Size(86, 33);
            this.btnAddGridCancel.TabIndex = 8;
            this.btnAddGridCancel.Text = "取消";
            this.btnAddGridCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddGridOk
            // 
            this.btnAddGridOk.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGridOk.Location = new System.Drawing.Point(33, 193);
            this.btnAddGridOk.Name = "btnAddGridOk";
            this.btnAddGridOk.Size = new System.Drawing.Size(86, 33);
            this.btnAddGridOk.TabIndex = 7;
            this.btnAddGridOk.Text = "确定";
            this.btnAddGridOk.UseVisualStyleBackColor = true;
            // 
            // fmAddContour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 250);
            this.Controls.Add(this.btnAddGridCancel);
            this.Controls.Add(this.btnAddGridOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbContour);
            this.Controls.Add(this.label1);
            this.Name = "fmAddContour";
            this.Text = "等值线生成";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbContourTIN;
        private System.Windows.Forms.RadioButton rbContourGrid;
        private System.Windows.Forms.TextBox tbContour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddGridCancel;
        private System.Windows.Forms.Button btnAddGridOk;
    }
}