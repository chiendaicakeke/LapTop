using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_hdnhap
    {
        public string ma { get; set; }
        public string nhanvien { get; set; }
        public string ncc { get; set; }
        public string ngaynhap { get; set; }

        public DTO_hdnhap() { }
        public DTO_hdnhap(string ma, string nhanvien, string ncc, string ngaynhap)
        {
            this.ma = ma;
            this.nhanvien = nhanvien;
            this.ncc = ncc;
            this.ngaynhap = ngaynhap;
        }
    }
}
