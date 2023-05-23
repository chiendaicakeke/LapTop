using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_hdnhap
    {
        public DataTable layHdnhap()
        {
            string query = @"hienThi_hdn";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void themHdnhap(DTO_hdnhap lt)
        {
            string query = @"them_hdn @ma , @nhanvien , @ncc , @ngaynhap ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.ma, lt.nhanvien, lt.ncc, lt.ngaynhap });
        }

        public void suaHdnhap(DTO_hdnhap lt)
        {
            string query = @"sua_hdn @ma , @nhanvien , @ncc , @ngaynhap ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.ma, lt.nhanvien, lt.ncc, lt.ngaynhap });
        }


        public void xoaHdnhap(DTO_hdnhap lt)
        {
            string query = @"xoa_hdn @ma ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.ma, lt.nhanvien, lt.ncc, lt.ngaynhap });
        }
    }
}
