using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace MarketOtomasyonProjesi
{
    class Urun
    {
        public OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=marketveritabani.accdb");
        public OleDbCommand sorgu = new OleDbCommand();

        public string urunad { get; set; }
        public string urunkod { get; set; }
        public string adet_fiyat { get; set; }
        public string urun_kategori { get; set; }
        public string urun_miktar { get; set; }
        public string indirimli_fiyat { get; set; }
        public string temizlik_urunu { get; set; }
        public string gida_urunu { get; set; }
        public string kampanya_urunu { get; set; }
        public decimal tu_fiyati { get; set; }
        public decimal gu_fiyati { get; set; }
        public decimal ku_fiyati { get; set; }
        public int tu_miktari { get; set; }
        public int gu_miktari { get; set; }
        public int ku_miktari { get; set; }

        private string yuzde_indirim { get; set; }
        public string Yuzde_indirim
        {
            get { return yuzde_indirim; }
            set { yuzde_indirim = value; }
        }

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