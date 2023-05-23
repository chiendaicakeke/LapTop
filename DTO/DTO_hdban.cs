using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    
        public class DTO_hdban
    {
            public string ma { get; set; }
            public string nhanvien { get; set; }
            public string khachhang { get; set; }
            public string ngayban { get; set; }

            public DTO_hdban() { }
            public DTO_hdban(string ma, string nhanvien, string khachhang , string ngayban)
            {
            this.ma = ma;
            this.nhanvien = nhanvien;
            this.khachhang = khachhang;
            this.ngayban = ngayban;
            }
        }
    
}
