using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BTVN5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label KetQua;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.GroupBox groupChon;
        private System.Windows.Forms.RadioButton rdbUSCLN;
        private System.Windows.Forms.RadioButton rdbBSCNN;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            A = new Label();
            B = new Label();
            KetQua = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtKetQua = new TextBox();
            groupChon = new GroupBox();
            rdbBSCNN = new RadioButton();
            rdbUSCLN = new RadioButton();
            btnTim = new Button();
            btnBoQua = new Button();
            btnThoat = new Button();
            groupChon.SuspendLayout();
            SuspendLayout();
         
            A.AutoSize = true;
            A.Location = new Point(30, 30);
            A.Name = "A";
            A.Size = new Size(28, 25);
            A.TabIndex = 0;
            A.Text = "A:";
           
            B.AutoSize = true;
            B.Location = new Point(30, 70);
            B.Name = "B";
            B.Size = new Size(26, 25);
            B.TabIndex = 1;
            B.Text = "B:";
     
            KetQua.AutoSize = true;
            KetQua.Location = new Point(30, 120);
            KetQua.Name = "KetQua";
            KetQua.Size = new Size(72, 25);
            KetQua.TabIndex = 5;
            KetQua.Text = "Kết quả";
          
            txtA.Location = new Point(70, 27);
            txtA.Name = "txtA";
            txtA.Size = new Size(150, 31);
            txtA.TabIndex = 2;
            txtA.TextChanged += txtA_TextChanged;
          
            txtB.Location = new Point(70, 67);
            txtB.Name = "txtB";
            txtB.Size = new Size(150, 31);
            txtB.TabIndex = 3;
           
            txtKetQua.Location = new Point(108, 119);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(150, 31);
            txtKetQua.TabIndex = 6;
            txtKetQua.TextChanged += txtKetQua_TextChanged;
         
            groupChon.Controls.Add(rdbBSCNN);
            groupChon.Controls.Add(rdbUSCLN);
            groupChon.Location = new Point(250, 20);
            groupChon.Name = "groupChon";
            groupChon.Size = new Size(120, 80);
            groupChon.TabIndex = 4;
            groupChon.TabStop = false;
            groupChon.Text = "Chọn tìm";
         
            rdbBSCNN.AutoSize = true;
            rdbBSCNN.Location = new Point(15, 50);
            rdbBSCNN.Name = "rdbBSCNN";
            rdbBSCNN.Size = new Size(94, 29);
            rdbBSCNN.TabIndex = 0;
            rdbBSCNN.Text = "BSCNN";
          
            rdbUSCLN.AutoSize = true;
            rdbUSCLN.Location = new Point(15, 25);
            rdbUSCLN.Name = "rdbUSCLN";
            rdbUSCLN.Size = new Size(91, 29);
            rdbUSCLN.TabIndex = 1;
            rdbUSCLN.Text = "USCLN";
         
            btnTim.Location = new Point(50, 160);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(80, 30);
            btnTim.TabIndex = 7;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
           
            btnBoQua.Location = new Point(150, 160);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(80, 30);
            btnBoQua.TabIndex = 8;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
           
            btnThoat.Location = new Point(250, 160);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(80, 30);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
         
            ClientSize = new Size(400, 220);
            Controls.Add(A);
            Controls.Add(B);
            Controls.Add(txtA);
            Controls.Add(txtB);
            Controls.Add(groupChon);
            Controls.Add(KetQua);
            Controls.Add(txtKetQua);
            Controls.Add(btnTim);
            Controls.Add(btnBoQua);
            Controls.Add(btnThoat);
            Name = "Form1";
            Text = "USCLN và BSCNN của A và B";
            groupChon.ResumeLayout(false);
            groupChon.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}


