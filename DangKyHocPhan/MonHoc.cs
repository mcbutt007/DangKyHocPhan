﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKyHocPhan
{
    public partial class MonHoc : Form
    {
        public MonHoc(string mamh)
        {
            this.mamh = mamh;
            InitializeComponent();
        }

        private string mamh;
        private string nguoithuchien = "admin";

        private void MonHoc_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mamh))
            {
                this.Text = "Thêm mới môn học";
            }
            else
            {
                this.Text = "Cập nhật môn học";
                var r = new Database().Select("exec selectMH '" + mamh + "'");
                txtMaMon.Text = r["MaMon"].ToString();
                txtMaMon.Enabled = false;
                txtTenMon.Text = r["TenMon"].ToString();
                txtSoTiet.Text = r["SoTiet"].ToString();
                txtLoaiMon.Text = r["LoaiMon"].ToString();
            }
        }
        private void button_them_Click(object sender, EventArgs e)
        {
            try
            {
                var st = int.Parse(txtSoTiet.Text);
                if (st <= 0)
                {
                    MessageBox.Show("Số tiết phải lớn hơn 0");
                    txtSoTiet.Select();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Số tiết phải là kiểu số nguyên");
                txtSoTiet.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtMaMon.Text))
            {
                MessageBox.Show("Mã môn học không được để trống");
                txtMaMon.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtTenMon.Text))
            {
                MessageBox.Show("Tên môn học không được để trống");
                txtTenMon.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtLoaiMon.Text))
            {
                MessageBox.Show("Loại môn không được để trống");
                txtTenMon.Select();
                return;
            }


            string sql = "";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mamh))
            {
                sql = "insertMH";
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithuchien
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@mamh",
                    value = txtMaMon.Text
                });
            }
            else
            {
                lstPara.Add(new CustomParameter()
                {
                    key = "@mamh",
                    value = mamh
                });

                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithuchien
                });
                sql = "updateMH";
            }

            lstPara.Add(new CustomParameter()
            {
                key = "@tenmonhoc",
                value = txtTenMon.Text
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@sotiet",
                value = txtSoTiet.Text
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@loaimon",
                value = txtLoaiMon.Text
            });

            var rs = new Database().ExeCute(sql, lstPara);

            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mamh))
                {
                    MessageBox.Show("Thêm mới môn học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin môn học thành công");
                }

                this.Dispose();

            }
            else
            {
                MessageBox.Show("Thực hiện truy vấn thất bại");
            }
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void txtMaMon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
