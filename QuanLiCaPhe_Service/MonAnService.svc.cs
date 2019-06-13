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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MonAnService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MonAnService.svc or MonAnService.svc.cs at the Solution Explorer and start debugging.
    public class MonAnService : IMonAnService
    {
        DBAccess db = new DBAccess();
        DAL_MonAn mon = new DAL_MonAn();
        public void DoWork()
        {
        }

        public DataTable getDSMon()
        {
            return mon.getDSMon();
        }

        public bool KiemTraMon(string maMon)
        {
            return mon.KiemTraMon(maMon);
        }

        public DataTable LayMonTheoLoai(string maLoaiMon)
        {
            return mon.LayMonTheoLoai(maLoaiMon);
        }

        public bool SuaMon(MonAn ma)
        {
            return mon.SuaMon(ma);
        }

        public bool ThemMon(MonAn ma)
        {
            return mon.ThemMon(ma);
        }

        public bool XoaMon(MonAn ma)
        {
            return mon.XoaMon(ma);
        }
    }
}
