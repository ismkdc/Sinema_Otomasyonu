using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class FrmKullaniciEkle : Form
    {
        OleDbCommand cmd;
        public FrmKullaniciEkle()
        {
            cmd = new OleDbCommand();
            InitializeComponent();
            cmd.Connection = FrmGiris.conn;
            FrmGiris.baglan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "insert into Kullanicilar(KullaniciAdi,Sifre,Ad,Soyad,Tip)values(@KullaniciAdi,@Sifre,@Ad,@Soyad,@Tip)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@KullaniciAdi",txtKAdi.Text.Trim());
            cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text.Trim());
            cmd.Parameters.AddWithValue("@Ad", txtAd.Text.Trim());
            cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text.Trim());
            cmd.Parameters.AddWithValue("@Tip", comboBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kullanıcı Eklendi.");
        }
    }
}
