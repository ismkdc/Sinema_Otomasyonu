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
    public partial class FrmSeansEkle : Form
    {
        OleDbCommand cmd;
        OleDbDataAdapter da;
        OleDbDataReader dr;
        public FrmSeansEkle()
        {
            InitializeComponent();
        }

        private void FrmSeansEkle_Load(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            cmd.Connection = FrmGiris.conn;
            FrmGiris.baglan();
            da = new OleDbDataAdapter(cmd);
            FimleriCek();
            SalonlariCek();
        }

        private void SalonlariCek()
        {
            cmd.CommandText = "select SalonSayisi from SinemaBilgi";
            int sayi = Convert.ToInt32(cmd.ExecuteScalar());
            for (int i = 1; i <= sayi; i++)
            {
                cmbSalon.Items.Add("Salon" + i.ToString());
            }
        }

        private void FimleriCek()
        {
            cmd.CommandText = "select * from Filmler";
            cmbFilm.ValueMember = "FilmNo";
            cmbFilm.DisplayMember = "FilmAdi";
            DataTable veri = new DataTable();
            da.Fill(veri);
            cmbFilm.DataSource = veri;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from Seanslar where FilmNo=@FilmNo and Salon=@Salon";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@FilmNo", cmbFilm.SelectedValue);
            cmd.Parameters.AddWithValue("@Salon", cmbSalon.Text[cmbSalon.Text.Length - 1]);
            dr=cmd.ExecuteReader();
            if (dr.Read())
            {
                string[] dizi = dr["Seanslar"].ToString().Split(',');
                if (dizi.Contains(txtSeans.Text.Trim()))
                {
                    dr.Close();
                    MessageBox.Show("Bu seans zaten var.");
                    return;
                }
                dr.Close();
                cmd.CommandText = "update Seanslar set Seanslar=Seanslar+@Seans where FilmNo=@FilmNo and Salon=@Salon";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Seans", "," + txtSeans.Text.Trim());
                cmd.Parameters.AddWithValue("@FilmNo", cmbFilm.SelectedValue);
                cmd.Parameters.AddWithValue("@Salon", cmbSalon.Text[cmbSalon.Text.Length - 1]);
                cmd.ExecuteNonQuery();
            }
            else
            {
                dr.Close();
                cmd.CommandText = "insert into Seanslar(FilmNo,Seanslar,Salon)values(@FilmNo,@Seanslar,@Salon)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@FilmNo", cmbFilm.SelectedValue);
                cmd.Parameters.AddWithValue("@Seans", txtSeans.Text.Trim());
                cmd.Parameters.AddWithValue("@Salon", cmbSalon.Text[cmbSalon.Text.Length - 1]);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Seans Eklendi.");
        }
    }
}
