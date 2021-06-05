
namespace QuanLyBanHang
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDM = new System.Windows.Forms.Label();
            this.dgvDANHMUC = new System.Windows.Forms.DataGridView();
            this.btnTrolai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDANHMUC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDM
            // 
            this.lblDM.AutoSize = true;
            this.lblDM.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDM.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDM.Location = new System.Drawing.Point(271, 18);
            this.lblDM.Name = "lblDM";
            this.lblDM.Size = new System.Drawing.Size(309, 38);
            this.lblDM.TabIndex = 1;
            this.lblDM.Text = "Danh Mục Khách Hàng";
            this.lblDM.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvDANHMUC
            // 
            this.dgvDANHMUC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDANHMUC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDANHMUC.Location = new System.Drawing.Point(175, 117);
            this.dgvDANHMUC.Name = "dgvDANHMUC";
            this.dgvDANHMUC.RowHeadersWidth = 62;
            this.dgvDANHMUC.RowTemplate.Height = 33;
            this.dgvDANHMUC.Size = new System.Drawing.Size(476, 225);
            this.dgvDANHMUC.TabIndex = 2;
            this.dgvDANHMUC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnTrolai
            // 
            this.btnTrolai.Location = new System.Drawing.Point(565, 399);
            this.btnTrolai.Name = "btnTrolai";
            this.btnTrolai.Size = new System.Drawing.Size(112, 34);
            this.btnTrolai.TabIndex = 3;
            this.btnTrolai.Text = "Trở lại";
            this.btnTrolai.UseVisualStyleBackColor = true;
            this.btnTrolai.Click += new System.EventHandler(this.btnTrolai_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTrolai);
            this.Controls.Add(this.dgvDANHMUC);
            this.Controls.Add(this.lblDM);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDANHMUC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDM;
        private System.Windows.Forms.DataGridView dgvDANHMUC;
        private System.Windows.Forms.Button btnTrolai;
    }
}