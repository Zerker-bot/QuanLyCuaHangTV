﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTV.Data
{
    public class SanPham
    {
        public int ID { get; set; }
        public int HangSanXuatID { get; set; }
        public int LoaiSanPhamID { get; set;}
        public string? TenSanPham { get; set; }
        public int GiaNhap { get; set; }
        public int GiaBan { get; set; }
        public int SoLuong { get; set; }
        public string? KichThuoc { get; set; }
        public string? DoPhanGiai { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get;set; }
        public virtual ObservableCollectionListSource<HoaDon_ChiTiet> HoaDon_ChiTiet { get; } = new();
        public virtual LoaiSanPham LoaiSanPham { get; set; } = null!;
        public virtual HangSanXuat HangSanXuat { get; set; } = null!;
    }
    [NotMapped]
    public class DanhSachSanPham
    {
        public int ID { get; set; }
        public int HangSanXuatID { get; set; }
        public string? TenHangSanXuat { get; set; }  // Thêm 
        public int LoaiSanPhamID { get; set; }
        public string? TenLoai { get; set; }         // Thêm 
        public string? TenSanPham { get; set; }
        public int GiaNhap { get; set; }
        public int GiaBan { get; set; }
        public int SoLuong { get; set; }
        public string? KichThuoc { get; set; }
        public string? DoPhanGiai { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }
    
    }
}
