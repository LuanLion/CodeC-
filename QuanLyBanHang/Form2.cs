using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            this.txtpassword.Clear();
            this.txtUser.Clear();
            this.txtUser.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show( "BẠN CÓ CHẮC THOÁT", "THÔNG BÁO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK) Application.Exit();
        }

        private void tbnDangnhap_Click(object sender, EventArgs e)
        {
            if (this.txtUser.Text == "teonv" && this.txtpassword.Text == "123")
                using (Form form = new Form1())
                {
                    form.ShowDialog();
                }
            else
            {
                MessageBox.Show("ĐĂNG NHẬP KHÔNG ĐÚNG", "THÔNG BÁO");
                this.txtUser.Focus();
            }
            
        }
    }
}
