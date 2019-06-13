using DTO_QLCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QuanLiCaPhe_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBanCoKhachService" in both code and config file together.
    [ServiceContract]
    public interface IBanCoKhachService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        bool kiemTraBanCoKhach(string maban);
        [OperationContract]
        string laySoBan(string maBan);
        [OperationContract]
        bool ThemBanCoKhach(BanCoKhach ban);
        [OperationContract]
        bool XoaBanCoKhach(BanCoKhach ban);
    }
}
