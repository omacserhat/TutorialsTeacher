using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMetotKullanımı
{
    //static kullandığımız anda yeni bir personel p = new personel oluşturmamıza gerek kalmadan Personel adıyla komutlarımızı hemen çağırabiliyoruz.
    class Program
    {
        static void Main(string[] args)
        {
            Personel.isimYazdir();

            Console.ReadLine();
        }
    }
}
