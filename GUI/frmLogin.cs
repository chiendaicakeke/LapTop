using BLL;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        BLL_TaiKhoan bllTk = new BLL_TaiKhoan();

        bool kiemTraTK(string tk, string mk)
        {
            return bllTk.layTaiKhoan(tk, mk).Rows.Count > 0;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string tk = txttk.Text;
            string mk = txtmk.Text;

            if (tk != "" || mk != "")
            {
                if (kiemTraTK(tk, mk))
                {
                    frmMain frm = new frmMain();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                }
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
        }
    }
}
