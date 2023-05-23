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
    public class BLL_hdnhap
    {
        DAL_hdnhap kh = new DAL_hdnhap();

        public DataTable layHdnhap()
        {
            return kh.layHdnhap();
        }

        public void themHdnhap(DTO_hdnhap lt)
        {
            kh.themHdnhap(lt);
        }

        public void suaHdnhap(DTO_hdnhap lt)
        {
            kh.suaHdnhap(lt);
        }

        public void xoaHdnhap(DTO_hdnhap lt)
        {
            kh.xoaHdnhap(lt);
        }
    }
}
