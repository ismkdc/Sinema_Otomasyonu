namespace SinemaOtomasyonu
{
    partial class FrmFatura
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
            this.lblTam = new System.Windows.Forms.Label();
            this.lblOgrenci = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.txtKupon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblIndirimsizFiyat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTam
            // 
            this.lblTam.AutoSize = true;
            this.lblTam.BackColor = System.Drawing.Color.Transparent;
            this.lblTam.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTam.Location = new System.Drawing.Point(42, 85);
            this.lblTam.Name = "lblTam";
            this.lblTam.Size = new System.Drawing.Size(173, 24);
            this.lblTam.TabIndex = 6;
            this.lblTam.Text = "0 Tane Tam Bilet";
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.AutoSize = true;
            this.lblOgrenci.BackColor = System.Drawing.Color.Transparent;
            this.lblOgrenci.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenci.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOgrenci.Location = new System.Drawing.Point(42, 119);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(212, 24);
            this.lblOgrenci.TabIndex = 6;
            this.lblOgrenci.Text = "0 Tane Öğrenci Bilet";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.BackColor = System.Drawing.Color.Transparent;
            this.lblToplam.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.ForeColor = System.Drawing.Color.Coral;
            this.lblToplam.Location = new System.Drawing.Point(226, 162);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(128, 24);
            this.lblToplam.TabIndex = 6;
            this.lblToplam.Text = "Toplam 0 TL";
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIptal.BackgroundImage = global::SinemaOtomasyonu.Properties.Resources.iptal;
            this.btnIptal.Location = new System.Drawing.Point(46, 192);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(99, 42);
            this.btnIptal.TabIndex = 27;
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSatis.BackgroundImage = global::SinemaOtomasyonu.Properties.Resources.satis;
            this.btnSatis.Location = new System.Drawing.Point(265, 192);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(89, 42);
            this.btnSatis.TabIndex = 28;
            this.btnSatis.UseVisualStyleBackColor = false;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // txtKupon
            // 
            this.txtKupon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKupon.Location = new System.Drawing.Point(46, 45);
            this.txtKupon.Name = "txtKupon";
            this.txtKupon.Size = new System.Drawing.Size(197, 26);
            this.txtKupon.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "İndirim Kuponu";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(265, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 39);
            this.button2.TabIndex = 30;
            this.button2.Text = "Kontrol Et";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblIndirimsizFiyat
            // 
            this.lblIndirimsizFiyat.AutoSize = true;
            this.lblIndirimsizFiyat.BackColor = System.Drawing.Color.Transparent;
            this.lblIndirimsizFiyat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIndirimsizFiyat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIndirimsizFiyat.Location = new System.Drawing.Point(42, 167);
            this.lblIndirimsizFiyat.Name = "lblIndirimsizFiyat";
            this.lblIndirimsizFiyat.Size = new System.Drawing.Size(107, 22);
            this.lblIndirimsizFiyat.TabIndex = 6;
            this.lblIndirimsizFiyat.Text = "*Eski Fiyat: ";
            this.lblIndirimsizFiyat.Visible = false;
            // 
            // FrmFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(395, 251);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtKupon);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblIndirimsizFiyat);
            this.Controls.Add(this.lblOgrenci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFatura";
            this.Load += new System.EventHandler(this.frmFatura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTam;
        public System.Windows.Forms.Label lblOgrenci;
        public System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.TextBox txtKupon;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label lblIndirimsizFiyat;
    }
}