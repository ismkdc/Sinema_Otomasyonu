using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class frmAnaForm : Form
    {
        int durum = 1;
        decimal CurrentOgrFiyat = 0, CurrentTamFiyat = 0, OgrFiyat3d = 0, TamFiyat3d = 0, OgrFiyat = 0, TamFiyat = 0;
        public static List<Button> doluKoltuklar = new List<Button>();
        public static List<Button> ikiliDoluKoltuklar = new List<Button>();
        int toplam = 0;
        public static decimal tutar = 0;
        public static int toplamogrenci;
        public static int toplamtam;
        public static string salonadı = "";
        public static string seans = "";
        public static string film = "";
        OleDbCommand cmd;
        OleDbDataReader dr;
        public frmAnaForm()
        {
            InitializeComponent();
            cmd = new OleDbCommand();
            cmd.Connection = FrmGiris.conn;
            FrmGiris.baglan();
        }


        private void btnKapat_MouseEnter(object sender, EventArgs e)
        {
            btnKapat.BackgroundImage = Properties.Resources.close2;
        }

        private void btnKapat_MouseLeave(object sender, EventArgs e)
        {
            btnKapat.BackgroundImage = Properties.Resources.close1;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_MouseEnter(object sender, EventArgs e)
        {
            btnCikis.BackgroundImage = Properties.Resources.cıkıs2;
        }

        private void btnCikis_MouseLeave(object sender, EventArgs e)
        {
            btnCikis.BackgroundImage = Properties.Resources.cıkıs1;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FrmGiris giris = new FrmGiris();
            giris.Show();
            this.Hide();
        }


        private void koltukDoldur(Button koltuk)
        {

                koltuk.BackColor = Color.Red;
                koltuk.FlatAppearance.MouseDownBackColor = Color.Red;
                koltuk.FlatAppearance.MouseOverBackColor = Color.Red;
                if (koltuk.Name.Contains("gkoltuk"))
                {
                    ikiliDoluKoltuklar.Add(koltuk);
                }
                doluKoltuklar.Add(koltuk);
                toplam = doluKoltuklar.Count + ikiliDoluKoltuklar.Count;
                numericOgrenci.Maximum = toplam;
                numericTam.Maximum = toplam;
                numericOgrenci.Enabled = true;
                numericTam.Enabled = true;
                lblToplamSeciliKoltukSay.Text = "Toplam "+ toplam + " Koltuk Seçili";
                if ((int)numericTam.Value + (int)numericOgrenci.Value == toplam)
                {
                    durum = 3;
                }
                else
                {
                    durum = 2;
                }
        }

        private void koltukBosalt(Button koltuk)
        {
            if (koltuk.Name.Contains("gkoltuk"))
            {
                koltuk.BackColor = Color.LightCoral;
                koltuk.FlatAppearance.MouseDownBackColor = Color.LightCoral;
                koltuk.FlatAppearance.MouseOverBackColor = Color.LightCoral;
                ikiliDoluKoltuklar.Remove(koltuk);
            }
            else
            {
                koltuk.BackColor = Color.Olive;
                koltuk.FlatAppearance.MouseDownBackColor = Color.Olive;
                koltuk.FlatAppearance.MouseOverBackColor = Color.Olive;                
            }
            doluKoltuklar.Remove(koltuk);
            toplam = doluKoltuklar.Count + ikiliDoluKoltuklar.Count;
            numericOgrenci.Maximum = toplam;
            numericTam.Maximum = toplam;
            lblToplamSeciliKoltukSay.Text = "Toplam " + toplam + " Koltuk Seçili";
            if (toplam == 0)
            {
                numericOgrenci.Enabled = false;
                numericTam.Enabled = false;
            }
            if ((int)numericTam.Value + (int)numericOgrenci.Value == toplam)
            {
                durum = 3;
            }
            else
            {
                durum = 2;
            }
            if (doluKoltuklar.Count == 0)
            {
                durum = 1;
            }

        }

       

        private void numericTam_ValueChanged(object sender, EventArgs e)
        {
            tutar = (Convert.ToInt32(numericTam.Value) * CurrentTamFiyat) + (Convert.ToInt32(numericOgrenci.Value) * CurrentOgrFiyat);
            lblTutar.Text = "Tutar: " + tutar.ToString() + " TL";
            numericOgrenci.Maximum = toplam - Convert.ToInt32(numericTam.Value);
            if ((int)numericTam.Value + (int)numericOgrenci.Value == toplam)
            {
                durum = 3;
            }
            else
            {
                durum = 2;
            }
        }

        private void numericOgrenci_ValueChanged(object sender, EventArgs e)
        {
            tutar = (Convert.ToInt32(numericTam.Value) * CurrentTamFiyat) + (Convert.ToInt32(numericOgrenci.Value) * CurrentOgrFiyat);
            lblTutar.Text = "Tutar: " + tutar.ToString() + " TL";
            numericTam.Maximum = toplam - Convert.ToInt32(numericOgrenci.Value);
            if ((int)numericTam.Value + (int)numericOgrenci.Value == toplam)
            {
                durum = 3;
            }
            else
            {
                durum = 2;
            }
        }

        private void frmAnaForm_Load(object sender, EventArgs e)
        {
            cozunurlukAyarla();
            numericTam.Minimum = 0;
            numericOgrenci.Minimum = 0;
            numericOgrenci.Enabled = false;
            numericTam.Enabled = false;
            filmleriCek();
            eskiKayitlariTemizle();
            koltuklariKapat();
            fiyatlariCek();
            seansKontrolEt();
            //Bu program ismail kundakcı tarafından yazılmıştır.

            //ismail kundakcı(mail)-> ism.kundakci@hotmail.com
            //ismail kundakcı(facebook) www.fb.com/ismkdc
        }

        private void cozunurlukAyarla()
        {
            int SimdikiWidth = 1367;

            int SimdikiHeight = 687;
            Rectangle ClientCozunurluk = new Rectangle();

            ClientCozunurluk = Screen.GetBounds(ClientCozunurluk);

            float OranWidth = ((float)ClientCozunurluk.Width / (float)SimdikiWidth);

            float OranHeight = ((float)ClientCozunurluk.Height / (float)SimdikiHeight);


            grupSalon.Scale(OranWidth, OranHeight);
        }

        private void eskiKayitlariTemizle()
        {
            cmd.CommandText="select SalonSayisi from SinemaBilgi";
            int salonsayisi=(int)cmd.ExecuteScalar();
            for (int i = salonsayisi; i > 0; i--)
            {
                string salonadı="Salon"+i.ToString();
                cmd.CommandText = String.Format("delete * from {0} where Tarih<@Tarih", salonadı);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Tarih", DateTime.Now.ToShortDateString());
                cmd.ExecuteNonQuery();
            }
        }

        private void fiyatlariCek()
        {
            cmd.CommandText = "select * from Sinemabilgi";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                OgrFiyat = (Convert.ToDecimal(dr["OgrFiyat"]));
                TamFiyat = (Convert.ToDecimal(dr["TamFiyat"]));
                OgrFiyat3d = (Convert.ToDecimal(dr["3dOgrFiyat"]));
                TamFiyat3d = (Convert.ToDecimal(dr["3dTamFiyat"]));
                CurrentTamFiyat = TamFiyat;
                CurrentOgrFiyat = OgrFiyat;
                lblOgrenci.Text = "Öğrenci " + CurrentOgrFiyat + " TL";
                lblTam.Text = "Tam " + CurrentTamFiyat + " TL";
            }
            dr.Close();
        }

        private void koltuklariKapat()
        {
            foreach (Control koltuk in grupSalon.Controls)
            {
                if (koltuk is Button)
                {
                    if (koltuk.Name.Contains("koltuk"))
                    {
                        koltuk.Enabled = false;
                        koltuk.BackColor = Color.Silver;
                    }
                }
            }
        }



        private void filmleriCek()
        {
            cmd.CommandText = "SELECT Filmler.FilmAdi, Filmler.Tur, Seanslar.Salon, Seanslar.Seanslar FROM Filmler INNER JOIN Seanslar ON Filmler.FilmNo = Seanslar.FilmNo";
            dr = cmd.ExecuteReader();
            int sayac = 0;

            while (dr.Read())
            {
                if (dr["Tur"].ToString().Contains("3D"))
                    treeView1.Nodes.Add(dr["FilmAdi"].ToString()+"(3D)" + " - " + dr["Salon"].ToString() + ".Salon");
                else
                    treeView1.Nodes.Add(dr["FilmAdi"].ToString() + " - " + dr["Salon"].ToString() + ".Salon");

                if (dr["Seanslar"].ToString().Contains(','))
                {
                    string[] dizi = dr["Seanslar"].ToString().Split(',');
                    foreach (string item in dizi)
                    {
                        treeView1.Nodes[sayac].Nodes.Add(item);
                    }

                }
                else
                {
                    treeView1.Nodes[sayac].Nodes.Add(dr["Seanslar"].ToString());
                }
                sayac++;
            }
            dr.Close();
            //Bu program ismail kundakcı tarafından yazılmıştır.

            //ismail kundakcı(mail)-> ism.kundakci@hotmail.com
            //ismail kundakcı(facebook) www.fb.com/ismkdc
        }


        private void doluKoltuklariGoster()
        {
            FrmGiris.baglan();
            List<string> dizi = new List<string>();
            cmd.CommandText = string.Format("Select KoltukNo From {0} where Seans=@Seans", salonadı);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Seans", seans);
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                dizi.Add(dr["KoltukNo"].ToString());
            }
            foreach (Control ckoltuk in this.grupSalon.Controls)
            {
                if (ckoltuk is Button)
                {
                    Button koltuk = (Button)ckoltuk;
                    if (dizi.Contains(koltuk.Name))
                    {
                        koltuk.Enabled = false;
                        koltuk.BackColor = Color.DarkGray;
                    }
                    else
                    {
                        if (koltuk.Name.Contains("gkoltuk"))
                        {
                            koltuk.Enabled = true;
                            koltuk.FlatAppearance.MouseDownBackColor = Color.LightCoral;
                            koltuk.FlatAppearance.MouseOverBackColor = Color.LightCoral;
                            koltuk.BackColor = Color.LightCoral;
                        }
                        else if(koltuk.Name.Contains("koltuk"))
                        {
                            koltuk.Enabled = true;
                            koltuk.FlatAppearance.MouseDownBackColor = Color.Olive;
                            koltuk.FlatAppearance.MouseOverBackColor = Color.Olive;
                            koltuk.BackColor = Color.Olive;
                        }
                    }
                }
            }
            dr.Close();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            if (durum == 1)
            {
                MessageBox.Show("Koltuk seçimi yapmadınız.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (durum == 2)
            {
                MessageBox.Show("Bütün koltukların tarifesini seçmediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (durum == 3)
            {
                DateTime date_seans = Convert.ToDateTime(seans);
                DateTime now = DateTime.Now;
                now = now.AddMinutes(5);
                if (date_seans < now)
                {
                    MessageBox.Show("Bu seansa artık bilet satışı yapılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    toplamogrenci = (int)numericOgrenci.Value;
                    toplamtam = (int)numericTam.Value;
                    FrmFatura frm = new FrmFatura();
                    frm.ShowDialog();
                    toplam = doluKoltuklar.Count + ikiliDoluKoltuklar.Count;
                    numericOgrenci.Maximum = toplam;
                    numericTam.Maximum = toplam;
                }
            }
            //Bu program ismail kundakcı tarafından yazılmıştır.

            //ismail kundakcı(mail)-> ism.kundakci@hotmail.com
            //ismail kundakcı(facebook) www.fb.com/ismkdc
        }



        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            TreeNode secilenSeans = treeView1.SelectedNode;

            try
            {
                if (secilenSeans.Text.Contains(':'))
                {
                    TreeNode secilenFilm = secilenSeans.Parent;
                    if (secilenFilm.Text.Contains("(3D)"))
                    {
                        CurrentOgrFiyat = OgrFiyat3d;
                        CurrentTamFiyat = TamFiyat3d;
                    }
                    else
                    {
                        CurrentOgrFiyat = OgrFiyat;
                        CurrentTamFiyat = TamFiyat;
                    }

                    lblOgrenci.Text = "Öğrenci " + CurrentOgrFiyat + " TL";
                    lblTam.Text = "Tam " + CurrentTamFiyat + " TL";
                    string[] dizi = secilenFilm.Text.Split('-');
                    film = dizi[0];
                    film = film.Substring(0, film.Length - 1);
                    salonadı = dizi[1];
                    salonadı = salonadı.Substring(1);
                    string[] dizi2 = salonadı.Split('.');
                    salonadı = dizi2[1] + dizi2[0];
                    seans = secilenSeans.Text;


                    doluKoltuklariGoster();

                    doluKoltuklar.Clear();
                    ikiliDoluKoltuklar.Clear();
                    numericOgrenci.Maximum = 0;
                    numericTam.Maximum = 0;
                    numericOgrenci.Enabled = false;
                    numericTam.Enabled = false;
                    durum = 1;

                    lblUyarı.Visible = false;

                    lblBilgi.Text = "Salon: " + salonadı + " - Film: " + film + " - Seans: " + seans;
                    lblBilgi.Visible = true;
                }
            }
            catch { }
        }


        private void koltuk_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackColor == Color.Red)
            {
                koltukBosalt(btn);
            }
            else
            {
                koltukDoldur(btn);
            }
            //Bu program ismail kundakcı tarafından yazılmıştır.

            //ismail kundakcı(mail)-> ism.kundakci@hotmail.com
            //ismail kundakcı(facebook) www.fb.com/ismkdc
        }

        private void timerKontrol_Tick(object sender, EventArgs e)
        {
            seansKontrolEt();
        }

        private void seansKontrolEt()
        {
            foreach (TreeNode node in treeView1.Nodes)
            {
                for (int i = node.Nodes.Count - 1; i >= 0; i--)
                {
                    DateTime seans = Convert.ToDateTime(node.Nodes[i].Text);
                    if (seans < DateTime.Now)
                    {
                        treeView1.Nodes.Remove(node.Nodes[i]);
                    }
                }
            }
        }




    }
}
