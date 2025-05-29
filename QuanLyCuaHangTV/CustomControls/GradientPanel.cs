using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;
using Timer = System.Windows.Forms.Timer;

namespace QuanLyCuaHangTV.CustomControls
{
    internal class GradientPanel : UserControl
    {
        private int _borderRadius = 20;
        private float _angle;
        private Color _color0 = ColorTranslator.FromHtml("#23074d    ");
        private Color _color1 = ColorTranslator.FromHtml("#cc5333     ");
        //  private Color _color0 = Color.Red;
        // private Color _color1 = Color.BlueViolet;
        private Timer _timer;

        [ToolboxItem(true)]
        public GradientPanel()
        {
            // Cấu hình để render mượt
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);

            // Khởi tạo timer
            _timer = new Timer { Interval = 10 }; // 100 FPS
            _timer.Tick += (s, e) =>
            {
                _angle = (_angle + 1.0f) % 360; // Tốc độ quay nhanh hơn
                Invalidate();
            };
            _timer.Start();
        }

        [Category("Appearance")]
        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; Invalidate(); }
        }

        [Category("Appearance")]
        public float Angle
        {
            get => _angle;
            set { _angle = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color Color0
        {
            get => _color0;
            set { _color0 = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color Color1
        {
            get => _color1;
            set { _color1 = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Tạo gradient mới mỗi lần vẽ để đảm bảo xoay mượt
            using (var brush = new LinearGradientBrush(
                ClientRectangle,
                _color0,
                _color1,
                _angle))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }

          
        }

        private GraphicsPath CreateRoundedPath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) _timer?.Dispose();
            base.Dispose(disposing);
        }
    }
}