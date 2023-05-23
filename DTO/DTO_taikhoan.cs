using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_taikhoan
    {
        public string tentk { get; set; }
        public string mk { get; set; }
        public string idnv { get; set; }

        public DTO_taikhoan() { }
        public DTO_taikhoan(string tentk, string mk, string idnv)
        {
            this.tentk = tentk;
            this.mk = mk;
            this.idnv = idnv;
        }
    }
}
