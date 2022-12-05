using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.IO;

namespace SinemaOtomasyonu
{
    public partial class FrmGiris : Form
    {
        string kad, sifre;
        bool kayitlimi = false;
        string yol = "data.txt";
        public static string kasiyer = "";
        public static OleDbConnection conn=new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb");
        public FrmGiris()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKapat_MouseEnter(object sender, EventArgs e)
        {
            btnKapat.BackgroundImage = Properties.Resources.close2;
        }

        private void btnKapat_MouseLeave(object sender, EventArgs e)
        {
            btnKapat.BackgroundImage = Properties.Resources.close1;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //Bu program ismail kundakcı tarafından yazılmıştır.

            //ismail kundakcı(mail)-> ism.kundakci@hotmail.com
            //ismail kundakcı(facebook) www.fb.com/ismkdc
            string ka = txtKadi.Text.Trim();
            string si = txtSifre.Text.Trim();
            if (kayitlimi)
            {
                if (!checkBox1.Checked)
                {
                    StreamWriter dosya = new StreamWriter(yol);
                    dosya.WriteLine("");
                    dosya.Close();
                }
                else if (checkBox1.Checked && kad != ka || sifre != si)
                {
                    StreamWriter dosya = new StreamWriter(yol);
                    dosya.WriteLine(ka);
                    dosya.WriteLine(si);
                    dosya.Close();
                }
            }
            else
            {
                if (checkBox1.Checked)
                {
                    StreamWriter dosya = new StreamWriter(yol);
                    dosya.WriteLine(ka);
                    dosya.WriteLine(si);
                    dosya.Close();
                }
            }

            GirisYap();
        }

        private void GirisYap()
        {
            string kullaniciadi = txtKadi.Text.Trim();
            string sifre = txtSifre.Text.Trim();


                baglan();
                OleDbCommand komut = new OleDbCommand("Select * from Kullanicilar where KullaniciAdi=@KullaniciAdi", conn);
                komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciadi);
                OleDbDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["Sifre"].ToString() == sifre && dr["KullaniciAdi"].ToString() == kullaniciadi && dr["Tip"].ToString() == "Kasiyer")
                    {
                        frmAnaForm anaform = new frmAnaForm();
                        anaform.Show();
                        anaform.lblKullanıcıAdı.Text = kullaniciadi;
                        kasiyer=kullaniciadi;
                        this.Hide();
                    }
                    else if (dr["Sifre"].ToString() == sifre && dr["KullaniciAdi"].ToString() == kullaniciadi && dr["Tip"].ToString() == "Admin")
                    {
                        FrmAdmin admin = new FrmAdmin();
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Şifreniz hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                baglantiyiKes();
            //Bu program ismail kundakcı tarafından yazılmıştır.

            //ismail kundakcı(mail)-> ism.kundakci@hotmail.com
            //ismail kundakcı(facebook) www.fb.com/ismkdc
            
        }
        public static void baglan()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public static void baglantiyiKes()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void FrmGiris_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();

                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GirisYap();
            }
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            string path = "efatura.pdf";
            if (File.Exists(path))
                File.Delete(path);

            if (File.Exists(yol))
            {
                StreamReader dosya = new StreamReader(yol);
                txtKadi.Text = dosya.ReadLine();
                txtSifre.Text = dosya.ReadLine();
                kad = txtKadi.Text;
                sifre = txtSifre.Text;
                if (txtKadi.Text.Length > 1 && txtSifre.Text.Length > 1)
                {
                    checkBox1.Checked = true;
                    kayitlimi = true;
                }
                dosya.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmFragman frm = new FrmFragman();
            frm.Show();
            this.Hide();
        }

    }
}
