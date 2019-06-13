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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrderService" in both code and config file together.
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        DataTable getDSOder();
        [OperationContract]
        DataTable GetDSOder(string maOder);
        [OperationContract]
        DataTable getMaNV();
        [OperationContract]
        string layMaBan(int soBan);
        [OperationContract]
        int layMaOder();
        [OperationContract]
        bool kiemTraTonTai1();
        [OperationContract]
        bool ThemOder(Oder od);
        [OperationContract]
        bool XoaOder(Oder od);
        [OperationContract]
        bool ChuyenBan(Oder od);
    }
}
