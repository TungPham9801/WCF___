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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BanSDNhieuService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BanSDNhieuService.svc or BanSDNhieuService.svc.cs at the Solution Explorer and start debugging.
    public class BanSDNhieuService : IBanSDNhieuService
    {
        DBAccess db = new DBAccess();
        DAL_BanSDNhieu bsd = new DAL_BanSDNhieu();
        public void DoWork()
        {
        }

        public bool kiemTraTonTai(string maban)
        {
            return bsd.kiemTraTonTai(maban);
        }

        public string layLuotSD(string maBan)
        {
            return bsd.layLuotSD(maBan);
        }

        public string laySoBan(string maBan)
        {
            return bsd.laySoBan(maBan);
        }

        public bool SuaLuotSD(BanSDNhieu ban)
        {
            return bsd.SuaLuotSD(ban);
        }

        public bool ThemBanSDNhieu(BanSDNhieu ban)
        {
            return bsd.ThemBanSDNhieu(ban);
        }
    }
}
