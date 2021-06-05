using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form1 : Form
    {
        void XemDanhMuc(int intDanhMuc)
        {
            Form frm = new Form3();
            frm.Text = intDanhMuc.ToString();
            frm.ShowDialog();
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show( "BẠN CÓ CHẮC THOÁT","THÔNG BÁO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK) Application.Exit();
        }

        private void danhMụcThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(1);
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(2);
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(3);
        }

        private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(4);
        }

        private void danhMụcHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(5);
        }

        private void danhMụcChiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(6);
        }

        private void quảnLýDanhMụcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcThànhPhốToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = new Form4();
            form.Text = "Quản Lý Danh Mục Thành Phố";
            form.ShowDialog();
        }

        private void quảnLýDanhMụcTheoNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = new Form5();
            form.Text = "Quản Lý Danh Mục Khách Hàng";
            form.ShowDialog();
        }

        private void danhMụcNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = new Form6();
            form.ShowDialog();
            this.Close();
        }
    }
}
