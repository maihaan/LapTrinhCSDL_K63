using QLBanHangK63.Controller;
using QLBanHangK63.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBanHangK63.GUI
{
    public partial class GPhanLoai : Form
    {
        public GPhanLoai()
        {
            InitializeComponent();
        }

        private void GPhanLoai_Load(object sender, EventArgs e)
        {
            // Doc danh sach phan loai len giao dien
            DocDS();
        }

        private void DocDS()
        {
            CPhanLoai c = new CPhanLoai();
            List<MPhanLoai> ds = c.SelectListByTen("");
            if (ds != null && ds.Count > 0)
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("TT", typeof(int));
                tb.Columns.Add("Mã", typeof(String));
                tb.Columns.Add("Tên", typeof(String));
                tb.Columns.Add("ID", typeof(int));
                int tt = 0;
                foreach(MPhanLoai m in ds)
                {
                    tt++;
                    DataRow r = tb.NewRow();
                    r["TT"] = tt;
                    r["ID"] = m.ID;
                    r["Mã"] = m.Ma;
                    r["Tên"] = m.Ten;
                    tb.Rows.Add(r);
                }
                dgvDanhSach.DataSource = tb;
                dgvDanhSach.Columns["ID"].Visible = false;
                dgvDanhSach.Columns["TT"].Width = 50;
                dgvDanhSach.Columns["Mã"].Width = 150;
            }
            else
                dgvDanhSach.DataSource = null;
        }

        private void btThemMoi_Click(object sender, EventArgs e)
        {
            if(tbMa.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                tbMa.Focus();
                return;
            }

            if (tbTen.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên phân loại!");
                tbTen.Focus();
                return;
            }

            CPhanLoai c = new CPhanLoai();
            int dem = c.Insert(tbMa.Text, tbTen.Text);
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn nhập vào đã tồn tại, bạn phải sử dụng mã khác!");
                tbMa.Focus();
                return;
            }
            else
            {
                tbMa.Text = "";
                tbTen.Text = "";
                tbMa.Focus();
                DocDS();
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvDanhSach.Rows[e.RowIndex];
            tbMa.Text = r.Cells["Mã"].Value.ToString();
            tbTen.Text = r.Cells["Tên"].Value.ToString();            
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (tbMa.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                tbMa.Focus();
                return;
            }

            if (tbTen.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên phân loại!");
                tbTen.Focus();
                return;
            }

            DataGridViewRow r = dgvDanhSach.SelectedRows[0];
            CPhanLoai c = new CPhanLoai();
            int dem = c.UpdateByMa(r.Cells["Mã"].Value.ToString(), tbTen.Text);
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn yêu cầu cập nhật không tồn tại!");
                tbMa.Focus();
                return;
            }
            else
            {
                tbMa.Text = "";
                tbTen.Text = "";
                tbMa.Focus();
                DocDS();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (tbMa.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                tbMa.Focus();
                return;
            }

            if (tbTen.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên phân loại!");
                tbTen.Focus();
                return;
            }

            DataGridViewRow r = dgvDanhSach.SelectedRows[0];
            CPhanLoai c = new CPhanLoai();
            int dem = c.DeleteByMa(r.Cells["Mã"].Value.ToString());
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn yêu cầu Xóa không tồn tại!");
                tbMa.Focus();
                return;
            }
            else
            {
                tbMa.Text = "";
                tbTen.Text = "";
                tbMa.Focus();
                DocDS();
            }
        }
    }
}
