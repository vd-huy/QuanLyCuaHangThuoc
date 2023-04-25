using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BTL_HSK
{
    public partial class FormThuoc : Form
    {
        public FormThuoc()
        {
            InitializeComponent();

        }
        string connectionSTR = "Data Source=DESKTOP-MJ5FCO6;Initial Catalog=Thuoc;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            txbMaThuoc.Focus();

            string queryNhaCungCap = "SELECT * FROM vvNhaCungCap";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // mở kết nối
                connection.Open();

                SqlCommand command = new SqlCommand(queryNhaCungCap, connection);
                SqlDataReader reader = command.ExecuteReader();

                // dùng datatable để load dữ liệu của SqlDataReader
                DataTable table = new DataTable();
                table.Load(reader);
                cbMaNCC.DataSource = table;
                cbMaNCC.DisplayMember = "sMaKH";
                cbMaNCC.ValueMember = "sMaKH";

                cbMaNCCSearch.DataSource = table;
                cbMaNCCSearch.DisplayMember = "sMaKH";
                cbMaNCCSearch.ValueMember = "sMaKH";

                // đóng kết nối
                connection.Close();


            }

            txbMaThuoc_TextChanged(sender, e);

            cbMaNCCSearch.SelectedIndex = -1;



        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectThuoc = "SELECT * FROM vvSelectThuoc";

                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    // mở kết nối
                    connection.Open();

                    SqlCommand command = new SqlCommand(SelectThuoc, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable tableThuoc = new DataTable();

                    adapter.Fill(tableThuoc);
                    dtgvThuoc.DataSource = tableThuoc;

                    // đóng kết nối
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chương trình lỗi", "thông báo");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (KiemTraMaThuocTonTai() == false)
                {
                    if (ThemDuLieuThuoc() > 0)
                    {
                        MessageBox.Show("them du lieu thanh cong");
                        btnXem_Click(sender, e);

                        txbMaThuoc.Clear();
                        txbTenThuoc.Clear();
                        txbSoLuong.Clear();
                        txbDonGia.Clear();
                    }
                    else
                    {
                        MessageBox.Show("them du lieu khong thanh cong");
                    }
                }
                else MessageBox.Show("Ma thuoc da ton tai");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chương trình lỗi", "thông báo");
            }



        }

        public int ThemDuLieuThuoc()
        {
            string procThemThuoc = "prThemThuoc";
            int i = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // mở kết nối
                connection.Open();



                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandText = procThemThuoc;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@sMaThuoc", txbMaThuoc.Text);
                command.Parameters.AddWithValue("@sTenThuoc", txbTenThuoc.Text);
                command.Parameters.AddWithValue("@sMaNCC", cbMaNCC.SelectedValue);
                command.Parameters.AddWithValue("@dHanSuDung", dtpHSD.Value);
                command.Parameters.AddWithValue("@iSoLuong", Convert.ToInt32(txbSoLuong.Text));
                command.Parameters.AddWithValue("@fDonGia", Convert.ToDouble(txbDonGia.Text));

                // trả về số dữ liệu được insert vào bảng 
                i = command.ExecuteNonQuery();

                // đóng kết nối
                connection.Close();

            }

            return i;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XoaThuocTheoMa(dtgvThuoc))
            {
                MessageBox.Show("xoa du lieu thanh cong");
                btnXem_Click(sender, e);
            }
            else
            {
                MessageBox.Show("xoa du lieu khong thanh cong");
            }
        }

        public bool XoaThuocTheoMa(DataGridView data)
        {
            string procXoaID = "prXoaTheoMaThuoc";
            bool check;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                int i = 0;
                connection.Open();
                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandText = procXoaID;
                command.CommandType = CommandType.StoredProcedure;

                string MaThuoc = data.SelectedCells[0].OwningRow.Cells["Mã Thuốc"].Value.ToString();
                command.Parameters.AddWithValue("@sMaThuoc", MaThuoc);

                if (CheckXoaThuoc() == false)
                {
                    i = command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Ma thuoc muon xoa ton tai trong bang ChiTietHoaDon");
                }
                check = (i > 0);

            }

            return check;

        }

        // kiểm tra xem mã muốn xóa có phải khóa ngoại của các bảng khác không
        public bool CheckXoaThuoc()
        {
            bool check = false;
            string query = "checkKhoaNgoaiThuoc";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = query;

                command.Parameters.AddWithValue("@sMaThuoc", txbMaThuoc.Text);

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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (SuaDuLieuThuoc())
                {
                    txbMaThuoc.ReadOnly = false;
                    MessageBox.Show("cap nhat du lieu thanh cong");
                    btnXem_Click(sender, e);

                    txbMaThuoc.Clear();
                    txbTenThuoc.Clear();
                    txbSoLuong.Clear();
                    txbDonGia.Clear();
                }
                else
                {
                    MessageBox.Show("cap nhat du lieu khong thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chương trình lỗi", "thông báo");
            }

        }

        // khi bấm vào ô muốn sửa dữ liệu thì tất cả dữ liệu của bản ghi sẽ hiện lên ở các textbox combobox 
        private void dtgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dtgvThuoc.CurrentRow.Index;

                txbMaThuoc.Text = dtgvThuoc.Rows[index].Cells[0].Value.ToString();
                txbTenThuoc.Text = dtgvThuoc.Rows[index].Cells[1].Value.ToString();
                cbMaNCC.SelectedValue = dtgvThuoc.Rows[index].Cells[2].Value;
                dtpHSD.Text = dtgvThuoc.Rows[index].Cells[3].Value.ToString();
                txbSoLuong.Text = dtgvThuoc.Rows[index].Cells[4].Value.ToString();
                txbDonGia.Text = dtgvThuoc.Rows[index].Cells[5].Value.ToString();

                txbMaThuoc.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("vui lòng bấm vào ô có dữ liệu", "thông báo");
            }


        }


        public bool SuaDuLieuThuoc()
        {
            string procSuaThuoc = "prSuaThuoc";
            int i;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandText = procSuaThuoc;
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.AddWithValue("@sMaThuoc", txbMaThuoc.Text);
                command.Parameters.AddWithValue("@sTenThuoc", txbTenThuoc.Text);
                command.Parameters.AddWithValue("@sMaNCC", cbMaNCC.SelectedValue);
                command.Parameters.AddWithValue("@dHanSuDung", dtpHSD.Value);
                command.Parameters.AddWithValue("@iSoLuong", Convert.ToInt32(txbSoLuong.Text));
                command.Parameters.AddWithValue("@fDonGia", Convert.ToDouble(txbDonGia.Text));




                i = command.ExecuteNonQuery();

                connection.Close();

            }

            return (i > 0);
        }

        private void txbDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // hàm được nhập số và . vào textbox
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

        private void txbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // hàm chỉ được nhập số vào textbox
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txbMaThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // hàm chỉ được nhập số và chữ trong textbox
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbTenThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // hàm chỉ đươc nhập chữ vào textbox
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        public bool KiemTraMaThuocTonTai()
        {
            string checkMaThuoc = "checkMaThuoc ";
            bool check;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // mở kết nối
                connection.Open();

                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandText = checkMaThuoc;
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@sMaThuoc", txbMaThuoc.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    check = true;
                }
                else check = false;
                // đóng kết nối
                connection.Close();

            }

            return check;

        }



        private void txbMaThuoc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbMaThuoc.Text))
            {

                errorProvider1.SetError(txbMaThuoc, "Vui lòng nhập giá trị vào ô này");
                //e.Cancel = true;
            }
            else
            {

                errorProvider1.SetError(txbMaThuoc, "");
            }
        }

        private void txbMaThuoc_TextChanged(object sender, EventArgs e)
        {
            // kiểm tra nếu ít nhất 1 trong 4 textbox không có dữ liệu thì vô hiệu hóa các nút button
            if (string.IsNullOrEmpty(txbMaThuoc.Text) ||
                string.IsNullOrEmpty(txbTenThuoc.Text) ||
                string.IsNullOrEmpty(txbSoLuong.Text) ||
                string.IsNullOrEmpty(txbDonGia.Text))
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

        public DataTable SelectThuoc()
        {
            string SelectThuoc = "SELECT * FROM Thuoc";

            DataTable tableThuoc = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // mở kết nối
                connection.Open();

                SqlCommand command = new SqlCommand(SelectThuoc, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(tableThuoc);



                // đóng kết nối
                connection.Close();

            }

            
                return tableThuoc;
            


        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string filterMaThuoc = txbMaThuocSearch.Text;
            string filterTenThuoc = txbTenThuocSearch.Text;
            string fiterMaNCC = cbMaNCCSearch.Text;


            DataView dtv = new DataView(SelectThuoc());
            if (string.IsNullOrEmpty(filterMaThuoc) && string.IsNullOrEmpty(filterTenThuoc) && string.IsNullOrEmpty(fiterMaNCC))
            {
                 MessageBox.Show("hãy điền ít nhất 1 thông tin để tìm kiếm");
            }
            else
            {
                if (string.IsNullOrEmpty(filterMaThuoc))
                {
                    dtv.RowFilter = "sTenThuoc LIKE '%" + filterTenThuoc + "%' and sMaNCC like '%" + fiterMaNCC + "%'";
                }
                if (string.IsNullOrEmpty(filterTenThuoc))
                {
                    dtv.RowFilter = "sMaThuoc LIKE '%" + filterMaThuoc + "%' and sMaNCC like '%" + fiterMaNCC + "%'";
                }
                if (string.IsNullOrEmpty(filterMaThuoc) && string.IsNullOrEmpty(filterTenThuoc))
                {
                    dtv.RowFilter = "sMaNCC LIKE '%" + fiterMaNCC + "%'";
                }
                if (!string.IsNullOrEmpty(filterMaThuoc) && !string.IsNullOrEmpty(filterTenThuoc))
                {
                    dtv.RowFilter = "sTenThuoc LIKE '%" + filterTenThuoc + "%' and sMaThuoc like '%" + filterMaThuoc + "%' and sMaNCC like '%" + fiterMaNCC + "%'";
                }

                if (dtv.Count == 0)
                {
                    MessageBox.Show("không tìm thấy thuốc");
                }
                else
                {
                    dtgvThuoc.DataSource = dtv;
                    dtgvThuoc.Refresh();
                    

                }
            }

            

            cbMaNCCSearch.SelectedIndex = -1;
            txbMaThuocSearch.Clear();
            txbTenThuocSearch.Clear();
        }

        private void btnInDS_Click(object sender, EventArgs e)
        {
            try
            {
                
                    using (SqlConnection connection = new SqlConnection(connectionSTR))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand();
                        command = connection.CreateCommand();
                        command.CommandText = "prSelectThuoc";
                        command.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // gán vào report
                        rptThuoc baocao = new rptThuoc();
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
