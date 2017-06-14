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
    public partial class FrmSeansDuzenle : Form
    {
        string[] dizi;

        OleDbCommand cmd;
        OleDbDataReader dr;
        public FrmSeansDuzenle()
        {
            InitializeComponent();
        }

        private void FrmSeansDuzenle_Load(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            cmd.Connection = FrmGiris.conn;
            FrmGiris.baglan();
            cmd.CommandText = "SELECT Filmler.FilmAdi FROM Filmler INNER JOIN Seanslar ON Filmler.FilmNo = Seanslar.FilmNo";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lstFilm.Items.Add(dr["FilmAdi"].ToString());
            }
            dr.Close();
        }

        private void lstFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT Filmler.FilmAdi,Seanslar.Salon FROM Filmler INNER JOIN Seanslar ON Filmler.FilmNo = Seanslar.FilmNo where FilmAdi=@FilmAdi";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@FilmAdi", lstFilm.SelectedItem.ToString());
            dr = cmd.ExecuteReader();
            lstSalon.Items.Clear();
            lstSeans.Items.Clear();
            while (dr.Read())
            {
                lstSalon.Items.Add("Salon" + dr["Salon"].ToString());
            }
            dr.Close();
        }

        private void lstSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT Filmler.FilmAdi,Seanslar.Salon,Seanslar.Seanslar FROM Filmler INNER JOIN Seanslar ON Filmler.FilmNo = Seanslar.FilmNo where FilmAdi=@FilmAdi and Salon=@Salon";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@FilmAdi", lstFilm.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Salon", lstSalon.SelectedItem.ToString()[lstSalon.SelectedItem.ToString().Length - 1]);
            dr = cmd.ExecuteReader();
            lstSeans.Items.Clear();
            if (dr.Read())
            {
                dizi = dr["Seanslar"].ToString().Split(',');
                foreach (string item in dizi)
                {
                    lstSeans.Items.Add(item);
                }
            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstSeans.Items.Count == 1)
            {
                cmd.CommandText = string.Format("delete * from Seanslar where FilmNo=(select FilmNo from Filmler where FilmAdi='{0}') and Salon=@Salon", lstFilm.SelectedItem.ToString());
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Salon", lstSalon.SelectedItem.ToString()[lstSalon.SelectedItem.ToString().Length - 1]);
                cmd.ExecuteNonQuery();
                lstSeans.Items.Remove(lstSeans.SelectedItem);
                MessageBox.Show("Seans Silindi.");
            }
            else
            {
                dizi[lstSeans.SelectedIndex] = "";
                string seanslar = "";
                cmd.CommandText = string.Format("update Seanslar set Seanslar=@Seanslar where FilmNo=(select FilmNo from Filmler where FilmAdi='{0}') and Salon=@Salon", lstFilm.SelectedItem.ToString());
                cmd.Parameters.Clear();
                foreach (string item in dizi)
                {
                    seanslar += item;
                }
                cmd.Parameters.AddWithValue("@Seanslar", seanslar);
                cmd.Parameters.AddWithValue("@Salon", lstSalon.SelectedItem.ToString()[lstSalon.SelectedItem.ToString().Length - 1]);
                cmd.ExecuteNonQuery();
                lstSeans.Items.Remove(lstSeans.SelectedItem);
                MessageBox.Show("Seans Silindi.");
            }
        }
    }
}
