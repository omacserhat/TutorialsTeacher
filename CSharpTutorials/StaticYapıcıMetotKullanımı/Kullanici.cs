using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapıcıMetotKullanımı
{
    public class Kullanici
    {
        private int kullaniciID { get; set; }
        private string isim { get; set; }
        private string soyisim { get; set; }
        private static int maas { get; set; }


        static Kullanici()
        {
            maas = 4000;
        }

        public Kullanici(int kullaniciid,string isim,string soyisim)
        {
            this.kullaniciID = kullaniciid;
            this.isim = isim;
            this.soyisim= soyisim;
            

        }

        public void bilgileriGoster()
        {
            Console.WriteLine("Kullanıcı Bilgiler");
            Console.WriteLine("Id: " + kullaniciID);
            Console.WriteLine("İsim: " + isim);
            Console.WriteLine("Soyisim: " + soyisim);
            Console.WriteLine("Maaş: " + maas);

        }

        public void zamYap(int zamMiktarı)
        {
            Console.WriteLine("Kullanıcıya zam yapılıyor...");
            Console.WriteLine("Şuanki Maaş: "+(maas+zamMiktarı));
            
        }
    }
}
