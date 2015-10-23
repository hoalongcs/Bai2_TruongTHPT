using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GiaoVien gv = new GiaoVien();
        HocSinh hs = new HocSinh();
        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tc.Visible = true;

            dgvGiaoVien.DataSource = gv.Show();
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tc.Visible = true;
            dgvHocSinh.DataSource = hs.Show();
        }
        public void DieuKhienGV(bool b)
        {
            txtHoTenGV.Enabled = txtLuong.Enabled = txtMaGV.Enabled = txtSDT.Enabled = b;
            cbGTGV.Enabled = cbMonHoc.Enabled = dtpNgaySinhGV.Enabled = b;
        }
        public void DieuKhienHS(bool b)
        {
            txtHoTen_HS.Enabled = txtMa_HS.Enabled = txtPhuHuynh.Enabled  = b;
            cbGT_HS.Enabled = cbNgaySinh_HS.Enabled = cbLop.Enabled = b;
        }
    }
}
