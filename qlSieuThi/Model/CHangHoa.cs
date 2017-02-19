using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlSieuThi.Model
{
    class CHangHoa
    {
        [PrimaryKey]
        public string Id { get; set; }
        public string Ten { get; set; }
        public string Congty { get; set; }
        public int Soluong { get; set; }

        public CHangHoa() { }

        public CHangHoa(string id, string ten, int soluong) {
            Id = id;
            Ten = ten;
            Soluong = soluong;
        }
    }
}
