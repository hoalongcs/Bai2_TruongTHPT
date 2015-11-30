using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Main
{
    public partial class QLGD : Form
    {
        public QLGD()
        {
            InitializeComponent();
        }

        MonHon mh = new MonHon();
        GiaoVien gv = new GiaoVien();
        CTGD ct = new CTGD();

        private void btnThem_Click(object sender, EventArgs e)
        {
            cboTenMon.DataSource = mh.Show();
            cboTenMon.DisplayMember = "TenMon";
            cboTenMon.ValueMember = "MaMon";
            cboTenMon.SelectedValue = "MaMon";
            cboTenMon.SelectedIndex = 0;
            //cboTenGV.DataSource = gv.Show(cboTenMon.Text);
            //cboTenGV.DisplayMember = "HoTen";
            //cboTenGV.ValueMember = "MaGV";
            //cboTenGV.SelectedValue = "MaGV";
            //cboTenGV.SelectedIndex = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QLGD_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTenLop.Text != "")
            {
                dataGridView1.DataSource = ct.Show(txtTenLop.Text);
            }
        }

        private void cboTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTenGV.DataSource = gv.Show(cboTenMon.Text);
            cboTenGV.DisplayMember = "HoTen";
            cboTenGV.ValueMember = "MaGV";
            cboTenGV.SelectedValue = "MaGV";
            if (cboTenGV.Items.Count > 0)
            {
                cboTenGV.SelectedIndex = 0;
            }
        }

        private void cboTenMon_TextChanged(object sender, EventArgs e)
        {
        }
                
    }
}
