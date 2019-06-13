using DTO_QLCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QuanLiCaPhe_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBanSDNhieuService" in both code and config file together.
    [ServiceContract]
    public interface IBanSDNhieuService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        bool kiemTraTonTai(string maban);
        [OperationContract]
        string laySoBan(string maBan);
        [OperationContract]
        string layLuotSD(string maBan);
        [OperationContract]
        bool ThemBanSDNhieu(BanSDNhieu ban);
        [OperationContract]
        bool SuaLuotSD(BanSDNhieu ban);
    }
}
