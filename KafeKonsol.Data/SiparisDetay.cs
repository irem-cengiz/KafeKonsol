using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeKonsol.Data
{
    public class SiparisDetay :Urun
    {
        public int Adet { get; set; }

        public string TutarTL { get; } = string.Empty;

        public decimal Tutar()
        {
            return 0;
        }
    }
}
