using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAL_QLCP;
using DTO_QLCP;

namespace QuanLiCaPhe_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BanCoKhachService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BanCoKhachService.svc or BanCoKhachService.svc.cs at the Solution Explorer and start debugging.
    public class BanCoKhachService : IBanCoKhachService
    {
        DBAccess db = new DBAccess();
        DAL_BanCoKhach bck = new DAL_BanCoKhach();
        public void DoWork()
        {
        }

        public bool kiemTraBanCoKhach(string maban)
        {
            return bck.kiemTraBanCoKhach(maban);
        }

        public string laySoBan(string maBan)
        {
            return bck.laySoBan(maBan);
        }

        public bool ThemBanCoKhach(BanCoKhach ban)
        {
            return bck.ThemBanCoKhach(ban);
        }

        public bool XoaBanCoKhach(BanCoKhach ban)
        {
            return bck.XoaBanCoKhach(ban);
        }
    }
}
