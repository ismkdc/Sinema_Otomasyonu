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
    public partial class FrmSalonlariDuzenle : Form
    {
        OleDbCommand cmd;
        public FrmSalonlariDuzenle()
        {
            InitializeComponent();
            cmd = new OleDbCommand();
            cmd.Connection = FrmGiris.conn;
            FrmGiris.baglan();
        }

        private void FrmSalonlariDuzenle_Load(object sender, EventArgs e)
        {       
            cmd.CommandText = "select SalonSayisi from SinemaBilgi";
            int sayi = Convert.ToInt32(cmd.ExecuteScalar());
            for (int i = 1; i <= sayi; i++)
            {
                listBox1.Items.Add("Salon" + i.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = string.Format("drop table Salon{0}", listBox1.SelectedItem.ToString()[listBox1.SelectedItem.ToString().Length-1]);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Salon Silindi.");
            cmd.CommandText = "update SinemaBilgi set SalonSayisi=SalonSayisi-1";
            cmd.ExecuteNonQuery();
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
