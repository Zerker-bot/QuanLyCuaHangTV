using Microsoft.EntityFrameworkCore;
using QuanLyCuaHangTV.CustomControls;
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
    public partial class frmKhachHang : Form
    {
        QLCHTVDbContext context = new QLCHTVDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id;
        private bool isInitialized = false;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
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
        private void frmKhachHang_Load(object sender, EventArgs e)
        {

            if (!isInitialized)
            {
                KhoiTaoComboBoxTimKiem();
                SetPlaceholder(txtTimKiem, "Tìm kiếm");
                tuychinhDataGridView();
                isInitialized = true;
            }
        
            BatTatChucNang(false);
            List<KhachHang> kh = new List<KhachHang>();
            kh = context.KhachHang.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kh;
            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            // Tương tự cho txtDienThoai và txtDiaChi
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa khách hàng " + txtHoVaTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                KhachHang kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                }
                context.SaveChanges();
                frmKhachHang_Load(sender, e);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    KhachHang kh = new KhachHang();
                    kh.HoVaTen = txtHoVaTen.Text;
                    kh.DienThoai = txtDienThoai.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    context.KhachHang.Add(kh);
                    context.SaveChanges();
                }
                else
                {
                    KhachHang kh = context.KhachHang.Find(id);
                    if (kh != null)
                    {
                        kh.HoVaTen = txtHoVaTen.Text;
                        kh.DienThoai = txtDienThoai.Text;
                        kh.DiaChi = txtDiaChi.Text;
                        context.KhachHang.Update(kh);
                        context.SaveChanges();
                    }
                }
                frmKhachHang_Load(sender, e);
            }

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //private void TimKiem(string tuKhoa)
        //{

        //    using (var context = new QLCHTVDbContext())
        //    {
        //        var selected = (KeyValuePair<string, string>)cboTimKiem.SelectedItem;
        //        string tenCot = selected.Value;
        //        List<KhachHang> ketQua = new List<KhachHang>(); // ← thêm dòng này


        //        switch (tenCot)
        //        {
        //            case "HoVaTen":
        //                ketQua = context.KhachHang
        //                  .Where(nv => EF.Functions.Collate(nv.HoVaTen, "Latin1_General_CI_AI").Contains(tuKhoa))
        //                  .ToList();
        //                break;

        //            case "DiaChi":
        //                ketQua = context.KhachHang
        //                     .Where(nv => EF.Functions.Collate(nv.DiaChi, "Latin1_General_CI_AI").Contains(tuKhoa))
        //                     .ToList();
        //                break;

        //            case "SoDienThoai":
        //                ketQua = context.KhachHang
        //                   .Where(nv => EF.Functions.Collate(nv.DienThoai, "Latin1_General_CI_AI").Contains(tuKhoa))
        //                   .ToList();
        //                break;
        //            default:
        //                // Không tìm được cột phù hợp
        //                break;
        //        }
        //        BindingSource bindingSource = new BindingSource();
        //        bindingSource.DataSource = ketQua;
        //        dataGridView.DataSource = bindingSource;

        //        // Cập nhật lại các TextBox với dòng được chọn
        //        if (ketQua.Count > 0)
        //        {
        //            // Gán lại các DataBindings cho TextBox
        //            txtHoVaTen.DataBindings.Clear();
        //            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

        //            txtDienThoai.DataBindings.Clear();
        //            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

        //            txtDiaChi.DataBindings.Clear();
        //            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

        //            // Đặt lại dòng được chọn là dòng đầu tiên
        //            bindingSource.Position = 0;
        //        }
        //    }

        //}
        private void TimKiem(string tuKhoa)
        {
            using (var context = new QLCHTVDbContext())
            {
                List<KhachHang> ketQua;

                // Nếu không có từ khóa hoặc placeholder "Tìm Kiếm" → lấy toàn bộ khách hàng
                if (string.IsNullOrWhiteSpace(tuKhoa) || tuKhoa == "Tìm kiếm")
                {
                    ketQua = context.KhachHang.ToList();
                }
                else
                {
                    var selected = (KeyValuePair<string, string>)cboTimKiem.SelectedItem;
                    string tenCot = selected.Value;
                    ketQua = new List<KhachHang>();

                    switch (tenCot)
                    {
                        case "HoVaTen":
                            ketQua = context.KhachHang
                              .Where(nv => EF.Functions.Collate(nv.HoVaTen, "Latin1_General_CI_AI").Contains(tuKhoa))
                              .ToList();
                            break;

                        case "DiaChi":
                            ketQua = context.KhachHang
                                  .Where(nv => EF.Functions.Collate(nv.DiaChi, "Latin1_General_CI_AI").Contains(tuKhoa))
                                  .ToList();
                            break;

                        case "SoDienThoai":
                            ketQua = context.KhachHang
                                .Where(nv => EF.Functions.Collate(nv.DienThoai, "Latin1_General_CI_AI").Contains(tuKhoa))
                                .ToList();
                            break;
                    }
                }

                // Đổ kết quả vào DataGridView
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = ketQua;
                dataGridView.DataSource = bindingSource;

                // Binding lại TextBox nếu có kết quả
                if (ketQua.Count > 0)
                {
                    txtHoVaTen.DataBindings.Clear();
                    txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

                    txtDienThoai.DataBindings.Clear();
                    txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

                    txtDiaChi.DataBindings.Clear();
                    txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

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
