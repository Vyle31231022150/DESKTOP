using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BTVN3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox NoiDung;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            NoiDung = new TextBox();
            btnHienThi = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // NoiDung
            // 
            NoiDung.Location = new Point(89, 56);
            NoiDung.Margin = new Padding(4, 5, 4, 5);
            NoiDung.Multiline = true;
            NoiDung.Name = "NoiDung";
            NoiDung.Size = new Size(413, 62);
            NoiDung.TabIndex = 0;
            NoiDung.TextChanged += txtNoiDung_TextChanged;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(50, 183);
            btnHienThi.Margin = new Padding(4, 5, 4, 5);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(167, 55);
            btnHienThi.TabIndex = 1;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(389, 174);
            btnThoat.Margin = new Padding(4, 5, 4, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(168, 55);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 281);
            Controls.Add(NoiDung);
            Controls.Add(btnHienThi);
            Controls.Add(btnThoat);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Các sự kiện";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}


