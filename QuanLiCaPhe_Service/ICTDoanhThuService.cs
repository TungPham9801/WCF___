using DTO_QLCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QuanLiCaPhe_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICTDoanhThuService" in both code and config file together.
    [ServiceContract]
    public interface ICTDoanhThuService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        string layDonGia(string maMon);
        [OperationContract]
        string laySLBan(string maMon);
        [OperationContract]
        bool kiemTraTonTaiCTDT(string maMon, DateTime ngay);
        [OperationContract]
        string laySLMonCu(string maMon, string maBan);
        [OperationContract]
        bool kiemTraTonTaiOder(int maOder);
        [OperationContract]
        bool ThemCTDoanhThu(CTDoanhThu ct);
        [OperationContract]
        bool SuaCTDoanhThu(CTDoanhThu ct);
    }
}
