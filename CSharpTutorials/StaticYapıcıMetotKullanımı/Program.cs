using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapıcıMetotKullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanici k1 = new Kullanici(1,"Serhat","OMAÇ") ;

            k1.bilgileriGoster();
            k1.zamYap(500);

            Console.ReadLine();

        }
    }
}
