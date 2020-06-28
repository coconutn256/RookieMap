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
    public partial class fmAddGrid : Form
    {
        public int x, y, n;
        public AddGridMethod method;
        public bool isvalid;
        public fmAddGrid()
        {
            InitializeComponent();
        }

        private void btnAddGridOk_Click(object sender, EventArgs e)
        {
            x = 0; y = 0; n=0;
            method = AddGridMethod.IDW;

            isvalid = int.TryParse(tbAddGridX.Text, out x) &
                            int.TryParse(tbAddGridY.Text, out y) &
                            int.TryParse(tbN.Text, out n);
            if (rb1.Checked)
                method = AddGridMethod.IDW;
            else if (rb2.Checked)
                method = AddGridMethod.DPW;

            if (!isvalid)
            {
                MessageBox.Show("输入非法，请输入整数");
                return;
            }
            else
            {
                this.Hide();
                fmMain owner = (fmMain)this.Owner;
                owner.AddGrid();
            }
        }

        private void btnAddGridCancel_Click(object sender, EventArgs e)
        {
            isvalid = false;
            this.Hide();
        }
    }
}
