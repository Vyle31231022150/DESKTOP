using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;


    namespace Bài_tập_tuần_2
    {
        partial class FormLogin
        {
            private System.ComponentModel.IContainer components = null;

            private TextBox txtTenDangNhap;
            private TextBox txtMatKhau;
            private Button btnDangNhap;
            private ErrorProvider loiNhapLieu;
            private ToolTip goiYNhapLieu;

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
            components = new System.ComponentModel.Container();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            loiNhapLieu = new ErrorProvider(components);
            goiYNhapLieu = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)loiNhapLieu).BeginInit();
            SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(73, 48);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "Tên đăng nhập";
            txtTenDangNhap.Size = new Size(153, 31);
            txtTenDangNhap.TabIndex = 0;
            goiYNhapLieu.SetToolTip(txtTenDangNhap, "Tài khoản mặc định: admin");
            txtTenDangNhap.TextChanged += txtTenDangNhap_TextChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(73, 105);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "Mật khẩu";
            txtMatKhau.Size = new Size(153, 31);
            txtMatKhau.TabIndex = 1;
            goiYNhapLieu.SetToolTip(txtMatKhau, "Mật khẩu mặc định: 123");
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(106, 160);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(75, 30);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // loiNhapLieu
            // 
            loiNhapLieu.ContainerControl = this;
            // 
            // FormLogin
            // 
            ClientSize = new Size(291, 234);
            Controls.Add(txtTenDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(btnDangNhap);
            Name = "FormLogin";
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)loiNhapLieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
    }