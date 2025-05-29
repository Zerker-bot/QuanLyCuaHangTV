using QuanLyCuaHangTV.CustomControls;
using QuanLyCuaHangTV.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
namespace QuanLyCuaHangTV.Forms
{
    public partial class frmMain : Form
    {
        private bool isLoginFormClosed = false;
        private bool? quyenhan; // Biến để lưu trữ quyền hạn
        private Timer animationTimer = new Timer();
        private int targetTop;
        HelpProvider helpProvider1 = new HelpProvider();
        public frmMain()
        {
            InitializeComponent();
            panelChuyenDong.Visible = false;
            panelThongKeSubMenu.Visible = false;
            string helpFilePath = Path.Combine(Application.StartupPath, "Helps", "help.html");
            if (File.Exists(helpFilePath))
            {
                helpProvider1.HelpNamespace = helpFilePath;
            }
            else
            {
                MessageBox.Show("Không tìm thấy file help.html tại: " + helpFilePath);
            }


            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.F1)
                {
                    Help.ShowHelp(this, helpProvider1.HelpNamespace);
                }
            };

            this.KeyPreview = true;

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();


        }
        public void batTatControl(bool? giaTri)
        {
            if (giaTri == null)
            {
                panelSideMenu.Hide();
            }
            else if (giaTri == true)
            {

                btnHangSanXuat.Show();
                btnNhanVien.Show();
                btnSanPham.Show();
                btnLoaiSanPham.Show();
                panelSideMenu.Show();
            }
            else if (giaTri == false)
            {
                btnHoaDon.Show();
                btnKhachHang.Show();
                btnDangXuat.Show();
                btnTrangChu.Show();
                btnThongKe.Show();
                btnHangSanXuat.Hide();
                btnNhanVien.Hide();
                btnSanPham.Hide();
                btnLoaiSanPham.Hide();
                panelSideMenu.Show();

                

            }
        }
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            int speed = 5; // càng nhỏ càng mượt

            if (Math.Abs(panelChuyenDong.Top - targetTop) <= speed)
            {
                panelChuyenDong.Top = targetTop;
                animationTimer.Stop();
            }
            else if (panelChuyenDong.Top < targetTop)
            {
                panelChuyenDong.Top += speed;
            }
            else
            {
                panelChuyenDong.Top -= speed;
            }
        }
        private void DiChuyenPanel(Control btn)
        {
            targetTop = btn.Top;
            panelChuyenDong.BringToFront();
            animationTimer.Interval = 10;
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();
            panelChuyenDong.Visible = true;

        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            DiChuyenPanel(btnLoaiSanPham);
            frmLoaiSanPham form = new frmLoaiSanPham();
            openChildForm(form);
            panelThongKeSubMenu.Visible = false;

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            DiChuyenPanel(btnNhanVien);
            frmNhanVien form = new frmNhanVien();
            openChildForm(form);
            panelThongKeSubMenu.Visible = false;

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            DiChuyenPanel(btnKhachHang);
            frmKhachHang form = new frmKhachHang();
            openChildForm(form);
            panelThongKeSubMenu.Visible = false;

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            DiChuyenPanel(btnSanPham);
            frmSanPham form = new frmSanPham();
            openChildForm(form);
            panelThongKeSubMenu.Visible = false;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDangNhap form = new frmDangNhap();
            batTatControl(null);
            form.FormClosed += FrmDangNhap_FormClosed;
            openChildForm(form);
           
        }

        private void FrmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            isLoginFormClosed = true;


            if (((frmDangNhap)sender).DialogResult == DialogResult.OK)
            {
                bool quyenHan = (bool)((frmDangNhap)sender).Tag;

                // Sử dụng giá trị quyenHan
                this.quyenhan = quyenHan;
                batTatControl(quyenHan);
                this.BeginInvoke(new Action(() =>
                {
                    DiChuyenPanel(btnTrangChu);
                    frmDashboard form = new frmDashboard();
                    openChildForm(form);
                    panelThongKeSubMenu.Visible = false;
                }));
                

            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            quyenhan = null;
            batTatControl(null);
            panelChuyenDong.Visible = false;
            panelThongKeSubMenu.Visible = false;
            frmDangNhap form = new frmDangNhap();
            form.FormClosed += FrmDangNhap_FormClosed;
            openChildForm(form);
        }

        private void btnHangSanXuat_Click(object sender, EventArgs e)
        {
            DiChuyenPanel(btnHangSanXuat);
            frmHangSanXuat form = new frmHangSanXuat();
            openChildForm(form);
            panelThongKeSubMenu.Visible = false;

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            DiChuyenPanel(btnHoaDon);
            frmHoaDon form = new frmHoaDon();
            openChildForm(form);
            panelThongKeSubMenu.Visible = false;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            DiChuyenPanel(btnTrangChu);

            //if (activeForm != null)
            //{
            //    activeForm.Close();
            //    activeForm = null;
            //}
            frmDashboard form = new frmDashboard();
            openChildForm(form);
            panelThongKeSubMenu.Visible = false;

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DiChuyenPanel(btnThongKe);
            panelThongKeSubMenu.Visible = !panelThongKeSubMenu.Visible;

        }

        private void btnThongKeSanPham_Click(object sender, EventArgs e)
        {
            frmThongKeSanPham form = new frmThongKeSanPham();
            openChildForm(form);
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu form = new frmThongKeDoanhThu();
            openChildForm(form);
        }
    }

}
