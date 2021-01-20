using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace MarketOtomasyonProjesi
{
    class Sube
    {
        public OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=marketveritabani.accdb");
        public OleDbCommand sorgu = new OleDbCommand();
        public string market_id { get; set; }
        public string market_adi { get; set; }
        public string market_subesi { get; set; }
        public string market_adresi { get; set; }
        public string market_telefonu { get; set; }
        public string market_vergino { get; set; }
        public string market_vergidairesi { get; set; }
        public string market_mersisno { get; set; }


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
