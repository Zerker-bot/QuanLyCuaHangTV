using QuanLyCuaHangTV.CustomControls;
using QuanLyCuaHangTV.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyCuaHangTV.Forms
{
    public partial class frmDangNhap : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr RoundRec(
            int LeftRec,
            int TopRec,
            int RightRec,
            int BottomRec,
            int Witdh,
            int Height
            );

        QLCHTVDbContext context = new QLCHTVDbContext(); // Khởi tạo biến ngữ cảnh CSDL 

        public frmDangNhap()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }
        private void SetDoubleBuffered(Control control, bool setting)
        {
            System.Reflection.PropertyInfo propertyInfo = typeof(Control).GetProperty(
                "DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance
            );
            propertyInfo?.SetValue(control, setting, null);
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

            this.BeginInvoke(new Action(() =>
            {
                // Sau khi form load, không để focus vào bất kỳ control nào
                this.ActiveControl = null;
            })); 
            SetPlaceholder(txtTenDangNhap,"Tên đăng nhập");
            SetPlaceholder(txtMatKhau, "Mật khẩu",true);
            this.DoubleBuffered = true;
            
            // panel gradient 
            GradientPanel panelChinh = new GradientPanel();
            panelChinh.Dock = DockStyle.Fill; // Dock vào toàn bộ form
            this.Controls.Add(panelChinh);
            panelChinh.SendToBack();
            panelChinh.BackColor = Color.Transparent;
            //panel login
            panelPhu.Region = System.Drawing.Region.FromHrgn(RoundRec(0, 0, panelPhu.Width, panelPhu.Height, 20, 20));
            panelPhu.BackColor = Color.FromArgb(70, 0, 0, 0);  // Trong suốt hơn
            panelChinh.Controls.Add(panelPhu);
            panelPhu.BringToFront();
            SetDoubleBuffered(panelPhu, true);

         

        }

     
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;

            if (tenDangNhap.Trim() == "" || tenDangNhap.Trim()=="Tên đăng nhập")
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
            }
            else if (matKhau.Trim() == "" || matKhau.Trim()=="Mật khẩu")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
            }
            else
            {
                var nhanVien = context.NhanVien.Where(r => r.TenDangNhap == tenDangNhap).SingleOrDefault();

                if (nhanVien == null)
                {
                    MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenDangNhap.Focus();
                }
                else
                {
                    if (BCrypt.Net.BCrypt.Verify(matKhau, nhanVien.MatKhau))
                    {

                        this.Tag = nhanVien.QuyenHan; // Gán giá trị boolean trực tiếp vào Tag
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatKhau.Focus();
                    }
                }
            }
        }
        private void SetPlaceholder(TextBox textBox, string placeholder, bool isPassword = false)
        {
            textBox.ForeColor = Color.Gray;
            textBox.Text = placeholder;

            // Nếu là mật khẩu, sử dụng dấu '*' trong PasswordChar
            if (isPassword)
            {
                textBox.PasswordChar = '\0'; // Tắt dấu *
            }

            textBox.GotFocus += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;

                    // Khi người dùng focus, bật lại PasswordChar
                    if (isPassword)
                    {
                        textBox.PasswordChar = '*'; // Hiển thị dấu *
                    }
                }
            };

            textBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;

                    // Nếu mất focus và không có giá trị trong ô, tắt dấu *
                    if (isPassword)
                    {
                        textBox.PasswordChar = '\0'; // Tắt dấu *
                    }
                }
            };
        }


      
    }
}
    
