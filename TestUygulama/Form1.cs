
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
            string malKoduAdý = MalKoduAdýTxtBx.Text;
            string malKodu = "";

            // Önce maladý var mý yok mu kontrolü yapýlýyor. Eðer mal adý ile arama yapýlmýþ ise Else kýsmýnda mal adýna ait malKodu elde ediliyor.
            if(!_testDbContext.Stks.Any(x => x.MalAdi == malKoduAdý))
            {
                // Eðer girilen isimde bir malAdý yok ise
                // bu isimde bir malKodu var mý yok mu kontrolü yapýlýr. Eðer bu isimde bir malkodu var ise Else kýsmýnda parametre olarak gidecek malKoduna setlenir. 
                if(!_testDbContext.Stks.Any(x => x.MalKodu == malKoduAdý))
                {
                    // girilen aramaya ait maladý veya malkodu yok ise kullanýcýya hata mesajý döner ve fonksiyondan çýkar.
                    MessageBox.Show("'" + malKoduAdý + "' \n Böyle bir malAdý veya malKodu bulunmamaktadýr.");
                    return;
                }
                else
                {
                    // MalKodu procedure parametre olarak gidecek malKoduna setleniyor
                    malKodu = malKoduAdý;
                }
            }
            else
            {
                // girilen parameter bir mal adýdýr. Mal adýna ait mal kodunun elde edilmesi gerekir.
                // Çünkü procedure malKodu parametresi almakta.
                malKodu = _testDbContext.Stks.First(x => x.MalAdi == malKoduAdý).MalKodu;
            }

            int baslangicTarihYýl = BaslangicTarihi.Value.Year;
            int baslangicTarihAy = BaslangicTarihi.Value.Month;
            int baslangicTarihGun = BaslangicTarihi.Value.Day;
            int intBaslangicTarihDegeri = Convert.ToInt32((new DateTime(baslangicTarihYýl, baslangicTarihAy, baslangicTarihGun)).ToOADate());

            int bitisTarihYýl = BitisTarihi.Value.Year;
            int bitisTarihAy = BitisTarihi.Value.Month;
            int bitisTarihGun = BitisTarihi.Value.Day;
            int intBitisTarihDegeri = Convert.ToInt32((new DateTime(bitisTarihYýl, bitisTarihAy, bitisTarihGun)).ToOADate());

            // Procedure çaðýralacak (Malkodu, Baþlangýç Tarihi ve Bitiþ Tarihi) bu parametrelerle
            // Dönen liste datagirdview e setlenecek.

            var stis = _testDbContext.Stis.FromSqlInterpolated($"exec IslemleriListele @MalKodu = '{malKodu}', @BaslangicTarih = {intBaslangicTarihDegeri}, @BitisTarihi = {intBitisTarihDegeri}").ToList();


        }
    }
}