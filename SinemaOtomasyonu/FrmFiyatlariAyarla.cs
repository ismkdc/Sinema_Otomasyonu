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
    public partial class FrmFiyatlariAyarla : Form
    {
        OleDbCommand cmd;
        public FrmFiyatlariAyarla()
        {
            InitializeComponent();
        }

        private void FrmFiyatlariAyarla_Load(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            cmd.Connection = FrmGiris.conn;
            FrmGiris.baglan();
            cmd.CommandText = "select * from SinemaBilgi";
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtTam.Text = dr["TamFiyat"].ToString();
                txtOgrenci.Text = dr["OgrFiyat"].ToString();
                txtTam3d.Text = dr["3dTamFiyat"].ToString();
                txtOgr3d.Text = dr["3dOgrFiyat"].ToString();
            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "update SinemaBilgi set TamFiyat=@TF,OgrFiyat=@OF,3dTamFiyat=@3dTam,3dOgrFiyat=@3dOgr";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@TF", txtTam.Text.Trim());
            cmd.Parameters.AddWithValue("@OF", txtOgrenci.Text.Trim());
            cmd.Parameters.AddWithValue("@3dTam", txtTam3d.Text.Trim());
            cmd.Parameters.AddWithValue("@3dOgr", txtOgr3d.Text.Trim());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Fiyatlar güncellendi!");
        }
    }
}
