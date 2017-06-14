using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void sinemaBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSinemaBilgi bilgi = new FrmSinemaBilgi();
            bilgi.MdiParent = this;
            bilgi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGiris giris = new FrmGiris();
            giris.Show();
            this.Hide();
        }

        private void fiyatlarıAyarlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFiyatlariAyarla frm = new FrmFiyatlariAyarla();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void yeniKuponToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYeniKupon frm = new FrmYeniKupon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kuponlarıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKuponlariDuzenle frm = new FrmKuponlariDuzenle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void filmEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilmEkle frm = new FrmFilmEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void filmleriDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilmleriDuzenle frm = new FrmFilmleriDuzenle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void salonEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalonEkle frm = new FrmSalonEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void salonlarıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalonlariDuzenle frm = new FrmSalonlariDuzenle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKullaniciEkle frm = new FrmKullaniciEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kullanıcılarıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKullaniciDuzenle frm = new FrmKullaniciDuzenle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void fragmanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFragmanEkle frm = new FrmFragmanEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void seansEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSeansEkle frm = new FrmSeansEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void seanslarıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSeansDuzenle frm = new FrmSeansDuzenle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void fişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFisler frm = new FrmFisler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void satışRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatisRaporu frm = new FrmSatisRaporu();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
