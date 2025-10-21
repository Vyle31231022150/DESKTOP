using System.Windows.Forms;

namespace Bài_tập_tuần_2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            loiNhapLieu.Clear();

            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                loiNhapLieu.SetError(txtTenDangNhap, "Vui lòng nhập tên đăng nhập!");
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                loiNhapLieu.SetError(txtMatKhau, "Vui lòng nhập mật khẩu!");

            if (txtTenDangNhap.Text == "admin" && txtMatKhau.Text == "123")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                FormDangKySanPham frm = new FormDangKySanPham();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi");
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
