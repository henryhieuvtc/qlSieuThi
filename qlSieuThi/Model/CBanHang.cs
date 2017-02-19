using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlSieuThi.Model
{
    class CBanHang
    {
        [PrimaryKey]
        public string Ma { get; set; }
        public string Makhachhang { get; set; }
        public List<CHangHoa> Hanghoa { get; set; }
        public string Tongtien { get; set; }

        CBanHang() { }
    }
}
