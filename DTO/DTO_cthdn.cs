using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_cthdn
    {
        public string ma { get; set; }
        public string mathang { get; set; }
        public string gianhap { get; set; }
        public string soluong { get; set; }

        public DTO_cthdn() { }
        public DTO_cthdn(string ma, string mathang, string gianhap, string soluong)
        {
            this.ma = ma;
            this.mathang = mathang;
            this.gianhap = gianhap;
            this.soluong = soluong;
        }
    }
}
