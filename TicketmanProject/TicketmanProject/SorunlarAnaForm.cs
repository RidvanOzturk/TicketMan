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
       
        private void FormGetir(Form frm)
        {
            panel2.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void KargoProblemleriBtn_Click(object sender, EventArgs e)
        {
            IcKargoProblemleri KargoProblem = new IcKargoProblemleri();
            FormGetir(KargoProblem);
            KargoProblemleriBtn.Enabled = false;
            LojistikDepoProblemleriBtn.Enabled = true;
        }

        private void SorunlarAnaForm_Load(object sender, EventArgs e)
        {
            adSoyadNoVeriLbl.Text = adSoyad + "\n" + no;
        }

        private void LojistikDepoProblemleriBtn_Click(object sender, EventArgs e)
        {
             IcLojistikDepoProblemleri LojistikProblem= new IcLojistikDepoProblemleri();
            FormGetir(LojistikProblem);
            LojistikDepoProblemleriBtn.Enabled = false;
            KargoProblemleriBtn.Enabled = true;
        }
    }
    }
