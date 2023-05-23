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
    public class BLL_mathang
    {
        DAL_mathang lap = new DAL_mathang();

        public DataTable layMathang()
        {
            return lap.layMathang();
        }

        public void themMathang(DTO_mathang lt)
        {
            lap.themMathang(lt);
        }

        public void suaMathang(DTO_mathang lt)
        {
            lap.suaMathang(lt);
        }

        public void xoaMathang(DTO_mathang lt)
        {
            lap.xoaMathang(lt);
        }
    }
}
