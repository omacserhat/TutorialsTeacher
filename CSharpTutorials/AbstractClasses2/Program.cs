using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Abstract Class içerisinde hem ortak olan (KAYDET) hemde ortak olmayan (DEĞERLENDİR) özellikler kullanılabilir.
//Yani Kaydeti ortak olarak kullanırken değerlendiri istediğimiz gibi ayarlayabiliriz.

namespace AbstractClasses2
{
    class Program
    {
        static void Main(string[] args)
        {
            AMevzuat aMevzuat = new AMevzuat();
            aMevzuat.Degerlendir();
            aMevzuat.Kaydet();
            Console.ReadLine();
        }
    }

    abstract class MevzuatBase
    {
        public abstract void Degerlendir();

        public void Kaydet()
        {
            Console.WriteLine("Kaydedildi");
        }
    }

    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("A Mevzuatına göre değerlendirildi.");
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted");
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
