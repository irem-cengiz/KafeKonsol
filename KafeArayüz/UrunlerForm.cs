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
    public partial class UrunlerForm : Form
    {
        private readonly KafeVeri _db;
        BindingList<Urun> urunler;
        public UrunlerForm(KafeVeri db)
        {
            _db = db;

            urunler = new BindingList<Urun>(db.Urunler);
            InitializeComponent();

            dgvUrunler.DataSource = urunler;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string urunAdi = txtUrunAd.Text.Trim();
            if (string.IsNullOrEmpty(urunAdi))

            {
                MessageBox.Show("Ürün adı girmediniz.");
                return;
            }

            if (btnEkle.Text == "EKLE")
            {
                var urun = new Urun { UrunAd = urunAdi, BirimFiyat = nudBirimFiyat.Value };
                urunler.Add(urun);
            }
            else if (_duzenlenen != null)
            {
                _duzenlenen.UrunAd = urunAdi;
                _duzenlenen.BirimFiyat = nudBirimFiyat.Value;
                urunler.ResetBindings();
            }

            FormuSifirla();
        }

        Urun? _duzenlenen;
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen seçim yapınız.");
                return;
            }

            var satir = dgvUrunler.SelectedRows[0];
            Urun urun = (Urun)satir.DataBoundItem;
            _duzenlenen = urun;
            txtUrunAd.Text = urun.UrunAd;
            nudBirimFiyat.Value = urun.BirimFiyat;
            btnEkle.Text = "Kaydet";
            dgvUrunler.Enabled = false;
            btnIptal.Show();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuSifirla();
        }

        private void FormuSifirla()  //düzenleme moduna girince yaptıklarını geri al
        {
            btnIptal.Hide();
            btnEkle.Text = "EKLE";
            txtUrunAd.Clear();
            nudBirimFiyat.Value = 0;
            dgvUrunler.Enabled = true;
            _duzenlenen = null;

        }
    }
}
