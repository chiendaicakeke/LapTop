using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_cthdb
    {
        DAL_cthdb kh = new DAL_cthdb();

        public DataTable layCthdb()
        {
            return kh.layCthdb();
        }

        public void themCthdb(DTO_cthdb lt)
        {
            kh.themCthdb(lt);
        }

        public void suaCthdb(DTO_cthdb lt)
        {
            kh.suaCthdb(lt);
        }

        public void xoaCthdb(DTO_cthdb lt)
        {
            kh.xoaCthdb(lt);
        }
    }
}
