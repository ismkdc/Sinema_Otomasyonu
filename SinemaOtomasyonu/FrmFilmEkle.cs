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
    public partial class FrmFilmEkle : Form
    {
        OleDbCommand cmd;
        public FrmFilmEkle()
        {
            InitializeComponent();
            cmd = new OleDbCommand();
            cmd.Connection = FrmGiris.conn;
            FrmGiris.baglan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "insert into Filmler(FilmAdi,Tur)values(@FilmAdi,@Tur)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@FilmAdi", txtFilmAd.Text.Trim());
            cmd.Parameters.AddWithValue("@Tur", comboBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Film Eklendi.");
        }
    }
}
