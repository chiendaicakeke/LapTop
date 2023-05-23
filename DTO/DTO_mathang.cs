using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_mathang
    {
        public string ma { get; set; }
        public string  ten { get; set; }
        public string ncc { get; set; }
        public string mota { get; set; }

        public DTO_mathang() { }
        public DTO_mathang(string ma, string ten, string ncc, string mota)
        {
            this.ma = ma;
            this.ten = ten;
            this.ncc = ncc;
            this.mota = mota;
        }
    }
}
