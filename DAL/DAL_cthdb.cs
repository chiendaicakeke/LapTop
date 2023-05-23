using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_cthdb
    {
        public DataTable layCthdb()
        {
            string query = @"hienThi_cthdb";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void themCthdb(DTO_cthdb lt)
        {
            string query = @"them_cthdb @ma , @mathang , @soluong , @giaban ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.id , lt.mathang , lt.soluong , lt.giaban });
        }

        public void suaCthdb(DTO_cthdb lt)
        {
            string query = @"sua_cthdb @ma , @mathang , @soluong , @giaban ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.id , lt.mathang , lt.soluong , lt.giaban });
        }


        public void xoaCthdb(DTO_cthdb lt)
        {
            string query = @"xoa_cthdb @ma ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { lt.id , lt.mathang , lt.soluong , lt.giaban });
        }
    }
}
