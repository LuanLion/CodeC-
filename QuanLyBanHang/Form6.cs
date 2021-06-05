using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanHang
{
    public partial class Form6 : Form
    {
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtTable
        SqlDataAdapter daNhanVien = null;
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtNhanVien = null;
        string strConnectionString = @"Data Source=DESKTOPOFLUAN\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        // Đối tượng kết nối
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        public Form6()
        {
            InitializeComponent();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtTen.ResetText();
            this.txtMaNV.ResetText();
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();
            this.txtHoLot.ResetText();
            this.txtngayNV.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            // Đưa con trỏ đến TextField txtThanhPho
            this.txtMaNV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtMaNV.ResetText();
            this.txtDienThoai.ResetText();
            this.txtDiaChi.ResetText();
            this.txtHoLot.ResetText();
            this.txtTen.ResetText();
            this.txtngayNV.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.panel.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            // Thứ tự dòng hiện hành
            int r = dgvNhanVien.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaNV.Text =
            dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            this.txtHoLot.Text =
            dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            this.txtTen.Text =
            dgvNhanVien.Rows[r].Cells[2].Value.ToString();
            this.txtngayNV.Text =
            dgvNhanVien.Rows[r].Cells[4].Value.ToString();
            this.txtDiaChi.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();
            this.txtDienThoai.Text = dgvNhanVien.Rows[r].Cells[6].Value.ToString();
            
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaNV.Focus();

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {// Khởi động connection
            try { 
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển Nhan viên
            daNhanVien = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
            dtNhanVien = new DataTable();
            dtNhanVien.Clear();
            daNhanVien.Fill(dtNhanVien);
            // Đưa dữ liệu lên DataGridView
            dgvNhanVien.DataSource = dtNhanVien;
            // Vận chuyển dữ liệu vào DataTable dtKhachHang
            daNhanVien = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
            dtNhanVien = new DataTable();
            dtNhanVien.Clear();
            daNhanVien.Fill(dtNhanVien);
            // Xóa trống các đối tượng trong Panel
            this.txtMaNV.ResetText();
            this.txtHoLot.ResetText();
            this.txtTen.ResetText();
            this.txtDienThoai.ResetText();
            this.txtngayNV.ResetText();
            this.txtDiaChi.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.panel.Enabled = false;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa 
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;
        }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NhanVien.Lỗi rồi!!!");
            }
}

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtNhanVien.Dispose();
            dtNhanVien = null;
            // Hủy kết nối
            conn = null;
        }
    }
}
