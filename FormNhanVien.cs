using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HSK
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        string connectionSTR = "Data Source=DESKTOP-MJ5FCO6;Initial Catalog=Thuoc;Integrated Security=True";

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            txbMaNV_TextChanged(sender, e);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string querySelect = "SELECT * FROM vvSelectNV";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(querySelect, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dtgvNhanVien.DataSource = table;

                connection.Close();
            }
        }

        private void txbMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbLuongCoBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else if (txbLuongCoBan.Text.Contains(",") && e.KeyChar == ',')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }


        private void txbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txbPhuCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else if (txbPhuCap.Text.Contains(",") && e.KeyChar == ',')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txbMaNV_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbMaNV.Text) || string.IsNullOrEmpty(txbTenNV.Text) || string.IsNullOrEmpty(txbLuongCoBan.Text) || string.IsNullOrEmpty(txbDiaChi.Text) || string.IsNullOrEmpty(txbSDT.Text) || string.IsNullOrEmpty(txbPhuCap.Text))
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private bool ThemNhanVien()
        {
            int i = 0;
            string prThemNhanVien = "prThemNhanVien";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand Command = new SqlCommand();
                Command = connection.CreateCommand();
                Command.CommandText = prThemNhanVien;
                Command.CommandType = CommandType.StoredProcedure;

                Command.Parameters.AddWithValue("@sMaNV", txbMaNV.Text);
                Command.Parameters.AddWithValue("@sTenNV", txbTenNV.Text);

                if (rbNam.Checked)
                {
                    Command.Parameters.AddWithValue("@bGioiTinh", true);
                }
                else
                {
                    Command.Parameters.AddWithValue("@bGioiTinh", false);

                }
                Command.Parameters.AddWithValue("@sDiaChi", txbDiaChi.Text);
                Command.Parameters.AddWithValue("@sDienThoai", txbSDT.Text);
                Command.Parameters.AddWithValue("@dNgaySinh", dtpNgaySinh.Value);
                Command.Parameters.AddWithValue("@fLuongCoBan", Convert.ToDouble(txbLuongCoBan.Text));
                Command.Parameters.AddWithValue("@fPhuCap", Convert.ToDouble(txbPhuCap.Text));

                i = Command.ExecuteNonQuery();
                connection.Close();
            }


            return (i > 0);
        }

        public bool KiemTraNVTonTai()
        {
            bool check = false;
            string query = "CheckNhanVien";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = query;

                command.Parameters.AddWithValue("@sMaNV", txbMaNV.Text);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }

                connection.Close();
            }
            return check;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraNVTonTai() == false)
            {
                if (ThemNhanVien())
                {
                    MessageBox.Show("them du lieu thanh cong");
                    btnXem_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("them khong du lieu thanh cong");
                }
            }
            else
            {
                MessageBox.Show("Ma nhan vien da ton tai");
            }

        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dtgvNhanVien.CurrentRow.Index;

                txbMaNV.Text = dtgvNhanVien.Rows[index].Cells[0].Value.ToString();
                txbMaNV.ReadOnly = true;
                txbTenNV.Text = dtgvNhanVien.Rows[index].Cells[1].Value.ToString();
                bool GioiTinh = Convert.ToBoolean(dtgvNhanVien.Rows[index].Cells[2].Value);
                if (GioiTinh == false)
                {
                    rbNu.Checked = true;
                }
                else
                {
                    rbNam.Checked = true;
                }
                txbDiaChi.Text = dtgvNhanVien.Rows[index].Cells[3].Value.ToString();
                txbSDT.Text = dtgvNhanVien.Rows[index].Cells[4].Value.ToString();
                dtpNgaySinh.Text = dtgvNhanVien.Rows[index].Cells[5].Value.ToString();
                txbLuongCoBan.Text = dtgvNhanVien.Rows[index].Cells[6].Value.ToString();
                txbPhuCap.Text = dtgvNhanVien.Rows[index].Cells[7].Value.ToString();
            }
            catch
            {
                MessageBox.Show("vui lòng bấm vào ô có dữ liệu", "thông báo");
            }


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (SuaNhanVien())
                {
                    txbMaNV.ReadOnly = false;
                    MessageBox.Show("cap nhat du lieu thanh cong");
                    btnXem_Click(sender, e);

                    txbMaNV.Clear();
                    txbTenNV.Clear();
                    txbDiaChi.Clear();
                    txbSDT.Clear();
                    txbPhuCap.Clear();
                    txbLuongCoBan.Clear();
                    dtpNgaySinh.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("cap nhat du lieu khong thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("sửa dữ liệu không thành công");
            }


        }

        public bool SuaNhanVien()
        {
            string procSuaThuoc = "prSuaNhanVien";
            int i;


            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandText = procSuaThuoc;
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.AddWithValue("@sMaNV", txbMaNV.Text);
                command.Parameters.AddWithValue("@sTenNV", txbTenNV.Text);
                if (rbNam.Checked)
                {
                    command.Parameters.AddWithValue("@bGioiTinh", true);
                }
                else
                {
                    command.Parameters.AddWithValue("@bGioiTinh", false);

                }
                command.Parameters.AddWithValue("@sDiaChi", txbDiaChi.Text);
                command.Parameters.AddWithValue("@sDienThoai", txbSDT.Text);
                command.Parameters.AddWithValue("@dNgaySinh", dtpNgaySinh.Value);
                command.Parameters.AddWithValue("@fPhuCap", Convert.ToDouble(txbPhuCap.Text));
                command.Parameters.AddWithValue("@fLuongCoBan", Convert.ToDouble(txbLuongCoBan.Text));

                i = command.ExecuteNonQuery();

                connection.Close();
            }




            return (i > 0);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkMaNVTrongHoaDon())
                {
                    MessageBox.Show("Mã nhân viên muốn xóa đã tồn tại trong hóa đơn");
                }
                else
                {
                    if (XoaNhanVien())
                    {
                        MessageBox.Show("xóa dữ liệu thành công");
                        btnXem_Click(sender, e);

                        txbMaNV.Clear();
                        txbTenNV.Clear();
                        txbDiaChi.Clear();
                        txbSDT.Clear();
                        txbPhuCap.Clear();
                        txbLuongCoBan.Clear();
                        dtpNgaySinh.Value = DateTime.Now;

                    }
                    else
                    {
                        MessageBox.Show("xóa dữ liệu không thành công");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("xóa dữ liệu không thành công");
            }


        }

        public bool XoaNhanVien()
        {
            int i = 0;

            string prXoaNhanVien = "prXoaNhanVien";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandText = prXoaNhanVien;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@sMaNV", txbMaNV.Text);

                i = command.ExecuteNonQuery();

                connection.Close();
            }

            return i > 0;
        }

        public bool checkMaNVTrongHoaDon()
        {
            string checkMaNVTrongHoaDon = "checkMaNVTrongHoaDon";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandText = checkMaNVTrongHoaDon;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@sMaNV", txbMaNV.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                connection.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string filterMaNV = txbMaNVSearch.Text;
            string filterTenNV = txbTenNVSearch.Text;
            string fiterSDT = txbSDTSearch.Text;


            DataView dtv = new DataView(SelectNV());
            if (string.IsNullOrEmpty(filterMaNV) && string.IsNullOrEmpty(filterTenNV) && string.IsNullOrEmpty(fiterSDT))
            {
                MessageBox.Show("hãy điền ít nhất 1 thông tin để tìm kiếm");
            }
            else
            {
                if (string.IsNullOrEmpty(filterMaNV))
                {
                    dtv.RowFilter = "sTenNV LIKE '%" + filterTenNV + "%' and sDienThoai like '%" + fiterSDT + "%'";
                }
                if (string.IsNullOrEmpty(filterTenNV))
                {
                    dtv.RowFilter = "sMaNV LIKE '%" + filterMaNV + "%' and sDienThoai like '%" + fiterSDT + "%'";
                }
                if (string.IsNullOrEmpty(fiterSDT))
                {
                    dtv.RowFilter = "sTenNV LIKE '%" + filterTenNV + "%' and sMaNV like '%" + filterMaNV + "%'";
                }
                if (string.IsNullOrEmpty(filterMaNV) && string.IsNullOrEmpty(filterTenNV))
                {
                    dtv.RowFilter = "sDienThoai LIKE '%" + fiterSDT + "%'";
                }
                if (!string.IsNullOrEmpty(filterMaNV) && !string.IsNullOrEmpty(filterTenNV) && !string.IsNullOrEmpty(fiterSDT))
                {
                    dtv.RowFilter = "sTenNV LIKE '%" + filterTenNV + "%' and sMaNV like '%" + filterMaNV + "%' and sDienThoai like '%" + fiterSDT + "%'";
                }

                if (dtv.Count == 0)
                {
                    MessageBox.Show("không tìm thấy nhân viên");
                }
                else
                {
                    dtgvNhanVien.DataSource = dtv;
                    dtgvNhanVien.Refresh();
                }

            }

            txbTenNVSearch.Clear();
            txbMaNVSearch.Clear();
            txbSDTSearch.Clear();
        }

        public DataTable SelectNV()
        {
            string SelectNV = "SELECT * FROM NhanVien";

            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // mở kết nối
                connection.Open();

                SqlCommand command = new SqlCommand(SelectNV, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(table);


                // đóng kết nối
                connection.Close();




            }
            return table;

        }

        private void btnInNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command = connection.CreateCommand();
                    command.CommandText = "prSelectNhanVien";
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // gán vào report
                    rptNhanVien baocao = new rptNhanVien();
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
