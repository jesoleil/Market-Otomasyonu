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
using System.Text.RegularExpressions;
using System.IO;

namespace MarketOtomasyonProjesi
{
    public partial class subelerform : Form
    {
        public subelerform()
        {
            InitializeComponent();
        }
        private void SubeGoster()
        {
            Sube sube = new Sube();
            try
            {
                sube.BaglantiAc();
                OleDbDataAdapter tedarikcilerilistele = new OleDbDataAdapter
                    ("select mid AS[ŞUBE ID],mad AS[ŞUBE ADI],msube AS[BULUNDUĞU İLÇE],madres AS[ADRES],mtelefon AS[TELEFON],mvergino AS[VERGİ NO],mvergidairesi AS[VERGİ DAİRESİ],mmersisno AS[MERSİS NO] from marketler Order By mad ASC", sube.baglan);
                DataSet dshafiza = new DataSet();
                tedarikcilerilistele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                sube.BaglantiKapat();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "SAS Market Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sube.BaglantiKapat();
            }
        }
        private void Temizle()
        {
            midbox.Clear();
            madbox.Clear();
            msubebox.SelectedIndex = -1;
            madresbox.Clear();
            mtelefonbox.Clear();
            mverginobox.Clear();
            mvergidairesibox.Clear();
            mersisnobox.Clear();
        }


        private void subelerform_Load(object sender, EventArgs e)
        {
            SubeGoster();
        }


        private void midbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void midbox_TextChanged(object sender, EventArgs e)
        {
            if (midbox.Text.Length < 4)
                errorProvider1.SetError(midbox, "Market kodu 4 haneli olmalıdır!");
            else
                errorProvider1.Clear();
        }



        private void mtelefonbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void mverginobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void mersisnobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void mvergidairesibox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void mersisnobox_TextChanged(object sender, EventArgs e)
        {
            if (mersisnobox.Text.Length < 16)
                errorProvider1.SetError(mersisnobox, "Mersis No 16 Karakter olmalıdır!");
            else
                errorProvider1.Clear();
        }

        private void mverginobox_TextChanged(object sender, EventArgs e)
        {
            if (mverginobox.Text.Length < 10)
                errorProvider1.SetError(mverginobox, "Vergi No 10 Karakter olmalıdır!");
            else
                errorProvider1.Clear();
        }


        private void tmzlbtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void gnclbtn_Click(object sender, EventArgs e)
        {
            Sube sube = new Sube();
            try
            {
                sube.BaglantiAc();
                OleDbCommand guncellekomutu = new OleDbCommand("update marketler set mid='" + midbox.Text + "',mad='" + madbox.Text + "',msube='" + msubebox.Text + "',madres='" + madresbox.Text + "',mtelefon='" + mtelefonbox.Text + "',mvergino='" + mverginobox.Text + "',mvergidairesi='" + mvergidairesibox.Text + "',mmersisno='" + mersisnobox.Text + "'where mid='" + midbox.Text + "'", sube.baglan);
                guncellekomutu.ExecuteNonQuery();
                sube.BaglantiKapat();

                MessageBox.Show("Kayıt Güncellendi!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SubeGoster();
                Temizle();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sube.BaglantiKapat();
            }
        }

        private void silbtn_Click_1(object sender, EventArgs e)
        {
           
        }

        private void kydtbtn_Click(object sender, EventArgs e)
        {
            bool kayitkontrol = false;

            Sube sube = new Sube();
            sube.BaglantiAc();
            OleDbCommand selectsorgu = new OleDbCommand("select * from marketler where mid='" + midbox.Text + "'", sube.baglan);
            OleDbDataReader kayitokuma = selectsorgu.ExecuteReader();
            while (kayitokuma.Read())
            {
                kayitkontrol = true;
                break;
            }
            sube.BaglantiKapat();

            if (kayitkontrol == false)
            {
                if (midbox.Text.Length < 4 || midbox.Text == "")
                    mid.ForeColor = Color.Red;
                else
                    mid.ForeColor = Color.Black;

                try
                {
                    sube.BaglantiAc();
                    OleDbCommand eklekomutu = new OleDbCommand("insert into marketler values('" + midbox.Text + "','" + madbox.Text + "','" + msubebox.Text + "','" + madresbox.Text + "','" + mtelefonbox.Text + "','" + mverginobox.Text + "','" + mvergidairesibox.Text + "','" + mersisnobox.Text + "')", sube.baglan);
                    eklekomutu.ExecuteNonQuery();
                    sube.BaglantiKapat();

                    MessageBox.Show("Yeni kayıt oluşturuldu!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    SubeGoster();
                    Temizle();
                }
                catch (Exception hatamsj)
                {
                    MessageBox.Show(hatamsj.Message, "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sube.BaglantiKapat();
                }
            }
            else
            {
                MessageBox.Show("Girilen Market numarası daha önceden kayıtlıdır!!", "SAS Marketler Zincirleri", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            Sube sube = new Sube();

            bool kayitarama = false;
            sube.BaglantiAc();
            OleDbCommand aramasorgusu = new OleDbCommand("select * from marketler where mid='" + midbox.Text + "'", sube.baglan);
            OleDbDataReader kayitokuma = aramasorgusu.ExecuteReader();
            while (kayitokuma.Read())
            {
                kayitarama = true;
                OleDbCommand deletesorgu = new OleDbCommand("delete from marketler where mid='" + midbox.Text + "'", sube.baglan);
                deletesorgu.ExecuteNonQuery();
                break;
            }
            if (kayitarama == false)
            {
                MessageBox.Show("Silinecek kayıt bulunamadı!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            sube.BaglantiKapat();
            SubeGoster();
            Temizle();

        }
    }
    }

