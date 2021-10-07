using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        /*
             STRUCT yapıları veri ve fonksiyon içeren yapılardır.

                     özet
            struct yapıcılar, sabitler, alanlar, yöntemler, özellikler, dizin oluşturucular, operatörler, olaylar ve iç içe türleri içerebilir.
            struct parametresiz bir kurucu veya bir yıkıcı içeremez.
            struct sınıfla aynı arabirimleri uygulayabilir.
            struct başka bir yapıyı veya sınıfı miras alamaz ve bir sınıfın temeli olamaz.
            struct üyeler soyut, mühürlü, sanal veya korumalı olarak belirtilemez.

            */

        struct Telefon // struct yapımız
        {
            public string Marka;
            public string Model;
            public int Fiyat;

        }

        static void Main(string[] args)
        {
            //instance almalıyız örneklemeliyiz.  
            //instance Bir class'tan türetilen nesnedir. Örneğin; Form1 frm = new Form1(); Burada frm nesnesi Form1 sınıfının instance 'ıdır.
            Telefon kullanTelefon;
            kullanTelefon.Marka = "Apple";
            kullanTelefon.Model = "iPhone X";
            kullanTelefon.Fiyat = 5500;

            Console.WriteLine(kullanTelefon.Marka);
            Console.WriteLine(kullanTelefon.Model);
            Console.WriteLine(kullanTelefon.Fiyat);

            Console.ReadLine();
        }
    }
}
