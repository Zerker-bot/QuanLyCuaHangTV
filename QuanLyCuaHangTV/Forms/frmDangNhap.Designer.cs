namespace QuanLyCuaHangTV.Forms
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            panelPhu = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txtMatKhau = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtTenDangNhap = new TextBox();
            lblLogin = new Label();
            panelPhu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelPhu
            // 
            panelPhu.Anchor = AnchorStyles.None;
            panelPhu.BackColor = Color.White;
            panelPhu.Controls.Add(button2);
            panelPhu.Controls.Add(button1);
            panelPhu.Controls.Add(panel2);
            panelPhu.Controls.Add(panel1);
            panelPhu.Controls.Add(lblLogin);
            panelPhu.Location = new Point(281, 132);
            panelPhu.Name = "panelPhu";
            panelPhu.Size = new Size(370, 288);
            panelPhu.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 123, 255);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(205, 220);
            button2.Name = "button2";
            button2.Size = new Size(105, 40);
            button2.TabIndex = 9;
            button2.Text = "Đăng nhập";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnDangNhap_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(220, 53, 69);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(70, 220);
            button1.Name = "button1";
            button1.Size = new Size(105, 40);
            button1.TabIndex = 8;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnThoat_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtMatKhau);
            panel2.Location = new Point(49, 144);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 49);
            panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.WhiteSmoke;
            txtMatKhau.BorderStyle = BorderStyle.None;
            txtMatKhau.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(52, 12);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(220, 27);
            txtMatKhau.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Location = new Point(49, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 49);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = Color.WhiteSmoke;
            txtTenDangNhap.BorderStyle = BorderStyle.None;
            txtTenDangNhap.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.ForeColor = Color.Black;
            txtTenDangNhap.Location = new Point(52, 11);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(217, 27);
            txtTenDangNhap.TabIndex = 3;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(95, 12);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(179, 40);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Đăng nhập";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(932, 553);
            Controls.Add(panelPhu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            Load += frmDangNhap_Load;
            panelPhu.ResumeLayout(false);
            panelPhu.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelPhu;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label lblLogin;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
    }
}