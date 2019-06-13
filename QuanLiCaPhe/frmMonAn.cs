using DTO_QLCP;
using QuanLiCaPhe.LoaiMonService;
using QuanLiCaPhe.MonAnService;
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
    public partial class frmMonAn : Form
    {
        MonAnServiceClient monan = new MonAnServiceClient();
        LoaiMonServiceClient loaimon = new LoaiMonServiceClient();

        public frmMonAn()
        {
            InitializeComponent();
        }
        public void LoadMonAn()
        {
            DataTable dt = new DataTable();
            dt = monan.getDSMon();
            dataGridViewMonAn.DataSource = dt;
        }
        private void frmMonAn_Load(object sender, EventArgs e)
        {
            LoadMonAn();
            //Load dl lên combobox : 
            DataTable data = new DataTable();
            data = loaimon.GetLoaiMon();
            cmbMaLoaiMon.DataSource = data;
            cmbMaLoaiMon.DisplayMember = "TenLoaiMon";
            cmbMaLoaiMon.ValueMember = "MaLoaiMon";

        }
        private MonAn GetDSMon()
        {
            MonAn ma = new MonAn();
            ma.MaMon = txtMaMon.Text;
            ma.TenMon = txtTenMon.Text;
            ma.MaLoaiMon = cmbMaLoaiMon.SelectedValue.ToString();
            ma.DonGia = txtdonGia.Text;
            ma.DonViTinh = txtDonViTinh.Text;
            return ma;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoaiMon formloai = new frmLoaiMon();
            formloai.Show();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MonAn ma = GetDSMon();
            if(txtMaMon.Text == ""||txtTenMon.Text ==""||txtdonGia.Text==""||txtDonViTinh.Text=="")
            {
                MessageBox.Show("Bạn Hãy Nhập Đủ Thông Tin !!");
            }
            else
            {
                if(monan.KiemTraMon(txtMaMon.Text) == false)
                {
                    if(monan.ThemMon(ma) == true)
                    {
                        MessageBox.Show("Thêm Thành Công !!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Không Thành Công !!");
                    }
                }
                else
                {
                    MessageBox.Show("Đã Có Món : " + txtMaMon.Text + " Trong Hệ Thống !!");
                }
            }
            LoadMonAn();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MonAn ma = GetDSMon();
            if (txtMaMon.Text == "" || txtTenMon.Text == "" || txtdonGia.Text == "" || txtDonViTinh.Text == "")
            {
                MessageBox.Show("Bạn Hãy Nhập Đủ Thông Tin !!");
            }
            else
            {
                if (monan.KiemTraMon(txtMaMon.Text) == true)
                {
                    if (monan.SuaMon(ma) == true)
                    {
                        MessageBox.Show("Thêm Thành Công !!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Không Thành Công !!");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa Có Món : " + txtMaMon.Text + " Trong Hệ Thống !!");
                }
            }
            LoadMonAn();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MonAn ma = GetDSMon();
            if (MessageBox.Show("Bạn có chắc muốn xóa loại món này?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (monan.XoaMon(ma))
                    MessageBox.Show("Xóa thành công");
                else
                    MessageBox.Show("Không thể xóa");
            }
            LoadMonAn();
        }

        private void dataGridViewMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.RowIndex;
            txtMaMon.Text = dataGridViewMonAn.Rows[a].Cells[0].Value.ToString();
            txtTenMon.Text = dataGridViewMonAn.Rows[a].Cells[1].Value.ToString();
            cmbMaLoaiMon.Text = dataGridViewMonAn.Rows[a].Cells[2].Value.ToString();
            txtdonGia.Text = dataGridViewMonAn.Rows[a].Cells[3].Value.ToString();
            txtDonViTinh.Text = dataGridViewMonAn.Rows[a].Cells[4].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            //string maBan;
            //frmChiTietBan formchitiet = new frmChiTietBan(maBan);
            //formchitiet.Show();
        }
    }
}
