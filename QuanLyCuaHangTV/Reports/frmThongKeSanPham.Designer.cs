namespace QuanLyCuaHangTV.Reports
{
    partial class frmThongKeSanPham
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
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            panel1 = new Panel();
            cboHangSanXuat = new ComboBox();
            cboLoaiSanPham = new ComboBox();
            btnLocKetQua = new Button();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer.Location = new Point(0, 99);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(819, 322);
            reportViewer.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(224, 226, 229);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnLocKetQua);
            panel1.Controls.Add(cboLoaiSanPham);
            panel1.Controls.Add(cboHangSanXuat);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 91);
            panel1.TabIndex = 1;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.Font = new Font("Consolas", 10.2F);
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(171, 31);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(151, 28);
            cboHangSanXuat.TabIndex = 0;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.Font = new Font("Consolas", 10.2F);
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(487, 31);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(151, 28);
            cboLoaiSanPham.TabIndex = 1;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLocKetQua.Location = new Point(644, 30);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(148, 29);
            btnLocKetQua.TabIndex = 2;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 32);
            label3.Name = "label3";
            label3.Size = new Size(153, 23);
            label3.TabIndex = 7;
            label3.Text = "Hãng sản xuất";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(328, 32);
            label1.Name = "label1";
            label1.Size = new Size(153, 23);
            label1.TabIndex = 8;
            label1.Text = "Loại sản phẩm";
            // 
            // frmThongKeSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 416);
            Controls.Add(panel1);
            Controls.Add(reportViewer);
            Name = "frmThongKeSanPham";
            Text = "frmThongKeSanPham";
            Load += frmThongKeSanPham_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Panel panel1;
        private Button btnLocKetQua;
        private ComboBox cboLoaiSanPham;
        private ComboBox cboHangSanXuat;
        private Label label1;
        private Label label3;
    }
}