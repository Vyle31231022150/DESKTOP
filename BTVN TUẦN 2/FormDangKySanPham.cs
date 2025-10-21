using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace Bài_tập_tuần_2
{
    public partial class FormDangKySanPham : Form
    {
        public FormDangKySanPham()
        {
            InitializeComponent();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            dgvDanhSachSP.Rows.Add(txtTenSP.Text, cboLoaiSP.Text, nudSoLuongSP.Value);
        }

        private void btnResetSP_Click(object sender, EventArgs e)
        {
            txtTenSP.Clear();
            cboLoaiSP.SelectedIndex = -1;
            nudSoLuongSP.Value = 0;
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachSP.SelectedRows.Count > 0)
                dgvDanhSachSP.Rows.RemoveAt(dgvDanhSachSP.SelectedRows[0].Index);
        }
    }
}

