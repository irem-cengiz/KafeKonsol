using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeKonsol.Data
{
    public class Siparis
    {
        public int MasaNo { get; set; }

        public SiparisDurum Durum { get; set; }
        public decimal OdenenTutar { get; set; }

        public DateTime AcilisZamani { get; set; } = DateTime.Now;

        public DateTime? KapanisZamani { get; set; } //nullable olmalı cünkü masaya oturan müsterilerin kapanıs zamanı belirli değil.

        public List<SiparisDetay> SiparisDetaylar { get; set; } = new List<SiparisDetay>(); // new() kullanılabilir. 


        public string ToplamTutarTL { get { return ToplamTutar().ToString("c2"); } }

        //diğer bir gösterimi oklu yöntem.
        //public string ToplamTutarTl=> ToplamTutar().ToString("c2");

        public decimal ToplamTutar()
        {
            return SiparisDetaylar.Sum(x=>x.Tutar());
        }

        //diğer gösterim sekli:
        //public decimal ToplamTutar()=> SiparisDetaylar.Sum(x=>x.Tutar());
    }
}
