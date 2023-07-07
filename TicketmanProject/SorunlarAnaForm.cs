using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketmanProject
{
    public partial class SorunlarAnaForm : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );
        public SorunlarAnaForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
       

        public string adSoyad;
        public string no;
        private void SorunlarAnaForm_Load(object sender, EventArgs e)
        {
            adSoyadNoVeriLbl.Text = string.Concat(adSoyad,Environment.NewLine,no);
        }
        private void FormGetir(Form frm)
        {
            panel2.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm);
            frm.Show();
        }
        private void secimleriTemizleBtn_Click(object sender, EventArgs e)
        {
            //clear
            panel2.Controls.Clear();
            IadeDegisimProblemleriBtn.Enabled = true;
            LojistikDepoProblemleriBtn.Enabled = true;
            KargoProblemleriBtn.Enabled = true;
            SiparisProblemleriBtn.Enabled = true;
            secimleriTemizleBtn.Visible = false;
            OdemeProblemleriBtn.Enabled = true;
            KampanyaProblemleriBtn.Enabled = true;
            WebSiteProblemleriBtn.Enabled = true;
            DigerProblemlerBtn.Enabled = true;
            KvkkBtn.Enabled = true;
        }

        private void KargoProblemleriBtn_Click(object sender, EventArgs e)
        {
            IcKargoProblemleri KargoProblem = new IcKargoProblemleri();
            FormGetir(KargoProblem);
            KargoProblemleriBtn.Enabled = false;
            SiparisProblemleriBtn.Enabled = true;
            LojistikDepoProblemleriBtn.Enabled = true;
            IadeDegisimProblemleriBtn.Enabled = true;
            secimleriTemizleBtn.Visible = true;
            OdemeProblemleriBtn.Enabled = true;
            KampanyaProblemleriBtn.Enabled = true;
            WebSiteProblemleriBtn.Enabled = true;
            DigerProblemlerBtn.Enabled = true;
            KvkkBtn.Enabled = true;
        }



        private void LojistikDepoProblemleriBtn_Click(object sender, EventArgs e)
        {
             IcLojistikDepoProblemleri LojistikProblem= new IcLojistikDepoProblemleri();
            FormGetir(LojistikProblem);
            LojistikDepoProblemleriBtn.Enabled = false;
            SiparisProblemleriBtn.Enabled = true;
            KargoProblemleriBtn.Enabled = true;
            IadeDegisimProblemleriBtn.Enabled = true;
            secimleriTemizleBtn.Visible = true;
            OdemeProblemleriBtn.Enabled = true;
            KampanyaProblemleriBtn.Enabled = true;
            WebSiteProblemleriBtn.Enabled = true;
            DigerProblemlerBtn.Enabled = true;
            KvkkBtn.Enabled = true;
        }

        private void SiparisProblemleriBtn_Click(object sender, EventArgs e)
        {
            IcSiparisProblemleri SiparisProblem = new IcSiparisProblemleri();
            FormGetir(SiparisProblem);
            SiparisProblemleriBtn.Enabled = false;
            LojistikDepoProblemleriBtn.Enabled = true;
            KargoProblemleriBtn.Enabled = true;
            IadeDegisimProblemleriBtn.Enabled = true;
            secimleriTemizleBtn.Visible = true;
            OdemeProblemleriBtn.Enabled = true;
            KampanyaProblemleriBtn.Enabled = true;
            WebSiteProblemleriBtn.Enabled = true;
            DigerProblemlerBtn.Enabled = true;
            KvkkBtn.Enabled = true;
        }

        private void IadeDegisimProblemleriBtn_Click(object sender, EventArgs e)
        {
            IcIadeDegisimProblemleri IadeDegisimProblem= new IcIadeDegisimProblemleri();
            FormGetir(IadeDegisimProblem);
            IadeDegisimProblemleriBtn.Enabled = false;
            LojistikDepoProblemleriBtn.Enabled = true;
            KargoProblemleriBtn.Enabled = true;
            SiparisProblemleriBtn.Enabled = true;
            secimleriTemizleBtn.Visible = true;
            OdemeProblemleriBtn.Enabled = true;
            KampanyaProblemleriBtn.Enabled = true;
            WebSiteProblemleriBtn.Enabled = true;
            DigerProblemlerBtn.Enabled = true;
            KvkkBtn.Enabled = true;
        }





        private void OdemeProblemleriBtn_Click(object sender, EventArgs e)
        {
            IcOdemeProblemleri OdemeProblemleri = new IcOdemeProblemleri();
            FormGetir(OdemeProblemleri);
            OdemeProblemleriBtn.Enabled = false;
            IadeDegisimProblemleriBtn.Enabled = true;
            LojistikDepoProblemleriBtn.Enabled = true;
            KargoProblemleriBtn.Enabled = true;
            SiparisProblemleriBtn.Enabled = true;
            secimleriTemizleBtn.Visible = true;
            KampanyaProblemleriBtn.Enabled = true;
            WebSiteProblemleriBtn.Enabled = true;
            DigerProblemlerBtn.Enabled = true;
            KvkkBtn.Enabled = true;
        }

        private void KampanyaProblemleriBtn_Click(object sender, EventArgs e)
        {
            IcKampanyaProblemleri KampanyaProblemleri = new IcKampanyaProblemleri();
            FormGetir(KampanyaProblemleri);
            KampanyaProblemleriBtn.Enabled = false;
            OdemeProblemleriBtn.Enabled = true;
            IadeDegisimProblemleriBtn.Enabled = true;
            LojistikDepoProblemleriBtn.Enabled = true;
            KargoProblemleriBtn.Enabled = true;
            SiparisProblemleriBtn.Enabled = true;
            secimleriTemizleBtn.Visible = true;
            WebSiteProblemleriBtn.Enabled = true;
            DigerProblemlerBtn.Enabled = true;
            KvkkBtn.Enabled = true;
        }

        private void WebSiteProblemleriBtn_Click(object sender, EventArgs e)
        {
            IcWebSiteProblemleri WebSiteProblemleri = new IcWebSiteProblemleri();
            FormGetir(WebSiteProblemleri);
            WebSiteProblemleriBtn.Enabled = false;
            KampanyaProblemleriBtn.Enabled = true;
            OdemeProblemleriBtn.Enabled = true;
            IadeDegisimProblemleriBtn.Enabled = true;
            LojistikDepoProblemleriBtn.Enabled = true;
            KargoProblemleriBtn.Enabled = true;
            SiparisProblemleriBtn.Enabled = true;
            secimleriTemizleBtn.Visible = true;
            DigerProblemlerBtn.Enabled = true;
            KvkkBtn.Enabled = true;
        }

        private void DigerProblemlerBtn_Click(object sender, EventArgs e)
        {
            IcDigerProblemler DigerProblemler = new IcDigerProblemler();
            FormGetir(DigerProblemler);
            DigerProblemlerBtn.Enabled = false;
            WebSiteProblemleriBtn.Enabled = true;
            KampanyaProblemleriBtn.Enabled = true;
            OdemeProblemleriBtn.Enabled = true;
            IadeDegisimProblemleriBtn.Enabled = true;
            LojistikDepoProblemleriBtn.Enabled = true;
            KargoProblemleriBtn.Enabled = true;
            SiparisProblemleriBtn.Enabled = true;
            secimleriTemizleBtn.Visible = true;
            KvkkBtn.Enabled = true;

        }

        private void KvkkBtn_Click(object sender, EventArgs e)
        {
            IcKvkk kvkk = new IcKvkk();
            FormGetir(kvkk);
            KvkkBtn.Enabled = false; 
            DigerProblemlerBtn.Enabled = false;
            WebSiteProblemleriBtn.Enabled = true;
            KampanyaProblemleriBtn.Enabled = true;
            OdemeProblemleriBtn.Enabled = true;
            IadeDegisimProblemleriBtn.Enabled = true;
            LojistikDepoProblemleriBtn.Enabled = true;
            KargoProblemleriBtn.Enabled = true;
            SiparisProblemleriBtn.Enabled = true;
            secimleriTemizleBtn.Visible = true;

        }
    }
    }
