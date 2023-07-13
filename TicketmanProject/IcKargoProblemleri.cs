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
     

        public void teslimatProblemleriBtn_Click(object sender, EventArgs e)
        {
          SorunlarAnaForm sorunlarAnaForm = new SorunlarAnaForm();
          AltTeslimatProblemleri altTeslimatProblemleri = new AltTeslimatProblemleri();
            sorunlarAnaForm.AltFormGetir(altTeslimatProblemleri);
        }
    }
}
