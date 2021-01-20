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
    public partial class urunlerform : Form
    {
        private float fiyat,oran,yuzdebir,yuzdemiktari,indirimlifiyati;

        public urunlerform()
        {
            InitializeComponent();
        }
        giris form1 = (giris)Application.OpenForms["giris"];
        private void GUrunGoster()
        {
            Urun urun = new Urun();
            try
            {
                urun.BaglantiAc();
                OleDbDataAdapter gidaurunlerilistele = new OleDbDataAdapter
                    ("select urunkod AS[BARKOD NUMARASI],urunad AS[ÜRÜN ADI],urunmiktar AS[TOPLAM STOK],adetfiyat AS[ADET FİYAT],bayraklısubestok AS[BAYRAKLI ŞUBE STOK],bornovasubestok AS[BORNOVA ŞUBE STOK],turgutlusubestok AS[TURGUTLU ŞUBE STOK],indirimorani AS[UYGULANAN İNDİRİM ORANI],indirimtarihi AS[İNDİRİMİN UYGULANDIĞI TARİH],indirimlifiyat AS[İNDİRİMLİ FİYATI] from gidaurunleri Order By urunad ASC", urun.baglan);
                DataSet dshafiza = new DataSet();
                gidaurunlerilistele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                urun.BaglantiKapat();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "SAS Market Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                urun.BaglantiKapat();
            }
        }
        private void TUrunGoster()
        {
            Urun urun = new Urun();
            try
            {
                urun.BaglantiAc();
                OleDbDataAdapter temizlikurunlerilistele = new OleDbDataAdapter
                    ("select urunkod AS[BARKOD NUMARASI],urunad AS[ÜRÜN ADI],urunmiktar AS[TOPLAM STOK],adetfiyat AS[ADET FİYAT],bayraklısubestok AS[BAYRAKLI ŞUBE STOK],bornovasubestok AS[BORNOVA ŞUBE STOK],turgutlusubestok AS[TURGUTLU ŞUBE STOK],indirimorani AS[UYGULANAN İNDİRİM ORANI],indirimtarihi AS[İNDİRİMİN UYGULANDIĞI TARİH],indirimlifiyat AS[İNDİRİMLİ FİYATI] from temizlikurunleri Order By urunad ASC", urun.baglan);
                DataSet dshafiza = new DataSet();
                temizlikurunlerilistele.Fill(dshafiza);
                dataGridView2.DataSource = dshafiza.Tables[0];
                urun.BaglantiKapat();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "SAS Market Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                urun.BaglantiKapat();
            }
        }
        private void KUrunGoster()
        {
            Urun urun = new Urun();
            try
            {
                urun.BaglantiAc();
                OleDbDataAdapter kampanyaurunlerilistele = new OleDbDataAdapter
                    ("select urunkod AS[BARKOD NUMARASI],urunad AS[ÜRÜN ADI],urunmiktar AS[TOPLAM STOK],adetfiyat AS[ADET FİYAT],bayraklısubestok AS[BAYRAKLI ŞUBE STOK],bornovasubestok AS[BORNOVA ŞUBE STOK],turgutlusubestok AS[TURGUTLU ŞUBE STOK],indirimorani AS[UYGULANAN İNDİRİM ORANI],indirimtarihi AS[İNDİRİMİN UYGULANDIĞI TARİH],indirimlifiyat AS[İNDİRİMLİ FİYATI] from kampanyaurunleri Order By urunad ASC", urun.baglan);
                DataSet dshafiza = new DataSet();
                kampanyaurunlerilistele.Fill(dshafiza);
                dataGridView3.DataSource = dshafiza.Tables[0];
                urun.BaglantiKapat();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "SAS Market Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                urun.BaglantiKapat();
            }
        }
        private void GTemizle()
        {
            gkategoricbox.SelectedIndex = -1;
            gkodbox.Clear();
            gadibox.Clear();
            gmiktarbox.Clear();
            gfiyatibox.Clear();
            gindirimoranibox.Clear();
            gindirimlifiyatbox.Clear();
        }
        private void TTemizle()
        {
            tkategoricbox.SelectedIndex = -1;
            tkodbox.Clear();
            tadibox.Clear();
            tmiktarbox.Clear();
            tfiyatibox.Clear();
            tindirimoranibox.Clear();
            tindirimlifiyatbox.Clear();
        }
        private void KTemizle()
        {
            kkategoricbox.SelectedIndex = -1;
            kkodbox.Clear();
            kadibox.Clear();
            kmiktarbox.Clear();
            kfiyatibox.Clear();
            kindirimoranibox.Clear();
            kindirimlifiyatbox.Clear();
        }
        private void urunlerform_Load(object sender, EventArgs e)
        {
           GUrunGoster();
           TUrunGoster();
           KUrunGoster();

            gkodbox.MaxLength = 10;
            tkodbox.MaxLength = 10;
            kkodbox.MaxLength = 10;
            gindirimoranibox.MaxLength = 3;
            tindirimoranibox.MaxLength = 3;
            kindirimoranibox.MaxLength = 3;

            gadibox.CharacterCasing = CharacterCasing.Upper;
            tadibox.CharacterCasing = CharacterCasing.Upper;
            kadibox.CharacterCasing = CharacterCasing.Upper;

            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            if(form1.yetki=="MÜDÜR")
            {
                tabControl1.Controls.Remove(gidaurunleri);
                tabControl1.Controls.Remove(temizlikurunleri);
                
            }
        }
        private void gkodbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void tkodbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void kkodbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void gadibox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void tadibox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void kadibox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void gmiktarbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void tmiktarbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void kmiktarbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void gfiyatibox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void tfiyatibox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void kfiyatibox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void gindirimoranibox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void tindirimoranibox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void kindirimoranibox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void gkodbox_TextChanged(object sender, EventArgs e)
        {
            if (gkodbox.Text.Length < 10)
                errorProvider1.SetError(gkodbox, "Barkod no 10 Karakter olmalıdır!");
            else
                errorProvider1.Clear();
        }
        private void tkodbox_TextChanged(object sender, EventArgs e)
        {
            if (tkodbox.Text.Length < 10)
                errorProvider1.SetError(tkodbox, "Barkod no 10 Karakter olmalıdır!");
            else
                errorProvider1.Clear();
        }
        private void kkodbox_TextChanged(object sender, EventArgs e)
        {
            if (kkodbox.Text.Length < 10)
                errorProvider1.SetError(kkodbox, "Barkod no 10 Karakter olmalıdır!");
            else
                errorProvider1.Clear();
        }
        private void gidaurunleri_Click(object sender, EventArgs e)
        {

        }
        private void gkydtbtn_Click(object sender, EventArgs e)
        {
            bool gkayitkontrol = false;
            Urun urun = new Urun();
            urun.BaglantiAc();
            OleDbCommand gselectsorgu = new OleDbCommand("select * from gidaurunleri where urunkod='" + gkodbox.Text + "'", urun.baglan);
            OleDbDataReader gkayitokuma = gselectsorgu.ExecuteReader();
            while (gkayitokuma.Read())
            {
                gkayitkontrol = true;
                break;
            }
            urun.BaglantiKapat();

            if (gkayitkontrol == false)
            {
                if (gkodbox.Text.Length < 10 || gkodbox.Text == "")
                    ukod.ForeColor = Color.Red;
                else
                    ukod.ForeColor = Color.Black;

                if (gfiyatibox.Text.Length < 1 || gfiyatibox.Text == "")
                    ufiyati.ForeColor = Color.Red;
                else
                    ufiyati.ForeColor = Color.Black;
                try
                {
                    urun.BaglantiAc();
                    OleDbCommand geklekomutu = new OleDbCommand("insert into gidaurunleri values('" + gkodbox.Text + "','" + gadibox.Text + "','" + gmiktarbox.Text + "','" + gbyrklstkbox.Text + "','" + gbrnvstkbox.Text + "','" + gtrgtlstkbox.Text + "','" + gfiyatibox.Text + "','" + gindirimoranibox.Text + "','" + dateTimePicker1.Value + "','" + gindirimlifiyatbox.Text + "')", urun.baglan);
                    geklekomutu.ExecuteNonQuery();
                    urun.BaglantiKapat();

                    MessageBox.Show("Yeni kayıt oluşturuldu!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    GUrunGoster();
                    GTemizle();
                }
                catch (Exception hatamsj)
                {
                    MessageBox.Show(hatamsj.Message, "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    urun.BaglantiKapat();
                }
            }
            else
            {
                MessageBox.Show("Girilen barkod numarası daha önceden kayıtlıdır!!", "SAS Marketler Zincirleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tkydtbtn_Click(object sender, EventArgs e)
        {
            bool tkayitkontrol = false;
            Urun urun = new Urun();
            urun.BaglantiAc();
            OleDbCommand tselectsorgu = new OleDbCommand("select * from temizlikurunleri where urunkod='" + tkodbox.Text + "'", urun.baglan);
            OleDbDataReader tkayitokuma = tselectsorgu.ExecuteReader();
            while (tkayitokuma.Read())
            {
                tkayitkontrol = true;
                break;
            }
            urun.BaglantiKapat();

            if (tkayitkontrol == false)
            {
                if (tkodbox.Text.Length < 10 || tkodbox.Text == "")
                    tkod.ForeColor = Color.Red;
                else
                    tkod.ForeColor = Color.Black;

                if (tfiyatibox.Text.Length < 1 || tfiyatibox.Text == "")
                    tfiyati.ForeColor = Color.Red;
                else
                    tfiyati.ForeColor = Color.Black;
                try
                {
                    urun.BaglantiAc();
                    OleDbCommand teklekomutu = new OleDbCommand("insert into temizlikurunleri values('" + tkodbox.Text + "','" + tadibox.Text + "','" + tmiktarbox.Text + "','" + tbyrkstkbox.Text + "','" + tbrnvstkbox.Text + "','" + ttrgtlstkbox.Text + "','" + tfiyatibox.Text + "','" + tindirimoranibox.Text + "','" + dateTimePicker2.Value + "','" + tindirimlifiyatbox.Text + "')", urun.baglan);
                    teklekomutu.ExecuteNonQuery();
                    urun.BaglantiKapat();

                    MessageBox.Show("Yeni kayıt oluşturuldu!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TUrunGoster();
                    TTemizle();
                }
                catch (Exception hatamsj)
                {
                    MessageBox.Show(hatamsj.Message, "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    urun.BaglantiKapat();
                }
            }
            else
            {
                MessageBox.Show("Girilen barkod numarası daha önceden kayıtlıdır!!", "SAS Marketler Zincirleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void kkydtbtn_Click(object sender, EventArgs e)
        {
            bool kkayitkontrol = false;
            Urun urun = new Urun();
            urun.BaglantiAc();
            OleDbCommand kselectsorgu = new OleDbCommand("select * from kampanyaurunleri where urunkod='" + kkodbox.Text + "'", urun.baglan);
            OleDbDataReader kkayitokuma = kselectsorgu.ExecuteReader();
            while (kkayitokuma.Read())
            {
                kkayitkontrol = true;
                break;
            }
            urun.BaglantiKapat();

            if (kkayitkontrol == false)
            {
                if (kkodbox.Text.Length < 10 || kkodbox.Text == "")
                    kkod.ForeColor = Color.Red;
                else
                    kkod.ForeColor = Color.Black;

                if (kfiyatibox.Text.Length < 1 || kfiyatibox.Text == "")
                    kfiyat.ForeColor = Color.Red;
                else
                    kfiyat.ForeColor = Color.Black;
                try
                {
                    urun.BaglantiAc();
                    OleDbCommand keklekomutu = new OleDbCommand("insert into kampanyaurunleri values('" + kkodbox.Text + "','" + kadibox.Text + "','" + kmiktarbox.Text + "','" + kbyrkstkbox.Text + "','" + kbrnvstkbox.Text + "','" + ktrgtlstkbox.Text + "','" + kfiyatibox.Text + "','" + kindirimoranibox.Text + "','" + dateTimePicker3.Value + "','" + kindirimlifiyatbox.Text + "')", urun.baglan);
                    keklekomutu.ExecuteNonQuery();
                    urun.BaglantiKapat();

                    MessageBox.Show("Yeni kayıt oluşturuldu!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    KUrunGoster();
                    KTemizle();
                }
                catch (Exception hatamsj)
                {
                    MessageBox.Show(hatamsj.Message, "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    urun.BaglantiKapat();
                }
            }
            else
            {
                MessageBox.Show("Girilen barkod numarası daha önceden kayıtlıdır!!", "SAS Marketler Zincirleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tsilbtn_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();

            bool tkayitarama = false;
            urun.BaglantiAc();
            OleDbCommand taramasorgusu = new OleDbCommand("select * from temizlikurunleri where urunkod='" + tkodbox.Text + "'", urun.baglan);
            OleDbDataReader tkayitokuma = taramasorgusu.ExecuteReader();
            while (tkayitokuma.Read())
            {
                tkayitarama = true;
                OleDbCommand deletesorgu = new OleDbCommand("delete from temizlikurunleri where urunkod='" + tkodbox.Text + "'", urun.baglan);
                deletesorgu.ExecuteNonQuery();
                break;
            }
            if (tkayitarama == false)
            {
                MessageBox.Show("Silinecek kayıt bulunamadı!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            urun.BaglantiKapat();
            TUrunGoster();
            TTemizle();
        }
        private void ksilbtn_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();

            bool kkayitarama = false;
            urun.BaglantiAc();
            OleDbCommand karamasorgusu = new OleDbCommand("select * from kampanyaurunleri where urunkod='" + kkodbox.Text + "'", urun.baglan);
            OleDbDataReader kkayitokuma = karamasorgusu.ExecuteReader();
            while (kkayitokuma.Read())
            {
                kkayitarama = true;
                OleDbCommand deletesorgu = new OleDbCommand("delete from kampanyaurunleri where urunkod='" + kkodbox.Text + "'", urun.baglan);
                deletesorgu.ExecuteNonQuery();
                break;
            }
            if (kkayitarama == false)
            {
                MessageBox.Show("Silinecek kayıt bulunamadı!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            urun.BaglantiKapat();
            KUrunGoster();
            KTemizle();
        }
        private void gsilbtn_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();

            bool gkayitarama = false;
            urun.BaglantiAc();
            OleDbCommand garamasorgusu = new OleDbCommand("select * from gidaurunleri where urunkod='" + gkodbox.Text + "'", urun.baglan);
            OleDbDataReader gkayitokuma = garamasorgusu.ExecuteReader();
            while (gkayitokuma.Read())
            {
                gkayitarama = true;
                OleDbCommand deletesorgu = new OleDbCommand("delete from gidaurunleri where urunkod='" + gkodbox.Text + "'", urun.baglan);
                deletesorgu.ExecuteNonQuery();
                break;
            }
            if (gkayitarama == false)
            {
                MessageBox.Show("Silinecek kayıt bulunamadı!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            urun.BaglantiKapat();
            GUrunGoster();
            GTemizle();
        }
        private void ktmzlbtn_Click(object sender, EventArgs e)
        {
            KTemizle();
        }
        private void ttmzlbtn_Click(object sender, EventArgs e)
        {
            TTemizle();
        }
        private void tgnclbtn_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            try
            {
                urun.BaglantiAc();
                OleDbCommand tguncellekomutu = new OleDbCommand("update temizlikurunleri set urunkod='" + tkodbox.Text + "',urunad='" + tadibox.Text + "',urunmiktar='" + tmiktarbox.Text + "',adetfiyat='" + tfiyatibox.Text + "',bayraklısubestok='" + tbyrkstkbox.Text + "',bornovasubestok='" + tbrnvstkbox.Text + "',turgutlusubestok='" + ttrgtlstkbox.Text + "',indirimorani='" + tindirimoranibox.Text + "',indirimtarihi='" + dateTimePicker2.Value + "', indirimlifiyat = '" + tindirimlifiyatbox.Text + "'where urunkod='" + tkodbox.Text + "'", urun.baglan);
                tguncellekomutu.ExecuteNonQuery();
                urun.BaglantiKapat();

                MessageBox.Show("Kayıt Güncellendi!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TUrunGoster();
                TTemizle();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                urun.BaglantiKapat();
            }
        }
        private void kgnclbtn_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            try
            {
                urun.BaglantiAc();
                OleDbCommand kguncellekomutu = new OleDbCommand("update kampanyaurunleri set urunkod='" + kkodbox.Text + "',urunad='" + kadibox.Text + "',urunmiktar='" + kmiktarbox.Text + "',adetfiyat='" + kfiyatibox.Text + "',bayraklısubestok='" + kbyrkstkbox.Text + "',bornovasubestok='" + kbrnvstkbox.Text + "',turgutlusubestok='" + ktrgtlstkbox.Text + "',indirimorani='" + kindirimoranibox.Text + "',indirimtarihi='" + dateTimePicker3.Value + "', indirimlifiyat = '" + kindirimlifiyatbox.Text + "'where urunkod='" + kkodbox.Text + "'", urun.baglan);
                kguncellekomutu.ExecuteNonQuery();
                urun.BaglantiKapat();

                MessageBox.Show("Kayıt Güncellendi!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                KUrunGoster();
                KTemizle();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                urun.BaglantiKapat();
            }
        }
        private void gtmzlbtn_Click(object sender, EventArgs e)
        {
            GTemizle();
        }

        private void kampanyaurunleri_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void ggnclbtn_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            try
            {
                urun.BaglantiAc();
                OleDbCommand gguncellekomutu = new OleDbCommand("update gidaurunleri set urunkod='" + gkodbox.Text + "',urunad='" + gadibox.Text + "',urunmiktar='" + gmiktarbox.Text + "',adetfiyat='" + gfiyatibox.Text + "',bayraklısubestok='" + gbyrklstkbox.Text + "',bornovasubestok='" + gbrnvstkbox.Text + "',turgutlusubestok='" + gtrgtlstkbox.Text + "',indirimorani='" + gindirimoranibox.Text + "',indirimtarihi='" + dateTimePicker1.Value +"', indirimlifiyat = '" + gindirimlifiyatbox.Text +  "'where urunkod='" + gkodbox.Text + "'", urun.baglan);
                gguncellekomutu.ExecuteNonQuery();
                urun.BaglantiKapat();

                MessageBox.Show("Kayıt Güncellendi!", "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                GUrunGoster();
                GTemizle();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "SAS Marketler Zinciri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                urun.BaglantiKapat();
            }
        }
        private void kindirimhesaplabtn_Click(object sender, EventArgs e)
        {
            fiyat = Convert.ToInt32(kfiyatibox.Text);
            oran = Convert.ToInt32(kindirimoranibox.Text);

            yuzdebir = fiyat / 100;
            yuzdemiktari = yuzdebir * oran;
            indirimlifiyati = fiyat - yuzdemiktari;
            kindirimlifiyatbox.Text = indirimlifiyati.ToString();
        }
        private void tindirimhesaplabtn_Click(object sender, EventArgs e)
        {
            fiyat = Convert.ToInt32(tfiyatibox.Text);
            oran = Convert.ToInt32(tindirimoranibox.Text);

            yuzdebir = fiyat / 100;
            yuzdemiktari = yuzdebir * oran;
            indirimlifiyati = fiyat - yuzdemiktari;
            tindirimlifiyatbox.Text = indirimlifiyati.ToString();
        }
        private void gindirimhesaplabtn_Click(object sender, EventArgs e)
        {
            fiyat = Convert.ToInt32(gfiyatibox.Text);
            oran = Convert.ToInt32(gindirimoranibox.Text);

            yuzdebir = fiyat / 100;
            yuzdemiktari = yuzdebir * oran;
            indirimlifiyati = fiyat - yuzdemiktari;
            gindirimlifiyatbox.Text = indirimlifiyati.ToString();
        }
    }
}