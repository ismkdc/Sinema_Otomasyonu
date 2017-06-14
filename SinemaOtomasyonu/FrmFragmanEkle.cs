using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class FrmFragmanEkle : Form
    {
        OleDbCommand cmd;
        string vidyol = "";
        public FrmFragmanEkle()
        {
            InitializeComponent();
        }

        private void FrmFragmanEkle_Load(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            cmd.Connection = FrmGiris.conn;
            FrmGiris.baglan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Vidyo Dosyası |*";
            file.Title = "Vidyo Dosyası Seçiniz..";

            if (file.ShowDialog() == DialogResult.OK)
            {
                string DosyaYol = file.FileName;
                textBox1.Text = DosyaYol;
                string harfler = "qwertyuıopğüişlkjhgfdsazxcvbnmöç";
                string fotoadi = "";
                int r = 0;
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    r = rnd.Next(31);
                    fotoadi += harfler[r];
                }
                vidyol = @"vid\" + fotoadi + "_" + "VID_" + file.SafeFileName;
                File.Copy(DosyaYol, vidyol);
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "insert into Fragmanlar(FragmanYol,Aciklama)values(@FragmanYol,@Aciklama)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@FragmanYol", vidyol);
            cmd.Parameters.AddWithValue("@Aciklama", textBox2.Text.Trim());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Fragman Eklendi.");
        }
    }
}
