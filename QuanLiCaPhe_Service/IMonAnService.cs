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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMonAnService" in both code and config file together.
    [ServiceContract]
    public interface IMonAnService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        DataTable getDSMon();
        [OperationContract]
        bool KiemTraMon(string maMon);
        [OperationContract]
        bool ThemMon(MonAn ma);
        [OperationContract]
        bool SuaMon(MonAn ma);
        [OperationContract]
        bool XoaMon(MonAn ma);
        [OperationContract]
        DataTable LayMonTheoLoai(string maLoaiMon);

    }
}
