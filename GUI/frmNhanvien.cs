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
    public partial class frmNhanvien : Form
    {
        BLL_nhanvien bl = new BLL_nhanvien();
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            dgvlaptop.DataSource = bl.layNhanvien();
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_nhanvien la = new DTO_nhanvien(txtId.Text, txtTen.Text, txtSex.Text, txtDiachi.Text, txtSdt.Text, txtEmail.Text);
            bl.themNhanvien(la);
            MessageBox.Show("Them thanh cong");
            frmNhanvien_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_nhanvien la = new DTO_nhanvien(txtId.Text, txtTen.Text, txtSex.Text, txtDiachi.Text, txtSdt.Text, txtEmail.Text);
            bl.suaNhanvien(la);
            frmNhanvien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTO_nhanvien la = new DTO_nhanvien(txtId.Text, txtTen.Text, txtSex.Text, txtDiachi.Text, txtSdt.Text, txtEmail.Text);
            bl.xoaNhanvien(la);
            frmNhanvien_Load(sender, e);
        }

        private void dgvlaptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvlaptop.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvlaptop.CurrentRow.Cells[1].Value.ToString();
            txtSex.Text = dgvlaptop.CurrentRow.Cells[2].Value.ToString();
            txtDiachi.Text = dgvlaptop.CurrentRow.Cells[3].Value.ToString();
            txtSdt.Text = dgvlaptop.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgvlaptop.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
