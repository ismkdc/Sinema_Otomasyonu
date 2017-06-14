using CrystalDecisions.CrystalReports.Engine;
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
    public partial class FrmFaturaShow : Form
    {
        public static CrystalReport1 rapor = new CrystalReport1();
        public FrmFaturaShow()
        {
            InitializeComponent();
        }

        private void FrmFaturaShow_Load(object sender, EventArgs e)
        {
            rapor.SetDataSource(FrmFatura.ds);
            crystalReportViewer1.ReportSource = rapor;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmeFatura frm = new FrmeFatura();
            frm.ShowDialog();
        }

       
    
    }
}
