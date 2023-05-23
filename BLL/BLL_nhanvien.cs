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
    public class BLL_nhanvien
    {
        DAL_nhanvien lap = new DAL_nhanvien();

        public DataTable layNhanvien()
        {
            return lap.layNhanvien();
        }

        public void themNhanvien(DTO_nhanvien lt)
        {
            lap.themNhanvien(lt);
        }

        public void suaNhanvien(DTO_nhanvien lt)
        {
            lap.suaNhanvien(lt);
        }

        public void xoaNhanvien(DTO_nhanvien lt)
        {
            lap.xoaNhanvien(lt);
        }
    }
}
