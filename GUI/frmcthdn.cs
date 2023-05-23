using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmcthdn : Form
    {
        BLL_cthdn bl = new BLL_cthdn();
        public frmcthdn()
        {
            InitializeComponent();
        }

        private void frmcthdn_Load(object sender, EventArgs e)
        {
            dgvlaptop.DataSource = bl.layCthdn();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_cthdn la = new DTO_cthdn(txtidhdn.Text, txtidhang.Text, txtgianhap.Text, txtsoluong.Text);
            bl.themCthdn(la);
            MessageBox.Show("Them thanh cong");
            frmcthdn_Load(sender, e);
        }

        private void dgvlaptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidhdn.Text = dgvlaptop.CurrentRow.Cells[0].Value.ToString();
            txtidhang.Text = dgvlaptop.CurrentRow.Cells[1].Value.ToString();
            txtgianhap.Text = dgvlaptop.CurrentRow.Cells[2].Value.ToString();
            txtsoluong.Text = dgvlaptop.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_cthdn la = new DTO_cthdn(txtidhdn.Text, txtidhang.Text, txtgianhap.Text, txtsoluong.Text );
            bl.suaCthdn(la);
            frmcthdn_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTO_cthdn la = new DTO_cthdn(txtidhdn.Text, txtidhang.Text, txtgianhap.Text, txtsoluong.Text);
            bl.xoaCthdn(la);
            frmcthdn_Load(sender, e);
        }
    }
}
