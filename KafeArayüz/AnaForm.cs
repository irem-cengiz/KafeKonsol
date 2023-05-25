using KafeKonsol.Data;

namespace KafeArayüz
{
    public partial class AnaForm : Form
    {

        KafeVeri db = new KafeVeri();  //kafe verideki masa sayısı kadar masa ekliyoruz

        public AnaForm()
        {
            InitializeComponent();
            OrnekUrunleriYukle();
            MasalariYukle();
        }

        private void OrnekUrunleriYukle()
        {
            db.Urunler.Add(new Urun() { UrunAd = "Kola", BirimFiyat = 20m });
            db.Urunler.Add(new Urun() { UrunAd = "Ayran", BirimFiyat = 15m });
        }

        private void MasalariYukle()
        {
            for (int i = 1; i <= db.MasaAdet; i++)
            {
                var lvi = new ListViewItem($"Masa {i}");
                lvi.Tag = i;  //tag içerisinde tek bir değer tutabiliriz.
                lvi.ImageKey = "bos";
                lvwMasalar.Items.Add(lvi);
            }
        }

        private void lvwMasalar_DoubleClick(object sender, EventArgs e)
        {

            var lviTiklanan = lvwMasalar.SelectedItems[0];
            /*MessageBox.Show(lviTiklanan.Text); */ //tıklanıp tıklanmadıgını kontrol için kulllanabiliriz.
            int masaNo = (int)lviTiklanan.Tag;
            //masa nolarını int olarak alabilmeliyim ki siparis oluşturabileyim.Tag ile bunu yaptık.

            //bu masa da suan oturan var mı?
            var siparis = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == masaNo); //aktif siparislerin defaultu null dır. burada diyoruz ki ilkini bulursan veya bulamazsan araması yapıyoruz. Aktif siparisler içerisinde masa no varsa o siparisi getir bulamazsa da null olsun.
            if (siparis == null)
            {
                lviTiklanan.ImageKey = "dolu";
                siparis = new Siparis() { MasaNo = masaNo };
                db.AktifSiparisler.Add(siparis);
            }

            //siparisform u bu siparis nesnesiyle birlikte aç.

            var frmSiparis = new SiparisForm(db, siparis);
            frmSiparis.ShowDialog();

            if (siparis.Durum != SiparisDurum.Aktif)
            {
                lviTiklanan.ImageKey = "bos";
            }

        }
        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            new GecmisSiparislerForm(db).ShowDialog();
        }

        private void tsmiUrunler_Click(object sender, EventArgs e)
        {
            new UrunlerForm(db).ShowDialog();
        }
    }
}