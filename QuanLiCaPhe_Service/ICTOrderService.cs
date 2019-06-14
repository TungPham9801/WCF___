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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICTOrderService" in both code and config file together.
    [ServiceContract]
    public interface ICTOrderService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        DataTable getCTOder(int maOder, string maBan);
        [OperationContract]
        DataTable GetCTOrder(string maBan);
        [OperationContract]
        bool kiemTraMon(string MaMon, string maBan, int maOder);
        [OperationContract]
        bool kiemTraGoiMon(int maOder);
        [OperationContract]
        bool kiemTraBan(int soBan);
        [OperationContract]
        string layDVT(string maMon);
        [OperationContract]
        string laySoBan(string MaBan);
        [OperationContract]
        string laySLMon(string maMon, string maBan);
        [OperationContract]
        bool ThemCTOder(CTOder ct);
        [OperationContract]
        bool NhapSoLuong(CTOder ct);
        [OperationContract]
        bool XoaMon(CTOder ct);
        [OperationContract]
        bool XoaCTOder(CTOder ct);
        [OperationContract]
        bool ChuyenBan(CTOder ct);
        [OperationContract]
        string layMaMon(string maOrder);
    }
}
