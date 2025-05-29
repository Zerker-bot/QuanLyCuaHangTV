namespace QuanLyCuaHangTV.Forms
{
    partial class frmHoaDon_ChiTiet
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtGhiChuHoaDon = new TextBox();
            cboNhanVien = new ComboBox();
            cboKhachHang = new ComboBox();
            cboSanPham = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            numDonGiaBan = new NumericUpDown();
            numSoLuongBan = new NumericUpDown();
            dataGridView = new DataGridView();
            SanPhamID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            btnLuuHoaDon = new Button();
            btnThoat = new Button();
            btnXacNhanBan = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(7, 6);
            label2.Name = "label2";
            label2.Size = new Size(300, 33);
            label2.TabIndex = 4;
            label2.Text = "Thông tin hóa đơn: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F);
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(164, 23);
            label1.TabIndex = 5;
            label1.Text = "Nhân viên lập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F);
            label3.Location = new Point(395, 42);
            label3.Name = "label3";
            label3.Size = new Size(131, 23);
            label3.TabIndex = 6;
            label3.Text = "Khách hàng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F);
            label4.Location = new Point(14, 101);
            label4.Name = "label4";
            label4.Size = new Size(186, 23);
            label4.TabIndex = 7;
            label4.Text = "Ghi chú hóa đơn:";
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Location = new Point(12, 128);
            txtGhiChuHoaDon.Margin = new Padding(3, 4, 3, 4);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(743, 27);
            txtGhiChuHoaDon.TabIndex = 8;
            txtGhiChuHoaDon.TextChanged += txtGhiChuHoaDon_TextChanged;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(14, 69);
            cboNhanVien.Margin = new Padding(3, 4, 3, 4);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(375, 28);
            cboNhanVien.TabIndex = 9;
            cboNhanVien.SelectedIndexChanged += cboNhanVien_SelectedIndexChanged;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(395, 69);
            cboKhachHang.Margin = new Padding(3, 4, 3, 4);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(360, 28);
            cboKhachHang.TabIndex = 10;
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(14, 187);
            cboSanPham.Margin = new Padding(3, 4, 3, 4);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(412, 28);
            cboSanPham.TabIndex = 11;
            cboSanPham.SelectionChangeCommitted += cboSanPham_SelectionChangeCommitted;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F);
            label5.Location = new Point(12, 160);
            label5.Name = "label5";
            label5.Size = new Size(109, 23);
            label5.TabIndex = 12;
            label5.Text = "Sản phẩm:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F);
            label6.Location = new Point(432, 160);
            label6.Name = "label6";
            label6.Size = new Size(142, 23);
            label6.TabIndex = 13;
            label6.Text = "Đơn giá bán:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 12F);
            label7.Location = new Point(593, 160);
            label7.Name = "label7";
            label7.Size = new Size(153, 23);
            label7.TabIndex = 14;
            label7.Text = "Số lượng bán:";
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Location = new Point(432, 188);
            numDonGiaBan.Margin = new Padding(3, 4, 3, 4);
            numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(155, 27);
            numDonGiaBan.TabIndex = 15;
            numDonGiaBan.ThousandsSeparator = true;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(593, 187);
            numSoLuongBan.Margin = new Padding(3, 4, 3, 4);
            numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(160, 27);
            numSoLuongBan.TabIndex = 16;
            numSoLuongBan.ThousandsSeparator = true;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SanPhamID, TenSanPham, DonGiaBan, SoLuongBan, ThanhTien });
            dataGridView.Location = new Point(14, 222);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(741, 318);
            dataGridView.TabIndex = 19;
            // 
            // SanPhamID
            // 
            SanPhamID.DataPropertyName = "SanPhamID";
            SanPhamID.FillWeight = 50.76142F;
            SanPhamID.HeaderText = "ID";
            SanPhamID.MinimumWidth = 6;
            SanPhamID.Name = "SanPhamID";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.FillWeight = 112.309647F;
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "#,##0";
            DonGiaBan.DefaultCellStyle = dataGridViewCellStyle2;
            DonGiaBan.FillWeight = 112.309647F;
            DonGiaBan.HeaderText = "Đơn giá bán";
            DonGiaBan.MinimumWidth = 6;
            DonGiaBan.Name = "DonGiaBan";
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            SoLuongBan.DefaultCellStyle = dataGridViewCellStyle3;
            SoLuongBan.FillWeight = 112.309647F;
            SoLuongBan.HeaderText = "Số lượng bán";
            SoLuongBan.MinimumWidth = 6;
            SoLuongBan.Name = "SoLuongBan";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Blue;
            dataGridViewCellStyle4.Format = "#,##0";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            ThanhTien.FillWeight = 112.309647F;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.Anchor = AnchorStyles.Right;
            btnLuuHoaDon.BackColor = Color.Black;
            btnLuuHoaDon.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            btnLuuHoaDon.ForeColor = Color.White;
            btnLuuHoaDon.Image = Properties.Resources.save;
            btnLuuHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuuHoaDon.Location = new Point(770, 396);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(150, 69);
            btnLuuHoaDon.TabIndex = 28;
            btnLuuHoaDon.Text = "Lưu  ";
            btnLuuHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnLuuHoaDon.UseVisualStyleBackColor = false;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Right;
            btnThoat.BackColor = Color.Gray;
            btnThoat.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Image = Properties.Resources.cancel;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(770, 472);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 69);
            btnThoat.TabIndex = 33;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Anchor = AnchorStyles.Right;
            btnXacNhanBan.BackColor = Color.FromArgb(40, 167, 69);
            btnXacNhanBan.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            btnXacNhanBan.ForeColor = Color.White;
            btnXacNhanBan.Image = Properties.Resources.add2;
            btnXacNhanBan.ImageAlign = ContentAlignment.MiddleLeft;
            btnXacNhanBan.Location = new Point(770, 68);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(150, 70);
            btnXacNhanBan.TabIndex = 34;
            btnXacNhanBan.Text = "Thêm ";
            btnXacNhanBan.TextAlign = ContentAlignment.MiddleRight;
            btnXacNhanBan.UseVisualStyleBackColor = false;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Right;
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            btnXoa.ForeColor = Color.WhiteSmoke;
            btnXoa.Image = Properties.Resources.delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(770, 144);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 70);
            btnXoa.TabIndex = 35;
            btnXoa.Text = "Xoá  ";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 226, 229);
            ClientSize = new Size(932, 553);
            Controls.Add(btnXoa);
            Controls.Add(btnXacNhanBan);
            Controls.Add(btnThoat);
            Controls.Add(btnLuuHoaDon);
            Controls.Add(dataGridView);
            Controls.Add(numSoLuongBan);
            Controls.Add(numDonGiaBan);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cboSanPham);
            Controls.Add(cboKhachHang);
            Controls.Add(cboNhanVien);
            Controls.Add(txtGhiChuHoaDon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmHoaDon_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHoaDon_ChiTiet";
            Load += frmHoaDon_ChiTiet_Load;
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtGhiChuHoaDon;
        private ComboBox cboNhanVien;
        private ComboBox cboKhachHang;
        private ComboBox cboSanPham;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown numDonGiaBan;
        private NumericUpDown numSoLuongBan;
        private DataGridView dataGridView;
        private Button btnLuuHoaDon;
        private Button btnThoat;
        private Button btnXacNhanBan;
        private Button btnXoa;
        private DataGridViewTextBoxColumn SanPhamID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}