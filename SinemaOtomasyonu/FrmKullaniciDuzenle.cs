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
    public partial class FrmKullaniciDuzenle : Form
    {
        OleDbCommand cmd;
        OleDbDataAdapter da;
        public FrmKullaniciDuzenle()
        {
            InitializeComponent();
            cmd = new OleDbCommand();
            da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            cmd.Connection = FrmGiris.conn;
            FrmGiris.baglan();
        }

        private void GridDoldur()
        {
            cmd.CommandText = "select * from Kullanicilar";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmKullaniciDuzenle_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "delete * from Kullanicilar where KullaniciNo=@No";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@No", dataGridView1.CurrentRow.Cells["KullaniciNo"].Value.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Silindi.");
            GridDoldur();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtAd.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            txtKadi.Text = dataGridView1.CurrentRow.Cells["KullaniciAdi"].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells["Sifre"].Value.ToString();
            txtTip.Text = dataGridView1.CurrentRow.Cells["Tip"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "update Kullanicilar set Ad=@Ad,Soyad=@Soyad,KullaniciAdi=@KullaniciAdi,Sifre=@Sifre,Tip=@Tip where KullaniciNo=@No";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Ad", txtAd.Text.Trim());
            cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text.Trim());
            cmd.Parameters.AddWithValue("@KullaniciAdi", txtKadi.Text.Trim());
            cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text.Trim());
            cmd.Parameters.AddWithValue("@Tip", txtTip.Text.Trim());
            cmd.Parameters.AddWithValue("@No", dataGridView1.CurrentRow.Cells["KullaniciNo"].Value.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Güncellendi.");
            GridDoldur();
        }
    }
}
