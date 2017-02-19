using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlSieuThi.Model
{
    class CNhanVien
    {
        [PrimaryKey]
        public string Ma { get; set; }
        public string Ten { get; set; }
        public bool Gioitinh { get; set; }
        //Datetime sau nay
        public string Ngaysinh { get; set; }
        public string Diachi { get; set; }
        public string Sdt { get; set; }

        CNhanVien() { }

        CNhanVien(string ma) { this.Ma = ma; }
    }
}
