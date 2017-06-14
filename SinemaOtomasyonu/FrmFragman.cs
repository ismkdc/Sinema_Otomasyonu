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
using WMPLib;

namespace SinemaOtomasyonu
{
    public partial class FrmFragman : Form
    {
        OleDbCommand cmd;
        OleDbDataReader dr;
        public FrmFragman()
        {
            InitializeComponent();
        }

        private void FrmFragman_Load(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            cmd.Connection = FrmGiris.conn;
            FrmGiris.baglan();
            cmd.CommandText = "select FragmanYol from Fragmanlar";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                IWMPMedia media = axWindowsMediaPlayer1.newMedia(dr["FragmanYol"].ToString());
                axWindowsMediaPlayer1.currentPlaylist.appendItem(media);
            }
            dr.Close();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void FrmFragman_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
