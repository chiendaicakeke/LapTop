using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace QLlaptop
{
    public partial class frmKhoHang : Form
    {
        BLL_mathang bl = new BLL_mathang();
        public frmKhoHang()
        {
            InitializeComponent();
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DTO_mathang la = new DTO_mathang(txtid.Text, txtten.Text, txtncc.Text, txtmota.Text);
            bl.themMathang(la);
            frmKhoHang_Load(sender, e);
        }

        private void frmKhoHang_Load(object sender, EventArgs e)
        {
          dgvlaptop.DataSource = bl.layMathang();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            DTO_mathang la = new DTO_mathang(txtid.Text, txtten.Text, txtncc.Text, txtmota.Text);
            bl.suaMathang(la);
            MessageBox.Show("Them thanh cong");
            frmKhoHang_Load(sender, e);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            DTO_mathang la = new DTO_mathang(txtid.Text, txtten.Text, txtncc.Text, txtmota.Text);
            bl.xoaMathang(la);
            frmKhoHang_Load(sender, e);
        }

        private void dgvlaptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvlaptop.CurrentRow.Cells[0].Value.ToString();
            txtten.Text = dgvlaptop.CurrentRow.Cells[1].Value.ToString();
            txtncc.Text = dgvlaptop.CurrentRow.Cells[2].Value.ToString();
            txtmota.Text = dgvlaptop.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
