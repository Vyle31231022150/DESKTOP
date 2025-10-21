namespace Bài_tập_tuần_2
{
    partial class FormDangKySanPham
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtTenSP;
        private ComboBox cboLoaiSP;
        private NumericUpDown nudSoLuongSP;
        private Button btnThemSP, btnXoaSP, btnResetSP;
        private DataGridView dgvDanhSachSP;

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
            txtTenSP = new TextBox();
            cboLoaiSP = new ComboBox();
            nudSoLuongSP = new NumericUpDown();
            btnThemSP = new Button();
            btnXoaSP = new Button();
            btnResetSP = new Button();
            dgvDanhSachSP = new DataGridView();
            colTen = new DataGridViewTextBoxColumn();
            colLoai = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)nudSoLuongSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSP).BeginInit();
            SuspendLayout();

            // txtTenSP
            txtTenSP.Location = new Point(30, 20);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.PlaceholderText = "Tên sản phẩm";
            txtTenSP.Size = new Size(255, 27);
            txtTenSP.TabIndex = 0;

            // cboLoaiSP
            cboLoaiSP.Items.AddRange(new object[] { "Cà phê", "Trà", "Nước ngọt" });
            cboLoaiSP.Location = new Point(30, 60);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new Size(255, 28);
            cboLoaiSP.TabIndex = 1;

            // nudSoLuongSP
            nudSoLuongSP.Location = new Point(30, 100);
            nudSoLuongSP.Name = "nudSoLuongSP";
            nudSoLuongSP.Size = new Size(255, 27);
            nudSoLuongSP.TabIndex = 2;

            // btnThemSP
            btnThemSP.Location = new Point(30, 140);
            btnThemSP.Name = "btnThemSP";
            btnThemSP.Size = new Size(75, 34);
            btnThemSP.TabIndex = 3;
            btnThemSP.Text = "Lưu";
            btnThemSP.Click += btnThemSP_Click;

            // btnXoaSP
            btnXoaSP.Location = new Point(120, 140);
            btnXoaSP.Name = "btnXoaSP";
            btnXoaSP.Size = new Size(75, 34);
            btnXoaSP.TabIndex = 4;
            btnXoaSP.Text = "Xóa";
            btnXoaSP.Click += btnXoaSP_Click;

            // btnResetSP
            btnResetSP.Location = new Point(210, 140);
            btnResetSP.Name = "btnResetSP";
            btnResetSP.Size = new Size(75, 34);
            btnResetSP.TabIndex = 5;
            btnResetSP.Text = "Làm mới";
            btnResetSP.Click += btnResetSP_Click;

            // dgvDanhSachSP
            dgvDanhSachSP.ColumnHeadersHeight = 29;
            dgvDanhSachSP.Columns.AddRange(new DataGridViewColumn[] { colTen, colLoai, colSoLuong });
            dgvDanhSachSP.Location = new Point(337, 12);
            dgvDanhSachSP.Name = "dgvDanhSachSP";
            dgvDanhSachSP.RowHeadersWidth = 51;
            dgvDanhSachSP.Size = new Size(400, 200);
            dgvDanhSachSP.TabIndex = 6;

            // Columns
            colTen.HeaderText = "Tên sản phẩm";
            colTen.MinimumWidth = 6;
            colTen.Name = "colTen";
            colTen.Width = 125;

            colLoai.HeaderText = "Loại sản phẩm";
            colLoai.MinimumWidth = 6;
            colLoai.Name = "colLoai";
            colLoai.Width = 125;

            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            colSoLuong.Width = 125;

            // FormDangKySanPham
            ClientSize = new Size(749, 260);
            Controls.Add(txtTenSP);
            Controls.Add(cboLoaiSP);
            Controls.Add(nudSoLuongSP);
            Controls.Add(btnThemSP);
            Controls.Add(btnXoaSP);
            Controls.Add(btnResetSP);
            Controls.Add(dgvDanhSachSP);
            Name = "FormDangKySanPham";
            Text = "Đăng ký sản phẩm";

            ((System.ComponentModel.ISupportInitialize)nudSoLuongSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #region Windows Form Designer generated code
        private DataGridViewTextBoxColumn colTen;
        private DataGridViewTextBoxColumn colLoai;
        private DataGridViewTextBoxColumn colSoLuong;
        #endregion
    }
}