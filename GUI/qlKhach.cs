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
    public partial class qlKhach : Form
    {
        BLL_khachhang bl =new BLL_khachhang();
        public qlKhach()
        {
            InitializeComponent();
        }
        

        private void qlKhach_Load(object sender, EventArgs e)
        {
            dgvlaptop.DataSource = bl.layKhachhang();
        }

        

        private void dgvKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvlaptop.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvlaptop.CurrentRow.Cells[1].Value.ToString();
            txtSdt.Text = dgvlaptop.CurrentRow.Cells[2].Value.ToString();
            txtDiachi.Text = dgvlaptop.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvlaptop.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            DTO_khachhang la = new DTO_khachhang(txtId.Text, txtTen.Text, txtSdt.Text, txtDiachi.Text, txtEmail.Text);
            bl.themKhachhang(la);
            MessageBox.Show("Them thanh cong");
            qlKhach_Load(sender, e);
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DTO_khachhang la = new DTO_khachhang(txtId.Text, txtTen.Text, txtSdt.Text, txtDiachi.Text, txtEmail.Text);
            bl.suaKhachhang(la);
            qlKhach_Load(sender, e);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DTO_khachhang la = new DTO_khachhang(txtId.Text, txtTen.Text, txtSdt.Text, txtDiachi.Text, txtEmail.Text);
            bl.xoaKhachhang(la);
            qlKhach_Load(sender, e);
        }
    }
}
