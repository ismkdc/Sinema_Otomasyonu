namespace SinemaOtomasyonu
{
    partial class FrmSatisRaporu
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblgun = new System.Windows.Forms.Label();
            this.lblhafta = new System.Windows.Forms.Label();
            this.lblay = new System.Windows.Forms.Label();
            this.lblyil = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bu günki toplam satış =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bu haftaki toplam satış =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bu ayki toplam satış =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bu yılki toplam satış =";
            // 
            // lblgun
            // 
            this.lblgun.AutoSize = true;
            this.lblgun.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgun.Location = new System.Drawing.Point(282, 30);
            this.lblgun.Name = "lblgun";
            this.lblgun.Size = new System.Drawing.Size(16, 22);
            this.lblgun.TabIndex = 0;
            this.lblgun.Text = "-";
            // 
            // lblhafta
            // 
            this.lblhafta.AutoSize = true;
            this.lblhafta.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhafta.Location = new System.Drawing.Point(282, 69);
            this.lblhafta.Name = "lblhafta";
            this.lblhafta.Size = new System.Drawing.Size(16, 22);
            this.lblhafta.TabIndex = 0;
            this.lblhafta.Text = "-";
            // 
            // lblay
            // 
            this.lblay.AutoSize = true;
            this.lblay.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblay.Location = new System.Drawing.Point(282, 110);
            this.lblay.Name = "lblay";
            this.lblay.Size = new System.Drawing.Size(16, 22);
            this.lblay.TabIndex = 0;
            this.lblay.Text = "-";
            // 
            // lblyil
            // 
            this.lblyil.AutoSize = true;
            this.lblyil.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyil.Location = new System.Drawing.Point(282, 148);
            this.lblyil.Name = "lblyil";
            this.lblyil.Size = new System.Drawing.Size(16, 22);
            this.lblyil.TabIndex = 0;
            this.lblyil.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmSatisRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 214);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblyil);
            this.Controls.Add(this.lblay);
            this.Controls.Add(this.lblhafta);
            this.Controls.Add(this.lblgun);
            this.Controls.Add(this.label1);
            this.Name = "FrmSatisRaporu";
            this.Text = "Satış Raporu";
            this.Load += new System.EventHandler(this.FrmSatisRaporu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblgun;
        private System.Windows.Forms.Label lblhafta;
        private System.Windows.Forms.Label lblay;
        private System.Windows.Forms.Label lblyil;
        private System.Windows.Forms.Timer timer1;
    }
}