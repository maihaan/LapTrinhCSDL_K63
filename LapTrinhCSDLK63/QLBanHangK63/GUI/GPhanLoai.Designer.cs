
namespace QLBanHangK63.GUI
{
    partial class GPhanLoai
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.btThemMoi = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phân loại";
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(16, 85);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(283, 23);
            this.tbMa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên phân loại";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(16, 146);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(283, 23);
            this.tbTen.TabIndex = 3;
            // 
            // btThemMoi
            // 
            this.btThemMoi.Location = new System.Drawing.Point(17, 187);
            this.btThemMoi.Name = "btThemMoi";
            this.btThemMoi.Size = new System.Drawing.Size(90, 30);
            this.btThemMoi.TabIndex = 4;
            this.btThemMoi.Text = "Thêm mới";
            this.btThemMoi.UseVisualStyleBackColor = true;
            this.btThemMoi.Click += new System.EventHandler(this.btThemMoi_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(113, 187);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(90, 30);
            this.btCapNhat.TabIndex = 5;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(209, 187);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(90, 30);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(320, 16);
            this.dgvDanhSach.MultiSelect = false;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(502, 516);
            this.dgvDanhSach.TabIndex = 7;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "QUẢN LÝ PHÂN LOẠI HÀNG";
            // 
            // GPhanLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btThemMoi);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(850, 583);
            this.MinimumSize = new System.Drawing.Size(850, 583);
            this.Name = "GPhanLoai";
            this.Text = "Quản lý phân loại Hàng";
            this.Load += new System.EventHandler(this.GPhanLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Button btThemMoi;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Label label3;
    }
}