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
    public partial class FrmKuponlariDuzenle : Form
    {
        OleDbCommand cmd;
        OleDbDataAdapter da;
        public FrmKuponlariDuzenle()
        {
            InitializeComponent();
        }

        private void FrmKuponlariDuzenle_Load(object sender, EventArgs e)
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
        }

        private void GridDoldur()
        {
            cmd.CommandText = "select * from IndirimKuponlari";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtKupon.Text = dataGridView1.CurrentRow.Cells["Kupon"].Value.ToString();
            txtIndirim.Text = dataGridView1.CurrentRow.Cells["IndirimMiktari"].Value.ToString();
            txtSKT.Text = dataGridView1.CurrentRow.Cells["SKTarihi"].Value.ToString();
            txtHak.Text = dataGridView1.CurrentRow.Cells["KullanimHakki"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "update IndirimKuponlari set Kupon=@Kupon,IndirimMiktari=@Miktar,SKTarihi=@SKT,KullanimHakki=@Hak where KuponNo=@No";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Kupon", txtKupon.Text.Trim());
            cmd.Parameters.AddWithValue("@Miktar", txtIndirim.Text.Trim());
            cmd.Parameters.AddWithValue("@SKT", txtSKT.Text.Trim());
            cmd.Parameters.AddWithValue("@Hak", txtHak.Text.Trim());
            cmd.Parameters.AddWithValue("@No",dataGridView1.CurrentRow.Cells["KuponNo"].Value.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Güncellendi.");
            GridDoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "delete * from IndirimKuponlari where KuponNo=@No";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@No",dataGridView1.CurrentRow.Cells["KuponNo"].Value.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Silindi.");
            GridDoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GridDoldur();
        }
    }
}
