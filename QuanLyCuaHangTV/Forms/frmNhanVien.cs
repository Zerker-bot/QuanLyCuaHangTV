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
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;

namespace QuanLyCuaHangTV.Forms
{
    public partial class frmNhanVien : Form
    {
        QLCHTVDbContext context = new QLCHTVDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã nhân viên (dùng cho Sửa và Xóa)
        private bool isInitialized = false;
        public frmNhanVien()
        {
            InitializeComponent();
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
        private void BatTatChucNang(bool giaTri)
        {

            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;
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
        private void KhoiTaoComboBoxTimKiem()
        {
            cboTimKiem.DisplayMember = "Key";
            cboTimKiem.ValueMember = "Value";

            cboTimKiem.Items.Add(new KeyValuePair<string, string>("Họ và tên", "HoVaTen"));
            cboTimKiem.Items.Add(new KeyValuePair<string, string>("Địa chỉ", "DiaChi"));
            cboTimKiem.Items.Add(new KeyValuePair<string, string>("Số điện thoại", "SoDienThoai"));

            cboTimKiem.SelectedIndex = 0;

            cboTimKiem.SelectedIndex = 0;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {

            if (!isInitialized)
            {
                KhoiTaoComboBoxTimKiem();
                SetPlaceholder(txtTimKiem, "Tìm kiếm");
                tuychinhDataGridView();
                isInitialized = true;

            }

            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;
            List<NhanVien> nv = new List<NhanVien>();
            nv = context.NhanVien.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;
            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);
            // Tương tự đối với txtDienThoai, txtDiaChi, txtTenDangNhap
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);
            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("SelectedIndex", bindingSource, "QuyenHan", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboQuyenHan.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhân viên " + txtHoVaTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                }
                context.SaveChanges();
                frmNhanVien_Load(sender, e);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                MessageBox.Show("Vui lòng nhập tên đăng nhập?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboQuyenHan.Text))
                MessageBox.Show("Vui lòng chọn quyền hạn cho nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                        MessageBox.Show("Vui lòng nhập mật khẩu?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        NhanVien nv = new NhanVien();
                        nv.HoVaTen = txtHoVaTen.Text;
                        nv.DienThoai = txtDienThoai.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text); // Mã hóa mật khẩu
                        nv.QuyenHan = cboQuyenHan.SelectedIndex == 1;
                        context.NhanVien.Add(nv);
                        context.SaveChanges();
                    }
                }
                else
                {
                    NhanVien nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.HoVaTen = txtHoVaTen.Text;
                        nv.DienThoai = txtDienThoai.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.QuyenHan = cboQuyenHan.SelectedIndex == 1;
                        context.NhanVien.Update(nv);
                        if (string.IsNullOrEmpty(txtMatKhau.Text))
                            context.Entry(nv).Property(x => x.MatKhau).IsModified = false; // Giữ nguyên mật khẩu cũ
                        else
                            nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text); // Cập nhật mật khẩu mới
                        context.SaveChanges();
                    }
                }
                frmNhanVien_Load(sender, e);
            }

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }
        private void TimKiem(string tuKhoa)
        {

            using (var context = new QLCHTVDbContext())
            {
                List<NhanVien> ketQua;

                // Nếu không có từ khóa hoặc placeholder "Tìm Kiếm" → lấy toàn bộ khách hàng
                if (string.IsNullOrWhiteSpace(tuKhoa) || tuKhoa == "Tìm kiếm")
                {
                    ketQua = context.NhanVien.ToList();
                }
                else
                {
                    var selected = (KeyValuePair<string, string>)cboTimKiem.SelectedItem;
                    string tenCot = selected.Value;
                    ketQua = new List<NhanVien>();
                    switch (tenCot)
                    {
                        case "HoVaTen":
                            ketQua = context.NhanVien
                              .Where(nv => EF.Functions.Collate(nv.HoVaTen, "Latin1_General_CI_AI").Contains(tuKhoa))
                              .ToList();
                            break;

                        case "DiaChi":
                            ketQua = context.NhanVien
                                 .Where(nv => EF.Functions.Collate(nv.DiaChi, "Latin1_General_CI_AI").Contains(tuKhoa))
                                 .ToList();
                            break;

                        case "SoDienThoai":
                            ketQua = context.NhanVien
                               .Where(nv => EF.Functions.Collate(nv.DienThoai, "Latin1_General_CI_AI").Contains(tuKhoa))
                               .ToList();
                            break;
                        default:
                            // Không tìm được cột phù hợp
                            break;
                    }
                }
                dataGridView.AutoGenerateColumns = false;

                BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = ketQua;
                    dataGridView.DataSource = bindingSource;

                    // Cập nhật lại các TextBox với dòng được chọn
                    if (ketQua.Count > 0)
                    {
                        // Gán lại các DataBindings cho TextBox
                        txtHoVaTen.DataBindings.Clear();
                        txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

                        txtDienThoai.DataBindings.Clear();
                        txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

                        txtDiaChi.DataBindings.Clear();
                        txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

                        txtTenDangNhap.DataBindings.Clear();
                        txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);

                        cboQuyenHan.DataBindings.Clear();
                        cboQuyenHan.DataBindings.Add("SelectedIndex", bindingSource, "QuyenHan", false, DataSourceUpdateMode.Never);

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

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
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
                }
            };

            textBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                }
            };
        }

    }
}
