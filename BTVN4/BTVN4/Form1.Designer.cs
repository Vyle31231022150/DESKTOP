using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BTVN4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label So1;
        private System.Windows.Forms.Label So2;
        private System.Windows.Forms.Label KetQua;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnDel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            So1 = new Label();
            So2 = new Label();
            KetQua = new Label();
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            txtKetQua = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            btnDel = new Button();
            SuspendLayout();
         
            So1.AutoSize = true;
            So1.Location = new Point(30, 30);
            So1.Name = "lblSo1";
            So1.Size = new Size(105, 25);
            So1.TabIndex = 0;
            So1.Text = "Số thứ nhất";
          
            So2.AutoSize = true;
            So2.Location = new Point(30, 70);
            So2.Name = "So2";
            So2.Size = new Size(93, 25);
            So2.TabIndex = 1;
            So2.Text = "Số thứ hai";
           
            KetQua.AutoSize = true;
            KetQua.Location = new Point(30, 160);
            KetQua.Name = "KetQua";
            KetQua.Size = new Size(72, 25);
            KetQua.TabIndex = 2;
            KetQua.Text = "Kết quả";
         
            txtSo1.Location = new Point(148, 30);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(180, 31);
            txtSo1.TabIndex = 3;
            txtSo1.TextChanged += txtSo1_TextChanged;
        
            txtSo2.Location = new Point(148, 67);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(180, 31);
            txtSo2.TabIndex = 4;
            txtSo2.TextChanged += txtSo2_TextChanged;
          
            txtKetQua.Location = new Point(120, 157);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(180, 31);
            txtKetQua.TabIndex = 5;
        
            btnCong.Location = new Point(30, 110);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(40, 30);
            btnCong.TabIndex = 6;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
        
            btnTru.Location = new Point(80, 110);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(40, 30);
            btnTru.TabIndex = 7;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
         
            btnNhan.Location = new Point(130, 110);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(40, 30);
            btnNhan.TabIndex = 8;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = true;
          
            btnChia.Location = new Point(180, 110);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(40, 30);
            btnChia.TabIndex = 9;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
         
            btnDel.Location = new Point(240, 110);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(60, 30);
            btnDel.TabIndex = 10;
            btnDel.Text = "Del";
            btnDel.UseVisualStyleBackColor = true;
         
            ClientSize = new Size(340, 210);
            Controls.Add(So1);
            Controls.Add(So2);
            Controls.Add(KetQua);
            Controls.Add(txtSo1);
            Controls.Add(txtSo2);
            Controls.Add(txtKetQua);
            Controls.Add(btnCong);
            Controls.Add(btnTru);
            Controls.Add(btnNhan);
            Controls.Add(btnChia);
            Controls.Add(btnDel);
            Name = "Form1";
            Text = "Máy tính bỏ túi";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}


