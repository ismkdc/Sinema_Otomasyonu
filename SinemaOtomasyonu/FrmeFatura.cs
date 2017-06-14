using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class FrmeFatura : Form
    {
        public FrmeFatura()
        {
            InitializeComponent();
        }
        public void MailGonder(string kime, string konu, string mesaj, string resim)
        {

            string email = "buraya emailinizi yazınız";
            string sifre = "buraya mail şifrenizi yazınız";


            SmtpClient client = new SmtpClient();
            MailMessage msg = new MailMessage();
            if (resim != null)
            {
                Attachment eklenecekdosya = new Attachment(resim);
                msg.Attachments.Add(eklenecekdosya);
            }
            msg.From = new MailAddress(email, "Fatura");
            msg.To.Add(kime);
            msg.Subject = konu;
            msg.IsBodyHtml = true;
            msg.Body = mesaj;
            msg.BodyEncoding = System.Text.Encoding.GetEncoding(1254);
            client.Credentials = new NetworkCredential(email, sifre);
            client.Port = 587;
            client.Host = "smtp.live.com";
            client.EnableSsl = true;
            client.Send(msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportOptions exportOpts = FrmFaturaShow.rapor.ExportOptions;
            exportOpts.ExportFormatType = ExportFormatType.PortableDocFormat;
            exportOpts.ExportDestinationType = ExportDestinationType.DiskFile;
            exportOpts.DestinationOptions = new DiskFileDestinationOptions();
            string Fname = "efatura.pdf";
            DiskFileDestinationOptions diskOpts = new DiskFileDestinationOptions();
            ((DiskFileDestinationOptions)FrmFaturaShow.rapor.ExportOptions.DestinationOptions).DiskFileName = Fname;
            FrmFaturaShow.rapor.Export(exportOpts);
            MailGonder(textBox1.Text.Trim(), "E-Fatura", "", Fname);
            MessageBox.Show("Gönderildi!");
            this.Close();
        }

    }
}
