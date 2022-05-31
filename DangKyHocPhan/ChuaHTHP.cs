using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace DangKyHocPhan
{
    public partial class ChuaHTHP : Form
    {
        public ChuaHTHP()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_HocKy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTruyVan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Truy Vấn Thành Công");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ChuaHTHP_Load(object sender, EventArgs e)
        {
            // Load cboHocKy
            string query = "SELECT * FROM dbo.DSHOCKY ORDER BY NamHoc DESC, HocKy DESC";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, new SqlConnection(Properties.Settings.Default.DKHPConnectionString)))
            {
                DataTable data = new DataTable();
                adapter.Fill(data);
                data.Columns.Add("HienThi", typeof(String));

                foreach (DataRow row in data.Rows)
                {
                    row["HienThi"] = ("Học kỳ " + (row["HocKy"].ToString() == "0" ? "hè" : row["HocKy"].ToString()) + " - Năm học " + row["NamHoc"].ToString());
                }

                cboHocKy.DataSource = data;
                cboHocKy.ValueMember = "MaHK";
                cboHocKy.DisplayMember = "HienThi";
            }
        }

        private void cboHocKy_DropDownClosed(object sender, EventArgs e)
        {
            string query = "select PHIEUDK.SoPhieu, sum(THUHOCPHI.SoTienThu) as [TienDaDong], Sum(CEILING(SoTiet * 1.0 / SoTinChi) * GiaTien) as [TienPhaiDong] from PHIEUDK full join THUHOCPHI on THUHOCPHI.SoPhieu = PHIEUDK.SoPhieu join DKHOCPHAN on DKHOCPHAN.SoPhieu = PHIEUDK.SoPhieu join MONHOC on MONHOC.MaMon = DKHOCPHAN.MonHoc join LOAIMON on LOAIMON.MaLoaiMon = MONHOC.LoaiMon where MaHK = @MaHK group by PHIEUDK.SoPhieu having(isnull(sum(THUHOCPHI.SoTienThu),0) < Sum(CEILING(SoTiet * 1.0 / SoTinChi) * GiaTien))";
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHK", cboHocKy.SelectedValue.ToString());
                DataTable dataTable = new DataTable();
                dataTable = new DataTable();
                connection.Open();
                dataTable.Load(command.ExecuteReader());
                connection.Close();
                dgvChuaHP.DataSource = dataTable;
            }
        }

        private void dgvChuaHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
