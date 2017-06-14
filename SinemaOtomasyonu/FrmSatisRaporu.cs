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
    public partial class FrmSatisRaporu : Form
    {
        OleDbDataReader dr;
        OleDbCommand cmd;
        public FrmSatisRaporu()
        {
            InitializeComponent();
            cmd = new OleDbCommand();
            cmd.Connection = FrmGiris.conn;
            FrmGiris.baglan();
        }

        private void FrmSatisRaporu_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cmd.CommandText = "select sum(Tutar) as a from Fisler where DateValue(Tarih)=date()";
            //cmd.Parameters.Clear();
            //cmd.Parameters.Add("@Tarih", OleDbType.Date).Value = DateTime.Now;
            dr = cmd.ExecuteReader();
            if (dr.Read())
                lblgun.Text = dr["a"].ToString();
            dr.Close();
            cmd.CommandText = "select sum(Tutar) as a from Fisler where Tarih between @ilk and @son";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ilk", OleDbType.Date).Value = DateTime.Now.AddDays(-7);
            cmd.Parameters.Add("@son", OleDbType.Date).Value = DateTime.Now;
            dr = cmd.ExecuteReader();
            if (dr.Read())
                lblhafta.Text = dr["a"].ToString();
            dr.Close();

            cmd.CommandText = "select sum(Tutar) as a from Fisler where Tarih between @ilk and @son";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ilk", OleDbType.Date).Value = DateTime.Now.AddDays(-30);
            cmd.Parameters.Add("@son", OleDbType.Date).Value = DateTime.Now;
            dr = cmd.ExecuteReader();
            if (dr.Read())
                lblay.Text = dr["a"].ToString();
            dr.Close();

            cmd.CommandText = "select sum(Tutar) as a from Fisler where Tarih between @ilk and @son";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Tarih", OleDbType.Date).Value = DateTime.Now.AddDays(-365);
            cmd.Parameters.Add("@son", OleDbType.Date).Value = DateTime.Now;
            dr = cmd.ExecuteReader();
            if (dr.Read())
                lblyil.Text = dr["a"].ToString();
            dr.Close();


            timer1.Stop();
        }
    }
}
