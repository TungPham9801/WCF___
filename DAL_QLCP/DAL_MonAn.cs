using DTO_QLCP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLCP
{
    public class DAL_MonAn
    {
        DBAccess db = new DBAccess();
        public DataTable getDSMon()
        {
            string query = " select*from tblDSMon";
            return db.getDS(query);
        }
        public DataTable LayMonTheoLoai(string maLoaiMon)
        {
            string query = "select*from tblDSMon where MaLoaiMon = N'" + maLoaiMon + "'";
            return db.getDS(query);
        }
        public bool KiemTraMon(string maMon)
        {
            return db.kiemTRaTonTai18(maMon);
        }
        public bool ThemMon(MonAn ma)
        {
            string[] param = { "@MaMonAn", "@TenMonAn", "@MaLoaiMon", "@DonGia", "@DonViTinh" };
            object[] values = { ma.MaMon, ma.TenMon, ma.MaLoaiMon, ma.DonGia, ma.DonViTinh };
            string query = "insert into tblDSMon(MaMon, TenMon,MaLoaiMon, Dongia,DonViTinh) values(@MaMonAn,@TenMonAn,@MaLoaiMon,@DonGia,@DonViTinh";
            return db.ExecuteNonQueryPara(query, param, values);
        }
        public bool SuaMon(MonAn ma)
        {
            string[] param = { "@MaMonAn", "@TenMonAn", "@MaLoaiMon", "@DonGia", "@DonViTinh" };
            object[] values = { ma.MaMon, ma.TenMon, ma.MaLoaiMon, ma.DonGia, ma.DonViTinh };
            string query = "update tblDSMon set TenMon = @TenMonAn,MaLoaiMon=@MaLoaiMon, Dongia=@DonGia,DonViTinh = @DonViTinh where MaMon = @MaMonAn";
            return db.ExecuteNonQueryPara(query, param, values);
        }
        public bool XoaMon(MonAn ma)
        {
            string[] param = { "@MaMonAn", "@TenMonAn", "@MaLoaiMon", "@DonGia", "@DonViTinh" };
            object[] values = { ma.MaMon, ma.TenMon, ma.MaLoaiMon, ma.DonGia, ma.DonViTinh };
            string query = "delete from tblDSMon where MaMon = @MaMonAn";
            return db.ExecuteNonQueryPara(query, param, values);
        }
    }
}
