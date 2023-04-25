using BTL_HSK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HSK
{
    public partial class formChiTietHoaDon : Form
    {
        public formChiTietHoaDon()
        {
            InitializeComponent();
        }

        string connectionSTR = "Data Source=DESKTOP-MJ5FCO6;Initial Catalog=Thuoc;Integrated Security=True";
        private void formChiTietHoaDon_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.HoaDon";
            string queryThuoc = "SELECT * FROM dbo.Thuoc";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // mở kết nối
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // dùng datatable để load dữ liệu của SqlDataReader
                DataTable table = new DataTable();
                table.Load(reader);
                cbMaHD.DataSource = table;
                cbMaHD.DisplayMember = "sMaHD";
                cbMaHD.ValueMember = "sMaHD";

                connection.Close();
            }

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // mở kết nối
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // dùng datatable để load dữ liệu của SqlDataReader
                DataTable table = new DataTable();
                table.Load(reader);
                cbMaHDSearch.DataSource = table;
                cbMaHDSearch.DisplayMember = "sMaHD";
                cbMaHDSearch.ValueMember = "sMaHD";

                connection.Close();
            }

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // mở kết nối
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // dùng datatable để load dữ liệu của SqlDataReader
                DataTable table = new DataTable();
                table.Load(reader);
                cbMaHDIn.DataSource = table;
                cbMaHDIn.DisplayMember = "sMaHD";
                cbMaHDIn.ValueMember = "sMaHD";

                connection.Close();
            }

            cbMaHDSearch.SelectedIndex = -1;


            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // mở kết nối
                connection.Open();

                SqlCommand command = new SqlCommand(queryThuoc, connection);
                SqlDataReader reader = command.ExecuteReader();

                // dùng datatable để load dữ liệu của SqlDataReader
                DataTable table = new DataTable();
                table.Load(reader);
                cbMaThuoc.DataSource = table;
                cbMaThuoc.DisplayMember = "sMaThuoc";
                cbMaThuoc.ValueMember = "sMaThuoc";


                

                // đóng kết nối
                connection.Close();


            }

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // mở kết nối
                connection.Open();

                SqlCommand command = new SqlCommand(queryThuoc, connection);
                SqlDataReader reader = command.ExecuteReader();

                // dùng datatable để load dữ liệu của SqlDataReader
                DataTable table = new DataTable();
                table.Load(reader);
                cbMaThuocSearch.DataSource = table;
                cbMaThuocSearch.DisplayMember = "sMaThuoc";
                cbMaThuocSearch.ValueMember = "sMaThuoc";

                // đóng kết nối
                connection.Close();


            }

            cbMaThuocSearch.SelectedIndex = -1;

            txbMucGiamGia_TextChanged(sender, e);
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkCTHDTonTai() == false)
                {
                    if (ThemCTHD() > 0)
                    {
                        MessageBox.Show("thêm dữ liệu thành công");
                        btnXem_Click_1(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("thêm dữ liệu không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Chi tiết hóa đơn muốn thêm đã tồn tại ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("đã xảy ra lỗi trong quá trình thêm dữ liệu");

            }


        }


        public int ThemCTHD()
        {
            string proc = "prThemCTHD";
            int i;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandText = proc;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@sMaHD", cbMaHD.SelectedValue);
                command.Parameters.AddWithValue("@sMaThuoc", cbMaThuoc.SelectedValue);
                command.Parameters.AddWithValue("@fDonGia", Convert.ToDouble(txbDonGia.Text));
                command.Parameters.AddWithValue("@iSoLuongMua", Convert.ToInt32(txbSoLuong.Text));
                command.Parameters.AddWithValue("@fMucGiamGia", Convert.ToDouble(txbMucGiamGia.Text));

                i = command.ExecuteNonQuery();

                connection.Close();


            }

            return i;



        }


        public bool checkCTHDTonTai()
        {
            string proc = "prCheckCTHDTonTai";
            int i;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandText = proc;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@sMaHD", cbMaHD.SelectedValue);
                command.Parameters.AddWithValue("@sMaThuoc", cbMaThuoc.SelectedValue);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    i = 1;
                }
                else
                {
                    i = 0;
                }

                connection.Close();


            }

            return i > 0;
        }




        private void btnXem_Click_1(object sender, EventArgs e)
        {
            string querySelect = "SELECT * FROM ChiTietHoaDon";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(querySelect, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dtgvCTHD.DataSource = table;

                connection.Close();
            }
        }

        private void txbDonGia_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else if (txbDonGia.Text.Contains(",") && e.KeyChar == ',')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txbSoLuong_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txbMucGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else if (txbMucGiamGia.Text.Contains(",") && e.KeyChar == ',')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txbMucGiamGia_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbSoLuong.Text) || string.IsNullOrEmpty(txbDonGia.Text) || string.IsNullOrEmpty(txbMucGiamGia.Text))
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
            }
        }

        private void dtgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgvCTHD.CurrentRow.Index;

            cbMaHD.SelectedValue = dtgvCTHD.Rows[index].Cells[0].Value;
            cbMaThuoc.SelectedValue = dtgvCTHD.Rows[index].Cells[1].Value;
            txbDonGia.Text = dtgvCTHD.Rows[index].Cells[2].Value.ToString();
            txbSoLuong.Text = dtgvCTHD.Rows[index].Cells[3].Value.ToString();
            txbMucGiamGia.Text = dtgvCTHD.Rows[index].Cells[4].Value.ToString();

            cbMaHD.Enabled = false;
            cbMaThuoc.Enabled = false;

        }

        public bool XoaCTHD()
        {
            string proc = "prXoaCTHD";
            int i;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandText = proc;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@sMaHD", cbMaHD.SelectedValue);
                command.Parameters.AddWithValue("@sMaThuoc", cbMaThuoc.SelectedValue);

                i = command.ExecuteNonQuery();

                connection.Close();


            }

            return i > 0;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (XoaCTHD() == true)
                {
                    MessageBox.Show("xóa dữ liệu thành công");
                    btnXem_Click_1(sender, e);
                }
                else
                {
                    MessageBox.Show("xóa dữ liệu không thành công");
                }

                cbMaHD.Enabled = true;
                cbMaThuoc.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("đã xảy ra lỗi khi xóa dữ liệu");
            }
        }

        public bool SuaCTHD()
        {
            

            string proc = "prSuaCTHD";
            int i;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandText = proc;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@sMaHD", cbMaHD.SelectedValue);
                command.Parameters.AddWithValue("@sMaThuoc", cbMaThuoc.SelectedValue);
                command.Parameters.AddWithValue("@fDonGia", Convert.ToDouble(txbDonGia.Text));
                command.Parameters.AddWithValue("@iSoLuongMua", Convert.ToInt32(txbSoLuong.Text));
                command.Parameters.AddWithValue("@fMucGiamGia", Convert.ToDouble(txbMucGiamGia.Text));

                i = command.ExecuteNonQuery();

                connection.Close();


            }
            return i > 0;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (SuaCTHD() == true)
                {
                    MessageBox.Show("sửa dữ liệu thành công");
                    btnXem_Click_1(sender, e);
                }
                else
                {
                    MessageBox.Show("sửa dữ liệu không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("đã xảy ra lỗi trong quá trình sửa dữ liệu");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string filterMaHD = cbMaHDSearch.Text;
            string filterThuoc = cbMaThuocSearch.Text.Trim();

            DataView dtv = new DataView(CTHD());
            if (string.IsNullOrEmpty(filterMaHD) && string.IsNullOrEmpty(filterThuoc))
            {
                MessageBox.Show("hãy điền ít nhất 1 thông tin để tìm kiếm");
            }
            else
            {

                if (string.IsNullOrEmpty(filterMaHD))
                {
                    dtv.RowFilter = "sMaThuoc LIKE '%" + filterThuoc + "%'";
                }
                if (string.IsNullOrEmpty(filterThuoc))
                {
                    dtv.RowFilter = "sMaHD LIKE '%" + filterMaHD + "%'";
                }
                if (!string.IsNullOrEmpty(filterMaHD) && !string.IsNullOrEmpty(filterThuoc))
                {
                    dtv.RowFilter = "sMaHD LIKE '%" + filterMaHD + "%' and sMaThuoc like '%" + filterThuoc + "%'";

                }

                if (dtv.Count == 0)
                {
                    MessageBox.Show("không tìm thấy chi tiết hóa đơn");
                }
                else
                {
                    dtgvCTHD.DataSource = dtv;
                    dtgvCTHD.Refresh();
                }
            }
            cbMaThuocSearch.SelectedIndex = -1;
            cbMaHDSearch.SelectedIndex = -1;
        }
        public DataTable CTHD()
        {

            string query = "SELECT * FROM dbo.ChiTietHoaDon";

            DataTable dt = new DataTable();


            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

                connection.Close();
            }

            return dt;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command = connection.CreateCommand();
                    command.CommandText = "prSelectCTHD";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@sMaHD", cbMaHDIn.SelectedValue.ToString());

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // gán vào report
                    rptChiTietHoaDon baocao = new rptChiTietHoaDon();
                    baocao.SetDataSource(table);
                    // hiển thị báo cáo
                    InBaoCao inBaoCao = new InBaoCao();
                    inBaoCao.crystalReportViewer1.ReportSource = baocao;
                    inBaoCao.ShowDialog();

                    connection.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Chương trình in xảy ra lỗi", "Thông báo");
            }
        }
    }
}
