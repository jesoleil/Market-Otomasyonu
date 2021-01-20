using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonProjesi
{
    class Calisan : Personel
    {
        public float zam_miktari { get; set; }
        
        public float MaasArttir(float maas, float zam_miktari)
        {
            return maas + (maas * (zam_miktari / 100));
           
        }
    }
}
