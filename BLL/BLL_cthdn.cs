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
    public class BLL_cthdn
    {
        DAL_cthdn kh = new DAL_cthdn();

        public DataTable layCthdn()
        {
            return kh.layCthdn();
        }

        public void themCthdn(DTO_cthdn lt)
        {
            kh.themCthdn(lt);
        }

        public void suaCthdn(DTO_cthdn lt)
        {
            kh.suaCthdn(lt);
        }

        public void xoaCthdn(DTO_cthdn lt)
        {
            kh.xoaCthdn(lt);
        }
    }
}
