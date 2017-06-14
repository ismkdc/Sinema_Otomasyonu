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

namespace SinemaOtomasyonu
{
    public partial class FrmFatura : Form
    {
        public static DataSet1 ds;
        string KuponNo = "";
        decimal indirim = 0;
        string koltular = "";
        bool kupon = false;
        OleDbCommand cmd = new OleDbCommand();
        decimal indirimlifiyat = 0;
        public FrmFatura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFatura_Load(object sender, EventArgs e)
        {
            lblTam.Text = frmAnaForm.toplamtam.ToString()+" Tane Tam Bilet";
            lblOgrenci.Text = frmAnaForm.toplamogrenci.ToString()+" Tane Öğrenci Bilet";
            lblToplam.Text = "Toplam " + frmAnaForm.tutar + " TL";
            cmd.Connection = FrmGiris.conn;
            FrmGiris.baglan();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            cmd.Connection = FrmGiris.conn;
                string tarih = DateTime.Now.ToString();
                string alankisi = txtKupon.Text.Trim();
                foreach (Button koltuk in frmAnaForm.doluKoltuklar)
                {
                    cmd.CommandText = string.Format("insert into {0}(KoltukNo,FilmAdi,Seans,Tarih)values(@KoltukNo,@FilmAdi,@Seans,@Tarih)", frmAnaForm.salonadı);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@KoltukNo", koltuk.Name);
                    cmd.Parameters.AddWithValue("@FilmAdi", frmAnaForm.film);
                    cmd.Parameters.AddWithValue("@Seans", frmAnaForm.seans);
                    cmd.Parameters.Add("@Tarih", OleDbType.Date).Value = DateTime.Now;
                    cmd.ExecuteNonQuery();
                    koltuk.BackColor = Color.Silver;
                    koltuk.Enabled = false;
                    if (koltuk.Name.Contains("gkoltuk")) { koltular += koltuk.Name.Substring(8).ToUpper() + "/"; }
                    else { koltular += koltuk.Name.Substring(7).ToUpper() + "/"; }
                }
                koltular = koltular.Remove(koltular.Length - 1);
                fisYaz();
                frmAnaForm.doluKoltuklar.Clear();
                frmAnaForm.ikiliDoluKoltuklar.Clear();
                DialogResult cevap = MessageBox.Show("Fişinizi Görmek İstermisiniz?", "Satış Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    FrmFaturaShow fatura = new FrmFaturaShow();
                    fatura.ShowDialog();
                }
                this.Close();


        }

        private void fisYaz()
        {
            if (kupon)
            {
                cmd.CommandText = "update IndirimKuponlari set KullanimHakki=KullanimHakki-1 where KuponNo=@KuponNo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@KuponNo", KuponNo);
                cmd.ExecuteNonQuery();
            }
            else { indirimlifiyat = frmAnaForm.tutar; }
            cmd.Parameters.Clear();
            cmd.CommandText = "insert into Fisler(SalonNo,FilmIsmi,Seans,KoltukNo,Kasiyer,Tarih,Saat,ToplamTamSay,ToplamOgrSay,IndirimsizTutar,Tutar)values(@SalonNo,@FilmIsmi,@Seans,@KoltukNo,@Kasiyer,@Tarih,@Saat,@ToplamTamSay,@ToplamOgrSay,@IndirimsizTutar,@Tutar)";
            cmd.Parameters.AddWithValue("@SalonNo", frmAnaForm.salonadı);
            cmd.Parameters.AddWithValue("@FilmIsmi", frmAnaForm.film);
            cmd.Parameters.AddWithValue("@Seans", frmAnaForm.seans);
            cmd.Parameters.AddWithValue("@KoltukNo", koltular);
            cmd.Parameters.AddWithValue("@Kasiyer", FrmGiris.kasiyer);
            cmd.Parameters.AddWithValue("@Tarih", DateTime.Now.ToShortDateString());
            cmd.Parameters.AddWithValue("@Saat", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@ToplamTamSay", frmAnaForm.toplamtam);
            cmd.Parameters.AddWithValue("@ToplamOgrSay", frmAnaForm.toplamogrenci);
            cmd.Parameters.AddWithValue("@IndirimsizTutar", frmAnaForm.tutar);
            cmd.Parameters.AddWithValue("@Tutar", indirimlifiyat);
            cmd.ExecuteNonQuery();

            cmd.CommandText = "select @@identity";
            int FisNo = (int)cmd.ExecuteScalar();
            cmd.Parameters.Clear();
            cmd.CommandText = "select * from Fisler where FisNo=@FisNo";
            cmd.Parameters.AddWithValue("@FisNo", FisNo);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            ds = new DataSet1();
            da.Fill(ds, "DtFis");

            cmd.CommandText = "select * from SinemaBilgi";
            OleDbDataAdapter da2 = new OleDbDataAdapter(cmd);
            da2.Fill(ds, "DtSinemaBilgi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "select * from IndirimKuponlari where Kupon=@Kupon";
            cmd.Parameters.AddWithValue("@Kupon", txtKupon.Text.Trim());
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if ((Convert.ToInt32(dr["KullanimHakki"])) <= 0)
                {
                    MessageBox.Show("Bu Kuponun Kullanım Hakkı Dolmuştur!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    DateTime skt = Convert.ToDateTime(dr["SKTarihi"]);
                    if (skt <= DateTime.Now)
                    {
                        MessageBox.Show("Kuponun Son Kullanma Tarihi Geçmiştir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        indirim = Convert.ToDecimal(dr["IndirimMiktari"]);
                        indirimlifiyat = frmAnaForm.tutar - ((frmAnaForm.tutar / 100) * indirim);
                        lblIndirimsizFiyat.Text = "*Eski Fiyat: " + frmAnaForm.tutar + " TL";
                        lblToplam.Text = "Yeni Fiyat: " + indirimlifiyat + " TL" + "(-%" + dr["IndirimMiktari"].ToString() + ")";
                        lblIndirimsizFiyat.Visible = true;
                        lblToplam.Location = new Point(140, 199);
                        this.Size = new Size(395, 284);
                        btnSatis.Location = new Point(265, 227);
                        btnIptal.Location = new Point(46, 227);
                        KuponNo = dr["KuponNo"].ToString();
                        kupon = true;
                    }
                }
            }
            else { MessageBox.Show("Kupon Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop); }

            dr.Close();
        }
    }
}
