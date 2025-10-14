namespace BTVN3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnHienThi.Click += BtnHienThi_Click;
            btnThoat.Click += BtnThoat_Click;
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            this.MouseClick += Form1_MouseClick;
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn mở ứng dụng không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void BtnHienThi_Click(object sender, EventArgs e)
        {
            string noiDung = NoiDung.Text;
            MessageBox.Show(noiDung, "Nội dung TextBox");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.H)
            {
                NoiDung.Text = "Xin chào Khoa CNTTKD";
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                MessageBox.Show("Bạn vừa nhấp chuột phải!");
            else if (e.Button == MouseButtons.Left)
                MessageBox.Show("Bạn vừa nhấp chuột trái!");
            else if (e.Button == MouseButtons.Middle)
                MessageBox.Show("Bạn vừa nhấp chuột giữa!");
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát ứng dụng không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {

        }
    }
}


