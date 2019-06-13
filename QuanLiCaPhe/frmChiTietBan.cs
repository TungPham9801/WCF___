using DTO_QLCP;
using QuanLiCaPhe.BanCoKhachService;
using QuanLiCaPhe.BanSDNhieuService;
using QuanLiCaPhe.CTDoanhThuService;
using QuanLiCaPhe.CTOrderService;
using QuanLiCaPhe.DoanhThuService;
using QuanLiCaPhe.HoaDonService;
using QuanLiCaPhe.LoaiMonService;
using QuanLiCaPhe.MonAnService;
using QuanLiCaPhe.OrderService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCaPhe
{
    public partial class frmChiTietBan : Form
    {
        HoaDonServiceClient hoadon = new HoaDonServiceClient();
        CTHoadonServiceClient cthoadon = new CTHoadonServiceClient();
        CTOrderServiceClient ctorder = new CTOrderServiceClient();
        OrderServiceClient orderr = new OrderServiceClient();
        BanCoKhachServiceClient bancokhach = new BanCoKhachServiceClient();
        LoaiMonServiceClient loaimon = new LoaiMonServiceClient();
        MonAnServiceClient monan = new MonAnServiceClient();
        DoanhThuServiceClient doanhthu = new DoanhThuServiceClient();
        CTDoanhThuServiceClient ctdoanhthu = new CTDoanhThuServiceClient();
        BanSDNhieuServiceClient bansd = new BanSDNhieuServiceClient();
        public frmChiTietBan(string text )
        {
            InitializeComponent();
            txtMaBan.Text = text;
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            gbThongTin.Visible = true;
            gbSoLuong.Visible = true;
            dataGridViewCTOrder.Visible = true;
        }

        private void frmChiTietBan_Load(object sender, EventArgs e)
        {
            int i = 0;
            if (orderr.kiemTraTonTai1() == false)
                txtMaOder.Text = "1";
            else
                if (bancokhach.kiemTraBanCoKhach(txtMaBan.Text) == false)
            {
                i = orderr.layMaOder() + 1;
                txtMaOder.Text = i.ToString();
            }
            DataTable tableNV = new DataTable();
            tableNV = orderr.getMaNV();
            cbMaNV.DataSource = tableNV;
            cbMaNV.DisplayMember = "TenNV";
            cbMaNV.ValueMember = "MaNV";
            if (bancokhach.kiemTraBanCoKhach(txtMaBan.Text))
            {
                binData1();
            }
            //else
            //    binData();
            //gắn dl vào cmb món và loại món
            DataTable dt = new DataTable();
            dt = loaimon.GetLoaiMon();
            cmbLoaiMon.DataSource = dt;
            cmbLoaiMon.DisplayMember = "TenLoaiMon";
            cmbLoaiMon.ValueMember = "MaLoaiMon";
            //
            
        }
        private void clearbin()
        {
            dataGridViewCTOrder.DataBindings.Clear();
        }
        private void ClearBind1()
        {
            txtMaOder.DataBindings.Clear();
        }

        private void binData1()
        {
            BindingSource bindSource = new BindingSource();
            string maBan = txtMaBan.Text;
            bindSource.DataSource = ctorder.GetCTOder1(maBan);
            clearbin();
            dataGridViewCTOrder.DataSource = bindSource;
            txtMaOder.DataBindings.Add("Text", bindSource, "MaOder");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            frmLoaiMon formloai = new frmLoaiMon();
            formloai.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            frmMonAn formmon = new frmMonAn();
            formmon.Show();
        }

        private void cmbLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = cmbLoaiMon.SelectedValue.ToString();
            DataTable dt1 = new DataTable();
            dt1 = monan.LayMonTheoLoai(a);
            cmbMon.DataSource = dt1;
            cmbMon.DisplayMember = "TenMon";
            cmbMon.ValueMember = "MaMon";
        }
        //
        //
        //

        #region get
        private Oder getOder()
        {
            Oder od = new Oder();
            int i = 0;
            od.MaNV = cbMaNV.SelectedValue.ToString();
            od.MaBan = txtMaBan.Text;
            Int32.TryParse(txtMaOder.Text, out i);
            od.MaOder = i;
            od.Ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
            return od;
        }

        private BanCoKhach getBanCoKhach()
        {
            BanCoKhach ban = new BanCoKhach();
            int i = 0;
            ban.MaBan = txtMaBan.Text;
            string soban = bancokhach.laySoBan(txtMaBan.Text);
            Int32.TryParse(soban, out i);
            ban.SoBan = i;
            return ban;
        }

        private CTOder getCTOder()
        {
            CTOder ct = new CTOder();

            string maMon = ctorder.layMaMon(txtMaOder.Text);
            int i = 0;
            ct.MaMon = maMon;
            i = int.Parse(txtMaOder.Text);
            ct.MaOder = i;
            string dvt = "";
            dvt = ctorder.layDVT(maMon);
            ct.MaBan = txtMaBan.Text;
            ct.DonViTinh = dvt;
            ct.SoLuong = 0;
            return ct;
        }

        private HoaDon getHD()
        {
            HoaDon hd = new HoaDon();
            hd.MaBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text, out i);
            hd.MaOder = i;
            hd.Ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
            return hd;
        }

        //private CTHoaDon getCTHD()
        //{
            //CTHoaDon cthd = new CTHoaDon();
            //CTOder ct = getCTOder();
            //int i = 0;
            //int maOder = int.Parse(txtMaOder.Text);
            //Int32.TryParse(cthoadon.layMaHD(maOder), out i);
            //cthd.MaHD = i;
            //cthd.MaMon = ct.MaMon;
            //cthd.TenMon = cthoadon.layTenMon(ct.MaMon);
            //string soLuong = txtSoLuong.Text;
            //int sl = 0;
            //Int32.TryParse(soLuong, out sl);
            //cthd.SoLuong = sl;
            //string dg = cthoadon.
            //float j = 0;
            //float.TryParse(dg, out j);
            //cthd.DonGia = j;
            //cthd.ThanhTien = cthd.SoLuong * cthd.DonGia;
            //return cthd;
        //}

        private DoanhThu getDoanhThu()
        {
            DoanhThu dt = new DoanhThu();
            dt.Ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
            dt.Tong = 0;
            return dt;
        }

        private BanSDNhieu getBanSDNhieu()
        {
            BanSDNhieu bsd = new BanSDNhieu();
            bsd.MaBan = txtMaBan.Text;
            int i = 0;
            string soban = bansd.laySoBan(txtMaBan.Text);
            Int32.TryParse(soban, out i);
            bsd.SoBan = i;
            bsd.LuotSD = 0;
            return bsd;
        }

        private CTDoanhThu getCTDoanhThu()
        {
            CTDoanhThu ct = new CTDoanhThu();
            CTOder ctod = getCTOder();
            ct.Ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
            ct.MaMon = ctod.MaMon;
            ct.SoLuong = 0;
            string dongia = ctdoanhthu.layDonGia(ct.MaMon);
            float i = 0;
            float.TryParse(dongia, out i);
            ct.TongTien = ct.SoLuong * i;
            return ct;
        }
        #endregion
    }
}
