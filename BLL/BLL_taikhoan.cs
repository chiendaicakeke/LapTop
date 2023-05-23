using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TaiKhoan
    {
        DAL_TaiKhoan DAL_tk = new DAL_TaiKhoan();

        public DataTable layTaiKhoan(string tk, string mk)
        {
            return DAL_tk.layTaiKhoan(tk, mk);
        }

        public bool kiemTraTK(string tenTaiKhoan, string matKhau)
        {
            return layTaiKhoan(tenTaiKhoan, matKhau).Rows.Count > 0;
        }
    }
}