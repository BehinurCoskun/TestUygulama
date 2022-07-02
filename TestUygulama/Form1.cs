
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using TestUygulama.Models;

namespace TestUygulama
{
    public partial class Form1 : Form
    {
        private TestContext _testDbContext;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _testDbContext = new TestContext();
        }

        private void ListeleButton_Click(object sender, EventArgs e)
        {
            string malKoduAd� = MalKoduAd�TxtBx.Text;
            string malKodu = "";

            // �nce malad� var m� yok mu kontrol� yap�l�yor. E�er mal ad� ile arama yap�lm�� ise Else k�sm�nda mal ad�na ait malKodu elde ediliyor.
            if(!_testDbContext.Stks.Any(x => x.MalAdi == malKoduAd�))
            {
                // E�er girilen isimde bir malAd� yok ise
                // bu isimde bir malKodu var m� yok mu kontrol� yap�l�r. E�er bu isimde bir malkodu var ise Else k�sm�nda parametre olarak gidecek malKoduna setlenir. 
                if(!_testDbContext.Stks.Any(x => x.MalKodu == malKoduAd�))
                {
                    // girilen aramaya ait malad� veya malkodu yok ise kullan�c�ya hata mesaj� d�ner ve fonksiyondan ��kar.
                    MessageBox.Show("'" + malKoduAd� + "' \n B�yle bir malAd� veya malKodu bulunmamaktad�r.");
                    return;
                }
                else
                {
                    // MalKodu procedure parametre olarak gidecek malKoduna setleniyor
                    malKodu = malKoduAd�;
                }
            }
            else
            {
                // girilen parameter bir mal ad�d�r. Mal ad�na ait mal kodunun elde edilmesi gerekir.
                // ��nk� procedure malKodu parametresi almakta.
                malKodu = _testDbContext.Stks.First(x => x.MalAdi == malKoduAd�).MalKodu;
            }

            int baslangicTarihY�l = BaslangicTarihi.Value.Year;
            int baslangicTarihAy = BaslangicTarihi.Value.Month;
            int baslangicTarihGun = BaslangicTarihi.Value.Day;
            int intBaslangicTarihDegeri = Convert.ToInt32((new DateTime(baslangicTarihY�l, baslangicTarihAy, baslangicTarihGun)).ToOADate());

            int bitisTarihY�l = BitisTarihi.Value.Year;
            int bitisTarihAy = BitisTarihi.Value.Month;
            int bitisTarihGun = BitisTarihi.Value.Day;
            int intBitisTarihDegeri = Convert.ToInt32((new DateTime(bitisTarihY�l, bitisTarihAy, bitisTarihGun)).ToOADate());

            // Procedure �a��ralacak (Malkodu, Ba�lang�� Tarihi ve Biti� Tarihi) bu parametrelerle
            // D�nen liste datagirdview e setlenecek.

            var stis = _testDbContext.Stis.FromSqlInterpolated($"exec IslemleriListele @MalKodu = '{malKodu}', @BaslangicTarih = {intBaslangicTarihDegeri}, @BitisTarihi = {intBitisTarihDegeri}").ToList();


        }
    }
}