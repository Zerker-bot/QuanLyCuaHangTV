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
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;

namespace QuanLyCuaHangTV.Forms
{
    public partial class frmSanPham : Form
    {
        QLCHTVDbContext context = new QLCHTVDbContext();    // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false;                          // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id;                                         // Lấy mã sản phẩm (dùng cho Sửa và Xóa) 
        string filePath = "";
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


        }
        private void KhoiTaoComboBoxTimKiem()
        {
            cboTimKiem.DisplayMember = "Key";
            cboTimKiem.ValueMember = "Value";

            cboTimKiem.Items.Add(new KeyValuePair<string, string>("Tên sản phẩm", "TenSanPham"));
            cboTimKiem.Items.Add(new KeyValuePair<string, string>("Hãng sản xuất", "TenHangSanXuat"));
            cboTimKiem.Items.Add(new KeyValuePair<string, string>("Loại sản phẩm", "TenLoai"));
            cboTimKiem.Items.Add(new KeyValuePair<string, string>("Độ phân giải", "DoPhanGiai"));
            cboTimKiem.Items.Add(new KeyValuePair<string, string>("KichThuoc", "KichThuoc"));


            cboTimKiem.SelectedIndex = 0;

            cboTimKiem.SelectedIndex = 0;
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            cboHangSanXuat.Enabled = giaTri;
            cboLoaiSanPham.Enabled = giaTri;
            txtTenSanPham.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numGiaNhap.Enabled = giaTri;
            numGiaBan.Enabled = giaTri;
            txtKichThuoc.Enabled = giaTri;
            txtDoPhanGiai.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnDoiAnh.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;

            if (giaTri) // Nếu đang ở trạng thái "Lưu" hoặc "Hủy bỏ"
            {
                btnLuu.BackColor = System.Drawing.Color.Green;
                btnHuyBo.BackColor = System.Drawing.Color.Gray;
                btnThem.BackColor = System.Drawing.SystemColors.Control;
                btnSua.BackColor = System.Drawing.SystemColors.Control;
                btnXoa.BackColor = System.Drawing.SystemColors.Control;
                btnDoiAnh.BackColor  = System.Drawing.SystemColors.Control;
            }
            else // Nếu đang ở trạng thái "Thêm", "Sửa" hoặc "Xóa"
            {
                btnLuu.BackColor = System.Drawing.SystemColors.Control;
                btnHuyBo.BackColor = System.Drawing.SystemColors.Control;
                btnThem.BackColor = System.Drawing.ColorTranslator.FromHtml("#28A745");
                btnSua.BackColor = System.Drawing.Color.Orange;
                btnXoa.BackColor = System.Drawing.ColorTranslator.FromHtml("#DC3545");
                btnDoiAnh.BackColor = System.Drawing.ColorTranslator.FromHtml("#17A2B8");
            }
        }
        public void LayLoaiSanPhamVaoComboBox()
        {
            cboLoaiSanPham.DataSource = context.LoaiSanPham.ToList();
            cboLoaiSanPham.ValueMember = "ID";
            cboLoaiSanPham.DisplayMember = "TenLoai";
        }
        public void LayHangSanXuatVaoComboBox()
        {
            cboHangSanXuat.DataSource = context.HangSanXuat.ToList();
            cboHangSanXuat.ValueMember = "ID";
            cboHangSanXuat.DisplayMember = "TenHangSanXuat";
        }
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            cboLoaiSanPham.Text = "";
            cboHangSanXuat.Text = "";
            txtTenSanPham.Clear();
            txtMoTa.Clear();
            numSoLuong.Value = 0;
            numGiaBan.Value = 0;
            picHinhAnh.Image = null;
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            if (!isInitialized)
            {
                KhoiTaoComboBoxTimKiem();
                SetPlaceholder(txtTimKiem, "Tìm kiếm");
                tuychinhDataGridView();
                isInitialized = true;
            }
            BatTatChucNang(false);
            LayLoaiSanPhamVaoComboBox();
            LayHangSanXuatVaoComboBox();
            dataGridView.AutoGenerateColumns = false;

            List<DanhSachSanPham> sp = new List<DanhSachSanPham>();
            sp = context.SanPham.Select(r => new DanhSachSanPham
            {
                ID = r.ID,
                LoaiSanPhamID = r.LoaiSanPhamID,
                TenLoai = r.LoaiSanPham.TenLoai,
                HangSanXuatID = r.HangSanXuatID,
                TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                TenSanPham = r.TenSanPham,
                DoPhanGiai = r.DoPhanGiai,
                KichThuoc = r.KichThuoc,
                SoLuong = r.SoLuong,
                GiaNhap = r.GiaNhap,
                GiaBan = r.GiaBan,
                HinhAnh = r.HinhAnh,
                MoTa = r.MoTa
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sp;

            cboLoaiSanPham.DataBindings.Clear();
            cboLoaiSanPham.DataBindings.Add("SelectedValue", bindingSource, "LoaiSanPhamID", false, DataSourceUpdateMode.Never);
            cboHangSanXuat.DataBindings.Clear();
            cboHangSanXuat.DataBindings.Add("SelectedValue", bindingSource, "HangSanXuatID", false, DataSourceUpdateMode.Never);
            // Tương tự đối với cboHangSanXuat
            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham", false, DataSourceUpdateMode.Never);
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);
            // Tương tự đối với txtMoTa
            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);
            numGiaBan.DataBindings.Clear();
            numGiaBan.DataBindings.Add("Value", bindingSource, "GiaBan", false, DataSourceUpdateMode.Never);
            numGiaNhap.DataBindings.Clear();
            numGiaNhap.DataBindings.Add("Value", bindingSource, "GiaNhap", false, DataSourceUpdateMode.Never);
            txtDoPhanGiai.DataBindings.Clear();
            txtDoPhanGiai.DataBindings.Add("Text", bindingSource, "DoPhanGiai", false, DataSourceUpdateMode.Never);
            txtKichThuoc.DataBindings.Clear();
            txtKichThuoc.DataBindings.Add("Text", bindingSource, "KichThuoc", false, DataSourceUpdateMode.Never);
            // Tương tự đối với numDonGia

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh");
            hinhAnh.Format += (s, e) =>
            {
                string fileName = e.Value?.ToString();
                string defaultImagePath = Path.Combine(Application.StartupPath, "Images", "default.jpg");

                // Xây dựng đường dẫn đầy đủ đến tệp ảnh hoặc gán ảnh mặc định nếu không có
                e.Value = string.IsNullOrEmpty(fileName) || !File.Exists(Path.Combine(Application.StartupPath, "Images", fileName))
                    ? defaultImagePath
                    : Path.Combine(Application.StartupPath, "Images", fileName);
            };

            picHinhAnh.DataBindings.Add(hinhAnh);
            dataGridView.DataSource = bindingSource;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;  // Đặt biến xuLyThem thành false để xác định đang sửa dữ liệu, không phải thêm mới
            BatTatChucNang(true);  // Bật các chức năng cho phép người dùng sửa thông tin (như các textbox, combobox, picturebox...)

            // Lấy ID của sản phẩm được chọn trong DataGridView
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["IDSP"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa sản phẩm ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["IDSP"].Value.ToString());
                SanPham sp = context.SanPham.Find(id);
                if (sp != null)
                {
                    context.SanPham.Remove(sp);
                }
                context.SaveChanges();
                frmSanPham_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboLoaiSanPham.Text))
                MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboHangSanXuat.Text))
                MessageBox.Show("Vui lòng chọn hãng sản xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuong.Value <= 0)
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numGiaBan.Value <= 0)
                MessageBox.Show("Đơn giá sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    SanPham sp = new SanPham();
                    sp.LoaiSanPhamID = (int)cboLoaiSanPham.SelectedValue;
                    sp.HangSanXuatID = (int)cboHangSanXuat.SelectedValue;
                    sp.TenSanPham = txtTenSanPham.Text;
                    sp.DoPhanGiai = txtDoPhanGiai.Text;
                    sp.KichThuoc = txtKichThuoc.Text;
                    sp.GiaNhap = (int)numGiaNhap.Value;
                    sp.GiaBan = (int)numGiaBan.Value;
                    sp.SoLuong = (int)numSoLuong.Value;
                    sp.MoTa = txtMoTa.Text;
                    sp.HinhAnh = string.IsNullOrEmpty(filePath) ? "default.jpg" : filePath;
                    context.SanPham.Add(sp);
                    context.SaveChanges();

                }
                else
                {
                    SanPham sp = context.SanPham.Find(id);
                    if (sp != null)
                    {
                        sp.LoaiSanPhamID = (int)cboLoaiSanPham.SelectedValue;
                        sp.HangSanXuatID = (int)cboHangSanXuat.SelectedValue;
                        sp.TenSanPham = txtTenSanPham.Text;
                        sp.DoPhanGiai = txtDoPhanGiai.Text;
                        sp.KichThuoc = txtKichThuoc.Text;
                        sp.GiaNhap = (int)numGiaNhap.Value;
                        sp.GiaBan = (int)numGiaBan.Value;
                        sp.SoLuong = (int)numSoLuong.Value;
                        sp.MoTa = txtMoTa.Text;
                        sp.HinhAnh = string.IsNullOrEmpty(filePath) ? "default.jpg" : filePath;
                        context.SanPham.Update(sp); // Cập nhật sản phẩm vào database
                        context.SaveChanges();
                    }
                }
                frmSanPham_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);

        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Nếu người dùng chọn ảnh và nhấn OK
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            // Kiểm tra nếu người dùng không chọn file và nhấn Cancel
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị ảnh lên PictureBox
                picHinhAnh.Image = Image.FromFile(ofd.FileName);

                // Copy ảnh về thư mục dự án (nếu cần)
                string fileName = Path.GetFileName(ofd.FileName);
                string destinationPath = Path.Combine(Application.StartupPath, "Images", fileName);

                // Tạo thư mục nếu chưa có
                Directory.CreateDirectory(Path.GetDirectoryName(destinationPath));

                // Chỉ copy nếu file chưa tồn tại
                if (!File.Exists(destinationPath))
                {
                    File.Copy(ofd.FileName, destinationPath);
                }
                // Lưu đường dẫn tương đối để đưa vào DB
                filePath = fileName;
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["IDSP"].Value.ToString());
                SanPham sp = context.SanPham.Find(id);
                sp.HinhAnh = filePath; // Chỉ lưu tên file
                context.SanPham.Update(sp);
                context.SaveChanges();

                // Làm mới dữ liệu
                frmSanPham_Load(sender, e);
            }
            else
            {
                // Nếu người dùng nhấn Cancel, bạn có thể đưa ra thông báo hoặc bỏ qua
                MessageBox.Show("Bạn chưa chọn ảnh!");
            }
        }

        private void dataGridView_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                string fileName = e.Value?.ToString();
                if (!string.IsNullOrEmpty(fileName))
                {
                    string fullPath = Path.Combine(Application.StartupPath, "Images", fileName);
                    if (File.Exists(fullPath))
                    {
                        Image img = Image.FromFile(fullPath);
                        e.Value = new Bitmap(img, new Size(60, 60)); // Resize ảnh nhỏ
                    }
                    else
                    {
                        e.Value = Image.FromFile(Path.Combine(Application.StartupPath, "Images", "default.jpg"));
                        // Ảnh mặc định nếu không tìm thấy
                    }
                }
                else
                {
                    // Nếu không có tên ảnh, gán ảnh mặc định hoặc để trống
                    e.Value = Image.FromFile(Path.Combine(Application.StartupPath, "Images", "default.jpg")); // Hoặc một ảnh mặc định
                }
            }
        }
        private void TimKiem(String tuKhoa)
        {

            List<DanhSachSanPham> ketQua;

            if (string.IsNullOrWhiteSpace(tuKhoa) || tuKhoa == "Tìm kiếm")
            {
                ketQua = context.SanPham
                    .Include(sp => sp.LoaiSanPham)
                    .Include(sp => sp.HangSanXuat)
                    .Select(sp => new DanhSachSanPham
                    {
                        ID = sp.ID,
                        LoaiSanPhamID = sp.LoaiSanPhamID,
                        TenLoai = sp.LoaiSanPham.TenLoai,
                        HangSanXuatID = sp.HangSanXuatID,
                        TenHangSanXuat = sp.HangSanXuat.TenHangSanXuat,
                        TenSanPham = sp.TenSanPham,
                        DoPhanGiai = sp.DoPhanGiai,
                        KichThuoc = sp.KichThuoc,
                        SoLuong = sp.SoLuong,
                        GiaNhap = sp.GiaNhap,
                        GiaBan = sp.GiaBan,
                        HinhAnh = sp.HinhAnh,
                        MoTa = sp.MoTa
                    })
                    .ToList();
            }
            else
            {
                var selected = (KeyValuePair<string, string>)cboTimKiem.SelectedItem;
                string tenCot = selected.Value;

                var spQuery = context.SanPham
                    .Include(sp => sp.LoaiSanPham)
                    .Include(sp => sp.HangSanXuat)
                    .AsQueryable();

                switch (tenCot)
                {
                    case "TenSanPham":
                        spQuery = spQuery.Where(sp => EF.Functions.Collate(sp.TenSanPham, "Latin1_General_CI_AI").Contains(tuKhoa));
                        break;

                    case "KichThuoc":
                        spQuery = spQuery.Where(sp => EF.Functions.Collate(sp.KichThuoc, "Latin1_General_CI_AI").Contains(tuKhoa));
                        break;

                    case "DoPhanGiai":
                        spQuery = spQuery.Where(sp => EF.Functions.Collate(sp.DoPhanGiai, "Latin1_General_CI_AI").Contains(tuKhoa));
                        break;

                    case "TenHangSanXuat":
                        spQuery = spQuery.Where(sp => EF.Functions.Collate(sp.HangSanXuat.TenHangSanXuat, "Latin1_General_CI_AI").Contains(tuKhoa));
                        break;

                    case "TenLoai":
                        spQuery = spQuery.Where(sp => EF.Functions.Collate(sp.LoaiSanPham.TenLoai, "Latin1_General_CI_AI").Contains(tuKhoa));
                        break;
                }

                ketQua = spQuery
                    .Select(sp => new DanhSachSanPham
                    {
                        ID = sp.ID,
                        LoaiSanPhamID = sp.LoaiSanPhamID,
                        TenLoai = sp.LoaiSanPham.TenLoai,
                        HangSanXuatID = sp.HangSanXuatID,
                        TenHangSanXuat = sp.HangSanXuat.TenHangSanXuat,
                        TenSanPham = sp.TenSanPham,
                        DoPhanGiai = sp.DoPhanGiai,
                        KichThuoc = sp.KichThuoc,
                        SoLuong = sp.SoLuong,
                        GiaNhap = sp.GiaNhap,
                        GiaBan = sp.GiaBan,
                        HinhAnh = sp.HinhAnh,
                        MoTa = sp.MoTa
                    })
                    .ToList();
            }
            dataGridView.AutoGenerateColumns = false;

            // Gán lại DataSource
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ketQua;
            dataGridView.DataSource = bindingSource;
            if (ketQua.Count > 0)
            {
                // Gán lại các DataBindings cho TextBox
                cboLoaiSanPham.DataBindings.Clear();
                cboLoaiSanPham.DataBindings.Add("SelectedValue", bindingSource, "LoaiSanPhamID", false, DataSourceUpdateMode.Never);
                cboHangSanXuat.DataBindings.Clear();
                cboHangSanXuat.DataBindings.Add("SelectedValue", bindingSource, "HangSanXuatID", false, DataSourceUpdateMode.Never);
                // Tương tự đối với cboHangSanXuat
                txtTenSanPham.DataBindings.Clear();
                txtTenSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham", false, DataSourceUpdateMode.Never);
                txtMoTa.DataBindings.Clear();
                txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);
                // Tương tự đối với txtMoTa
                numSoLuong.DataBindings.Clear();
                numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);
                numGiaBan.DataBindings.Clear();
                numGiaBan.DataBindings.Add("Value", bindingSource, "GiaBan", false, DataSourceUpdateMode.Never);
                numGiaNhap.DataBindings.Clear();
                numGiaNhap.DataBindings.Add("Value", bindingSource, "GiaNhap", false, DataSourceUpdateMode.Never);
                txtDoPhanGiai.DataBindings.Clear();
                txtDoPhanGiai.DataBindings.Add("Text", bindingSource, "DoPhanGiai", false, DataSourceUpdateMode.Never);
                txtKichThuoc.DataBindings.Clear();
                txtKichThuoc.DataBindings.Add("Text", bindingSource, "KichThuoc", false, DataSourceUpdateMode.Never);
                // Đặt lại dòng được chọn là dòng đầu tiên
                bindingSource.Position = 0;
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


