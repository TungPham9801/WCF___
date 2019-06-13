using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QLCP
{
    public class BanSDNhieu
    {
        private string maBan;
        private int soBan;
        private int luotSD;

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

        public int LuotSD
        {
            get { return luotSD; }
            set { luotSD = value; }
        }
    }
}
