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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHoaDonService" in both code and config file together.
    [ServiceContract]
    public interface IHoaDonService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        DataTable getHoaDon();
        [OperationContract]
        string layMaHD(int maOder);
        [OperationContract]
        bool ThemHD(HoaDon hd);
        [OperationContract]
        bool XoaHD(HoaDon hd);
        [OperationContract]
        bool ChuyenBan(HoaDon hd);

    }
}
