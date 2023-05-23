using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeKonsol.Data
{
    public class SiparisDetay //üründen miras almıyoruz cünkü menu de ürün ismi değişebilir birim fiyat değişebilir.geçmişe yönelik sorgular için miras yapılmamalı.


    {
        /* public string? UrunAd { get; set; }*/   //bu hali nullable hale getiriyor. buraya null gelebilsin diyor.ürün ad olsa da olmasa da olur demek. ama bizde ürün ad olmak zorunda soru işaretli yöntemi yapamayız.

        public string UrunAd { get; set; } = null!;

        public decimal BirimFiyat { get ; set; }    
        public int Adet { get; set; }

        public string TutarTL { get{ return Tutar().ToString("c2"); } }

        public decimal Tutar()
        {
            return Adet * BirimFiyat;
        }
    }
}
