using KafeKonsol.Data;
using System.Text.Json;

namespace KafeArayüz
{
    public partial class AnaForm : Form
    {

        KafeVeri db = new KafeVeri();  //kafe verideki masa sayısı kadar masa ekliyoruz

        public AnaForm()
        {
            InitializeComponent();
            //Açılırken örnek hallerini değilde son kapattıgımız kaydettiğimiz halde programın açılmasını istiyoruz.
            VerileriYuke();  //Açılırken eger kaydettiğimiz dosyayı bulamazsa örnek veri yükle yani örnek kafedeki verileri getir diyoruz.try catch içerisinde belirttik.
          
            MasalariYukle();
        }

        private void VerileriYuke()   
        {
            try
            {
                string json = File.ReadAllText("veri.json");  // bu sefer de json serialization yapılmış dosyayo nesne seklinde yani kafe veri şeklindeki db ye dönüştürmek istiyoruz.

                db = JsonSerializer.Deserialize<KafeVeri>(json)!; //kapanırken ki kayıt işleminin ters dönüşümünü yaptık.

            }
            catch (Exception)
            {

                OrnekUrunleriYukle();
            }
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
                lvi.ImageKey = db.AktifSiparisler.Any(x => x.MasaNo == i) ? "dolu" : "bos";  
                //aktif masaları tek tek tarıyor. i masa nosu ile bir siparis varsa bunu dolu(yeşil) masa yapıyor yoksa masa bos kalıyor.
                //çıkarken kaydolan verilerin programı açtıgımızda masa doluluk durumlarını güncellememizi sağlar.
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

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //form kapanırken veriler kaydedilsin istiyoruz.
            VerileriKaydet();
        }

        private void VerileriKaydet()
        {
            //Serialization yaparak verileri kapatmadan kaydedeceğiz.

            string json = JsonSerializer.Serialize(db);  //db kafe  verileridir. yani kafeveri classındaki masa adet, urunler, aktif siparisler ve geçmiş siparis bilgilerini tutan nesnedir. Biz burada nesneyi stringe çeviriyoruz. Nesneden stringe cevirmeye Serialization denir.

            File.WriteAllText("veri.json", json);   // stringe cevrileni json formatındaki stringi writealltext komutu ile dosya olarak kaydettik.
            //fakat yeni eklediğimizin de kaydolmasını istiyoruz.
       

        }
    }
}