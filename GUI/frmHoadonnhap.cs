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

namespace QLlaptop
{
    public partial class frmHoadonnhap : Form
    {
        public frmHoadonnhap()
        {
            InitializeComponent();
        }
        BLL_hdnhap bl = new BLL_hdnhap();

        private void frmHoadonnhap_Load(object sender, EventArgs e)
        {
            dgvlaptop.DataSource = bl.layHdnhap();
        }

        private void dgvHdnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMahdn.Text = dgvlaptop.CurrentRow.Cells[0].Value.ToString();
            txtNv.Text = dgvlaptop.CurrentRow.Cells[1].Value.ToString();
            txtMancc.Text = dgvlaptop.CurrentRow.Cells[2].Value.ToString();
            txtNgaynhap.Text = dgvlaptop.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHDN = txtMahdn.Text;
            string maNV = txtNv.Text;
            string maNCC = txtMancc.Text;
            string ngayNhap = txtNgaynhap.Text;

            DTO_hdnhap la = new DTO_hdnhap(maHDN, maNV, maNCC, ngayNhap);
            bl.themHdnhap(la);
            MessageBox.Show("Them thanh cong");
            frmHoadonnhap_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_hdnhap la = new DTO_hdnhap(txtMahdn.Text, txtNv.Text, txtMancc.Text, txtNgaynhap.Text );
            bl.suaHdnhap(la);
            frmHoadonnhap_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTO_hdnhap la = new DTO_hdnhap(txtMahdn.Text, txtNv.Text, txtMancc.Text, txtNgaynhap.Text );
            bl.xoaHdnhap(la);
            frmHoadonnhap_Load(sender, e);
        }
    }
}
