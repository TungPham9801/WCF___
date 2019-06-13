using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QLCP
{
    public class BanCoKhach
    {
        private string maBan;
        private int soBan;

        public string MaBan
        {
            get { return maBan; }
            set { maBan = value; }
        }

        public int SoBan
        {
            get { return soBan; }
            set { soBan = value; }
        }
    }
}
