using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QLCP
{
    public class DoanhThu
    {
        private DateTime ngay;
        private float tong;

        public DateTime Ngay
        {
            get { return ngay; }
            set { ngay = value; }
        }

        public float Tong
        {
            get { return tong; }
            set { tong = value; }
        }
    }
}
