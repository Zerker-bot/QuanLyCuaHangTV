﻿using Microsoft.Reporting.WinForms;
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

namespace QuanLyCuaHangTV.Reports
{
    public partial class frmThongKeDoanhThu : Form
    {
        QLCHTVDbContext context = new QLCHTVDbContext();
        QLCHTVDataSet.DanhSachHoaDonDataTable danhSachHoaDonDataTable = new QLCHTVDataSet.DanhSachHoaDonDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            var danhSachHoaDon = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => Convert.ToInt32(r.SoLuongBan * r.DonGiaBan))
            }).ToList();
            foreach (var row in danhSachHoaDon)
            {
                danhSachHoaDonDataTable.AddDanhSachHoaDonRow(row.ID,
                    row.NhanVienID,
                    row.HoVaTenNhanVien,
                    row.KhachHangID,
                    row.HoVaTenKhachHang,
                    row.NgayLap,
                    row.GhiChuHoaDon,
                    row.TongTienHoaDon ?? 0);
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachHoaDon";
            reportDataSource.Value = danhSachHoaDonDataTable;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");
            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả thời gian)");
            reportViewer.LocalReport.SetParameters(reportParameter);
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;

            reportViewer.RefreshReport();
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            var danhSachHoaDon = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => Convert.ToInt32(r.SoLuongBan * r.DonGiaBan))
            });

            danhSachHoaDon = danhSachHoaDon.Where(r => r.NgayLap >= dtpTuNgay.Value && r.NgayLap <= dtpDenNgay.Value);

            danhSachHoaDonDataTable.Clear();
            foreach (var row in danhSachHoaDon)
            {
                danhSachHoaDonDataTable.AddDanhSachHoaDonRow(row.ID,
                    row.NhanVienID,
                    row.HoVaTenNhanVien,
                    row.KhachHangID,
                    row.HoVaTenKhachHang,
                    row.NgayLap,
                    row.GhiChuHoaDon,
                    row.TongTienHoaDon ?? 0);
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachHoaDon";
            reportDataSource.Value = danhSachHoaDonDataTable;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");

            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "Từ ngày " + dtpTuNgay.Text + " - Đến ngày: " + dtpDenNgay.Text);
            reportViewer.LocalReport.SetParameters(reportParameter);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;

            reportViewer.RefreshReport();
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu_Load(sender, e);
        }
    }
}
