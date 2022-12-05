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
    public partial class FrmFisler : Form
    {
        OleDbCommand cmd;
        OleDbDataAdapter da;
        public FrmFisler()
        {
            InitializeComponent();
        }

        private void FrmFisler_Load(object sender, EventArgs e)
        {
            //Bu program ismail kundakcı tarafından yazılmıştır.

            //ismail kundakcı(mail)-> ism.kundakci@hotmail.com
            //ismail kundakcı(facebook) www.fb.com/ismkdc
            cmd = new OleDbCommand();
            da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            cmd.Connection = FrmGiris.conn;
            FrmGiris.baglan();
            GridDoldur();
            KasiyerCek();
        }

        private void KasiyerCek()
        {
            cmd.CommandText = "select KullaniciAdi from Kullanicilar";
            cmbKasiyer.DisplayMember = "KullaniciAdi";
            DataTable kasiyer = new DataTable();
            da.Fill(kasiyer);
            cmbKasiyer.DataSource = kasiyer;
        }
        private void GridDoldur()
        {
            cmd.CommandText = "select * from Fisler";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from Fisler where Kasiyer=@Kasiyer and Tarih Between @ilk and @son";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Kasiyer", cmbKasiyer.Text);
            cmd.Parameters.Add("@ilk", OleDbType.Date).Value = dateTimePicker1.Value;
            cmd.Parameters.Add("@son", OleDbType.Date).Value = dateTimePicker2.Value;
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

   
    }
}
