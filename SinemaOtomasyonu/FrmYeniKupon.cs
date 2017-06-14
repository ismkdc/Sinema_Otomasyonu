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
    public partial class FrmYeniKupon : Form
    {
        OleDbCommand cmd;
        public FrmYeniKupon()
        {
            InitializeComponent();
            cmd = new OleDbCommand();
            cmd.Connection = FrmGiris.conn;
            FrmGiris.baglan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "insert into IndirimKuponlari(Kupon,IndirimMiktari,SKTarihi,KullanimHakki)values(@Kupon,@IndirimMiktari,@SKTarihi,@KullanimHakki)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Kupon", txtKupon.Text.Trim());
            cmd.Parameters.AddWithValue("@IndirimMiktari", txtIndirim.Text.Trim());
            cmd.Parameters.AddWithValue("@SKTarihi", txtSKT.Text.Trim());
            cmd.Parameters.AddWithValue("@KullanimHakki", txtHak.Text.Trim());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kupon Eklendi.");
        }
    }
}
