using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DTO_QLCP;
using System.Data;

namespace QuanLiCaPhe_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INhanVienService" in both code and config file together.
    [ServiceContract]
    public interface INhanVienService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        bool ThemNV(NhanVien nv);
        [OperationContract]
        DataTable getDSNV();
        [OperationContract]
        DataTable getDSNV_theoma(string maNV);
        [OperationContract]
        bool kiemTraNhanVien(string maNV);
        [OperationContract]
        bool SuaNV(NhanVien nv);
        [OperationContract]
        bool XoaNV(NhanVien nv);


    }
}
