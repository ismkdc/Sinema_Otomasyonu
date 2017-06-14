namespace SinemaOtomasyonu
{
    partial class FrmAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sinemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinemaBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiyatlarıAyarlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indirimKuponlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKuponToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kuponlarıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmleriDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonlarıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcılarıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reklamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fragmanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seanslarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seansEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seanslarıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muhasebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinemaToolStripMenuItem,
            this.indirimKuponlarıToolStripMenuItem,
            this.filmlerToolStripMenuItem,
            this.salonlarToolStripMenuItem,
            this.kullanıcılarToolStripMenuItem,
            this.reklamToolStripMenuItem,
            this.seanslarToolStripMenuItem,
            this.muhasebeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1344, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sinemaToolStripMenuItem
            // 
            this.sinemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinemaBilgileriToolStripMenuItem,
            this.fiyatlarıAyarlaToolStripMenuItem});
            this.sinemaToolStripMenuItem.Name = "sinemaToolStripMenuItem";
            this.sinemaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sinemaToolStripMenuItem.Text = "Sinema";
            // 
            // sinemaBilgileriToolStripMenuItem
            // 
            this.sinemaBilgileriToolStripMenuItem.Name = "sinemaBilgileriToolStripMenuItem";
            this.sinemaBilgileriToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.sinemaBilgileriToolStripMenuItem.Text = "Sinema Bilgileri";
            this.sinemaBilgileriToolStripMenuItem.Click += new System.EventHandler(this.sinemaBilgileriToolStripMenuItem_Click);
            // 
            // fiyatlarıAyarlaToolStripMenuItem
            // 
            this.fiyatlarıAyarlaToolStripMenuItem.Name = "fiyatlarıAyarlaToolStripMenuItem";
            this.fiyatlarıAyarlaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.fiyatlarıAyarlaToolStripMenuItem.Text = "Fiyatları Ayarla";
            this.fiyatlarıAyarlaToolStripMenuItem.Click += new System.EventHandler(this.fiyatlarıAyarlaToolStripMenuItem_Click);
            // 
            // indirimKuponlarıToolStripMenuItem
            // 
            this.indirimKuponlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKuponToolStripMenuItem,
            this.kuponlarıDüzenleToolStripMenuItem});
            this.indirimKuponlarıToolStripMenuItem.Name = "indirimKuponlarıToolStripMenuItem";
            this.indirimKuponlarıToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.indirimKuponlarıToolStripMenuItem.Text = "İndirim Kuponları";
            // 
            // yeniKuponToolStripMenuItem
            // 
            this.yeniKuponToolStripMenuItem.Name = "yeniKuponToolStripMenuItem";
            this.yeniKuponToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.yeniKuponToolStripMenuItem.Text = "Yeni Kupon";
            this.yeniKuponToolStripMenuItem.Click += new System.EventHandler(this.yeniKuponToolStripMenuItem_Click);
            // 
            // kuponlarıDüzenleToolStripMenuItem
            // 
            this.kuponlarıDüzenleToolStripMenuItem.Name = "kuponlarıDüzenleToolStripMenuItem";
            this.kuponlarıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.kuponlarıDüzenleToolStripMenuItem.Text = "Kuponları Düzenle";
            this.kuponlarıDüzenleToolStripMenuItem.Click += new System.EventHandler(this.kuponlarıDüzenleToolStripMenuItem_Click);
            // 
            // filmlerToolStripMenuItem
            // 
            this.filmlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmEkleToolStripMenuItem,
            this.filmleriDüzenleToolStripMenuItem});
            this.filmlerToolStripMenuItem.Name = "filmlerToolStripMenuItem";
            this.filmlerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.filmlerToolStripMenuItem.Text = "Filmler";
            // 
            // filmEkleToolStripMenuItem
            // 
            this.filmEkleToolStripMenuItem.Name = "filmEkleToolStripMenuItem";
            this.filmEkleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.filmEkleToolStripMenuItem.Text = "Film Ekle";
            this.filmEkleToolStripMenuItem.Click += new System.EventHandler(this.filmEkleToolStripMenuItem_Click);
            // 
            // filmleriDüzenleToolStripMenuItem
            // 
            this.filmleriDüzenleToolStripMenuItem.Name = "filmleriDüzenleToolStripMenuItem";
            this.filmleriDüzenleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.filmleriDüzenleToolStripMenuItem.Text = "Filmleri Düzenle";
            this.filmleriDüzenleToolStripMenuItem.Click += new System.EventHandler(this.filmleriDüzenleToolStripMenuItem_Click);
            // 
            // salonlarToolStripMenuItem
            // 
            this.salonlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salonEkleToolStripMenuItem,
            this.salonlarıDüzenleToolStripMenuItem});
            this.salonlarToolStripMenuItem.Name = "salonlarToolStripMenuItem";
            this.salonlarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.salonlarToolStripMenuItem.Text = "Salonlar";
            // 
            // salonEkleToolStripMenuItem
            // 
            this.salonEkleToolStripMenuItem.Name = "salonEkleToolStripMenuItem";
            this.salonEkleToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.salonEkleToolStripMenuItem.Text = "Salon Ekle";
            this.salonEkleToolStripMenuItem.Click += new System.EventHandler(this.salonEkleToolStripMenuItem_Click);
            // 
            // salonlarıDüzenleToolStripMenuItem
            // 
            this.salonlarıDüzenleToolStripMenuItem.Name = "salonlarıDüzenleToolStripMenuItem";
            this.salonlarıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.salonlarıDüzenleToolStripMenuItem.Text = "Salonları Düzenle";
            this.salonlarıDüzenleToolStripMenuItem.Click += new System.EventHandler(this.salonlarıDüzenleToolStripMenuItem_Click);
            // 
            // kullanıcılarToolStripMenuItem
            // 
            this.kullanıcılarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıEkleToolStripMenuItem,
            this.kullanıcılarıDüzenleToolStripMenuItem});
            this.kullanıcılarToolStripMenuItem.Name = "kullanıcılarToolStripMenuItem";
            this.kullanıcılarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.kullanıcılarToolStripMenuItem.Text = "Kullanıcılar";
            // 
            // kullanıcıEkleToolStripMenuItem
            // 
            this.kullanıcıEkleToolStripMenuItem.Name = "kullanıcıEkleToolStripMenuItem";
            this.kullanıcıEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kullanıcıEkleToolStripMenuItem.Text = "Kullanıcı Ekle";
            this.kullanıcıEkleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıEkleToolStripMenuItem_Click);
            // 
            // kullanıcılarıDüzenleToolStripMenuItem
            // 
            this.kullanıcılarıDüzenleToolStripMenuItem.Name = "kullanıcılarıDüzenleToolStripMenuItem";
            this.kullanıcılarıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kullanıcılarıDüzenleToolStripMenuItem.Text = "Kullanıcıları Düzenle";
            this.kullanıcılarıDüzenleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcılarıDüzenleToolStripMenuItem_Click);
            // 
            // reklamToolStripMenuItem
            // 
            this.reklamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fragmanlarToolStripMenuItem});
            this.reklamToolStripMenuItem.Name = "reklamToolStripMenuItem";
            this.reklamToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.reklamToolStripMenuItem.Text = "Reklam";
            // 
            // fragmanlarToolStripMenuItem
            // 
            this.fragmanlarToolStripMenuItem.Name = "fragmanlarToolStripMenuItem";
            this.fragmanlarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.fragmanlarToolStripMenuItem.Text = "Fragmanlar";
            this.fragmanlarToolStripMenuItem.Click += new System.EventHandler(this.fragmanlarToolStripMenuItem_Click);
            // 
            // seanslarToolStripMenuItem
            // 
            this.seanslarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seansEkleToolStripMenuItem,
            this.seanslarıDüzenleToolStripMenuItem});
            this.seanslarToolStripMenuItem.Name = "seanslarToolStripMenuItem";
            this.seanslarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.seanslarToolStripMenuItem.Text = "Seanslar";
            // 
            // seansEkleToolStripMenuItem
            // 
            this.seansEkleToolStripMenuItem.Name = "seansEkleToolStripMenuItem";
            this.seansEkleToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.seansEkleToolStripMenuItem.Text = "Seans Ekle";
            this.seansEkleToolStripMenuItem.Click += new System.EventHandler(this.seansEkleToolStripMenuItem_Click);
            // 
            // seanslarıDüzenleToolStripMenuItem
            // 
            this.seanslarıDüzenleToolStripMenuItem.Name = "seanslarıDüzenleToolStripMenuItem";
            this.seanslarıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.seanslarıDüzenleToolStripMenuItem.Text = "Seansları Düzenle";
            this.seanslarıDüzenleToolStripMenuItem.Click += new System.EventHandler(this.seanslarıDüzenleToolStripMenuItem_Click);
            // 
            // muhasebeToolStripMenuItem
            // 
            this.muhasebeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fişlerToolStripMenuItem,
            this.satışRaporuToolStripMenuItem});
            this.muhasebeToolStripMenuItem.Name = "muhasebeToolStripMenuItem";
            this.muhasebeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.muhasebeToolStripMenuItem.Text = "Muhasebe";
            // 
            // fişlerToolStripMenuItem
            // 
            this.fişlerToolStripMenuItem.Name = "fişlerToolStripMenuItem";
            this.fişlerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fişlerToolStripMenuItem.Text = "Fişler";
            this.fişlerToolStripMenuItem.Click += new System.EventHandler(this.fişlerToolStripMenuItem_Click);
            // 
            // satışRaporuToolStripMenuItem
            // 
            this.satışRaporuToolStripMenuItem.Name = "satışRaporuToolStripMenuItem";
            this.satışRaporuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.satışRaporuToolStripMenuItem.Text = "Satış Raporu";
            this.satışRaporuToolStripMenuItem.Click += new System.EventHandler(this.satışRaporuToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1176, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1257, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.TabStop = false;
            this.button2.Text = "Kapat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1344, 658);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sinemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinemaBilgileriToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem fiyatlarıAyarlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indirimKuponlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKuponToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kuponlarıDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmleriDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonlarıDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarıDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reklamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fragmanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muhasebeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seanslarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seansEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seanslarıDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışRaporuToolStripMenuItem;
    }
}