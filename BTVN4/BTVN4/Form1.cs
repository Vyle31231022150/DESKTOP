namespace BTVN4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {
            // Gán sự kiện cho các nút
            btnCong.Click += BtnCong_Click;
            btnTru.Click += BtnTru_Click;
            btnNhan.Click += BtnNhan_Click;
            btnChia.Click += BtnChia_Click;
            btnDel.Click += BtnDel_Click;

            // Gán sự kiện kiểm tra nhập liệu
            txtSo1.KeyPress += TxtSo_KeyPress;
            txtSo2.KeyPress += TxtSo_KeyPress;
        }
        private void TxtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // chặn ký tự không hợp lệ
            }
        }

        private void BtnCong_Click(object sender, EventArgs e)
        {
            if (TryGetValues(out double a, out double b))
                txtKetQua.Text = (a + b).ToString();
        }

        private void BtnTru_Click(object sender, EventArgs e)
        {
            if (TryGetValues(out double a, out double b))
                txtKetQua.Text = (a - b).ToString();
        }

        private void BtnNhan_Click(object sender, EventArgs e)
        {
            if (TryGetValues(out double a, out double b))
                txtKetQua.Text = (a * b).ToString();
        }

        private void BtnChia_Click(object sender, EventArgs e)
        {
            if (TryGetValues(out double a, out double b))
            {
                if (b == 0)
                    MessageBox.Show("Không chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    txtKetQua.Text = (a / b).ToString();
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtKetQua.Clear();
        }

        private bool TryGetValues(out double a, out double b)
        {
            bool ok1 = double.TryParse(txtSo1.Text, out a);
            bool ok2 = double.TryParse(txtSo2.Text, out b);
            if (!ok1 || !ok2)
            {
                MessageBox.Show("Nhập hai số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void txtSo2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


