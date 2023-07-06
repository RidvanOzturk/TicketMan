using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketmanProject.AltKirilim;

namespace TicketmanProject
{
    public partial class IcKargoProblemleri : Form
    {
        public IcKargoProblemleri()
        {
            InitializeComponent();
        }
        private void FormGetir(Form frm)
        {
            IcKargoPanel.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            IcKargoPanel.Controls.Add(frm);
            frm.Show();
        }
        private void teslimatProblemleriBtn_Click(object sender, EventArgs e)
        {
            AltTeslimatProblemleri altTeslimatProblemleri = new AltTeslimatProblemleri();
            FormGetir(altTeslimatProblemleri);

        }
    }
}
