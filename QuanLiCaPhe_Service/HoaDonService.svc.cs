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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HoaDonService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HoaDonService.svc or HoaDonService.svc.cs at the Solution Explorer and start debugging.
    public class HoaDonService : IHoaDonService
    {
        DBAccess db = new DBAccess();
        DAL_HoaDon hoadon = new DAL_HoaDon();
        public bool ChuyenBan(HoaDon hd)
        {
            return hoadon.ChuyenBan(hd);
        }

        public void DoWork()
        {
        }

        public DataTable getHoaDon()
        {
            return hoadon.getHoaDon();
        }

        public string layMaHD(int maOder)
        {
            return hoadon.layMaHD(maOder);
        }

        public bool ThemHD(HoaDon hd)
        {
            return hoadon.ThemHD(hd);
        }

        public bool XoaHD(HoaDon hd)
        {
            return hoadon.XoaHD(hd);
        }
    }
}
