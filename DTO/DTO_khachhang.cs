using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_khachhang
    {
        public string ma { get; set; }
        public string ten { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }

        public DTO_khachhang() { }
        public DTO_khachhang(string ma, string ten, string diachi, string sdt, string email)
        {
            this.ma = ma;
            this.ten = ten;
            this.diachi = diachi;
            this.sdt = sdt;
            this.email = email;
        }
    }
}
