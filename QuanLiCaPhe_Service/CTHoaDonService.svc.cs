using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAL_QLCP;
using DTO_QLCP;

namespace QuanLiCaPhe_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CTHoaDonService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CTHoaDonService.svc or CTHoaDonService.svc.cs at the Solution Explorer and start debugging.
    public class CTHoaDonService : ICTHoaDonService
    {
        DBAccess db = new DBAccess();
        DAL_CTHoaDon cthoadon = new DAL_CTHoaDon();
        public void DoWork()
        {
        }

        public DataTable getCTHD()
        {
            return cthoadon.getCTHD();
        }

        public bool kiemTraMonHD(int maHD, string maMon)
        {
            return cthoadon.kiemTraMonHD(maHD, maMon);
        }

        public string layDonGia(string maMon)
        {
            return cthoadon.layDonGia(maMon);
        }

        public DataTable LayDSCTHD(int maHoaDon)
        {
            return cthoadon.LayDSCTHD(maHoaDon);
        }

        public string layMaHD(int maOder)
        {
            return cthoadon.layMaHD(maOder);
        }

        public string layTenMon(string maMon)
        {
            return cthoadon.layTenMon(maMon);
        }

        public bool SuaCTHD(CTHoaDon ct)
        {
            return cthoadon.SuaCTHD(ct);
        }

        public bool ThemCTHD(CTHoaDon ct)
        {
            return cthoadon.ThemCTHD(ct);
        }

        public bool XoaMon(CTHoaDon ct)
        {
            return cthoadon.XoaMon(ct);
        }
    }
}
