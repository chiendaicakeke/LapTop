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
    public partial class frmHoadonban : Form
    {
        BLL_hdban bl = new BLL_hdban();
        public frmHoadonban()
        {
            InitializeComponent();
        }



        private void frmHoadonban_Load(object sender, EventArgs e)
        {
            dgvlaptop.DataSource = bl.layHdban();
        }

       

        private void dgvHdban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdhd.Text = dgvlaptop.CurrentRow.Cells[0].Value.ToString();
            txtIdnv.Text = dgvlaptop.CurrentRow.Cells[1].Value.ToString();
            txtIdkhach.Text = dgvlaptop.CurrentRow.Cells[2].Value.ToString();
            txtNgayban.Text = dgvlaptop.CurrentRow.Cells[3].Value.ToString();
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_hdban la = new DTO_hdban(txtIdhd.Text, txtIdnv.Text, txtIdkhach.Text, txtNgayban.Text );
            bl.themHdban(la);
            MessageBox.Show("Them thanh cong");
            frmHoadonban_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_hdban la = new DTO_hdban(txtIdhd.Text, txtIdnv.Text, txtIdkhach.Text, txtNgayban.Text);
            bl.suaHdban(la);
            frmHoadonban_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTO_hdban la = new DTO_hdban(txtIdhd.Text, txtIdnv.Text, txtIdkhach.Text, txtNgayban.Text);
            bl.xoaHdban(la);
            frmHoadonban_Load(sender, e);
        }
    }
}
