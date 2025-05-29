namespace QuanLyCuaHangTV.Forms
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            btnLapHoaDon = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dataGridView = new DataGridView();
            IDHD = new DataGridViewTextBoxColumn();
            HoVaTenNhanVien = new DataGridViewTextBoxColumn();
            HoVaTenKhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTienHoaDon = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel1 = new Panel();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            pictureBox1 = new PictureBox();
            cboTimKiem = new ComboBox();
            txtTimKiem = new TextBox();
            label1 = new Label();
            label3 = new Label();
            btnInHoaDon = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.Anchor = AnchorStyles.Right;
            btnLapHoaDon.BackColor = Color.FromArgb(40, 167, 69);
            btnLapHoaDon.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            btnLapHoaDon.ForeColor = Color.White;
            btnLapHoaDon.Image = Properties.Resources.add2;
            btnLapHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnLapHoaDon.Location = new Point(804, 49);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(170, 86);
            btnLapHoaDon.TabIndex = 25;
            btnLapHoaDon.Text = "    Lập hóa đơn";
            btnLapHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnLapHoaDon.UseVisualStyleBackColor = false;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Right;
            btnSua.BackColor = Color.Orange;
            btnSua.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Image = Properties.Resources.edit;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(804, 141);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(170, 70);
            btnSua.TabIndex = 26;
            btnSua.Text = "Sửa  ";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Right;
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            btnXoa.ForeColor = Color.WhiteSmoke;
            btnXoa.Image = Properties.Resources.delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(804, 217);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(170, 70);
            btnXoa.TabIndex = 27;
            btnXoa.Text = "Xoá  ";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { IDHD, HoVaTenNhanVien, HoVaTenKhachHang, NgayLap, TongTienHoaDon });
            dataGridView.Location = new Point(9, 94);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(789, 493);
            dataGridView.TabIndex = 33;
            // 
            // IDHD
            // 
            IDHD.DataPropertyName = "ID";
            IDHD.HeaderText = "ID";
            IDHD.MinimumWidth = 6;
            IDHD.Name = "IDHD";
            // 
            // HoVaTenNhanVien
            // 
            HoVaTenNhanVien.DataPropertyName = "HoVaTenNhanVien";
            HoVaTenNhanVien.HeaderText = "Nhân viên";
            HoVaTenNhanVien.MinimumWidth = 6;
            HoVaTenNhanVien.Name = "HoVaTenNhanVien";
            // 
            // HoVaTenKhachHang
            // 
            HoVaTenKhachHang.DataPropertyName = "HoVaTenKhachHang";
            HoVaTenKhachHang.HeaderText = "Khách hàng";
            HoVaTenKhachHang.MinimumWidth = 6;
            HoVaTenKhachHang.Name = "HoVaTenKhachHang";
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            NgayLap.DefaultCellStyle = dataGridViewCellStyle2;
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            // 
            // TongTienHoaDon
            // 
            TongTienHoaDon.DataPropertyName = "TongTienHoaDon";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.Format = "#,##0";
            TongTienHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            TongTienHoaDon.HeaderText = "Thành tiền";
            TongTienHoaDon.MinimumWidth = 6;
            TongTienHoaDon.Name = "TongTienHoaDon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(285, 33);
            label2.TabIndex = 34;
            label2.Text = "Danh sách hoá đơn:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dtpTuNgay);
            panel1.Controls.Add(dtpDenNgay);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cboTimKiem);
            panel1.Controls.Add(txtTimKiem);
            panel1.Location = new Point(12, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 38);
            panel1.TabIndex = 41;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(577, 6);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(96, 27);
            dtpTuNgay.TabIndex = 32;
            dtpTuNgay.CloseUp += dtpTuNgay_CloseUp;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(679, 6);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(104, 27);
            dtpDenNgay.TabIndex = 42;
            dtpDenNgay.CloseUp += dtpDenNgay_CloseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.search1;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // cboTimKiem
            // 
            cboTimKiem.FlatStyle = FlatStyle.Flat;
            cboTimKiem.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTimKiem.FormattingEnabled = true;
            cboTimKiem.ItemHeight = 20;
            cboTimKiem.Location = new Point(431, 4);
            cboTimKiem.Name = "cboTimKiem";
            cboTimKiem.Size = new Size(140, 28);
            cboTimKiem.TabIndex = 30;
            cboTimKiem.SelectedIndexChanged += cboTimKiem_SelectedIndexChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.None;
            txtTimKiem.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(43, 8);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(382, 20);
            txtTimKiem.TabIndex = 29;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 10.2F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(589, 25);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 42;
            label1.Text = "Từ ngày:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 10.2F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(691, 26);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 43;
            label3.Text = "Đến ngày:";
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Anchor = AnchorStyles.Right;
            btnInHoaDon.BackColor = Color.FromArgb(0, 123, 255);
            btnInHoaDon.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            btnInHoaDon.ForeColor = Color.WhiteSmoke;
            btnInHoaDon.Image = (Image)resources.GetObject("btnInHoaDon.Image");
            btnInHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnInHoaDon.Location = new Point(804, 293);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Padding = new Padding(5, 0, 0, 0);
            btnInHoaDon.Size = new Size(170, 79);
            btnInHoaDon.TabIndex = 44;
            btnInHoaDon.Text = "In hoá đơn";
            btnInHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnInHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInHoaDon.UseVisualStyleBackColor = false;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 226, 229);
            ClientSize = new Size(977, 600);
            Controls.Add(btnInHoaDon);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(dataGridView);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLapHoaDon);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmHoaDon";
            Text = "frmHoaDon";
            Load += frmHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLapHoaDon;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dataGridView;
        private Label label2;
        private DataGridViewTextBoxColumn IDHD;
        private DataGridViewTextBoxColumn HoVaTenNhanVien;
        private DataGridViewTextBoxColumn HoVaTenKhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTienHoaDon;
        private Panel panel1;
        private PictureBox pictureBox1;
        private ComboBox cboTimKiem;
        private TextBox txtTimKiem;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private Label label1;
        private Label label3;
        private Button btnInHoaDon;
    }
}