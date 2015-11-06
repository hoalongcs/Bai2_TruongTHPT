﻿using System;
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
    public partial class Hoc_Sinh : Form
    {
        public Hoc_Sinh()
        {
            InitializeComponent();
        }

        HocSinh hs = new HocSinh();
        int chon;

        public void KhoiTao()
        {
            txtMa_HS.Enabled = txtHoTen_HS.Enabled = txtPhuHuynh.Enabled = txtTK_HS.Enabled = cbGT_HS.Enabled = cbLop.Enabled = cbTK_HS.Enabled = dtpNgaySinh_HS.Enabled = txtDiaChi.Enabled = false;
            btnThem_HS.Enabled = btnSua_HS.Enabled = btnXoa_HS.Enabled = btnTK_HS.Enabled = true;
            btnLuu_HS.Enabled = false;
        }

        public void Mo()
        {
            txtMa_HS.Enabled = txtHoTen_HS.Enabled = txtPhuHuynh.Enabled = txtTK_HS.Enabled = cbGT_HS.Enabled = cbLop.Enabled = cbTK_HS.Enabled = dtpNgaySinh_HS.Enabled = txtDiaChi.Enabled = true;
            btnThem_HS.Enabled = btnSua_HS.Enabled = btnXoa_HS.Enabled = btnTK_HS.Enabled = false;
            btnLuu_HS.Enabled = true;
        }

        public void SetNull()
        {
            txtMa_HS.Text = txtHoTen_HS.Text = txtDiaChi.Text = txtPhuHuynh.Text = cbGT_HS.Text = cbLop.Text = cbTK_HS.Text = txtTK_HS.Text = "";
            dtpNgaySinh_HS.Text = DateTime.Now.ToShortDateString();
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMa_HS.Text = dgvHocSinh.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen_HS.Text = dgvHocSinh.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbGT_HS.Text = dgvHocSinh.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgaySinh_HS.Text = dgvHocSinh.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvHocSinh.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPhuHuynh.Text = dgvHocSinh.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbLop.Text = dgvHocSinh.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            { }
        }

        private void btnSua_HS_Click(object sender, EventArgs e)
        {
            Mo();
            SetNull();
            btnTK_HS.Enabled = txtTK_HS.Enabled = cbTK_HS.Enabled = true;
            txtMa_HS.Enabled = false;
            chon = 1;
        }

        private void btnXoa_HS_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa học sinh này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                hs.Xoa_HS(txtMa_HS.Text);
                MessageBox.Show("Xóa thành công!");
                Hoc_Sinh_Load (sender, e);
                SetNull();
            }
        }

        private void btnLuu_HS_Click(object sender, EventArgs e)
        {
            if(chon ==1)
            {
                if (txtHoTen_HS.Text == "" || cbGT_HS.Text == "" || txtDiaChi.Text == "" || txtPhuHuynh.Text == "" || cbLop.Text == "" || dtpNgaySinh_HS.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa học sinh này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        hs.Sua_HS(txtMa_HS.Text, txtHoTen_HS.Text, cbGT_HS.Text, dtpNgaySinh_HS.Text, txtDiaChi.Text, txtPhuHuynh.Text, cbLop.Text);
                        MessageBox.Show("Sửa thành công!");
                        SetNull();
                        Hoc_Sinh_Load(sender, e);
                    }
                } 
            }

        }

        private void Hoc_Sinh_Load(object sender, EventArgs e)
        {
            KhoiTao();
            dgvHocSinh.DataSource = hs.Show();

            cbLop.DataSource = hs.LayThongTinLop();
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
            cbLop.SelectedValue = "MaLop";
            chon = 0;
        }
    }
}
