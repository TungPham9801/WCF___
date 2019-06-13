using DTO_QLCP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLCP
{
    public class DAL_LoaiMon
    {
        DBAccess db = new DBAccess();
        public DataTable GetLoaiMon()
        {
            string query = " select*from tblLoaiMon";
            return db.getDS(query);
        }
        public bool KiemTraLoaiMon(string maLoaiMon)

        {
            return db.kiemTraTonTai19(maLoaiMon);
        }
        public bool ThemLoaiMon(LoaiMon lm)
        {
            string[] param = { "@MaLoaiMon", "@TenLoaiMon" };
            object[] values = { lm.MaLoaiMon, lm.TenLoaiMon };
            string query = "insert into tblLoaiMon(MaLoaiMon,TenLoaiMon) values (@MaLoaiMon,@TenLoaiMon)";
            return db.ExecuteNonQueryPara(query, param, values);

        }
        public bool SuaLoaiMon(LoaiMon lm)
        {
            string[] param = { "@MaLoaiMon", "@TenLoaiMon" };
            object[] values = { lm.MaLoaiMon, lm.TenLoaiMon };
            string query = "update tblLoaiMon set TenLoaiMon= @TenLoaiMon where MaLoaiMon =@MaLoaiMon";
            return db.ExecuteNonQueryPara(query, param, values);
        }
        public bool XoaLoaiMon(LoaiMon lm)
        {
            string[] param = { "@MaLoaiMon", "@TenLoaiMon" };
            object[] values = { lm.MaLoaiMon, lm.TenLoaiMon };
            string query = "delete from tblLoaiMon  where MaLoaiMon =@MaLoaiMon";
            return db.ExecuteNonQueryPara(query, param, values);
        }
    }
}
