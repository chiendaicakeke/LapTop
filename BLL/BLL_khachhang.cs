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
    public class BLL_khachhang
    {
        DAL_khachhang kh = new DAL_khachhang();

        public DataTable layKhachhang()
        {
            return kh.layKhachhang();
        }

        public void themKhachhang(DTO_khachhang lt)
        {
            kh.themKhachhang(lt);
        }

        public void suaKhachhang(DTO_khachhang lt)
        {
            kh.suaKhachhang(lt);
        }

        public void xoaKhachhang(DTO_khachhang lt)
        {
            kh.xoaKhachhang(lt);
        }
    }
}
