using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_nhanvien
    {
        public DataTable layNhanvien()
        {
            string query = @"hienThi_nv";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void themNhanvien(DTO_nhanvien lt)
        {
            string query = @"them_nv @ma , @ten , @gioitinh , @quequan , @sdt , @email  ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.ma, lt.ten, lt.gioitinh, lt.quequan, lt.sdt, lt.email });
        }

        public void suaNhanvien(DTO_nhanvien lt)
        {
            string query = @"sua_nv @ma , @ten , @gioitinh , @quequan , @sdt , @email  ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.ma, lt.ten, lt.gioitinh, lt.quequan, lt.sdt, lt.email });
        }

        public void xoaNhanvien(DTO_nhanvien lt)
        {
            string query = @"xoa_nv @ma ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.ma, lt.ten, lt.gioitinh, lt.quequan, lt.sdt, lt.email });
        }
    }
}
