using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeKonsol.Data
{
    public enum SiparisDurum   //sayılara etiket vermeye yarar.  //sayıları = ile atarsak veri tabanına kayıt olan seyler icin uyumluluk bozulmaz.
    {
        Aktif=0,
        Odendi=1,
        Iptal=2

    }
}
