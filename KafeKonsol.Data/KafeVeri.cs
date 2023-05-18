using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeKonsol.Data
{
   public  class KafeVeri
    {
        public int MasaAdet { get; set; } =20;

        List<Urun> Urunler { get; set; } = new();
        List<Siparis> AktifSiparisler { get; set; } = new();
        List<Siparis> GecmisSiparisler { get; set; } = new();

    }
}
