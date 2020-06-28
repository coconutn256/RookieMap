using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RookieMap
{
    public partial class fmDenseGrid : Form
    {
        public int x, y;
        public bool isvalid;

        private void btnDenseGridOk_MouseClick(object sender, MouseEventArgs e)
        {
            x = 0; y = 0;

            isvalid = int.TryParse(tbDenseGridX.Text, out x) &
                            int.TryParse(tbDenseGridY.Text, out y);

            if (!isvalid)
            {
                MessageBox.Show("输入非法，请输入大于0的整数");
                return;
            } else if (x <=0 || y <= 0)
            {
                MessageBox.Show("输入非法，请输入大于0的整数");
                return;
            }
            else
            {
                this.Hide();
                fmMain owner = (fmMain)this.Owner;
                owner.DenseGrid();
            }
        }

        private void btnDenseGridCancel_Click(object sender, EventArgs e)
        {
            isvalid = false;
            this.Hide();
        }

        public fmDenseGrid()
        {
            InitializeComponent();
            x = 1;
            y = 1;
        }
    }
}
