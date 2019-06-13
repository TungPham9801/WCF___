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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DoanhThuService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DoanhThuService.svc or DoanhThuService.svc.cs at the Solution Explorer and start debugging.
    public class DoanhThuService : IDoanhThuService
    {
        DBAccess db = new DBAccess();
        DAL_DoanhThu doanhthu = new DAL_DoanhThu();
        public void DoWork()
        {
        }

        public bool kiemTraTonTaiDT(DateTime ngay)
        {
            return doanhthu.kiemTraTonTaiDT(ngay);
        }

        public string layDoanhThu(DateTime ngay)
        {
            return doanhthu.layDoanhThu(ngay);
        }

        public bool SuaDoanhThu(DoanhThu dt)
        {
            return doanhthu.SuaDoanhThu(dt);
        }

        public bool ThemDoanhThu(DoanhThu dt)
        {
            return doanhthu.ThemDoanhThu(dt);
        }
    }
}
