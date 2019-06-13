using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DTO_QLCP;
using DAL_QLCP;
using System.Data;
using System.Data.SqlClient;
 

namespace QuanLiCaPhe_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NhanVienService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select NhanVienService.svc or NhanVienService.svc.cs at the Solution Explorer and start debugging.
    public class NhanVienService : INhanVienService
    {
        DBAccess db = new DBAccess();
        DAL_NhanVien dalnv = new DAL_NhanVien();
        public void DoWork()
        {
        }

        public DataTable getDSNV()
        {
            return dalnv.getDSNV();
        }

        public DataTable getDSNV_theoma(string maNV)
        {
            string query = "Select *from tblNhanVien where MaNV='" + maNV + "'";
            return db.getDS(query);
        }

        public bool kiemTraNhanVien(string maNV)
        {
            return db.kiemTraTonTai2(maNV);
        }

        public bool SuaNV(NhanVien nv)
        {
            return dalnv.SuaNV(nv);
        }

        public bool ThemNV(NhanVien nv)
        {
            return dalnv.ThemNV(nv);
        }

        public bool XoaNV(NhanVien nv)
        {
            return dalnv.XoaNV(nv);
        }
    }
}
