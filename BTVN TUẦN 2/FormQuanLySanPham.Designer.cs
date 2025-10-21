using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bài_tập_tuần_2
{
    partial class FormQuanLySanPham
    {
        private System.ComponentModel.IContainer thanhPhan = null;

        private Panel khungTrai, khungPhai;
        private TextBox oNhapTen;
        private ComboBox hopLoai;
        private NumericUpDown oNhapSoLuong;
        private Button nutThem, nutSua, nutXoa;
        private GroupBox nhomTinhTrang;
        private RadioButton chonConHang, chonHetHang;
        private DataGridView bangSanPham;
        private ErrorProvider thongBaoLoi;
        private ToolTip goiY;
        private StatusStrip thanhTrangThai;
        private ToolStripStatusLabel lblTrangThai;
        private PictureBox anhBia;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (thanhPhan != null))
                thanhPhan.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLySanPham));
            khungTrai = new Panel();
            anhBia = new PictureBox();
            oNhapTen = new TextBox();
            hopLoai = new ComboBox();
            oNhapSoLuong = new NumericUpDown();
            nhomTinhTrang = new GroupBox();
            chonConHang = new RadioButton();
            chonHetHang = new RadioButton();
            nutThem = new Button();
            nutSua = new Button();
            nutXoa = new Button();
            khungPhai = new Panel();
            bangSanPham = new DataGridView();
            thongBaoLoi = new ErrorProvider(components);
            goiY = new ToolTip(components);
            thanhTrangThai = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            khungTrai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)anhBia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oNhapSoLuong).BeginInit();
            nhomTinhTrang.SuspendLayout();
            khungPhai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bangSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thongBaoLoi).BeginInit();
            thanhTrangThai.SuspendLayout();
            SuspendLayout();
            // 
            // khungTrai
            // 
            khungTrai.BackColor = Color.MintCream;
            khungTrai.Controls.Add(anhBia);
            khungTrai.Controls.Add(oNhapTen);
            khungTrai.Controls.Add(hopLoai);
            khungTrai.Controls.Add(oNhapSoLuong);
            khungTrai.Controls.Add(nhomTinhTrang);
            khungTrai.Controls.Add(nutThem);
            khungTrai.Controls.Add(nutSua);
            khungTrai.Controls.Add(nutXoa);
            khungTrai.Dock = DockStyle.Left;
            khungTrai.Location = new Point(0, 0);
            khungTrai.Name = "khungTrai";
            khungTrai.Size = new Size(300, 420);
            khungTrai.TabIndex = 1;
            // 
            // anhBia
            // 
            anhBia.Image = (Image)resources.GetObject("anhBia.Image");
            anhBia.Location = new Point(19, 238);
            anhBia.Name = "anhBia";
            anhBia.Size = new Size(263, 163);
            anhBia.TabIndex = 0;
            anhBia.TabStop = false;
            anhBia.Click += anhBia_Click;
            // 
            // oNhapTen
            // 
            oNhapTen.Location = new Point(38, 16);
            oNhapTen.Name = "oNhapTen";
            oNhapTen.Size = new Size(220, 31);
            oNhapTen.TabIndex = 1;
            goiY.SetToolTip(oNhapTen, "Nhập tên sản phẩm");
            // 
            // hopLoai
            // 
            hopLoai.Items.AddRange(new object[] { "Cà phê", "Trà", "Nước ngọt" });
            hopLoai.Location = new Point(38, 49);
            hopLoai.Name = "hopLoai";
            hopLoai.Size = new Size(220, 33);
            hopLoai.TabIndex = 2;
            goiY.SetToolTip(hopLoai, "Chọn loại sản phẩm");
            // 
            // oNhapSoLuong
            // 
            oNhapSoLuong.Location = new Point(38, 83);
            oNhapSoLuong.Name = "oNhapSoLuong";
            oNhapSoLuong.Size = new Size(220, 31);
            oNhapSoLuong.TabIndex = 3;
            goiY.SetToolTip(oNhapSoLuong, "Nhập số lượng > 0");
            // 
            // nhomTinhTrang
            // 
            nhomTinhTrang.Controls.Add(chonConHang);
            nhomTinhTrang.Controls.Add(chonHetHang);
            nhomTinhTrang.Location = new Point(38, 116);
            nhomTinhTrang.Name = "nhomTinhTrang";
            nhomTinhTrang.Size = new Size(220, 80);
            nhomTinhTrang.TabIndex = 4;
            nhomTinhTrang.TabStop = false;
            nhomTinhTrang.Text = "Tình trạng sản phẩm";
            // 
            // chonConHang
            // 
            chonConHang.Checked = true;
            chonConHang.Location = new Point(10, 30);
            chonConHang.Name = "chonConHang";
            chonConHang.Size = new Size(104, 24);
            chonConHang.TabIndex = 0;
            chonConHang.TabStop = true;
            chonConHang.Text = "Còn hàng";
            // 
            // chonHetHang
            // 
            chonHetHang.Location = new Point(100, 30);
            chonHetHang.Name = "chonHetHang";
            chonHetHang.Size = new Size(104, 24);
            chonHetHang.TabIndex = 1;
            chonHetHang.Text = "Hết hàng";
            // 
            // nutThem
            // 
            nutThem.Location = new Point(19, 202);
            nutThem.Name = "nutThem";
            nutThem.Size = new Size(75, 30);
            nutThem.TabIndex = 5;
            nutThem.Text = "Thêm";
            nutThem.Click += btnThem_Click;
            // 
            // nutSua
            // 
            nutSua.Location = new Point(109, 202);
            nutSua.Name = "nutSua";
            nutSua.Size = new Size(75, 30);
            nutSua.TabIndex = 6;
            nutSua.Text = "Sửa";
            nutSua.Click += btnSua_Click;
            // 
            // nutXoa
            // 
            nutXoa.Location = new Point(199, 202);
            nutXoa.Name = "nutXoa";
            nutXoa.Size = new Size(75, 30);
            nutXoa.TabIndex = 7;
            nutXoa.Text = "Xóa";
            nutXoa.Click += btnXoa_Click;
            // 
            // khungPhai
            // 
            khungPhai.Controls.Add(bangSanPham);
            khungPhai.Dock = DockStyle.Fill;
            khungPhai.Location = new Point(300, 0);
            khungPhai.Name = "khungPhai";
            khungPhai.Size = new Size(799, 420);
            khungPhai.TabIndex = 0;
            // 
            // bangSanPham
            // 
            bangSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bangSanPham.ColumnHeadersHeight = 29;
            bangSanPham.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            bangSanPham.Dock = DockStyle.Fill;
            bangSanPham.Location = new Point(0, 0);
            bangSanPham.Name = "bangSanPham";
            bangSanPham.RowHeadersWidth = 62;
            bangSanPham.Size = new Size(799, 420);
            bangSanPham.TabIndex = 0;
            bangSanPham.CellContentClick += bangSanPham_CellContentClick;
            // 
            // thongBaoLoi
            // 
            thongBaoLoi.ContainerControl = this;
            // 
            // thanhTrangThai
            // 
            thanhTrangThai.ImageScalingSize = new Size(20, 20);
            thanhTrangThai.Items.AddRange(new ToolStripItem[] { lblTrangThai });
            thanhTrangThai.Location = new Point(0, 420);
            thanhTrangThai.Name = "thanhTrangThai";
            thanhTrangThai.Size = new Size(1099, 22);
            thanhTrangThai.TabIndex = 2;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(0, 15);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Tên sản phẩm";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Loại";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Tình trạng";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FormQuanLySanPham
            // 
            BackColor = Color.White;
            ClientSize = new Size(1099, 442);
            Controls.Add(khungPhai);
            Controls.Add(khungTrai);
            Controls.Add(thanhTrangThai);
            Name = "FormQuanLySanPham";
            Text = "Quản lý sản phẩm cửa hàng Việt Nam";
            WindowState = FormWindowState.Maximized;
            khungTrai.ResumeLayout(false);
            khungTrai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)anhBia).EndInit();
            ((System.ComponentModel.ISupportInitialize)oNhapSoLuong).EndInit();
            nhomTinhTrang.ResumeLayout(false);
            khungPhai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bangSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)thongBaoLoi).EndInit();
            thanhTrangThai.ResumeLayout(false);
            thanhTrangThai.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private System.ComponentModel.IContainer components;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
