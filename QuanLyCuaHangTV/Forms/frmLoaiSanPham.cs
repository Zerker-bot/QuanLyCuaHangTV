using Microsoft.EntityFrameworkCore;
using QuanLyCuaHangTV.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyCuaHangTV.Forms
{

    public partial class frmLoaiSanPham : Form
    {
        QLCHTVDbContext context = new QLCHTVDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id;
        private bool isComboBoxInitialized = false;
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;

            btnHuyBo.Enabled = giaTri;
            txtTenLoai.Enabled = giaTri;

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
        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {

            tuychinhDataGridView();
            BatTatChucNang(false);
            SetPlaceholder(txtTimKiem, "Tìm kiếm");
            List<LoaiSanPham> lsp = new List<LoaiSanPham>();
            lsp = context.LoaiSanPham.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lsp;

            txtTenLoai.DataBindings.Clear();
            txtTenLoai.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenLoai.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Xác nhận xóa loại sản phẩm?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                LoaiSanPham lsp = context.LoaiSanPham.Find(id);
                if (lsp != null)
                {
                    context.LoaiSanPham.Remove(lsp);
                }
                context.SaveChanges();

                frmLoaiSanPham_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    LoaiSanPham lsp = new LoaiSanPham();
                    lsp.TenLoai = txtTenLoai.Text;
                    context.LoaiSanPham.Add(lsp);

                    context.SaveChanges();
                }
                else
                {
                    LoaiSanPham lsp = context.LoaiSanPham.Find(id);
                    if (lsp != null)
                    {
                        lsp.TenLoai = txtTenLoai.Text;
                        context.LoaiSanPham.Update(lsp);

                        context.SaveChanges();
                    }
                }

                frmLoaiSanPham_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham_Load(sender, e);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TimKiem(string tuKhoa)
        {

            using (var context = new QLCHTVDbContext())
            {
                List<LoaiSanPham> ketQua;

                // Nếu không có từ khóa hoặc placeholder "Tìm Kiếm" → lấy toàn bộ khách hàng
                if (string.IsNullOrWhiteSpace(tuKhoa) || tuKhoa == "Tìm kiếm")
                {
                    ketQua = context.LoaiSanPham.ToList();
                }
                else
                {
                    ketQua = new List<LoaiSanPham>();
                    ketQua = context.LoaiSanPham
                     .Where(nv => EF.Functions.Collate(nv.TenLoai, "Latin1_General_CI_AI").Contains(tuKhoa))
                        .ToList();
                }

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = ketQua;
                dataGridView.DataSource = bindingSource;

                // Cập nhật lại các TextBox với dòng được chọn
                if (ketQua.Count > 0)
                {
                    // Gán lại các DataBindings cho TextBox
                    txtTenLoai.DataBindings.Clear();
                    txtTenLoai.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);

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
