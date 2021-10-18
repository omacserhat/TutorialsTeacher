using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02StaticDegiskenKullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan c1 = new Calisan();

            c1.calisanID = 1;
            c1.isim = "Serhat";
            c1.soyisim = "OMAÇ";
            Calisan.maas = 5000;

            Console.WriteLine("Id: "+ c1.calisanID);
            Console.WriteLine("İsim: "+ c1.isim);
            Console.WriteLine("Soyisim: "+ c1.soyisim);
            Console.WriteLine("Maaş: "+ Calisan.maas);

            Console.ReadLine();
        }
    }
}
