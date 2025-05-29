using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyCuaHangTV.Data;

namespace QuanLyCuaHangTV.Forms
{

    public partial class frmHangSanXuat : Form
    {
        QLCHTVDbContext context = new QLCHTVDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id;
        public frmHangSanXuat()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenHangSanXuat.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            if (giaTri) // Nếu đang ở trạng thái "Lưu" hoặc "Hủy bỏ"
            {
                btnLuu.BackColor = System.Drawing.Color.Green;
                btnHuyBo.BackColor = System.Drawing.Color.Gray;
                btnThem.BackColor = System.Drawing.SystemColors.Control;
                btnSua.BackColor = System.Drawing.SystemColors.Control;
                btnXoa.BackColor = System.Drawing.SystemColors.Control;
            }
            else // Nếu đang ở trạng thái "Thêm", "Sửa" hoặc "Xóa"
            {
                btnLuu.BackColor = System.Drawing.SystemColors.Control;
                btnHuyBo.BackColor = System.Drawing.SystemColors.Control;
                btnThem.BackColor = System.Drawing.ColorTranslator.FromHtml("#28A745");
                btnSua.BackColor = System.Drawing.Color.Orange;
                btnXoa.BackColor = System.Drawing.ColorTranslator.FromHtml("#DC3545");
            }
        }
        public void tuychinhDataGridView()
        {
            // Màu nền tổng thể
            dataGridView.BackgroundColor = Color.White;
            dataGridView.GridColor = Color.LightGray;

            // Font đẹp
            dataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Header
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView.EnableHeadersVisualStyles = false;

            // Row style
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 220, 220);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenHangSanXuat.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa hãng sản xuất?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                HangSanXuat hsx = context.HangSanXuat.Find(id);
                if (hsx != null)
                {
                    context.HangSanXuat.Remove(hsx);
                }
                context.SaveChanges();
                frmHangSanXuat_Load(sender, e);
            }
        }

        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            tuychinhDataGridView();
            SetPlaceholder(txtTimKiem, "Tìm kiếm");
            BatTatChucNang(false);
            List<HangSanXuat> hsx = new List<HangSanXuat>();
            hsx = context.HangSanXuat.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = hsx;
            txtTenHangSanXuat.DataBindings.Clear();
            txtTenHangSanXuat.DataBindings.Add("Text", bindingSource, "TenHangSanXuat", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHangSanXuat.Text))
                MessageBox.Show("Vui lòng nhập tên hãng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    HangSanXuat hsx = new HangSanXuat();
                    hsx.TenHangSanXuat = txtTenHangSanXuat.Text;
                    context.HangSanXuat.Add(hsx);
                    context.SaveChanges();
                }
                else
                {
                    HangSanXuat hsx = context.HangSanXuat.Find(id);
                    if (hsx != null)
                    {
                        hsx.TenHangSanXuat = txtTenHangSanXuat.Text;
                        context.HangSanXuat.Update(hsx);
                        context.SaveChanges();
                    }
                }
                frmHangSanXuat_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmHangSanXuat_Load(sender, e);

        }
        private void TimKiem(string tuKhoa)
        {

            using (var context = new QLCHTVDbContext())
            {
                List<HangSanXuat> ketQua;

                // Nếu không có từ khóa hoặc placeholder "Tìm Kiếm" → lấy toàn bộ khách hàng
                if (string.IsNullOrWhiteSpace(tuKhoa) || tuKhoa == "Tìm kiếm")
                {
                    ketQua = context.HangSanXuat.ToList();
                }
                else
                {
                    ketQua = new List<HangSanXuat>();
                    ketQua = context.HangSanXuat
                     .Where(nv => EF.Functions.Collate(nv.TenHangSanXuat, "Latin1_General_CI_AI").Contains(tuKhoa))
                        .ToList();
                }

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = ketQua;
                dataGridView.DataSource = bindingSource;

                // Cập nhật lại các TextBox với dòng được chọn
                if (ketQua.Count > 0)
                {
                    // Gán lại các DataBindings cho TextBox
                    txtTenHangSanXuat.DataBindings.Clear();
                    txtTenHangSanXuat.DataBindings.Add("Text", bindingSource, "TenHangSanXuat", false, DataSourceUpdateMode.Never);

                    // Đặt lại dòng được chọn là dòng đầu tiên
                    bindingSource.Position = 0;
                }
            }

        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            TimKiem(tuKhoa);
        }
        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.ForeColor = Color.Gray;
            textBox.Text = placeholder;

            textBox.GotFocus += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    //textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    // textBox.ForeColor = Color.Gray;
                }
            };
        }
    }
}
