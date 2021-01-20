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

namespace MarketOtomasyonProjesi
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }
        public string yetki;
        private void Giris_btn_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            try
            {
                personel.BaglantiAc();
                personel.k_adi = Ad_tbx.Text;
                personel.sifre = Sifre_tbx.Text;
                OleDbCommand selectsorgu = new OleDbCommand("select * from kullanicilar", personel.baglan);
                OleDbDataReader kayitokuma = selectsorgu.ExecuteReader();
                void BilgileriGoster()
                {
                    personel.tcno = kayitokuma.GetValue(0).ToString();
                    personel.adi = kayitokuma.GetValue(1).ToString();
                    personel.soyadi = kayitokuma.GetValue(2).ToString();
                    personel.yetki = kayitokuma.GetValue(3).ToString();
                }
                while (kayitokuma.Read())
                {
                    yetki = kayitokuma["yetki"].ToString();
                    if (kayitokuma["kullaniciadi"].ToString() == Ad_tbx.Text &&
                        kayitokuma["parola"].ToString() == Sifre_tbx.Text)
                    {
                        BilgileriGoster();
                        this.Hide();
                        anasayfa frm2 = new anasayfa();
                        frm2.Show();
                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz !");
            }

        }

        private void Cikis_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sifre_tbx_TextChanged(object sender, EventArgs e)
        {
            Sifre_tbx.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
