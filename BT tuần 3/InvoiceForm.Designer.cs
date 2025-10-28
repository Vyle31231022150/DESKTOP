using System.Drawing.Printing;

namespace BT_tuần_3
{
    partial class InvoiceForm
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pbLogo;
        private Label lblStoreName;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private DataGridView dgvBill;
        private Button btnAddItem;
        private Button btnRemoveItem;
        private Button btnSaveBill;
        private Button btnPrintBill;
        private Label lblTotalText;
        private Label lblTotalAmount;
        private PrintPreviewDialog previewDialog;
        private PrintDocument printDocument1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            pbLogo = new PictureBox();
            lblStoreName = new Label();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            dgvBill = new DataGridView();
            btnAddItem = new Button();
            btnRemoveItem = new Button();
            btnSaveBill = new Button();
            btnPrintBill = new Button();
            lblTotalText = new Label();
            lblTotalAmount = new Label();
            previewDialog = new PrintPreviewDialog();
            printDocument1 = new PrintDocument();

            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            SuspendLayout();

            pbLogo.BorderStyle = BorderStyle.FixedSingle;
            pbLogo.Location = new Point(16, 12);
            pbLogo.Size = new Size(80, 80);
            pbLogo.TabStop = false;

            lblStoreName.AutoSize = true;
            lblStoreName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblStoreName.Location = new Point(110, 20);
            lblStoreName.Text = "CỬA HÀNG MINI - VIỆT";

            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(16, 110);
            lblCustomerName.Text = "Tên khách hàng:";

            txtCustomerName.Location = new Point(130, 107);
            txtCustomerName.Size = new Size(360, 27);

            dgvBill.Location = new Point(16, 140);
            dgvBill.Size = new Size(972, 318);

            btnAddItem.Location = new Point(16, 470);
            btnAddItem.Size = new Size(145, 38);
            btnAddItem.Text = "Thêm sản phẩm";
            btnAddItem.Click += BtnAddItem_Click;

            btnRemoveItem.Location = new Point(167, 471);
            btnRemoveItem.Size = new Size(124, 37);
            btnRemoveItem.Text = "Xóa sản phẩm";
            btnRemoveItem.Click += BtnRemoveItem_Click;

            btnSaveBill.Location = new Point(299, 470);
            btnSaveBill.Size = new Size(107, 38);
            btnSaveBill.Text = "Lưu hóa đơn";
            btnSaveBill.Click += BtnSaveBill_Click;

            btnPrintBill.Location = new Point(415, 471);
            btnPrintBill.Size = new Size(94, 37);
            btnPrintBill.Text = "In biên lai";
            btnPrintBill.Click += BtnPrintBill_Click;

            lblTotalText.AutoSize = true;
            lblTotalText.Location = new Point(540, 470);
            lblTotalText.Text = "Tổng tiền:";

            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalAmount.Location = new Point(610, 470);
            lblTotalAmount.Text = "0 VNĐ";

            previewDialog.ClientSize = new Size(400, 300);
            previewDialog.Document = printDocument1;
            previewDialog.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");

            ClientSize = new Size(1012, 518);
            Controls.AddRange(new Control[] {
                pbLogo, lblStoreName, lblCustomerName, txtCustomerName,
                dgvBill, btnAddItem, btnRemoveItem, btnSaveBill, btnPrintBill,
                lblTotalText, lblTotalAmount
            });
            Text = "Hóa đơn";
            StartPosition = FormStartPosition.CenterParent;

            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
