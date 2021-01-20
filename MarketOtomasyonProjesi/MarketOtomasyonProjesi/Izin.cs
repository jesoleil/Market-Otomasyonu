using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace MarketOtomasyonProjesi
{
    class Izin:Personel
    {
        public int haftalık_izin_hak { get; set; }
        public int yillik_izin_hak { get; set; }

        public Izin()
        {
            this.haftalık_izin_hak = 1;
            this.yillik_izin_hak = 14;
        }
        public string Izinturu
        {
            get
            {
                return izinturu;
            }
            set
            {
                izinturu = value;
            }
        }
        public int Izinbaslangic
        {
            get
            {
                return izinbaslangic;
            }
            set
            {
                izinbaslangic = value;
            }
        }
        public int Izinbitis
        {
            get
            {
                return izinbitis;
            }
            set
            {
                izinbitis = value;
            }
        }
        public string Izin_kalan_gun
        {
            get
            {
                return izin_kalan_gun;
            }
            set
            {
                izin_kalan_gun = value;
            }
        }

        public string Yillik_izin_süresi
        {
            get
            {
                return yillik_izin_süresi;
            }
            set
            {
                yillik_izin_süresi = value;
            }
        }

        public string Haftalik_izin_gunu
        {
            get
            {
                return haftalik_izin_gunu;
            }
            set
            {
                haftalik_izin_gunu = value;
            }
        }


    }
}
