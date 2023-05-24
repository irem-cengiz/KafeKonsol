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
    public partial class SiparisForm : Form
    {
        private readonly KafeVeri _db;
        private readonly Siparis _siparis;
        private readonly BindingList<SiparisDetay> _siparisDetaylar;

        public SiparisForm()
        {

        }

        public SiparisForm(KafeVeri db, Siparis siparis)
        {

            _db = db;
            _siparis = siparis;
            _siparisDetaylar = new BindingList<SiparisDetay>(_siparis.SiparisDetaylar);  //bininglist data source ı olanlarda kullanılır. combobox ,datagridwiev gibi.
            _siparisDetaylar.ListChanged += _siparisDetaylar_ListChanged; ;
            InitializeComponent();
            dgvDetaylar.AutoGenerateColumns = false;
            dgvDetaylar.DataSource = _siparisDetaylar;
            Guncelle();

        }

        private void _siparisDetaylar_ListChanged(object? sender, ListChangedEventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            Text = $"Masa {_siparis.MasaNo} (Açılış zamanı:{_siparis.AcilisZamani})";  // masalara tıkladıgımızda açılan sayfada masa numarası sayfa ismi oldu.
            lblMasaNo.Text = _siparis.MasaNo.ToString("00");  //lblmasa no labelinde 00 formatında tıkladıgımız masa no yazsın.
            lblOdemeTutari.Text = _siparis.ToplamTutarTL;
            cboUrun.DataSource = _db.Urunler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun urun = (Urun)cboUrun.SelectedItem;  //selectedıtem cinsi object bunu urune cast etmek gerekiyor.comboboxta urunler var

            if (urun == null) return;                 //eğer ürün seçiliyse o ürünün ürün ad birim fiyat adet özellikleri siparis detayımızda yazsın.

            var sd = _siparisDetaylar.FirstOrDefault(x => x.UrunAd == urun.UrunAd);

            if (sd == null)
            {
                sd = new SiparisDetay()
                {
                    UrunAd = urun.UrunAd,              //datagridwiev de bu sıra ile detayları listele metodunda listeler.
                    BirimFiyat = urun.BirimFiyat,
                    Adet = (int)nudAdet.Value
                };

                _siparisDetaylar.Add(sd);

            }
            else

            {
                sd.Adet += (int)nudAdet.Value;
                _siparisDetaylar.ResetBindings();   // bağları tekrar kur (böylelikle değişiklik oldu bilgisi ulaşacak) listchanged eventi tetikleneck.
            }


        }

        private void btnAnasayfayaDon_Click(object sender, EventArgs e)
        {
            Close();   //tıkladıgımızda sayfayı kapatıyor.
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            SiparisDurum siparisDurum = new SiparisDurum();
            siparisDurum = SiparisDurum.Odendi;
            MasayiKapat(SiparisDurum.Odendi, _siparis.ToplamTutar());
        }

        private void MasayiKapat(SiparisDurum yeniDurum, decimal odenenTutar)
        {
            _siparis.Durum = yeniDurum;
            _siparis.OdenenTutar = odenenTutar;
            _siparis.KapanisZamani = DateTime.Now;

            _db.AktifSiparisler.Remove(_siparis);
            _db.GecmisSiparisler.Add(_siparis);
            Close();

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
         
        }
    }
}
