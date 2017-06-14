namespace SinemaOtomasyonu
{
    partial class FrmYeniKupon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKupon = new System.Windows.Forms.TextBox();
            this.txtIndirim = new System.Windows.Forms.TextBox();
            this.txtSKT = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHak = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtKupon
            // 
            this.txtKupon.Location = new System.Drawing.Point(94, 25);
            this.txtKupon.Name = "txtKupon";
            this.txtKupon.Size = new System.Drawing.Size(177, 20);
            this.txtKupon.TabIndex = 0;
            // 
            // txtIndirim
            // 
            this.txtIndirim.Location = new System.Drawing.Point(94, 51);
            this.txtIndirim.Name = "txtIndirim";
            this.txtIndirim.Size = new System.Drawing.Size(177, 20);
            this.txtIndirim.TabIndex = 0;
            // 
            // txtSKT
            // 
            this.txtSKT.Location = new System.Drawing.Point(94, 77);
            this.txtSKT.Mask = "00/00/0000";
            this.txtSKT.Name = "txtSKT";
            this.txtSKT.Size = new System.Drawing.Size(177, 20);
            this.txtSKT.TabIndex = 1;
            this.txtSKT.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kupon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İndirim(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Son K. Tarihi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kullanım Hakkı";
            // 
            // txtHak
            // 
            this.txtHak.Location = new System.Drawing.Point(94, 101);
            this.txtHak.Name = "txtHak";
            this.txtHak.Size = new System.Drawing.Size(177, 20);
            this.txtHak.TabIndex = 4;
            // 
            // FrmYeniKupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 165);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHak);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSKT);
            this.Controls.Add(this.txtIndirim);
            this.Controls.Add(this.txtKupon);
            this.Name = "FrmYeniKupon";
            this.Text = "Yeni Kupon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKupon;
        private System.Windows.Forms.TextBox txtIndirim;
        private System.Windows.Forms.MaskedTextBox txtSKT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHak;
    }
}