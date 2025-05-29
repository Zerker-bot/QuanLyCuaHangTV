﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTV.Data
{
    public class KhachHang
    {
        public int ID { get; set; }
        public string HoVaTen { get; set; }
        public string? DienThoai { get; set; }
        public string? DiaChi { get;set; }
        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
    }
}
