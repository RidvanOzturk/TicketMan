using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketmanProject
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void devamBtn_Click(object sender, EventArgs e)
        {
            SorunlarAnaForm anaForm = new SorunlarAnaForm();
           
            anaForm.adSoyad = adSoyadTxt.Text;
            anaForm.no = telNoTxt.Text;
            if (adSoyadTxt.Text == "" || telNoTxt.Text == "")
            {
                MessageBox.Show("Lütfen Bilgileri Doğru Doldurunuz.","Hata!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else { 
            anaForm.Show();
            this.Hide();//lskdfjlksdf
            }
        }
    }
}
