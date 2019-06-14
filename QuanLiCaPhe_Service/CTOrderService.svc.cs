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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CTOrderService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CTOrderService.svc or CTOrderService.svc.cs at the Solution Explorer and start debugging.
    public class CTOrderService : ICTOrderService
    {
        DBAccess db = new DBAccess();
        DAL_CTOrder ctoder = new DAL_CTOrder();
        public bool ChuyenBan(CTOder ct)
        {
            return ctoder.ChuyenBan(ct);
        }

        public void DoWork()
        {
        }

        public DataTable getCTOder(int maOder, string maBan)
        {
            return ctoder.getCTOder(maOder, maBan);
        }

        public DataTable GetCTOrder(string maBan)
        {
            return ctoder.GetCTOder(maBan);
        }

        public bool kiemTraBan(int soBan)
        {
            return ctoder.kiemTraBan(soBan);
        }

        public bool kiemTraGoiMon(int maOder)
        {
            return ctoder.kiemTraGoiMon(maOder);
        }

        public bool kiemTraMon(string MaMon, string maBan, int maOder)
        {
            return ctoder.kiemTraMon(MaMon, maBan, maOder);
        }

        public string layDVT(string maMon)
        {
            return ctoder.layDVT(maMon);
        }

        public string layMaMon(string maOrder)
        {
            return ctoder.layMaMon(maOrder);
        }

        public string laySLMon(string maMon, string maBan)
        {
            return ctoder.laySLMon(maMon, maBan);
        }

        public string laySoBan(string MaBan)
        {
            return ctoder.laySoBan(MaBan);
        }

        public bool NhapSoLuong(CTOder ct)
        {
            return ctoder.NhapSoLuong(ct);
        }

        public bool ThemCTOder(CTOder ct)
        {
            return ctoder.ThemCTOder(ct);
        }

        public bool XoaCTOder(CTOder ct)
        {
            return ctoder.XoaCTOder(ct);
        }

        public bool XoaMon(CTOder ct)
        {
            return ctoder.XoaMon(ct);
        }
    }
}
