namespace BT_tuần_3
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        // MenuStrip
        private MenuStrip mnMain;
        private ToolStripMenuItem mnHeThong;
        private ToolStripMenuItem mnLogin;
        private ToolStripMenuItem mnLogout;
        private ToolStripMenuItem mnExit;

        private ToolStripMenuItem mnQuanLy;
        private ToolStripMenuItem mnNhanVien;
        private ToolStripMenuItem mnSanPham;
        private ToolStripMenuItem mnHoaDon;

        private ToolStripMenuItem mnTroGiup;
        private ToolStripMenuItem mnGioiThieu;
        private ToolStripMenuItem mnLienHe;

        // StatusStrip
        private StatusStrip ssMain;
        private ToolStripStatusLabel ssUser;
        private ToolStripStatusLabel ssForm;
        private ToolStripStatusLabel ssTime;

        // Timer và NotifyIcon
        private System.Windows.Forms.Timer tmClock;
        private NotifyIcon niMain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // --- MENU ---
            this.mnMain = new MenuStrip();
            this.mnHeThong = new ToolStripMenuItem();
            this.mnLogin = new ToolStripMenuItem();
            this.mnLogout = new ToolStripMenuItem();
            this.mnExit = new ToolStripMenuItem();

            this.mnQuanLy = new ToolStripMenuItem();
            this.mnNhanVien = new ToolStripMenuItem();
            this.mnSanPham = new ToolStripMenuItem();
            this.mnHoaDon = new ToolStripMenuItem();

            this.mnTroGiup = new ToolStripMenuItem();
            this.mnGioiThieu = new ToolStripMenuItem();
            this.mnLienHe = new ToolStripMenuItem();

            // --- STATUS ---
            this.ssMain = new StatusStrip();
            this.ssUser = new ToolStripStatusLabel();
            this.ssForm = new ToolStripStatusLabel();
            this.ssTime = new ToolStripStatusLabel();

            this.tmClock = new System.Windows.Forms.Timer(this.components);
            this.niMain = new NotifyIcon(this.components);

            // ---------- HỆ THỐNG ----------
            this.mnHeThong.Text = "Hệ thống";
            this.mnLogin.Text = "Đăng nhập";
            this.mnLogin.ShortcutKeys = Keys.Control | Keys.L;
            this.mnLogin.Click += new EventHandler(this.mnLogin_Click);

            this.mnLogout.Text = "Đăng xuất";
            this.mnLogout.ShortcutKeys = Keys.Control | Keys.O;
            this.mnLogout.Click += new EventHandler(this.mnLogout_Click);

            this.mnExit.Text = "Thoát";
            this.mnExit.ShortcutKeys = Keys.Alt | Keys.F4;
            this.mnExit.Click += new EventHandler(this.mnExit_Click);

            this.mnHeThong.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.mnLogin, this.mnLogout, new ToolStripSeparator(), this.mnExit
            });

            // ---------- QUẢN LÝ ----------
            this.mnQuanLy.Text = "Quản lý";
            this.mnNhanVien.Text = "Nhân viên";
            this.mnSanPham.Text = "Sản phẩm";
            this.mnHoaDon.Text = "Hóa đơn";

            this.mnNhanVien.Click += new EventHandler(this.mnNhanVien_Click);
            this.mnSanPham.Click += new EventHandler(this.mnSanPham_Click);
            this.mnHoaDon.Click += new EventHandler(this.mnHoaDon_Click);

            this.mnQuanLy.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.mnNhanVien, this.mnSanPham, this.mnHoaDon
            });

            // ---------- TRỢ GIÚP ----------
            this.mnTroGiup.Text = "Trợ giúp";
            this.mnGioiThieu.Text = "Giới thiệu";
            this.mnLienHe.Text = "Liên hệ";
            this.mnGioiThieu.Click += new EventHandler(this.mnGioiThieu_Click);
            this.mnLienHe.Click += new EventHandler(this.mnLienHe_Click);
            this.mnTroGiup.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.mnGioiThieu, this.mnLienHe
            });

            // ---------- MENU MAIN ----------
            this.mnMain.Items.AddRange(new ToolStripItem[]
            {
                this.mnHeThong, this.mnQuanLy, this.mnTroGiup
            });

            // ---------- STATUSSTRIP ----------
            this.ssMain.Items.AddRange(new ToolStripItem[]
            {
                this.ssUser, this.ssForm, this.ssTime
            });

            // ---------- TIMER ----------
            this.tmClock.Interval = 1000;
            this.tmClock.Tick += new EventHandler(this.tmClock_Tick);

            // ---------- NOTIFYICON ----------
            this.niMain.Text = "MiniStoreManager";
            this.niMain.Icon = SystemIcons.Application;
            this.niMain.DoubleClick += new EventHandler(this.niMain_DoubleClick);

            // ---------- FORM SETTINGS ----------
            this.Controls.Add(this.mnMain);
            this.Controls.Add(this.ssMain);
            this.MainMenuStrip = this.mnMain;
            this.menuStripMain = this.mnMain;

            this.IsMdiContainer = true;
            this.Text = "Mini Store Manager";
            this.WindowState = FormWindowState.Maximized;
            this.Resize += new EventHandler(this.FormMain_Resize);
        }
    }
}
