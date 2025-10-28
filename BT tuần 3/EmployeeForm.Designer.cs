namespace BT_tuần_3
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private DataGridView dgvEmployees;
        private TextBox txtEmployeeId;
        private TextBox txtEmployeeName;
        private TextBox txtEmployeePosition;
        private Button btnAddEmployee;
        private Button btnUpdateEmployee;
        private Button btnDeleteEmployee;
        private Label lblEmployeeId;
        private Label lblEmployeeName;
        private Label lblEmployeePosition;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvEmployees = new DataGridView();
            txtEmployeeId = new TextBox();
            txtEmployeeName = new TextBox();
            txtEmployeePosition = new TextBox();
            btnAddEmployee = new Button();
            btnUpdateEmployee = new Button();
            btnDeleteEmployee = new Button();
            lblEmployeeId = new Label();
            lblEmployeeName = new Label();
            lblEmployeePosition = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeight = 29;
            dgvEmployees.Location = new Point(10, 10);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(460, 250);
            dgvEmployees.TabIndex = 0;
            dgvEmployees.SelectionChanged += dgvEmployees_SelectionChanged;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(80, 268);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(150, 27);
            txtEmployeeId.TabIndex = 2;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(80, 302);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(150, 27);
            txtEmployeeName.TabIndex = 4;
            // 
            // txtEmployeePosition
            // 
            txtEmployeePosition.Location = new Point(330, 268);
            txtEmployeePosition.Name = "txtEmployeePosition";
            txtEmployeePosition.Size = new Size(140, 27);
            txtEmployeePosition.TabIndex = 6;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(80, 340);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(75, 31);
            btnAddEmployee.TabIndex = 7;
            btnAddEmployee.Text = "Thêm";
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.Location = new Point(160, 340);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(75, 31);
            btnUpdateEmployee.TabIndex = 8;
            btnUpdateEmployee.Text = "Sửa";
            btnUpdateEmployee.Click += btnUpdateEmployee_Click;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new Point(240, 340);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(75, 31);
            btnDeleteEmployee.TabIndex = 9;
            btnDeleteEmployee.Text = "Xóa";
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.Location = new Point(10, 270);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(46, 23);
            lblEmployeeId.TabIndex = 1;
            lblEmployeeId.Text = "ID";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.Location = new Point(10, 305);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(64, 23);
            lblEmployeeName.TabIndex = 3;
            lblEmployeeName.Text = "Họ tên";
            // 
            // lblEmployeePosition
            // 
            lblEmployeePosition.Location = new Point(260, 270);
            lblEmployeePosition.Name = "lblEmployeePosition";
            lblEmployeePosition.Size = new Size(64, 23);
            lblEmployeePosition.TabIndex = 5;
            lblEmployeePosition.Text = "Chức vụ";
            // 
            // EmployeeForm
            // 
            ClientSize = new Size(480, 400);
            Controls.Add(dgvEmployees);
            Controls.Add(lblEmployeeId);
            Controls.Add(txtEmployeeId);
            Controls.Add(lblEmployeeName);
            Controls.Add(txtEmployeeName);
            Controls.Add(lblEmployeePosition);
            Controls.Add(txtEmployeePosition);
            Controls.Add(btnAddEmployee);
            Controls.Add(btnUpdateEmployee);
            Controls.Add(btnDeleteEmployee);
            Name = "EmployeeForm";
            Text = "Nhân viên";
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
