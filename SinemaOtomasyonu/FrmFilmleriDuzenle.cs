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
    public partial class FrmFilmleriDuzenle : Form
    {
        OleDbCommand cmd;
        OleDbDataAdapter da;
        public FrmFilmleriDuzenle()
        {
            InitializeComponent();
        }

        private void FrmFilmleriDuzenle_Load(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            cmd.Connection = FrmGiris.conn;
            FrmGiris.baglan();
            GridDoldur();
        }

        private void GridDoldur()
        {
            cmd.CommandText = "select * from Filmler";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "delete * from Filmler where FilmNo=@No";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@No", dataGridView1.CurrentRow.Cells["FilmNo"].Value.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Silindi.");
            GridDoldur();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtFilmAdi.Text = dataGridView1.CurrentRow.Cells["FilmAdi"].Value.ToString();
            txtTur.Text = dataGridView1.CurrentRow.Cells["Tur"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "update Filmler set FilmAdi=@Fadi,Tur=@Tur where FilmNo=@No";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Fadi", txtFilmAdi.Text.Trim());
            cmd.Parameters.AddWithValue("@Tur", txtTur.Text.Trim());
            cmd.Parameters.AddWithValue("@No", dataGridView1.CurrentRow.Cells["FilmNo"].Value.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Güncellendi.");
            GridDoldur();
        }
    }
}
