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
    public partial class frmCthdb : Form
    {
        BLL_cthdb bl = new BLL_cthdb();
        public frmCthdb()
        {
            InitializeComponent();
        }

        private void frmCthdb_Load(object sender, EventArgs e)
        {
            dgvlaptop.DataSource = bl.layCthdb();
        }

        private void dgvlaptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidhd.Text = dgvlaptop.CurrentRow.Cells[0].Value.ToString();
            txtidhang.Text = dgvlaptop.CurrentRow.Cells[1].Value.ToString();
            txtsoluong.Text = dgvlaptop.CurrentRow.Cells[2].Value.ToString();
            txtgiaban.Text = dgvlaptop.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_cthdb la = new DTO_cthdb(txtidhd.Text, txtidhang.Text, txtsoluong.Text, txtgiaban.Text );
            bl.themCthdb(la);
            frmCthdb_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_cthdb la = new DTO_cthdb(txtidhd.Text, txtidhang.Text, txtsoluong.Text, txtgiaban.Text);
            bl.suaCthdb(la);
            frmCthdb_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTO_cthdb la = new DTO_cthdb(txtidhd.Text, txtidhang.Text, txtsoluong.Text, txtgiaban.Text);
            bl.xoaCthdb(la);
            frmCthdb_Load(sender, e);
        }
    }
}
