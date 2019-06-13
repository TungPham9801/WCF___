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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CTDoanhThuService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CTDoanhThuService.svc or CTDoanhThuService.svc.cs at the Solution Explorer and start debugging.
    public class CTDoanhThuService : ICTDoanhThuService
    {
        DBAccess db = new DBAccess();
        DAL_CTDoanhThu ctdoanhthu = new DAL_CTDoanhThu();

        public void DoWork()
        {
        }

        public bool kiemTraTonTaiCTDT(string maMon, DateTime ngay)
        {
            return ctdoanhthu.kiemTraTonTaiCTDT(maMon, ngay);
        }

        public bool kiemTraTonTaiOder(int maOder)
        {
            return ctdoanhthu.kiemTraTonTaiOder(maOder);
           
        }

        public string layDonGia(string maMon)
        {
            return ctdoanhthu.layDonGia(maMon);
        }

        public string laySLBan(string maMon)
        {
            return ctdoanhthu.laySLBan(maMon);
        }

        public string laySLMonCu(string maMon, string maBan)
        {
            return ctdoanhthu.laySLMonCu(maMon, maBan);
        }

        public bool SuaCTDoanhThu(CTDoanhThu ct)
        {
            return ctdoanhthu.SuaCTDoanhThu(ct);
        }

        public bool ThemCTDoanhThu(CTDoanhThu ct)
        {
            return ctdoanhthu.ThemCTDoanhThu(ct);
        }
    }
}
