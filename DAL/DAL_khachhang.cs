using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_khachhang
    {
        public DataTable layKhachhang()
        {
            string query = @"hienThi_kh";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void themKhachhang(DTO_khachhang lt)
        {
            string query = @"them_kh @ma , @ten , @diachi , @sdt , @email ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.ma , lt.ten , lt.sdt, lt.diachi, lt.email });
        }

        public void suaKhachhang(DTO_khachhang lt)
        {
            string query = @"sua_kh @ma , @ten , @diachi , @sdt , @email ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.ma, lt.ten, lt.sdt, lt.diachi, lt.email });
        }

        public void xoaKhachhang(DTO_khachhang lt)
        {
            string query = @"xoa_kh @ma ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.ma, lt.ten, lt.sdt, lt.diachi, lt.email });
        }
    }
}
