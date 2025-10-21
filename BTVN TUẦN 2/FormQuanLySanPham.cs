namespace Bài_tập_tuần_2
{
    public partial class FormQuanLySanPham : Form
    {
        public FormQuanLySanPham()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lblTrangThai.Text = "Đã thêm sản phẩm mới!";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lblTrangThai.Text = "Đã cập nhật thông tin sản phẩm!";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lblTrangThai.Text = "Đã xóa sản phẩm!";
        }

        private void anhBia_Click(object sender, EventArgs e)
        {

        }

        private void bangSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

