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
    public partial class Form5 : Form
    {
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtTable
        SqlDataAdapter daKhachHang = null;
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtKhachHang = null;
        string strConnectionString = @"Data Source=DESKTOPOFLUAN\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        // Đối tượng kết nối
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        // Đối tượng đưa dữ liệu vào DataTable dtThanhPho
        SqlDataAdapter daThanhPho = null;
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtThanhPho = null;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                // Khởi động connection
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu lên DataTable dtThanhPho
                daKhachHang = new SqlDataAdapter("SELECT * FROM KhachHang", conn);
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                daKhachHang.Fill(dtKhachHang);
                // Khởi động connection
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu vào DataTable dtThanhPho
                daThanhPho = new SqlDataAdapter("SELECT * FROM THANHPHO", conn);
                dtThanhPho = new DataTable();
                dtThanhPho.Clear();
                daThanhPho.Fill(dtThanhPho);
                // Đưa dữ liệu lên DataGridView
                dgvKhachHang.DataSource = dtKhachHang;
                // Đưa dữ liệu lên ComboBox trong DataGridView
                this.comboThanhPho.DataSource = dtThanhPho;
                this.comboThanhPho.DisplayMember = "TenThanhPho";
                this.comboThanhPho.ValueMember = "ThanhPho";
                // Vận chuyển dữ liệu vào DataTable dtKhachHang
                daKhachHang = new SqlDataAdapter("SELECT * FROM KHACHHANG", conn);
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                daKhachHang.Fill(dtKhachHang);
                // Thay đổi độ rộng cột
                dgvKhachHang.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtKhachHang.ResetText();
                this.txtCty.ResetText();
                this.txtDiaChi.ResetText();
                this.txtDienThoai.ResetText();
                this.comboThanhPho.ResetText();
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
                MessageBox.Show("Không lấy được nội dung trong table Khachhang.Lỗi rồi!!!");
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtKhachHang.ResetText();
            this.txtCty.ResetText();
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();
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

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            throw new NotImplementedException();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtKhachHang.Dispose();
            dtKhachHang = null;
            // Hủy kết nối
            conn = null;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtKhachHang.ResetText();
            this.txtCty.ResetText();
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();
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
            this.txtKhachHang.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            // Thứ tự dòng hiện hành
            int r = dgvKhachHang.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtKhachHang.Text =
            dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            this.txtCty.Text =
            dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString();
            this.txtDienThoai.Text = dgvKhachHang.Rows[r].Cells[4].Value.ToString();
            this.comboThanhPho.Text = dgvKhachHang.Rows[r].Cells[4].Value.ToString();
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
            this.txtKhachHang.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                // Thực hiện lệnh
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                // Lấy thứ tự record hiện hành
                int r = dgvKhachHang.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strTHANHPHO =
                dgvKhachHang.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                cmd.CommandText = System.String.Concat("Delete From KhachHang Where MaKH = '" + strTHANHPHO + "'");
                cmd.CommandType = CommandType.Text;
                // Thực hiện câu lệnh SQL
                cmd.ExecuteNonQuery();
                // Cập nhật lại DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã xóa xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
            // Đóng kết nối
            conn.Close();
        }
    }
}
