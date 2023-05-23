using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_hdban
    {
        public DataTable layHdban()
        {
            string query = @"hienThi_hdb";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void themHdban(DTO_hdban lt)
        {
            string query = @"them_hdb @ma , @nhanvien , @khachhang , @ngayban ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.ma , lt.nhanvien , lt.khachhang , lt.ngayban });
        }

        public void suaHdban(DTO_hdban lt)
        {
            string query = @"sua_hdb @ma , @nhanvien , @khachhang , @ngayban ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.ma, lt.nhanvien, lt.khachhang, lt.ngayban });
        }


        public void xoaHdban(DTO_hdban lt)
        {
            string query = @"xoa_hdb @ma ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.ma, lt.nhanvien, lt.khachhang, lt.ngayban });
        }
    }
}

