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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LoaiMonService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LoaiMonService.svc or LoaiMonService.svc.cs at the Solution Explorer and start debugging.
    public class LoaiMonService : ILoaiMonService
    {
        DBAccess db = new DBAccess();
        DAL_LoaiMon loaimon = new DAL_LoaiMon();
        public void DoWork()
        {
        }

        public DataTable GetLoaiMon()
        {
            return loaimon.GetLoaiMon();
        }

        public bool KiemTraLoaiMon(string maLoaiMon)
        {
            return loaimon.KiemTraLoaiMon(maLoaiMon);
        }

        public bool SuaLoaiMon(LoaiMon lm)
        {
            return loaimon.SuaLoaiMon(lm);
        }

        public bool ThemLoaiMon(LoaiMon lm)
        {
            return loaimon.ThemLoaiMon(lm);
        }

        public bool XoaLoaiMon(LoaiMon lm)
        {
            return loaimon.XoaLoaiMon(lm);
        }
    }
}
