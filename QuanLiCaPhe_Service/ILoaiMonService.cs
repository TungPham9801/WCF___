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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILoaiMonService" in both code and config file together.
    [ServiceContract]
    public interface ILoaiMonService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        DataTable GetLoaiMon();
        [OperationContract]
        bool KiemTraLoaiMon(string maLoaiMon);
        [OperationContract]
        bool ThemLoaiMon(LoaiMon lm);
        [OperationContract]
        bool SuaLoaiMon(LoaiMon lm);
        [OperationContract]
        bool XoaLoaiMon(LoaiMon lm);
    }
}
