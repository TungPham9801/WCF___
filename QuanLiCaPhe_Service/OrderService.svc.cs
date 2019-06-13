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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrderService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select OrderService.svc or OrderService.svc.cs at the Solution Explorer and start debugging.
    public class OrderService : IOrderService
    {
        DBAccess db = new DBAccess();
        DAL_Order oder = new DAL_Order();

        public bool ChuyenBan(Oder od)
        {
            return oder.ChuyenBan(od);
        }

        public void DoWork()
        {
        }

        public DataTable getDSOder()
        {
            return oder.getDSOder();
        }

        public DataTable GetDSOder(string maOder)
        {
            return oder.getDSOder(maOder);
        }

        public DataTable getMaNV()
        {
            return oder.getMaNV();
        }

        public bool kiemTraTonTai1()
        {
            return oder.kiemTraTonTai1();
        }

        public string layMaBan(int soBan)
        {
            return oder.layMaBan(soBan);
        }

        public int layMaOder()
        {
            return oder.layMaOder();
        }

        public bool ThemOder(Oder od)
        {
            return oder.ThemOder(od);
        }

        public bool XoaOder(Oder od)
        {
            return oder.XoaOder(od);
        }
    }
}
