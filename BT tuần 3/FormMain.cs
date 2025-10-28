using System;
using System.Linq;
using System.Windows.Forms;

namespace BT_tuần_3
{
    public partial class FormMain : Form
    {
        private string currentUser = "Guest";

        public FormMain(string username = "Guest")
        {
            InitializeComponent();
            currentUser = string.IsNullOrWhiteSpace(username) ? "Guest" : username;
            UpdateStatus();
            tmClock.Start();
        }

        private void UpdateStatus()
        {
            ssUser.Text = $"User: {currentUser}";
            ssForm.Text = "Form: -";

            bool isGuest = string.Equals(currentUser, "Guest", StringComparison.OrdinalIgnoreCase);
            mnLogout.Enabled = !isGuest;
            mnQuanLy.Enabled = !isGuest;
        }

        // --- MENU EVENT HANDLERS ---
        private void mnLogin_Click(object sender, EventArgs e)
        {
            using (var dlg = new LoginForm())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var prop = dlg.GetType().GetProperty("Username");
                    currentUser = prop?.GetValue(dlg) as string ?? "Guest";
                    UpdateStatus();
                }
            }
        }

        private void mnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            currentUser = "Guest";
            UpdateStatus();

            foreach (var child in this.MdiChildren.ToArray())
                child.Close();
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void mnNhanVien_Click(object sender, EventArgs e) => OpenMdiChild(typeof(EmployeeForm));
        private void mnSanPham_Click(object sender, EventArgs e) => OpenMdiChild(typeof(ProductForm));
        private void mnHoaDon_Click(object sender, EventArgs e) => OpenMdiChild(typeof(InvoiceForm));

        private void mnGioiThieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mini Store Manager - Demo\nTác giả: Bạn", "Giới thiệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnLienHe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email: support@example.com\nPhone: +84 123456789", "Liên hệ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- MDI CHILD HELPER ---
        private void OpenMdiChild(Type formType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formType)
                {
                    f.BringToFront();
                    return;
                }
            }

            Form child;
            try
            {
                child = (Form)Activator.CreateInstance(formType, currentUser);
            }
            catch
            {
                child = (Form)Activator.CreateInstance(formType);
            }

            child.MdiParent = this;
            child.Show();
            ssForm.Text = "Form: " + child.Text;
        }

        // --- TIMER & NOTIFY ---
        private void tmClock_Tick(object sender, EventArgs e)
        {
            ssTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                niMain.Visible = true;
                niMain.ShowBalloonTip(400);
            }
        }

        private void niMain_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            niMain.Visible = false;
        }
    }
}
