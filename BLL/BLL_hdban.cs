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
    public class BLL_hdban
    {
        DAL_hdban kh = new DAL_hdban();

        public DataTable layHdban()
        {
            return kh.layHdban();
        }

        public void themHdban(DTO_hdban lt)
        {
            kh.themHdban(lt);
        }

        public void suaHdban(DTO_hdban lt)
        {
            kh.suaHdban(lt);
        }

        public void xoaHdban(DTO_hdban lt)
        {
            kh.xoaHdban(lt);
        }
    }
}
