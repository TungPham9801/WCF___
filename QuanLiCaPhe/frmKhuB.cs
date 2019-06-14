using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_QLCP;
using DTO_QLCP;
using QuanLiCaPhe.BanCoKhachService;
using QuanLiCaPhe.CTOrderService;
using QuanLiCaPhe.OrderService;

namespace QuanLiCaPhe
{  
    public partial class frmKhuB : Form
    {
        BanCoKhachServiceClient bancokhach = new BanCoKhachServiceClient();
        OrderServiceClient order = new OrderServiceClient();
        CTOrderServiceClient ctorder = new CTOrderServiceClient();
        public frmKhuB()
        {
            InitializeComponent();
        }

        private void btnSoDoChinh_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSoDoChinh FromSoDoChinh;
            FromSoDoChinh = new frmSoDoChinh();
            FromSoDoChinh.Show();
        }

        private void btnBan31_Click(object sender, EventArgs e)
        {
            int i = 31;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan32_Click(object sender, EventArgs e)
        {
            int i = 32;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan33_Click(object sender, EventArgs e)
        {
            int i = 33;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan34_Click(object sender, EventArgs e)
        {
            int i = 34;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan35_Click(object sender, EventArgs e)
        {
            int i = 35;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void tbnBan36_Click(object sender, EventArgs e)
        {
            int i = 36;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan37_Click(object sender, EventArgs e)
        {
            int i = 37;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan38_Click(object sender, EventArgs e)
        {
            int i = 38;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan39_Click(object sender, EventArgs e)
        {
            int i = 39;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan40_Click(object sender, EventArgs e)
        {
            int i = 40;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan41_Click(object sender, EventArgs e)
        {
            int i = 41;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan42_Click(object sender, EventArgs e)
        {
            int i = 42;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan43_Click(object sender, EventArgs e)
        {
            int i = 43;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan44_Click(object sender, EventArgs e)
        {
            int i = 44;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan45_Click(object sender, EventArgs e)
        {
            int i = 45;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan46_Click(object sender, EventArgs e)
        {
            int i = 46;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan47_Click(object sender, EventArgs e)
        {
            int i = 47;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan48_Click(object sender, EventArgs e)
        {
            int i = 48;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan49_Click(object sender, EventArgs e)
        {
            int i = 49;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan50_Click(object sender, EventArgs e)
        {
            int i = 50;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan51_Click(object sender, EventArgs e)
        {
            int i = 51;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan52_Click(object sender, EventArgs e)
        {
            int i = 52;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan53_Click(object sender, EventArgs e)
        {
            int i = 53;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan54_Click(object sender, EventArgs e)
        {
            int i = 54;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan55_Click(object sender, EventArgs e)
        {
            int i = 55;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan56_Click(object sender, EventArgs e)
        {
            int i = 56;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan57_Click(object sender, EventArgs e)
        {
            int i = 57;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan58_Click(object sender, EventArgs e)
        {
            int i = 58;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan59_Click(object sender, EventArgs e)
        {
            int i = 59;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void btnBan60_Click(object sender, EventArgs e)
        {
            int i = 60;
            string maBan = order.layMaBan(i);
            this.Close();
            frmChiTietBan FromCTBan;
            FromCTBan = new frmChiTietBan(maBan);
            FromCTBan.Show();
        }

        private void frmKhuB_Load(object sender, EventArgs e)
        {
            if (bancokhach.kiemTraBanCoKhach("B31"))
                btnBan31.Text = "31(CK)";
            else
                btnBan31.Text = "BÀN 31";

            if (bancokhach.kiemTraBanCoKhach("B32"))
                btnBan32.Text = "32(CK)";
            else
                btnBan32.Text = "BÀN 32";

            if (bancokhach.kiemTraBanCoKhach("B33"))
                btnBan33.Text = "33(CK)";
            else
                btnBan33.Text = "BÀN 33";

            if (bancokhach.kiemTraBanCoKhach("B34"))
                btnBan34.Text = "34(CK)";
            else
                btnBan34.Text = "BÀN 34";

            if (bancokhach.kiemTraBanCoKhach("B35"))
                btnBan35.Text = "35(CK)";
            else
                btnBan35.Text = "BÀN 35";

            if (bancokhach.kiemTraBanCoKhach("B36"))
                btnBan36.Text = "36(CK)";
            else
                btnBan36.Text = "BÀN 36";

            if (bancokhach.kiemTraBanCoKhach("B37"))
                btnBan37.Text = "37(CK)";
            else
                btnBan37.Text = "BÀN 37";

            if (bancokhach.kiemTraBanCoKhach("B38"))
                btnBan38.Text = "38(CK)";
            else
                btnBan38.Text = "BÀN 38";

            if (bancokhach.kiemTraBanCoKhach("B39"))
                btnBan39.Text = "39(CK)";
            else
                btnBan39.Text = "BÀN 39";

            if (bancokhach.kiemTraBanCoKhach("B40"))
                btnBan40.Text = "40(CK)";
            else
                btnBan40.Text = "BÀN 40";

            if (bancokhach.kiemTraBanCoKhach("B41"))
                btnBan41.Text = "41(CK)";
            else
                btnBan41.Text = "BÀN 41";

            if (bancokhach.kiemTraBanCoKhach("B42"))
                btnBan42.Text = "42(CK)";
            else
                btnBan42.Text = "BÀN 42";

            if (bancokhach.kiemTraBanCoKhach("B43"))
                btnBan43.Text = "43(CK)";
            else
                btnBan43.Text = "BÀN 43";

            if (bancokhach.kiemTraBanCoKhach("B44"))
                btnBan44.Text = "44(CK)";
            else
                btnBan44.Text = "BÀN 44";

            if (bancokhach.kiemTraBanCoKhach("B45"))
                btnBan45.Text = "45(CK)";
            else
                btnBan45.Text = "BÀN 45";

            if (bancokhach.kiemTraBanCoKhach("B46"))
                btnBan46.Text = "46(CK)";
            else
                btnBan46.Text = "BÀN 46";

            if (bancokhach.kiemTraBanCoKhach("B47"))
                btnBan47.Text = "47(CK)";
            else
                btnBan47.Text = "BÀN 47";

            if (bancokhach.kiemTraBanCoKhach("B48"))
                btnBan48.Text = "48(CK)";
            else
                btnBan48.Text = "BÀN 48";

            if (bancokhach.kiemTraBanCoKhach("B49"))
                btnBan49.Text = "49(CK)";
            else
                btnBan49.Text = "BÀN 49";

            if (bancokhach.kiemTraBanCoKhach("B50"))
                btnBan50.Text = "50(CK)";
            else
                btnBan50.Text = "BÀN 50";

            if (bancokhach.kiemTraBanCoKhach("B51"))
                btnBan51.Text = "51(CK)";
            else
                btnBan51.Text = "BÀN 51";

            if (bancokhach.kiemTraBanCoKhach("B52"))
                btnBan52.Text = "52(CK)";
            else
                btnBan52.Text = "BÀN 52";

            if (bancokhach.kiemTraBanCoKhach("B53"))
                btnBan53.Text = "53(CK)";
            else
                btnBan53.Text = "BÀN 53";

            if (bancokhach.kiemTraBanCoKhach("B54"))
                btnBan54.Text = "54(CK)";
            else
                btnBan54.Text = "BÀN 54";

            if (bancokhach.kiemTraBanCoKhach("B55"))
                btnBan55.Text = "55(CK)";
            else
                btnBan55.Text = "BÀN 55";

            if (bancokhach.kiemTraBanCoKhach("B56"))
                btnBan56.Text = "56(CK)";
            else
                btnBan56.Text = "BÀN 56";

            if (bancokhach.kiemTraBanCoKhach("B57"))
                btnBan57.Text = "57(CK)";
            else
                btnBan57.Text = "BÀN 57";

            if (bancokhach.kiemTraBanCoKhach("B58"))
                btnBan58.Text = "58(CK)";
            else
                btnBan58.Text = "BÀN 58";

            if (bancokhach.kiemTraBanCoKhach("B59"))
                btnBan59.Text = "59(CK)";
            else
                btnBan59.Text = "BÀN 59";

            if (bancokhach.kiemTraBanCoKhach("B60"))
                btnBan60.Text = "60(CK)";
            else
                btnBan60.Text = "BÀN 60";
        }
    }
}
