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

namespace QuanLyBanHang
{
    public partial class Ketnoicsdl : Form

    {
        string strConnectionString = @"Data Source=DESKTOPOFLUAN\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        // Đối tượng kết nối
        
        public Ketnoicsdl()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
          /*  try
            {
                // Khởi động connection
                SqlConnection conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu lên DataTable dtThanhPho
                daThanhPho = new SqlDataAdapter("SELECT * FROM THANHPHO", conn);
                dtThanhPho = new DataTable();
                dtThanhPho.Clear();
                daThanhPho.Fill(dtThanhPho);
                // Đưa dữ liệu lên ListBox
                this.lstThanhPho.DataSource = dtThanhPho;
                this.lstThanhPho.DisplayMember = "TenThanhPho";
                this.lstThanhPho.ValueMember = "ThanhPho";
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO.Lỗi rồi!!!");
            }*/

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            }
    }
}
