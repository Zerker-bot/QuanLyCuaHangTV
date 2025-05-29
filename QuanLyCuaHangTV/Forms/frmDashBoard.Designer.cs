namespace QuanLyCuaHangTV.Forms
{
    partial class frmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelRevenue = new Panel();
            lblDoanhThu = new Label();
            lblRevenueTitle = new Label();
            panelProducts = new Panel();
            lblSanPhamDaBan = new Label();
            lblProductsTitle = new Label();
            panelCustomers = new Panel();
            lblSoKhachHang = new Label();
            lblCustomersTitle = new Label();
            cartesianChartRevenue = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            panelRevenue.SuspendLayout();
            panelProducts.SuspendLayout();
            panelCustomers.SuspendLayout();
            SuspendLayout();
            // 
            // panelRevenue
            // 
            panelRevenue.BackColor = Color.FromArgb(50, 70, 100);
            panelRevenue.BorderStyle = BorderStyle.FixedSingle;
            panelRevenue.Controls.Add(lblDoanhThu);
            panelRevenue.Controls.Add(lblRevenueTitle);
            panelRevenue.Location = new Point(12, 30);
            panelRevenue.Name = "panelRevenue";
            panelRevenue.Padding = new Padding(2);
            panelRevenue.Size = new Size(380, 150);
            panelRevenue.TabIndex = 1;
            // 
            // lblDoanhThu
            // 
            lblDoanhThu.AutoSize = true;
            lblDoanhThu.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblDoanhThu.ForeColor = Color.FromArgb(64, 158, 255);
            lblDoanhThu.Location = new Point(22, 82);
            lblDoanhThu.Name = "lblDoanhThu";
            lblDoanhThu.Size = new Size(124, 46);
            lblDoanhThu.TabIndex = 1;
            lblDoanhThu.Text = "0 VNĐ";
            // 
            // lblRevenueTitle
            // 
            lblRevenueTitle.AutoSize = true;
            lblRevenueTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblRevenueTitle.ForeColor = Color.FromArgb(200, 200, 200);
            lblRevenueTitle.Location = new Point(22, 32);
            lblRevenueTitle.Name = "lblRevenueTitle";
            lblRevenueTitle.Size = new Size(193, 31);
            lblRevenueTitle.TabIndex = 0;
            lblRevenueTitle.Text = "Tổng Doanh Thu";
            // 
            // panelProducts
            // 
            panelProducts.BackColor = Color.FromArgb(30, 40, 60);
            panelProducts.Controls.Add(lblSanPhamDaBan);
            panelProducts.Controls.Add(lblProductsTitle);
            panelProducts.Location = new Point(410, 30);
            panelProducts.Name = "panelProducts";
            panelProducts.Size = new Size(380, 150);
            panelProducts.TabIndex = 2;
            // 
            // lblSanPhamDaBan
            // 
            lblSanPhamDaBan.AutoSize = true;
            lblSanPhamDaBan.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSanPhamDaBan.ForeColor = Color.FromArgb(255, 153, 51);
            lblSanPhamDaBan.Location = new Point(20, 80);
            lblSanPhamDaBan.Name = "lblSanPhamDaBan";
            lblSanPhamDaBan.Size = new Size(40, 46);
            lblSanPhamDaBan.TabIndex = 1;
            lblSanPhamDaBan.Text = "0";
            // 
            // lblProductsTitle
            // 
            lblProductsTitle.AutoSize = true;
            lblProductsTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblProductsTitle.ForeColor = Color.FromArgb(200, 200, 200);
            lblProductsTitle.Location = new Point(20, 30);
            lblProductsTitle.Name = "lblProductsTitle";
            lblProductsTitle.Size = new Size(202, 31);
            lblProductsTitle.TabIndex = 0;
            lblProductsTitle.Text = "Sản Phẩm Đã Bán";
            // 
            // panelCustomers
            // 
            panelCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCustomers.BackColor = Color.FromArgb(30, 40, 60);
            panelCustomers.Controls.Add(lblSoKhachHang);
            panelCustomers.Controls.Add(lblCustomersTitle);
            panelCustomers.Location = new Point(808, 30);
            panelCustomers.Name = "panelCustomers";
            panelCustomers.Size = new Size(380, 150);
            panelCustomers.TabIndex = 3;
            // 
            // lblSoKhachHang
            // 
            lblSoKhachHang.AutoSize = true;
            lblSoKhachHang.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSoKhachHang.ForeColor = Color.FromArgb(153, 255, 153);
            lblSoKhachHang.Location = new Point(20, 80);
            lblSoKhachHang.Name = "lblSoKhachHang";
            lblSoKhachHang.Size = new Size(40, 46);
            lblSoKhachHang.TabIndex = 1;
            lblSoKhachHang.Text = "0";
            // 
            // lblCustomersTitle
            // 
            lblCustomersTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCustomersTitle.AutoSize = true;
            lblCustomersTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblCustomersTitle.ForeColor = Color.FromArgb(200, 200, 200);
            lblCustomersTitle.Location = new Point(20, 30);
            lblCustomersTitle.Name = "lblCustomersTitle";
            lblCustomersTitle.Size = new Size(177, 31);
            lblCustomersTitle.TabIndex = 0;
            lblCustomersTitle.Text = "Số Khách Hàng";
            // 
            // cartesianChartRevenue
            // 
            cartesianChartRevenue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartesianChartRevenue.BackColor = Color.FromArgb(25, 35, 55);
            cartesianChartRevenue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cartesianChartRevenue.ForeColor = Color.White;
            cartesianChartRevenue.Location = new Point(12, 195);
            cartesianChartRevenue.MatchAxesScreenDataRatio = false;
            cartesianChartRevenue.Name = "cartesianChartRevenue";
            cartesianChartRevenue.Size = new Size(1176, 662);
            cartesianChartRevenue.TabIndex = 5;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 20, 44);
            ClientSize = new Size(1200, 900);
            Controls.Add(cartesianChartRevenue);
            Controls.Add(panelCustomers);
            Controls.Add(panelProducts);
            Controls.Add(panelRevenue);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDashboard";
            Text = "Bảng Điều Khiển";
            Load += frmDashboard_Load;
            panelRevenue.ResumeLayout(false);
            panelRevenue.PerformLayout();
            panelProducts.ResumeLayout(false);
            panelProducts.PerformLayout();
            panelCustomers.ResumeLayout(false);
            panelCustomers.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelRevenue;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblRevenueTitle;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Label lblSanPhamDaBan;
        private System.Windows.Forms.Label lblProductsTitle;
        private System.Windows.Forms.Panel panelCustomers;
        private System.Windows.Forms.Label lblSoKhachHang;
        private System.Windows.Forms.Label lblCustomersTitle;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChartRevenue;
    }
}