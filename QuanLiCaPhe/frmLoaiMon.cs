using DTO_QLCP;
using QuanLiCaPhe.LoaiMonService;
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
    public partial class frmLoaiMon : Form
    {
        LoaiMonServiceClient loaimon = new LoaiMonServiceClient();
        public frmLoaiMon()
        {
            InitializeComponent();
        }
        public void LoadLoaiMon()
        {
            DataTable dt = new DataTable();
            dt = loaimon.GetLoaiMon();
            dataGridViewLoaiMon.DataSource = dt;
        }
        private void frmLoaiMon_Load(object sender, EventArgs e)
        {
            LoadLoaiMon();
        }
        private LoaiMon GetDataLoaiMon()
        {
            LoaiMon lm = new LoaiMon();
            lm.MaLoaiMon = txtMaLoaiMon.Text;
            lm.TenLoaiMon = txtTenLoaiMon.Text;
            return lm;
        }
        private void clearbin()
        {
            txtMaLoaiMon.DataBindings.Clear();
            txtTenLoaiMon.DataBindings.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoaiMon lm = GetDataLoaiMon();
            if(txtMaLoaiMon.Text == "" || txtTenLoaiMon.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin");
            }
            else
            {
                if(loaimon.KiemTraLoaiMon(txtMaLoaiMon.Text) == false)
                {
                    if(loaimon.ThemLoaiMon(lm)==true)
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
                    MessageBox.Show("Đã Có Loại Món : " + txtMaLoaiMon.Text + " Trong Danh Sách !!");
                }
            }
            LoadLoaiMon();
            clearbin();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoaiMon lm = GetDataLoaiMon();
            if (txtMaLoaiMon.Text == "" || txtTenLoaiMon.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin");
            }
            else
            {
                if (loaimon.KiemTraLoaiMon(txtMaLoaiMon.Text) == true)
                {
                    if (loaimon.SuaLoaiMon(lm) == true)
                    {
                        MessageBox.Show("Sửa Thành Công !!");
                    }
                    else
                    {
                        MessageBox.Show("Sửa Không Thành Công !!");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa Có Loại Món : " + txtMaLoaiMon.Text + " Trong Danh Sách !!");
                }
            }
            LoadLoaiMon();
            clearbin();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LoaiMon lm = GetDataLoaiMon();
            if (MessageBox.Show("Bạn có chắc muốn xóa loại món này?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (loaimon.XoaLoaiMon(lm))
                    MessageBox.Show("Xóa thành công");
                else
                    MessageBox.Show("Không thể xóa");
            }
            LoadLoaiMon();
            clearbin();
        }

        private void dataGridViewLoaiMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.RowIndex;
            txtMaLoaiMon.Text = dataGridViewLoaiMon.Rows[a].Cells[0].Value.ToString();
            txtTenLoaiMon.Text = dataGridViewLoaiMon.Rows[a].Cells[1].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMonAn formmon = new frmMonAn();
            formmon.Show();
        }
    }
}
