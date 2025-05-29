using System;
using System.Windows.Forms;
using QuanLyCuaHangTV.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using SkiaSharp;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System.Globalization;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.SkiaSharpView.Painting;

namespace QuanLyCuaHangTV.Forms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        QLCHTVDbContext context = new QLCHTVDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        private void LoadChart()
        {
            var now = DateTime.Now;
            var startMonth = new DateTime(now.Year, now.Month, 1).AddMonths(-5);

            var doanhThuTheoThang = context.HoaDon
                .Include(hd => hd.HoaDon_ChiTiet)
                .Where(hd => hd.NgayLap >= startMonth)
                .AsEnumerable()
                .GroupBy(hd => new { hd.NgayLap.Year, hd.NgayLap.Month })
                .Select(g => new
                {
                    Nam = g.Key.Year,
                    Thang = g.Key.Month,
                    TongDoanhThu = g.Sum(hd => hd.HoaDon_ChiTiet.Sum(hdct => (decimal)hdct.SoLuongBan * hdct.DonGiaBan))
                })
                .ToList();

            var labels = new List<string>();
            var values = new List<decimal>();

            for (int i = 0; i < 6; i++)
            {
                var date = startMonth.AddMonths(i);
                labels.Add(date.ToString("MM/yyyy"));

                var item = doanhThuTheoThang.FirstOrDefault(x => x.Nam == date.Year && x.Thang == date.Month);
                values.Add(item?.TongDoanhThu ?? 0);
            }

            cartesianChartRevenue.Series = new ISeries[]
            {
        new ColumnSeries<decimal>
        {
            Values = values,
            Name = "Doanh thu",

        }
            };

            cartesianChartRevenue.XAxes = new[]
            {
        new Axis
        {
            Labels = labels,
            LabelsRotation = 15,
            Name = "Tháng/Năm",
              NamePaint = new SolidColorPaint(SKColors.White, 16),   // màu trắng, size 16
            LabelsPaint = new SolidColorPaint(SKColors.White, 14), // màu trắng, size 14
            SeparatorsPaint = new SolidColorPaint(SKColors.Gray.WithAlpha(80)), // vạch lưới màu xám nhạt
            TicksPaint = new SolidColorPaint(SKColors.White),       // vạch đánh dấu trắng
        }
    };

            cartesianChartRevenue.YAxes = new[]
            {
        new Axis
        {
            Name = "Doanh thu (VNĐ)",
            Labeler = value => value.ToString("C0", new CultureInfo("vi-VN")),
              NamePaint = new SolidColorPaint(SKColors.White, 16),   // màu trắng, size 16
            LabelsPaint = new SolidColorPaint(SKColors.White, 14), // màu trắng, size 14
            SeparatorsPaint = new SolidColorPaint(SKColors.Gray.WithAlpha(80)), // vạch lưới màu xám nhạt
            TicksPaint = new SolidColorPaint(SKColors.White),       // vạch đánh dấu trắng
        }
    };
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            try
            {

                decimal tongDoanhThu = context.HoaDon
                    .Include(hd => hd.HoaDon_ChiTiet)
                    .Sum(hd => hd.HoaDon_ChiTiet.Sum(hdct => (decimal)hdct.SoLuongBan * hdct.DonGiaBan));
                int tongSanPhamBan = context.HoaDon_ChiTiet
                   .Sum(hdct => hdct.SoLuongBan);
                int tongKhachHang = context.KhachHang
                    .Count();

                lblDoanhThu.Text = tongDoanhThu.ToString("#,##0 VNĐ");
                lblSanPhamDaBan.Text = tongSanPhamBan.ToString();
                lblSoKhachHang.Text = tongKhachHang.ToString();

                LoadChart();

            }
            catch (Exception ex)
            {
              

                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}