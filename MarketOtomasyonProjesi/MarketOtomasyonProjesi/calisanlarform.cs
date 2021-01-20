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
    public partial class calisanlarform : Form
    {
        public calisanlarform()
        {
            InitializeComponent();
        }
        int yillikhak = 14;

        private void CalisanlarGoster()
        {
            Personel personel = new Personel();
            try
            {
                personel.BaglantiAc();
                OleDbDataAdapter calisanlarilistele = new OleDbDataAdapter
                   ("select tckimlikno AS[TC KİMLİK NO],ad AS[ADI],soyad AS[SOYADI],telefon AS[TELEFON],adres AS[ADRES],pozisyon AS[POZİSYONU],sube AS[ŞUBE],maas AS[MAAŞI],isegiristarih AS[İŞE GİRİŞ TARİHİ],zamorani AS[ZAM ORANI],yenimaas AS [YENİ MAAS] from calisanlar where adres is not null Order By ad ASC", personel.baglan);
                DataSet dshafiza = new DataSet();
                calisanlarilistele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                personel.BaglantiKapat();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                personel.BaglantiKapat();
            }
        }
        private void IzinlerGoster()
        {
            Personel izin = new Personel();
            try
            {
                izin.BaglantiAc();
                OleDbDataAdapter izinlerilistele = new OleDbDataAdapter
                   ("select tcno AS[TC KİMLİK NO],ad AS[ADI],soyad AS[SOYADI],izinturu AS[İZİN TÜRÜ],izinbaslangic AS[İZİN BAŞLANGIÇ TARİHİ],izinbitis AS[İZİN BİTİŞ TARİHİ],gunsayisi AS[İZİNLİ GÜN SAYISI],kalanhak AS[KALAN HAK] from izinler Order By ad ASC", izin.baglan);
                DataSet dshafiza = new DataSet();
                izinlerilistele.Fill(dshafiza);
                dataGridView2.DataSource = dshafiza.Tables[0];
                izin.BaglantiKapat();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                izin.BaglantiKapat();
            }
        }
        private void calisanlarform_Load(object sender, EventArgs e)
        {
            CalisanlarGoster();
            IzinlerGoster();
            tcnobox.Mask = "00000000000";
            adbox.Mask = "LL??????????????";
            soyadbox.Mask = "LL???????????";
            telnobox.Mask = "00000000000";


        }

        private void tcnobox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tcnobox_TextChanged(object sender, EventArgs e)
        {
            if (tcnobox.Text.Length < 11)
                errorProvider1.SetError(tcnobox, "TC Kimlik No 11 Karakter olmalıdır!");
            else
                errorProvider1.Clear();

        }

        private void tcnobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void adbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void soyadbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void telnobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void maasbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void Temizle()
        {
            tcnobox.Clear();
            adbox.Clear();
            soyadbox.Clear();
            telnobox.Clear();
            adresbox.Clear();
            pzsynbox.SelectedIndex = -1;
            subebox.SelectedIndex = -1;
            maasbox.Clear();
        }

        private void tmzlbtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void kydtbtn_Click(object sender, EventArgs e)
        {
            bool kayitkontrol = false;

            Personel personel = new Personel();
            personel.BaglantiAc();
            OleDbCommand selectsorgu = new OleDbCommand("select * from calisanlar where tckimlikno='" + tcnobox.Text + "'", personel.baglan);
            OleDbDataReader kayitokuma = selectsorgu.ExecuteReader();
            while (kayitokuma.Read())
            {
                kayitkontrol = true;
                break;
            }
            personel.BaglantiKapat();

            if (kayitkontrol == false)
            {
                if (tcnobox.Text.Length < 11 || tcnobox.Text == "")
                    tcno.ForeColor = Color.Red;
                else
                    tcno.ForeColor = Color.Black;

                if (adresbox.Text.Length < 2 || adresbox.Text == "")
                    adres.ForeColor = Color.Red;
                else
                    adres.ForeColor = Color.Black;

                if (tcnobox.MaskCompleted != false && adbox.MaskCompleted != false && soyadbox.MaskCompleted != false && telnobox.MaskCompleted != false && adresbox.Text != "" && pzsynbox.Text != "" && subebox.Text != "" && maasbox.Text != "")
                {
                    try
                    {
                        personel.BaglantiAc();
                        OleDbCommand eklekomutu = new OleDbCommand("insert into calisanlar values('" + tcnobox.Text + "','" + adbox.Text + "','" + soyadbox.Text + "','" + telnobox.Text + "','" + adresbox.Text + "','" + pzsynbox.Text + "','" + subebox.Text + "','" + maasbox.Text + "','" + dateTimePicker1.Value + "','" + zamtbx.Text + "','" + yenimaastbx.Text + "')", personel.baglan);
                        eklekomutu.ExecuteNonQuery();
                        personel.BaglantiKapat();

                        MessageBox.Show("Yeni kayıt oluşturuldu!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        CalisanlarGoster();
                        Temizle();
                    }
                    catch (Exception hatamsj)
                    {
                        MessageBox.Show(hatamsj.Message, "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        personel.BaglantiKapat();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları doldunurunuz!", "SAS Marketler Zincirleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Girilen TC Kimlik Numarası daha önceden kayıtlıdır!!", "SAS Marketler Zincirleri", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void gnclbtn_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            if (tcnobox.MaskCompleted != false && adbox.MaskCompleted != false && soyadbox.MaskCompleted != false && telnobox.MaskCompleted != false && adresbox.Text != "" && pzsynbox.Text != "" && subebox.Text != "" && maasbox.Text != "")
            {
                try
                {
                    personel.BaglantiAc();
                    OleDbCommand guncellekomutu = new OleDbCommand("update calisanlar set ad='" + adbox.Text + "',soyad='" + soyadbox.Text + "',telefon='" + telnobox.Text + "',adres='" + adresbox.Text + "',pozisyon='" + pzsynbox.Text + "',sube='" + subebox.Text + "',maas='" + maasbox.Text + "',isegiristarih='" + dateTimePicker1.Value + "',zamorani='" + zamtbx.Text + "',yenimaas='" + yenimaastbx.Text + "'where tckimlikno='" + tcnobox.Text + "'", personel.baglan);
                    guncellekomutu.ExecuteNonQuery();
                    personel.BaglantiKapat();

                    MessageBox.Show("Kayıt Güncellendi!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CalisanlarGoster();
                    Temizle();
                }
                catch (Exception hatamsj)
                {
                    MessageBox.Show(hatamsj.Message, "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    personel.BaglantiKapat();
                }
            }
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();

            if (tcnobox.MaskCompleted == true)
            {
                bool kayitarama = false;
                personel.BaglantiAc();
                OleDbCommand aramasorgusu = new OleDbCommand("select * from calisanlar where tckimlikno='" + tcnobox.Text + "'", personel.baglan);
                OleDbDataReader kayitokuma = aramasorgusu.ExecuteReader();
                while (kayitokuma.Read())
                {
                    kayitarama = true;
                    OleDbCommand deletesorgu = new OleDbCommand("delete from calisanlar where tckimlikno='" + tcnobox.Text + "'", personel.baglan);
                    deletesorgu.ExecuteNonQuery();
                    break;
                }
                if (kayitarama == false)
                {
                    MessageBox.Show("Silinecek kayıt bulunamadı!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                personel.BaglantiKapat();
                CalisanlarGoster();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen 11 karakterli TC Kimlik No giriniz!", "SAS Marketler Zincirleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void izineklebtn_Click(object sender, EventArgs e)
        {
            if (izingunsayisibox.Text != "")
            {
                int izingunu = int.Parse(izingunsayisibox.Text);

                int kalanhak = yillikhak - izingunu;
                izinkalanbox.Text = kalanhak.ToString();

                Personel izin = new Personel();
                izin.BaglantiAc();
                OleDbCommand selectsorgu = new OleDbCommand("select * from izinler where kalanhak='" + izinkalanbox.Text + "'", izin.baglan);
                OleDbDataReader kayitokuma = selectsorgu.ExecuteReader();
                while (kayitokuma.Read())
                {
                    _ = kalanhak >= 0;
                    break;
                }
                
                int girilengun = Convert.ToInt32(izingunsayisibox.Text);
                string girilentc = izintcbox.Text;

                if (kayitokuma["tcno"].ToString() == izintcbox.Text)
                {
                        while (girilengun <= kalanhak)
                        {
                            if (kalanhak >= 0 && kalanhak <= 14)
                            {
                                if (izintcbox.Text != "" && izinadbox.Text != "" && izinsoyadbox.Text != "" && izinturbox.Text != "")
                                {
                                    try
                                    {
                                        izin.BaglantiAc();
                                        OleDbCommand eklekomutu = new OleDbCommand("insert into izinler values('" + izintcbox.Text + "','" + izinadbox.Text + "','" + izinsoyadbox.Text + "','" + izinturbox + "','" + izinbaslangic.Value + "','" + izinbitis.Value + "','" + izingunsayisibox.Text + "','" + izinkalanbox.Text + "')", izin.baglan);
                                        eklekomutu.ExecuteNonQuery();
                                        izin.BaglantiKapat();

                                        MessageBox.Show("Yeni izin oluşturuldu!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        IzinlerGoster();
                                        Temizle();
                                    }
                                    catch (Exception hatamsj)
                                    {
                                        MessageBox.Show(hatamsj.Message, "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        izin.BaglantiKapat();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Lütfen tüm alanları doldunurunuz!", "SAS Marketler Zincirleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Hakkınız kalmamıştır!!", "SAS Marketler Zincirleri", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            _ = kalanhak - girilengun;
                            break;

                        }                 
                }
                izin.BaglantiKapat();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void izinbaslangic_ValueChanged(object sender, EventArgs e)
        {

        }

        private void izinbitis_ValueChanged(object sender, EventArgs e)
        {

            if (izinbitis.Value != izinbaslangic.Value)
            {
                if (this.izinbitis.Value < this.izinbaslangic.Value)
                {
                    MessageBox.Show("İzin bitiş tarihi, izin başlangıç tarihinden önce olamaz");
                    this.izinbitis.Value = this.izinbaslangic.Value;
                    return;
                }
                else
                {
                    TimeSpan fark;
                    fark = DateTime.Parse(izinbitis.Text) - DateTime.Parse(izinbaslangic.Text);
                    izingunsayisibox.Text = fark.TotalDays.ToString();
                }
            }
            else
            {
                MessageBox.Show("İzin bitiş tarihi, izin başlangıç tarihiyle aynı olamaz!");
            }
            //  if(yillikhak-izingunsayisibox) 
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void izinkalanbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void izinsilbtn_Click(object sender, EventArgs e)
        {

            Personel izin = new Personel();
            bool kayitarama = false;
            izin.BaglantiAc();
            OleDbCommand aramasorgusu = new OleDbCommand("select * from izinler where tcno='" + izintcbox.Text + "'", izin.baglan);
            OleDbDataReader kayitokuma = aramasorgusu.ExecuteReader();
            while (kayitokuma.Read())
            {
                kayitarama = true;
                OleDbCommand deletesorgu = new OleDbCommand("delete from izinler where tcno='" + izintcbox.Text + "'", izin.baglan);
                deletesorgu.ExecuteNonQuery();
                break;
            }
            if (kayitarama == false)
            {
                MessageBox.Show("Silinecek kayıt bulunamadı!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            izin.BaglantiKapat();
            IzinlerGoster();
            Temizle();

        }
        private void izingnclbtn_Click(object sender, EventArgs e)
        {
            Personel izin = new Personel();

            try
            {
                izin.BaglantiAc();
                OleDbCommand guncellekomutu = new OleDbCommand("update izinler set tcno='" + izintcbox.Text + "',ad='" + izinadbox.Text + "',soyad='" + izinsoyadbox.Text + "',izinturu='" + izinturbox.Text + "',izinbaslangic='" + izinbaslangic.Value + "',izinbitis='" + izinbitis.Value + "',gunsayisi='" + izingunsayisibox.Text + "',kalanhak='" + izinkalanbox.Text + "'", izin.baglan);
                guncellekomutu.ExecuteNonQuery();
                izin.BaglantiKapat();

                MessageBox.Show("Kayıt Güncellendi!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                IzinlerGoster();
                Temizle();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                izin.BaglantiKapat();
            }

        }

        private void tablosıfırlabtn_Click(object sender, EventArgs e)
        {
            Personel izin = new Personel();
            bool kayitarama = false;
            izin.BaglantiAc();
            OleDbCommand aramasorgusu = new OleDbCommand("select * from izinler where izinturu='" + izinturbox.Text + "'", izin.baglan);
            OleDbDataReader kayitokuma = aramasorgusu.ExecuteReader();
            while (kayitokuma.Read())
            {
                kayitarama = true;
                OleDbCommand deletesorgu = new OleDbCommand("delete from izinler where izinturu='HAFTALIK İZİN'='" + izinturbox.Text + "'", izin.baglan);
                deletesorgu.ExecuteNonQuery();
                break;
            }
            if (kayitarama == false)
            {
                MessageBox.Show("Silinecek kayıt bulunamadı!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            izin.BaglantiKapat();
            IzinlerGoster();
            Temizle();
        }

        private void personelislemleri_Click(object sender, EventArgs e)
        {

        }

        private void zamtbx_TextChanged(object sender, EventArgs e)
        {
            Calisan calisan = new Calisan();
            calisan.BaglantiAc();
            float suanki_maas, zam_orani;
            suanki_maas = float.Parse(maasbox.Text);
            zam_orani = float.Parse(zamtbx.Text);
            yenimaastbx.Text = calisan.MaasArttir(suanki_maas, zam_orani).ToString();
            calisan.BaglantiKapat();

        }
    }
}



