using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_cthdn
    {
        public DataTable layCthdn()
        {
            string query = @"hienThi_cthdn";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void themCthdn(DTO_cthdn lt)
        {
            string query = @"them_cthdn @ma , @mathang , @soluong , @giaban ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.ma, lt.mathang, lt.gianhap, lt.soluong });
        }

        public void suaCthdn(DTO_cthdn lt)
        {
            string query = @"sua_cthdn @ma , @mathang , @soluong , @giaban ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.ma, lt.mathang, lt.gianhap, lt.soluong });
        }


        public void xoaCthdn(DTO_cthdn lt)
        {
            string query = @"xoa_cthdn @ma ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.ma, lt.mathang, lt.gianhap, lt.soluong });
        }
    }
}
