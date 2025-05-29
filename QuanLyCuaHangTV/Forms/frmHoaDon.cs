

using Microsoft.EntityFrameworkCore;
using QuanLyCuaHangTV.Data;
using QuanLyCuaHangTV.Data;
using QuanLyCuaHangTV.Forms;
using QuanLyCuaHangTV.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace QuanLyCuaHangTV.Forms
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        QLCHTVDbContext context = new QLCHTVDbContext();
        int id;
        BindingList<DanhSachHoaDon_ChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>();
        private bool isInitialized = false;

        public void tuychinhDataGridView()
        {
            // Màu nền tổng thể
            dataGridView.BackgroundColor = Color.White;
            dataGridView.GridColor = Color.LightGray;
            dataGridView.DefaultCellStyle.ForeColor = SystemColors.ControlText;
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
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }


        }
        private void KhoiTaoComboBoxTimKiem()
        {
            cboTimKiem.DisplayMember = "Key";
            cboTimKiem.ValueMember = "Value";

            cboTimKiem.Items.Add(new KeyValuePair<string, string>("Nhân viên", "TenNhanVien"));
            cboTimKiem.Items.Add(new KeyValuePair<string, string>("Khách hàng", "TenKhachHang"));


            cboTimKiem.SelectedIndex = 0;

            cboTimKiem.SelectedIndex = 0;
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            if (!isInitialized)
            {
                tuychinhDataGridView();
                KhoiTaoComboBoxTimKiem();
                SetPlaceholder(txtTimKiem, "Tìm kiếm");
                dtpTuNgay.Value = new DateTime(2000, 1, 1);
                dtpDenNgay.Value = DateTime.Now;
                isInitialized = true;
            }
            dataGridView.AutoGenerateColumns = false;

            List<DanhSachHoaDon> hd = new List<DanhSachHoaDon>();
            hd = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => Convert.ToInt16(r.SoLuongBan) * r.DonGiaBan),
            }).ToList();

            dataGridView.DataSource = hd;
        }
        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                chiTiet.OnFormClosed += () =>
                {
                    frmHoaDon_Load(sender, e); // Reload lại danh sách sau khi đóng form
                };
                chiTiet.ShowDialog();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["IDHD"].Value.ToString());
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
            {

                chiTiet.OnFormClosed += () =>
                {
                    frmHoaDon_Load(sender, e); // Reload lại danh sách sau khi đóng form

                };
                chiTiet.ShowDialog();
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa hoá đơn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["IDHD"].Value.ToString());
                HoaDon hd = context.HoaDon.Find(id);
                if (hd != null)
                {
                    context.HoaDon.Remove(hd);
                }
                context.SaveChanges();

                frmHoaDon_Load(sender, e);
            }
        }
        public void TimKiem(string tuKhoa)
        {
            List<DanhSachHoaDon> ketQua;

            // Thiết lập khoảng thời gian từ DateTimePicker
            var tuNgay = dtpTuNgay.Value.Date;
            var denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1); // Đến cuối ngày

            // Tạo câu truy vấn ban đầu lọc theo ngày
            var query = context.HoaDon
                .AsNoTracking()
                .Include(hd => hd.NhanVien)
                .Include(hd => hd.KhachHang)
                .Include(hd => hd.HoaDon_ChiTiet)
                .ThenInclude(ct => ct.SanPham)
                .Where(hd => hd.NgayLap >= tuNgay && hd.NgayLap <= denNgay)
                .AsQueryable();

            // Nếu có từ khóa tìm kiếm, lọc theo tên khách hàng hoặc nhân viên
            if (!string.IsNullOrWhiteSpace(tuKhoa) && tuKhoa != "Tìm kiếm")
            {
                var selected = (KeyValuePair<string, string>)cboTimKiem.SelectedItem;
                string tenCot = selected.Value;

                switch (tenCot)
                {
                    case "TenKhachHang":
                        query = query.Where(hd => hd.KhachHang.HoVaTen.Contains(tuKhoa));
                        break;
                    case "TenNhanVien":
                        query = query.Where(hd => hd.NhanVien.HoVaTen.Contains(tuKhoa));
                        break;
                }
            }

            // Thực hiện truy vấn và lấy kết quả
            ketQua = query
                .Select(hd => new DanhSachHoaDon
                {
                    ID = hd.ID,
                    HoVaTenNhanVien = hd.NhanVien.HoVaTen,
                    HoVaTenKhachHang = hd.KhachHang.HoVaTen,
                    NgayLap = hd.NgayLap,
                    TongTienHoaDon = hd.HoaDon_ChiTiet
                        .Sum(ct => Convert.ToInt32(ct.SoLuongBan) * ct.DonGiaBan) // Tính tổng tiền
                })
                .ToList();

            // Cập nhật DataGridView với kết quả tìm kiếm
            dataGridView.AutoGenerateColumns = false;

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ketQua;
            dataGridView.DataSource = bindingSource;
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

        private void dtpTuNgay_CloseUp(object sender, EventArgs e)
        {
            String tuKhoa = txtTimKiem.Text.Trim();
            TimKiem(tuKhoa);
        }

        private void dtpDenNgay_CloseUp(object sender, EventArgs e)
        {
            String tuKhoa = txtTimKiem.Text.Trim();
            TimKiem(tuKhoa);
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["IDHD"].Value.ToString());
            using (frmInHoaDon inHoaDon = new frmInHoaDon(id))
            {
                inHoaDon.ShowDialog();
            }
        }
    }
}