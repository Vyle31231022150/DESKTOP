using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_tuần_3
{
    public partial class InvoiceForm : Form
    {
        private PrintDocument billPrinter;
        private List<Product> itemList = new List<Product>();
        private string defaultCustomer = "Khách hàng lẻ";
        private DataTable billTable;
        private decimal totalAmount = 0m;
        private string logoFilePath = "logo.png";
        private Color themeColor = Color.FromArgb(0, 120, 70);

        public InvoiceForm(string username = "Guest")
        {
            InitializeComponent();
            InitBillTable();
            lblStoreName.ForeColor = themeColor;
            this.BackColor = Color.WhiteSmoke;

            try
            {
                if (File.Exists(logoFilePath))
                {
                    pbLogo.Image = Image.FromFile(logoFilePath);
                    pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pbLogo.BackColor = themeColor;
                }
            }
            catch
            {
                pbLogo.BackColor = themeColor;
            }

            UpdateTotalDisplay();
        }

        private void InitBillTable()
        {
            billTable = new DataTable();
            billTable.Columns.Add("ProductCode", typeof(string));
            billTable.Columns.Add("ProductName", typeof(string));
            billTable.Columns.Add("Quantity", typeof(int));
            billTable.Columns.Add("UnitPrice", typeof(decimal));
            billTable.Columns.Add("SubTotal", typeof(decimal), "Quantity * UnitPrice");

            billPrinter = new PrintDocument();
            billPrinter.PrintPage += BillPrinter_PrintPage;

            dgvBill.DataSource = billTable;

            dgvBill.Columns["ProductCode"].HeaderText = "Mã";
            dgvBill.Columns["ProductName"].HeaderText = "Tên sản phẩm";
            dgvBill.Columns["Quantity"].HeaderText = "Số lượng";
            dgvBill.Columns["UnitPrice"].HeaderText = "Đơn giá";
            dgvBill.Columns["SubTotal"].HeaderText = "Thành tiền";

            dgvBill.Columns["UnitPrice"].DefaultCellStyle.Format = "N0";
            dgvBill.Columns["SubTotal"].DefaultCellStyle.Format = "N0";

            dgvBill.AllowUserToAddRows = false;
            dgvBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBill.MultiSelect = false;
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new AddProductDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    billTable.Rows.Add(dialog.Code, dialog.Name, dialog.Quantity, dialog.Price);
                    UpdateTotalDisplay();
                }
            }
        }

        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvBill.CurrentRow == null) return;
            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm đã chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            dgvBill.Rows.RemoveAt(dgvBill.CurrentRow.Index);
            UpdateTotalDisplay();
        }

        private void BtnSaveBill_Click(object sender, EventArgs e)
        {
            if (billTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm trong hóa đơn.", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "CSV files|*.csv";
                saveDialog.FileName = $"HoaDon_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
                if (saveDialog.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var content = new StringBuilder();
                    content.AppendLine($"Tên khách hàng,{txtCustomerName.Text}");
                    content.AppendLine($"Ngày,{DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                    content.AppendLine();
                    content.AppendLine("Mã,Tên,Số lượng,Đơn giá,Thành tiền");
                    foreach (DataRow row in billTable.Rows)
                    {
                        content.AppendLine($"{row["ProductCode"]},{EscapeCsv(row["ProductName"].ToString())},{row["Quantity"]},{row["UnitPrice"]},{row["SubTotal"]}");
                    }
                    content.AppendLine($",,,Tổng,{totalAmount}");
                    File.WriteAllText(saveDialog.FileName, content.ToString(), Encoding.UTF8);
                    MessageBox.Show("Đã lưu hóa đơn.", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnPrintBill_Click(object sender, EventArgs e)
        {
            if (billTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm để in.", "In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var preview = new PrintPreviewDialog())
            {
                preview.Document = billPrinter;
                preview.Width = 800;
                preview.Height = 600;
                preview.ShowDialog();
            }
        }

        private void BillPrinter_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int marginLeft = 40;
            int currentY = 20;

            if (pbLogo.Image != null)
            {
                try
                {
                    g.DrawImage(pbLogo.Image, new Rectangle(marginLeft, currentY, 80, 80));
                }
                catch { }
            }

            using (Font titleFont = new Font("Arial", 14, FontStyle.Bold))
            using (SolidBrush brush = new SolidBrush(themeColor))
            {
                g.DrawString("CỬA HÀNG MINI - VIỆT", titleFont, brush, marginLeft + 100, currentY + 10);
            }

            currentY += 100;

            using (Font f = new Font("Arial", 10))
            {
                g.DrawString($"Tên khách hàng: {txtCustomerName.Text}", f, Brushes.Black, marginLeft, currentY);
                currentY += 20;
                g.DrawString($"Ngày: {DateTime.Now:yyyy-MM-dd HH:mm:ss}", f, Brushes.Black, marginLeft, currentY);
                currentY += 25;

                using (Font headerFont = new Font("Arial", 9, FontStyle.Bold))
                {
                    g.DrawString("STT", headerFont, Brushes.Black, marginLeft, currentY);
                    g.DrawString("Tên sản phẩm", headerFont, Brushes.Black, marginLeft + 40, currentY);
                    g.DrawString("SL", headerFont, Brushes.Black, marginLeft + 300, currentY);
                    g.DrawString("Đơn giá", headerFont, Brushes.Black, marginLeft + 350, currentY);
                    g.DrawString("Thành tiền", headerFont, Brushes.Black, marginLeft + 430, currentY);
                }

                currentY += 18;
                g.DrawLine(Pens.Black, marginLeft, currentY, marginLeft + 520, currentY);
                currentY += 6;

                int index = 1;
                foreach (DataRow r in billTable.Rows)
                {
                    if (currentY > e.MarginBounds.Bottom - 50)
                    {
                        e.HasMorePages = true;
                        return;
                    }

                    string name = r["ProductName"].ToString();
                    int qty = Convert.ToInt32(r["Quantity"]);
                    decimal price = Convert.ToDecimal(r["UnitPrice"]);
                    decimal amount = Convert.ToDecimal(r["SubTotal"]);

                    g.DrawString(index.ToString(), f, Brushes.Black, marginLeft, currentY);
                    g.DrawString(name, f, Brushes.Black, marginLeft + 40, currentY);
                    g.DrawString(qty.ToString(), f, Brushes.Black, marginLeft + 300, currentY);
                    g.DrawString(price.ToString("N0"), f, Brushes.Black, marginLeft + 350, currentY);
                    g.DrawString(amount.ToString("N0"), f, Brushes.Black, marginLeft + 430, currentY);
                    currentY += 20;
                    index++;
                }

                currentY += 10;
                g.DrawLine(Pens.Black, marginLeft, currentY, marginLeft + 520, currentY);
                currentY += 10;
                using (Font totalFont = new Font("Arial", 11, FontStyle.Bold))
                {
                    g.DrawString("TỔNG: " + totalAmount.ToString("N0") + " VNĐ", totalFont, Brushes.Red, marginLeft + 300, currentY);
                }
            }

            e.HasMorePages = false;
        }

        private string EscapeCsv(string text)
        {
            if (text.Contains(",") || text.Contains("\"") || text.Contains("\n"))
            {
                return $"\"{text.Replace("\"", "\"\"")}\"";
            }
            return text;
        }

        private void UpdateTotalDisplay()
        {
            totalAmount = 0m;
            foreach (DataRow r in billTable.Rows)
            {
                totalAmount += Convert.ToDecimal(r["SubTotal"]);
            }
            lblTotalAmount.Text = totalAmount.ToString("N0") + " VNĐ";
        }
    }
}
