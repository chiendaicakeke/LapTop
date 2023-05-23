using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_cthdb
    {
        public string id { get; set; }
        public string mathang { get; set; }
        public string soluong { get; set; }
        public string giaban { get; set; }

        public DTO_cthdb() { }
        public DTO_cthdb(string id, string mathang, string soluong, string giaban)
        {
            this.id = id;
            this.mathang = mathang;
            this.soluong = soluong;
            this.giaban = giaban;
        }
    }
}
