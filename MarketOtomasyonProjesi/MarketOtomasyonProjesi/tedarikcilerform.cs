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
    public partial class tedarikcilerform : Form
    {
        public tedarikcilerform()
        {
            InitializeComponent();
        }

        private void TedarikciGoster()
        {
            Tedarikci tedarikci = new Tedarikci();
            try
            {
                tedarikci.BaglantiAc();
                OleDbDataAdapter tedarikcilerilistele = new OleDbDataAdapter
                    ("select firmano AS[FİRMA NO],firmaad AS[FİRMA ADI],firmatelefon AS[TELEFON],firmaadres AS[ADRES],firmaeposta AS[EPOSTA],firmakategori AS[KATEGORİ],firmavergino AS[VERGİ NO],firmavergidairesi AS[VERGİ DAİRESİ] from tedarikciler Order By firmaad ASC", tedarikci.baglan);
                DataSet dshafiza = new DataSet();
                tedarikcilerilistele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                tedarikci.BaglantiKapat();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "SAS Market Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tedarikci.BaglantiKapat();
            }
        }
        private void Temizle()
        {
            fidbox.Clear();
            fadibox.Clear();
            ftelnobox.Clear();
            fadresbox.Clear();
            epostabox.Clear();
            kategoricbox.SelectedIndex = -1;
            verginobox.Clear();
            vergiadbox.Clear();
        }

        private void tedarikcilerform_Load(object sender, EventArgs e)
        {
            TedarikciGoster();
        }
        private void fidbox_TextChanged(object sender, EventArgs e)
        {
            if (fidbox.Text.Length < 7)
                errorProvider1.SetError(fidbox, "TC Kimlik No 11 Karakter olmalıdır!");
            else
                errorProvider1.Clear();
        }

        private void fidbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void fadibox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ftelnobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void verginobox_TextChanged(object sender, EventArgs e)
        {
            if (verginobox.Text.Length < 10)
                errorProvider1.SetError(verginobox, "Vergi No 10 Karakter olmalıdır!");
            else
                errorProvider1.Clear();

        }

        private void verginobox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }



        private void kydtbtn_Click_1(object sender, EventArgs e)
        {
            bool kayitkontrol2 = false;

            Tedarikci tedarikci = new Tedarikci();
            tedarikci.BaglantiAc();
            OleDbCommand selectsorgu2 = new OleDbCommand("select * from tedarikciler where firmano='" + fidbox.Text + "'", tedarikci.baglan);
            OleDbDataReader kayitokuma2 = selectsorgu2.ExecuteReader();
            while (kayitokuma2.Read())
            {
                kayitkontrol2 = true;
                break;
            }
            tedarikci.BaglantiKapat();

            if (kayitkontrol2 == false)
            {
                if (fidbox.Text.Length < 7 || fidbox.Text == "")
                    fid.ForeColor = Color.Red;
                else
                    fid.ForeColor = Color.Black;

                if (fadresbox.Text.Length < 2 || fadresbox.Text == "")
                    fiadres.ForeColor = Color.Red;
                else
                    fiadres.ForeColor = Color.Black;

                try
                {
                    tedarikci.BaglantiAc();
                    OleDbCommand eklekomutu = new OleDbCommand("insert into tedarikciler values('" + fidbox.Text + "','" + fadibox.Text + "','" + ftelnobox.Text + "','" + fadresbox.Text + "','" + epostabox.Text + "','" + kategoricbox.Text + "','" + verginobox.Text + "','" + vergiadbox.Text + "')", tedarikci.baglan);
                    eklekomutu.ExecuteNonQuery();
                    tedarikci.BaglantiKapat();

                    MessageBox.Show("Yeni kayıt oluşturuldu!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TedarikciGoster();
                    Temizle();
                }
                catch (Exception hatamsj)
                {
                    MessageBox.Show(hatamsj.Message, "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tedarikci.BaglantiKapat();
                }
            }
            else
            {
                MessageBox.Show("Girilen Firma Numarası daha önceden kayıtlıdır!!", "SAS Marketler Zincirleri", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void tmzlbtn_Click_1(object sender, EventArgs e)
        {
            Temizle();
        }

        private void gnclbtn_Click_1(object sender, EventArgs e)
        {
            Tedarikci tedarikci = new Tedarikci();
            try
            {
                tedarikci.BaglantiAc();
                OleDbCommand guncellekomutu = new OleDbCommand("update tedarikciler set firmano='" + fidbox.Text + "',firmaad='" + fadibox.Text + "',firmatelefon='" + ftelnobox.Text + "',firmaadres='" + fadresbox.Text + "',firmaeposta='" + epostabox.Text + "',firmakategori='" + kategoricbox.Text + "',firmavergino='" + verginobox.Text + "',firmavergidairesi='" + vergiadbox.Text + "'where firmano='" + fidbox.Text + "'", tedarikci.baglan);
                guncellekomutu.ExecuteNonQuery();
                tedarikci.BaglantiKapat();

                MessageBox.Show("Kayıt Güncellendi!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TedarikciGoster();
                Temizle();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tedarikci.BaglantiKapat();
            }
        }

        private void silbtn_Click_1(object sender, EventArgs e)
        {
            Tedarikci tedarikci = new Tedarikci();

                bool kayitarama = false;
                tedarikci.BaglantiAc();
                OleDbCommand aramasorgusu = new OleDbCommand("select * from tedarikciler where firmano='" + fidbox.Text + "'", tedarikci.baglan);
                OleDbDataReader kayitokuma = aramasorgusu.ExecuteReader();
                while (kayitokuma.Read())
                {
                    kayitarama = true;
                    OleDbCommand deletesorgu = new OleDbCommand("delete from tedarikciler where firmano='" + fidbox.Text + "'", tedarikci.baglan);
                    deletesorgu.ExecuteNonQuery();
                    break;
                }
                if (kayitarama == false)
                {
                    MessageBox.Show("Silinecek kayıt bulunamadı!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                tedarikci.BaglantiKapat();
                TedarikciGoster();
                Temizle();

        }
    }
}
