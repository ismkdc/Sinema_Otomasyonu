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
    public partial class FrmSalonEkle : Form
    {
        int sayi = -1;
        OleDbCommand cmd;
        public FrmSalonEkle()
        {
            InitializeComponent();
            cmd = new OleDbCommand();
            cmd.Connection = FrmGiris.conn;
            FrmGiris.baglan();
        }

        private void FrmSalonEkle_Load(object sender, EventArgs e)
        {
            cmd.CommandText = "select SalonSayisi+1 from SinemaBilgi";
            sayi = Convert.ToInt32(cmd.ExecuteScalar());
            label1.Text = "Yeni Salon Adı: Salon" + sayi.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sayi != -1)
            {
                cmd.CommandText = string.Format("select * into Salon{0} from Salon", sayi.ToString());
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update SinemaBilgi set SalonSayisi=SalonSayisi+1";
                cmd.ExecuteNonQuery();
                sayi++;
                MessageBox.Show("Salon Eklendi.");
                label1.Text = "Yeni Salon Adı: Salon" + sayi.ToString();
            }

        }
    }
}
