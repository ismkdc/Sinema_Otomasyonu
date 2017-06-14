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
    public partial class FrmSinemaBilgi : Form
    {
        OleDbCommand cmd;
        public FrmSinemaBilgi()
        {
            InitializeComponent();
        }

        private void frmSinemaBilgi_Load(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            cmd.Connection = FrmGiris.conn;
            FrmGiris.baglan();
            cmd.CommandText = "select SinemaAd from SinemaBilgi";
            textBox1.Text = cmd.ExecuteScalar().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "update SinemaBilgi set SinemaAd=@NewAd";
            cmd.Parameters.AddWithValue("@NewAd", textBox1.Text.Trim());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Güncellendi!");
        }
    }
}
