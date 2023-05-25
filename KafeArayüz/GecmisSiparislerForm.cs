using KafeKonsol.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeArayüz
{
    public partial class GecmisSiparislerForm : Form
    {
        private readonly KafeVeri _db;
        public GecmisSiparislerForm(KafeVeri db)
        {
            _db = db;
            InitializeComponent();
            dgvSiparisler.DataSource = _db.GecmisSiparisler;   //SİPARİS PROPERTY sinde yazdıgımız özellikleri sırayla data gridwiev özelliğinden dolayı direk tablo haline getirip yazabiliyor. data source bu görevi yerine getiriyor.
        }

        private void dgvSiparisler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSiparisler.SelectedRows.Count ==0)
            {
                dgvDetaylar.DataSource = null;
            }
            else
            {
                var seciliSatir = dgvSiparisler.SelectedRows[0];   //seçili olanların ilkini secili satır olarak kaydettik.
                var siparis = (Siparis)seciliSatir.DataBoundItem;  // secili satır data bound item verilen siparisin özelliklerini tag gibi                                                                       tutmaya yarar. bu bilgileri siparise atadı.
                dgvDetaylar.DataSource = siparis.SiparisDetaylar;    //databoundıtem ile kayıt olaran siparisteki siparis özellikleri
                                                                     //siparis detayındaki özellikleri de datagridview özelliğini                                                             kullanarak tabloya aktarıyor.
            }
        }
    }
}
