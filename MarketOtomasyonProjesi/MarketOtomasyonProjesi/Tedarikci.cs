using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace MarketOtomasyonProjesi
{
    class Tedarikci
    {
        public OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=marketveritabani.accdb");
        public OleDbCommand sorgu = new OleDbCommand();

        public int firma_id { get; set; }
        public string firma_ad { get; set; }
        public string firma_telefon { get; set; }
        public string firma_adres { get; set; }
        public string firma_eposta { get; set; }
        public string firma_kategori { get; set; }
        public string firma_vergino { get; set; }
        public string firma_vergi_daire { get; set; }

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
