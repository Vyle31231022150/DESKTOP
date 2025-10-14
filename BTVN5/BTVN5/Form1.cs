namespace BTVN5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Gán sự kiện cho nút
            btnTim.Click += BtnTim_Click;
            btnBoQua.Click += BtnBoQua_Click;
            btnThoat.Click += BtnThoat_Click;

            // Chỉ cho phép nhập số
            txtA.KeyPress += Txt_KeyPress;
            txtB.KeyPress += Txt_KeyPress;
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số hoặc phím điều khiển (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtA.Text, out int a) || !int.TryParse(txtB.Text, out int b))
            {
                MessageBox.Show("Vui lòng nhập hai số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rdbUSCLN.Checked)
            {
                txtKetQua.Text = TinhUSCLN(a, b).ToString();
            }
            else if (rdbBSCNN.Checked)
            {
                txtKetQua.Text = TinhBSCNN(a, b).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kiểu tính USCLN hoặc BSCNN!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBoQua_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
            rdbUSCLN.Checked = false;
            rdbBSCNN.Checked = false;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private int TinhUSCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private int TinhBSCNN(int a, int b)
        {
            int uscln = TinhUSCLN(a, b);
            return Math.Abs(a * b) / uscln;
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


