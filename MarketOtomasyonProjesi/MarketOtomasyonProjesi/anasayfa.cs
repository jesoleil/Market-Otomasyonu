using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonProjesi
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        giris form1 = (giris)Application.OpenForms["giris"];

        private void calisanlarbtn_Click(object sender, EventArgs e)
        {
            calisanlarform calisanlarsec = new calisanlarform();
            calisanlarsec.ShowDialog();
        }

        private void urunlerbtn_Click(object sender, EventArgs e)
        {
            urunlerform urunlersec = new urunlerform();
            urunlersec.ShowDialog();
        }

        private void tedarikbtn_Click(object sender, EventArgs e)
        {
            tedarikcilerform tedarikcisec = new tedarikcilerform();
            tedarikcisec.ShowDialog();

        }

        private void subelerbtn_Click(object sender, EventArgs e)
        {
            subelerform subesec = new subelerform();
            subesec.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            MessageBox.Show(form1.yetki.ToString(), "SAS Marketler Zinciri");
           
            if (form1.yetki == "MÜDÜR")
            {
                calisanlarbtn.Hide();
                subelerbtn.Hide();
                tedarikbtn.Hide();
            }
        }
    }
}
