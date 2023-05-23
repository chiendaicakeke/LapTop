using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_nhanvien
    {
        public string ma { get; set; }
        public string ten { get; set; }
        public string gioitinh { get; set; }
        public string quequan { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }

        public DTO_nhanvien() { }
        public DTO_nhanvien(string ma, string ten, string gioitinh, string quequan, string sdt, string email)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.quequan = quequan;
            this.sdt = sdt;
            this.email = email;
        }
    }
}
