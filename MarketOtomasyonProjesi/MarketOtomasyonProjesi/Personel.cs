using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace MarketOtomasyonProjesi
{
    class Personel
    {
        public OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=marketveritabani.accdb");
        public OleDbCommand sorgu = new OleDbCommand();
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string k_adi { get; set; }
        public string sifre { get; set; }
        public string tcno { get; set; }
        public string ikamet { get; set; }
        public string yetki { get; set; }
        public string sube { get; set; }
        public int calisma_suresi { get; set; }
        public decimal maas { get; set; }
        public string izinturu { get; set; }
        public int izinbaslangic { get; set; }
        public int izinbitis { get; set; }
        public string izin_kalan_gun { get; set; }
        public string yillik_izin_süresi { get; set; }
        public string haftalik_izin_gunu { get; set; }

        public void BaglantiAc()
        {
            baglan.Close();
            baglan.Open();
            sorgu.Connection = baglan;
            sorgu.Parameters.Clear();
        }

        public void BaglantiKapat()
        {
            baglan.Close();
        }

    }
}
