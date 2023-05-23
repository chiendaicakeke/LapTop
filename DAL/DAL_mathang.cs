using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_mathang
    {
        public DataTable layMathang()
        {
            string query = @"hienThi_mh";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void themMathang(DTO_mathang lt)
        {
            string query = @"them_mh @ma , @ten , @ncc , @mota  ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.ma, lt.ten, lt.ncc, lt.mota});
        }

        public void suaMathang(DTO_mathang lt)
        {
            string query = @"sua_mh @ma , @ten , @ncc , @mota   ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.ma, lt.ten, lt.ncc, lt.mota });
        }

        public void xoaMathang(DTO_mathang lt)
        {
            string query = @"xoa_mh @ma ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.ma, lt.ten, lt.ncc, lt.mota });
        }
    }
}
