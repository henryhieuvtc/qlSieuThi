using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlSieuThi.Model
{
    class CHangHoa
    {
        //scan code
        [PrimaryKey]
        private string ma;
        private string ten;
        private int soluong;
        private string tencongty;

        CHangHoa()
        {

        }

        CHangHoa(string Ma, string Ten, int Soluong, string Tencongty)
        {
            ma = Ma;
            ten = Ten;
            soluong = Soluong;
            tencongty = Tencongty;
        }

        CHangHoa(string Ma, string Ten, int Soluong)
        {
            ma = Ma;
            ten = Ten;
            soluong = Soluong;
        }

        public string Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public string Tencongty
        {
            get
            {
                return tencongty;
            }

            set
            {
                tencongty = value;
            }
        }
    }
}
