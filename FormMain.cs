using BTL_HSK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HSK
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormThuoc formThuoc= new FormThuoc();
            formThuoc.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormNhanVien formNhanVien = new FormNhanVien();
            formNhanVien.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            formChiTietHoaDon chiTietHoaDon = new formChiTietHoaDon();
            chiTietHoaDon.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            //KhachHang khach = new KhachHang();
            //khach.ShowDialog();
        }
    }
}
