using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace BT_tuần_3
{
    public partial class EmployeeForm : Form
    {
        private BindingList<Employee> employeeList = new BindingList<Employee>();

        public EmployeeForm(string username = null)
        {
            InitializeComponent();
            dgvEmployees.DataSource = employeeList;
            // sample data
            employeeList.Add(new Employee { Id = "E01", FullName = "Nguyễn A", Position = "Sale" });
            employeeList.Add(new Employee { Id = "E02", FullName = "Trần B", Position = "Manager" });
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeId.Text) || string.IsNullOrWhiteSpace(txtEmployeeName.Text)) return;
            if (employeeList.Any(x => x.Id == txtEmployeeId.Text.Trim()))
            {
                MessageBox.Show("ID đã tồn tại");
                return;
            }
            employeeList.Add(new Employee
            {
                Id = txtEmployeeId.Text.Trim(),
                FullName = txtEmployeeName.Text.Trim(),
                Position = txtEmployeePosition.Text.Trim()
            });
            ClearInputFields();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null) return;
            var emp = dgvEmployees.CurrentRow.DataBoundItem as Employee;
            if (emp == null) return;
            emp.FullName = txtEmployeeName.Text.Trim();
            emp.Position = txtEmployeePosition.Text.Trim();
            dgvEmployees.Refresh();
            ClearInputFields();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null) return;
            var emp = dgvEmployees.CurrentRow.DataBoundItem as Employee;
            if (emp == null) return;
            if (MessageBox.Show($"Xóa {emp.FullName}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                employeeList.Remove(emp);
            }
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null) return;

            var obj = dgvEmployees.CurrentRow.DataBoundItem;
            if (obj is Employee emp)
            {
                txtEmployeeId.Text = emp.Id;
                txtEmployeeName.Text = emp.FullName;
                txtEmployeePosition.Text = emp.Position;
            }
            else
            {
                var row = dgvEmployees.CurrentRow;
                txtEmployeeId.Text = row.Cells[0]?.Value?.ToString() ?? "";
                txtEmployeeName.Text = row.Cells[1]?.Value?.ToString() ?? "";
                txtEmployeePosition.Text = row.Cells[2]?.Value?.ToString() ?? "";
            }
            txtEmployeeId.Enabled = false;
        }

        private void ClearInputFields()
        {
            txtEmployeeId.Text = "";
            txtEmployeeName.Text = "";
            txtEmployeePosition.Text = "";
            txtEmployeeId.Enabled = true;
        }
    }
}
