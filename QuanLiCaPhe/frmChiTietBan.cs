using DTO_QLCP;
using QuanLiCaPhe.BanCoKhachService;
using QuanLiCaPhe.BanSDNhieuService;
using QuanLiCaPhe.CTDoanhThuService;
using QuanLiCaPhe.CTHoadonService;
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
        CTHoaDonServiceClient cthoadon = new CTHoaDonServiceClient();
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
            
            Oder od = getOder();
            HoaDon hd = getHD();
            BanCoKhach ban = getBanCoKhach();
            BanSDNhieu bsd = getBanSDNhieu();
            if (bancokhach.kiemTraBanCoKhach(ban.MaBan))
            {
                gbThongTin.Visible = true;
                dataGridViewCTOrder.Visible = true;
            }
            else
            {
                if (orderr.ThemOder(od) == false || bancokhach.ThemBanCoKhach(ban) == false)
                    MessageBox.Show("Không thể thực hiện gọi món");
                else
                {
                    gbThongTin.Visible = true;
                    dataGridViewCTOrder.Visible = true;
                }
                if (hoadon.ThemHD(hd) == false)
                    MessageBox.Show("Không thể thêm hóa đơn");
            }
            if (bansd.kiemTraTonTai(txtMaBan.Text) == false)
            {
                bsd.LuotSD = 1;
                bansd.ThemBanSDNhieu(bsd);
            }
            else
            {
                int i = int.Parse(txtMaOder.Text);
                if (ctorder.kiemTraGoiMon(i) == false)
                {
                    string luotsd = bansd.layLuotSD(txtMaBan.Text);
                    int lsd = 0;
                    Int32.TryParse(luotsd, out lsd);
                    int luotsddung = lsd + 1;
                    bsd.LuotSD = luotsddung;
                    bansd.SuaLuotSD(bsd);
                }
            }
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
            bindSource.DataSource = ctorder.GetCTOrder(maBan);
            clearbin();
            dataGridViewCTOrder.DataSource = bindSource;
            txtMaOder.DataBindings.Add("Text", bindSource, "MaOder");
        }
        private void binData()
        {
            BindingSource bindSource = new BindingSource();
            string maBan = txtMaBan.Text;
            bindSource.DataSource = ctorder.GetCTOrder(maBan);
            clearbin();
            //txtMaOder.DataBindings.Add("Text", bindSource, "MaOder");
            dataGridViewCTOrder.DataSource = bindSource;
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

            string maMon = cmbMon.SelectedValue.ToString() ;
            int i = 0;
            ct.MaMon = maMon;
            i = int.Parse(txtMaOder.Text);
            ct.MaOder = i;
            string dvt ;
            dvt = ctorder.layDVT(maMon);
            ct.MaBan = txtMaBan.Text;
            ct.DonViTinh = dvt;
            ct.SoLuong = 0;
            //ct.SoLuong = Convert.ToInt32(txtSoLuong.Text);
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

        private CTHoaDon getCTHD()
        {
            CTHoaDon cthd = new CTHoaDon();
            CTOder ct = getCTOder();
            int i = 0;
            int maOder = int.Parse(txtMaOder.Text);
            Int32.TryParse(cthoadon.layMaHD(maOder), out i);
            cthd.MaHD = i;
            cthd.MaMon = cmbMon.SelectedValue.ToString();
            cthd.TenMon = cthoadon.layTenMon(cmbMon.SelectedValue.ToString());
            string soLuong = txtSoLuong.Text;
            int sl = 0;
            Int32.TryParse(soLuong, out sl);
            cthd.SoLuong = sl;
            string dg = cthoadon.layDonGia(cmbMon.SelectedValue.ToString());
            float j = 0;
            float.TryParse(dg, out j);
            cthd.DonGia = j;
            cthd.ThanhTien = cthd.SoLuong * cthd.DonGia;
            return cthd;
        }

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
            ct.MaMon = cmbMon.SelectedValue.ToString() ;
            ct.SoLuong = 0;
            string dongia = ctdoanhthu.layDonGia(ct.MaMon);
            float i = 0;
            float.TryParse(dongia, out i);
            ct.TongTien = ct.SoLuong * i;
            return ct;
        }


        #endregion

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            gbThongTin.Visible = true;
            dataGridViewCTOrder.Visible = true;
            BanCoKhach bck = getBanCoKhach();
            Oder od = getOder();
            CTOder ctod = getCTOder();
            int i = 0;
            Int32.TryParse(txtMaOder.Text, out i);
            ctod.MaOder = i;
            //gbChonNhom.Visible = false;
            btnHoaDon.Visible = true;
            bancokhach.XoaBanCoKhach(bck);
            ctorder.XoaCTOder(ctod);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmReportHD report;
            report = new frmReportHD(txtMaOder.Text, txtMaBan.Text);
            report.Show();
            this.Close();
        }

        private void btnBoMon_Click(object sender, EventArgs e)
        {
            CTOder ct = getCTOder();
            CTHoaDon cthd = getCTHD();
            CTDoanhThu ctdt = getCTDoanhThu();
            if (cmbMon.Text == "")
                MessageBox.Show("Vui lòng chọn món muốn bỏ!");
            else
            {
                string sl = ctorder.laySLMon(cmbMon.SelectedValue.ToString(), txtMaBan.Text);
                int i = 0;
                i = int.Parse(sl);
                int slc = int.Parse(txtSoLuong.Text);
                if (i > 1)
                {
                    ct.SoLuong = slc - 1;
                    cthd.SoLuong = slc - 1;
                    ct.MaOder = int.Parse(txtMaOder.Text);
                    ct.MaMon = cmbMon.SelectedValue.ToString();
                    cthd.MaMon = cmbMon.SelectedValue.ToString();
                    if (ctorder.NhapSoLuong(ct) == false)
                        MessageBox.Show("Không thể bỏ món");
                    if (cthoadon.SuaCTHD(cthd) == false)
                        MessageBox.Show("Không thể bỏ món trong hóa đơn");
                }
                else
                {
                    ct.MaMon = cmbMon.SelectedValue.ToString();
                    cthd.MaMon = cmbMon.SelectedValue.ToString();
                    ct.MaBan = txtMaBan.Text;
                    if (ctorder.XoaMon(ct) && cthoadon.XoaMon(cthd))
                        MessageBox.Show("Đã xóa món");
                    else
                        MessageBox.Show("Không thể xóa món");
                }
            }
            ctdt.MaMon = cmbMon.SelectedValue.ToString();
            int slb = 0;
            string slban = ctdoanhthu.laySLBan(ctdt.MaMon);
            Int32.TryParse(slban, out slb);
            ctdt.SoLuong = slb - 1;
            string dongia = ctdoanhthu.layDonGia(ctdt.MaMon);
            float dg = 0;
            float.TryParse(dongia, out dg);
            ctdt.TongTien = ctdt.SoLuong * dg;
            ctdoanhthu.SuaCTDoanhThu(ctdt);
            binData();
            gbSoLuong.Visible = false;
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            gbThongTin.Visible = true;
            dataGridViewCTOrder.Visible = true;
            int i = 0;
            Int32.TryParse(txtMaOder.Text, out i);
            if (ctorder.kiemTraGoiMon(i) == false)
                MessageBox.Show("Bàn " + txtMaBan.Text + " chưa có khách nên không cần chuyển.");
            else
            {
                gbChuyenBan.Visible = true;
            }
        }

        private void btnOKChuyen_Click(object sender, EventArgs e)
        {
            gbChuyenBan.Visible = false;
            BanCoKhach bck = getBanCoKhach();
            Oder od = getOder();
            CTOder ctod = getCTOder();
            HoaDon hd = getHD();
            int maod = 0;
            Int32.TryParse(txtMaOder.Text, out maod);
            int soban = 0;
            Int32.TryParse(txtBanChuyen.Text, out soban);
            string maban = orderr.layMaBan(soban);
            od.MaBan = maban;
            ctod.MaBan = maban;
            hd.MaBan = maban;
            bck.MaBan = txtMaBan.Text;
            bancokhach.XoaBanCoKhach(bck);
            bck.MaBan = maban;
            if (bancokhach.ThemBanCoKhach(bck) && orderr.ChuyenBan(od) && ctorder.ChuyenBan(ctod) && hoadon.ChuyenBan(hd))
                MessageBox.Show("Đã chuyển bàn");
            BanSDNhieu bsd1 = getBanSDNhieu();
            BanSDNhieu bsd2 = new BanSDNhieu();
            bsd2.MaBan = txtBanChuyen.Text;
            string soban2 = bansd.laySoBan(txtBanChuyen.Text);
            int sb2 = 0;
            Int32.TryParse(soban2, out sb2);
            bsd2.SoBan = sb2;
            string luotsd2 = bansd.layLuotSD(txtBanChuyen.Text);
            int lsd2 = 0;
            Int32.TryParse(luotsd2, out lsd2);
            int luotsddung2 = lsd2 + 1;
            bsd2.LuotSD = luotsddung2;
            bansd.SuaLuotSD(bsd2);

            string luotsd1 = bansd.layLuotSD(txtMaBan.Text);
            int lsd1 = 0;
            Int32.TryParse(luotsd1, out lsd1);
            int luotsddung1 = lsd1 + 1;
            bsd1.LuotSD = luotsddung1;
            bansd.SuaLuotSD(bsd1);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (gbThongTin.Visible == false && dataGridViewCTOrder.Visible == false)
            {
                this.Close();
                frmSoDoChinh formchinh = new frmSoDoChinh();
                formchinh.Show();
            }
            else
            {
                frmSoDoChinh SoDoChinh = new frmSoDoChinh();
                string maban = txtMaBan.Text;
                //FromSoDoChinh = new frmSoDoChinh();
                BanCoKhach bck = getBanCoKhach();
                Oder od = getOder();
                CTOder ctod = getCTOder();
                HoaDon hd = getHD();
                CTHoaDon cthd = getCTHD();
                BanSDNhieu bsd = getBanSDNhieu();
                bck.MaBan = txtMaBan.Text;
                int i = int.Parse(txtMaOder.Text);
                od.MaOder = i;
                hd.MaOder = i;
                string maHD = hoadon.layMaHD(i);
                int mahd = 0;
                Int32.TryParse(maHD, out mahd);
                string luotsd = bansd.layLuotSD(txtMaBan.Text);
                int lsd = 0;
                Int32.TryParse(luotsd, out lsd);
                if (ctorder.kiemTraGoiMon(i) == false)
                {
                    hoadon.XoaHD(hd);
                    bancokhach.XoaBanCoKhach(bck);
                    orderr.XoaOder(od);
                    int luotsddung = lsd - 1;
                    bsd.LuotSD = luotsddung;
                    bansd.SuaLuotSD(bsd);
                }
                this.Close();
                SoDoChinh.Show();
            }
        }

        private void cmbMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = false;
            CTOder ct = getCTOder();
            CTHoaDon cthd = getCTHD();
            DoanhThu dt = getDoanhThu();
            CTDoanhThu ctdt = getCTDoanhThu();
            int i = 0;
            i = int.Parse(txtSoLuong.Text);
            ct.SoLuong = i;
            cthd.SoLuong = i;
            dt.Ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
            ctdt.Ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
            if (doanhthu.kiemTraTonTaiDT(dt.Ngay) == false)
                doanhthu.ThemDoanhThu(dt);
            if (ctdoanhthu.kiemTraTonTaiCTDT(ctdt.MaMon, ctdt.Ngay) == false)
            {
                ctdt.SoLuong = i;
                string dongia = ctdoanhthu.layDonGia(ctdt.MaMon);
                float dg = 0;
                float.TryParse(dongia, out dg);
                ctdt.TongTien = ctdt.SoLuong * dg;
                ctdoanhthu.ThemCTDoanhThu(ctdt);
            }

            if (cthoadon.kiemTraMonHD(cthd.MaHD, cthd.MaMon))
            {
                cthoadon.SuaCTHD(cthd);
                float dthu = 0;
                string doanhthuu = doanhthu.layDoanhThu(Convert.ToDateTime(dtNgay.Value.ToShortDateString()));
                float.TryParse(doanhthuu, out dthu);
                dt.Tong = dthu + (cthd.SoLuong * cthd.DonGia);
                doanhthu.SuaDoanhThu(dt);

                int slb = 0;
                string slban = ctdoanhthu.laySLBan(ct.MaMon);
                Int32.TryParse(slban, out slb);
                int slc = 0;
                string slcon = ctdoanhthu.laySLMonCu(ctdt.MaMon, txtMaBan.Text);
                Int32.TryParse(slcon, out i);
                ctdt.SoLuong = (slb + i) - slc;
                string dongia = ctdoanhthu.layDonGia(ctdt.MaMon);
                float dg = 0;
                float.TryParse(dongia, out dg);
                ctdt.TongTien = ctdt.SoLuong * dg;
                ctdoanhthu.SuaCTDoanhThu(ctdt);
            }
            else
            {
                if (cthoadon.ThemCTHD(cthd) == false)
                    MessageBox.Show("Không thể thêm chi tiết vào hóa đơn");
                float dthu = 0;
                string doanhthuu = doanhthu.layDoanhThu(Convert.ToDateTime(dtNgay.Value.ToShortDateString()));
                float.TryParse(doanhthuu, out dthu);
                dt.Tong = dthu + (cthd.SoLuong * cthd.DonGia);
                doanhthu.SuaDoanhThu(dt);

                int slb = 0;
                string slban = ctdoanhthu.laySLBan(ct.MaMon);
                Int32.TryParse(slban, out slb);
                ctdt.SoLuong = slb + i;
                string dongia = ctdoanhthu.layDonGia(ctdt.MaMon);
                float dg = 0;
                float.TryParse(dongia, out dg);
                ctdt.TongTien = ctdt.SoLuong * dg;
                ctdoanhthu.SuaCTDoanhThu(ctdt);
            }
            if (ctorder.ThemCTOder(ct) == false)
                MessageBox.Show("Không thể thêm số lượng");
            txtSoLuong.Text = "";
            binData();
        }

        private void dataGridViewCTOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbSoLuong.Visible = true;
            int a = e.RowIndex;
            txtMaBan.Text = dataGridViewCTOrder.Rows[a].Cells[1].Value.ToString();
            txtMaOder.Text = dataGridViewCTOrder.Rows[a].Cells[0].Value.ToString();
            cmbMon.Text = dataGridViewCTOrder.Rows[a].Cells[2].Value.ToString();
            txtSoLuong.Text = dataGridViewCTOrder.Rows[a].Cells[3].Value.ToString();
        }
    }
}
