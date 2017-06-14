namespace SinemaOtomasyonu
{
    partial class FrmSeansDuzenle
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
            this.lstFilm = new System.Windows.Forms.ListBox();
            this.lstSalon = new System.Windows.Forms.ListBox();
            this.lstSeans = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstFilm
            // 
            this.lstFilm.FormattingEnabled = true;
            this.lstFilm.Location = new System.Drawing.Point(12, 12);
            this.lstFilm.Name = "lstFilm";
            this.lstFilm.Size = new System.Drawing.Size(179, 238);
            this.lstFilm.TabIndex = 0;
            this.lstFilm.SelectedIndexChanged += new System.EventHandler(this.lstFilm_SelectedIndexChanged);
            // 
            // lstSalon
            // 
            this.lstSalon.FormattingEnabled = true;
            this.lstSalon.Location = new System.Drawing.Point(197, 12);
            this.lstSalon.Name = "lstSalon";
            this.lstSalon.Size = new System.Drawing.Size(179, 238);
            this.lstSalon.TabIndex = 0;
            this.lstSalon.SelectedIndexChanged += new System.EventHandler(this.lstSalon_SelectedIndexChanged);
            // 
            // lstSeans
            // 
            this.lstSeans.FormattingEnabled = true;
            this.lstSeans.Location = new System.Drawing.Point(382, 12);
            this.lstSeans.Name = "lstSeans";
            this.lstSeans.Size = new System.Drawing.Size(179, 238);
            this.lstSeans.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Film";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seanslar";
            // 
            // FrmSeansDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstSeans);
            this.Controls.Add(this.lstSalon);
            this.Controls.Add(this.lstFilm);
            this.Name = "FrmSeansDuzenle";
            this.Text = "Seans Düzenle";
            this.Load += new System.EventHandler(this.FrmSeansDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFilm;
        private System.Windows.Forms.ListBox lstSalon;
        private System.Windows.Forms.ListBox lstSeans;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}