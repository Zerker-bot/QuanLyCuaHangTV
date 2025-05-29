namespace QuanLyCuaHangTV.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            panelSideMenu = new Panel();
            panelThongKeSubMenu = new Panel();
            btnThongKeDoanhThu = new Button();
            btnThongKeSanPham = new Button();
            btnThongKe = new Button();
            panelChuyenDong = new Panel();
            btnDangXuat = new Button();
            btnHoaDon = new Button();
            btnNhanVien = new Button();
            btnKhachHang = new Button();
            btnHangSanXuat = new Button();
            btnSanPham = new Button();
            btnLoaiSanPham = new Button();
            btnTrangChu = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panelChildForm = new Panel();
            panelSideMenu.SuspendLayout();
            panelThongKeSubMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(4, 12, 28);
            panelSideMenu.Controls.Add(panelThongKeSubMenu);
            panelSideMenu.Controls.Add(btnThongKe);
            panelSideMenu.Controls.Add(panelChuyenDong);
            panelSideMenu.Controls.Add(btnDangXuat);
            panelSideMenu.Controls.Add(btnHoaDon);
            panelSideMenu.Controls.Add(btnNhanVien);
            panelSideMenu.Controls.Add(btnKhachHang);
            panelSideMenu.Controls.Add(btnHangSanXuat);
            panelSideMenu.Controls.Add(btnSanPham);
            panelSideMenu.Controls.Add(btnLoaiSanPham);
            panelSideMenu.Controls.Add(btnTrangChu);
            panelSideMenu.Controls.Add(panel1);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(234, 916);
            panelSideMenu.TabIndex = 0;
            // 
            // panelThongKeSubMenu
            // 
            panelThongKeSubMenu.BackColor = Color.FromArgb(30, 40, 60);
            panelThongKeSubMenu.Controls.Add(btnThongKeDoanhThu);
            panelThongKeSubMenu.Controls.Add(btnThongKeSanPham);
            panelThongKeSubMenu.Dock = DockStyle.Top;
            panelThongKeSubMenu.Location = new Point(0, 644);
            panelThongKeSubMenu.Name = "panelThongKeSubMenu";
            panelThongKeSubMenu.Size = new Size(234, 70);
            panelThongKeSubMenu.TabIndex = 11;
            // 
            // btnThongKeDoanhThu
            // 
            btnThongKeDoanhThu.BackColor = Color.FromArgb(30, 40, 60);
            btnThongKeDoanhThu.Dock = DockStyle.Top;
            btnThongKeDoanhThu.FlatAppearance.BorderSize = 0;
            btnThongKeDoanhThu.FlatStyle = FlatStyle.Flat;
            btnThongKeDoanhThu.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            btnThongKeDoanhThu.ForeColor = Color.White;
            btnThongKeDoanhThu.ImageAlign = ContentAlignment.MiddleRight;
            btnThongKeDoanhThu.Location = new Point(0, 35);
            btnThongKeDoanhThu.Margin = new Padding(0);
            btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            btnThongKeDoanhThu.Size = new Size(234, 35);
            btnThongKeDoanhThu.TabIndex = 1;
            btnThongKeDoanhThu.Text = "Doanh thu";
            btnThongKeDoanhThu.TextAlign = ContentAlignment.MiddleRight;
            btnThongKeDoanhThu.UseVisualStyleBackColor = false;
            btnThongKeDoanhThu.Click += btnThongKeDoanhThu_Click;
            // 
            // btnThongKeSanPham
            // 
            btnThongKeSanPham.BackColor = Color.FromArgb(30, 40, 60);
            btnThongKeSanPham.Dock = DockStyle.Top;
            btnThongKeSanPham.FlatAppearance.BorderSize = 0;
            btnThongKeSanPham.FlatStyle = FlatStyle.Flat;
            btnThongKeSanPham.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            btnThongKeSanPham.ForeColor = Color.White;
            btnThongKeSanPham.Location = new Point(0, 0);
            btnThongKeSanPham.Margin = new Padding(0);
            btnThongKeSanPham.Name = "btnThongKeSanPham";
            btnThongKeSanPham.Size = new Size(234, 35);
            btnThongKeSanPham.TabIndex = 0;
            btnThongKeSanPham.Text = "Sản phẩm";
            btnThongKeSanPham.TextAlign = ContentAlignment.MiddleRight;
            btnThongKeSanPham.UseVisualStyleBackColor = false;
            btnThongKeSanPham.Click += btnThongKeSanPham_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Dock = DockStyle.Top;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Image = (Image)resources.GetObject("btnThongKe.Image");
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(0, 573);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(12, 0, 0, 0);
            btnThongKe.Size = new Size(234, 71);
            btnThongKe.TabIndex = 10;
            btnThongKe.Text = " Thống kê";
            btnThongKe.TextAlign = ContentAlignment.MiddleRight;
            btnThongKe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // panelChuyenDong
            // 
            panelChuyenDong.BackColor = Color.White;
            panelChuyenDong.Location = new Point(0, 76);
            panelChuyenDong.Name = "panelChuyenDong";
            panelChuyenDong.Size = new Size(5, 71);
            panelChuyenDong.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Dock = DockStyle.Bottom;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Image = (Image)resources.GetObject("btnDangXuat.Image");
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(0, 845);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(12, 0, 0, 0);
            btnDangXuat.Size = new Size(234, 71);
            btnDangXuat.TabIndex = 7;
            btnDangXuat.Text = " Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleRight;
            btnDangXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Dock = DockStyle.Top;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnHoaDon.ForeColor = Color.White;
            btnHoaDon.Image = (Image)resources.GetObject("btnHoaDon.Image");
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(0, 502);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Padding = new Padding(12, 0, 0, 0);
            btnHoaDon.Size = new Size(234, 71);
            btnHoaDon.TabIndex = 6;
            btnHoaDon.Text = " Hoá đơn";
            btnHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.Image = (Image)resources.GetObject("btnNhanVien.Image");
            btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new Point(0, 431);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(12, 0, 0, 0);
            btnNhanVien.Size = new Size(234, 71);
            btnNhanVien.TabIndex = 5;
            btnNhanVien.Text = " Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleRight;
            btnNhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.Image = (Image)resources.GetObject("btnKhachHang.Image");
            btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.Location = new Point(0, 360);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Padding = new Padding(12, 0, 0, 0);
            btnKhachHang.Size = new Size(234, 71);
            btnKhachHang.TabIndex = 4;
            btnKhachHang.Text = " Khách hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleRight;
            btnKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnHangSanXuat
            // 
            btnHangSanXuat.Dock = DockStyle.Top;
            btnHangSanXuat.FlatAppearance.BorderSize = 0;
            btnHangSanXuat.FlatStyle = FlatStyle.Flat;
            btnHangSanXuat.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnHangSanXuat.ForeColor = Color.White;
            btnHangSanXuat.Image = (Image)resources.GetObject("btnHangSanXuat.Image");
            btnHangSanXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnHangSanXuat.Location = new Point(0, 289);
            btnHangSanXuat.Name = "btnHangSanXuat";
            btnHangSanXuat.Padding = new Padding(12, 0, 0, 0);
            btnHangSanXuat.Size = new Size(234, 71);
            btnHangSanXuat.TabIndex = 3;
            btnHangSanXuat.Text = " Hãng sản xuất";
            btnHangSanXuat.TextAlign = ContentAlignment.MiddleRight;
            btnHangSanXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHangSanXuat.UseVisualStyleBackColor = true;
            btnHangSanXuat.Click += btnHangSanXuat_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.Dock = DockStyle.Top;
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnSanPham.ForeColor = Color.White;
            btnSanPham.Image = (Image)resources.GetObject("btnSanPham.Image");
            btnSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnSanPham.Location = new Point(0, 218);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Padding = new Padding(12, 0, 0, 0);
            btnSanPham.Size = new Size(234, 71);
            btnSanPham.TabIndex = 2;
            btnSanPham.Text = " Sản phẩm";
            btnSanPham.TextAlign = ContentAlignment.MiddleRight;
            btnSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // btnLoaiSanPham
            // 
            btnLoaiSanPham.BackgroundImageLayout = ImageLayout.Zoom;
            btnLoaiSanPham.Dock = DockStyle.Top;
            btnLoaiSanPham.FlatAppearance.BorderSize = 0;
            btnLoaiSanPham.FlatStyle = FlatStyle.Flat;
            btnLoaiSanPham.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnLoaiSanPham.ForeColor = Color.White;
            btnLoaiSanPham.Image = (Image)resources.GetObject("btnLoaiSanPham.Image");
            btnLoaiSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoaiSanPham.Location = new Point(0, 147);
            btnLoaiSanPham.Name = "btnLoaiSanPham";
            btnLoaiSanPham.Padding = new Padding(12, 0, 0, 0);
            btnLoaiSanPham.Size = new Size(234, 71);
            btnLoaiSanPham.TabIndex = 1;
            btnLoaiSanPham.Text = " Loại sản phẩm";
            btnLoaiSanPham.TextAlign = ContentAlignment.MiddleRight;
            btnLoaiSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoaiSanPham.UseVisualStyleBackColor = true;
            btnLoaiSanPham.Click += btnLoaiSanPham_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.Dock = DockStyle.Top;
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnTrangChu.ForeColor = Color.White;
            btnTrangChu.Image = (Image)resources.GetObject("btnTrangChu.Image");
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(0, 76);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Padding = new Padding(12, 0, 0, 0);
            btnTrangChu.Size = new Size(234, 71);
            btnTrangChu.TabIndex = 8;
            btnTrangChu.Text = " Trang chủ";
            btnTrangChu.TextAlign = ContentAlignment.MiddleRight;
            btnTrangChu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTrangChu.UseVisualStyleBackColor = true;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 76);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(16, 20, 44);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(234, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1248, 916);
            panelChildForm.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1482, 916);
            Controls.Add(panelChildForm);
            Controls.Add(panelSideMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TIVIZONE";
            Load += frmMain_Load;
            panelSideMenu.ResumeLayout(false);
            panelThongKeSubMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Button btnHoaDon;
        private Button btnNhanVien;
        private Button btnKhachHang;
        private Button btnHangSanXuat;
        private Button btnSanPham;
        private Button btnLoaiSanPham;
        private Panel panelChildForm;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnDangXuat;
        private Panel panelChuyenDong;
        private Button btnTrangChu;
        private Button btnThongKe;
        private Panel panelThongKeSubMenu;
        private Button btnThongKeDoanhThu;
        private Button btnThongKeSanPham;
    }
}