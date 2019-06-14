using DTO_QLCP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QuanLiCaPhe_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICTHoaDonService" in both code and config file together.
    [ServiceContract]
    public interface ICTHoaDonService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        DataTable getCTHD();
        [OperationContract]
        string layMaHD(int maOder);
        [OperationContract]
        string layTenMon(string maMon);
        [OperationContract]
        bool kiemTraMonHD(int maHD, string maMon);
        [OperationContract]
        string layDonGia(string maMon);
        [OperationContract]
        bool ThemCTHD(CTHoaDon ct);
        [OperationContract]
        bool SuaCTHD(CTHoaDon ct);
        [OperationContract]
        bool XoaMon(CTHoaDon ct);
        [OperationContract]
        DataTable LayDSCTHD(int maHoaDon);
    }
}
