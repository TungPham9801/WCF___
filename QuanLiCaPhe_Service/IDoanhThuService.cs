using DTO_QLCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QuanLiCaPhe_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDoanhThuService" in both code and config file together.
    [ServiceContract]
    public interface IDoanhThuService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        bool kiemTraTonTaiDT(DateTime ngay);
        [OperationContract]
        string layDoanhThu(DateTime ngay);
        [OperationContract]
        bool ThemDoanhThu(DoanhThu dt);
        [OperationContract]
        bool SuaDoanhThu(DoanhThu dt);
    }
}
