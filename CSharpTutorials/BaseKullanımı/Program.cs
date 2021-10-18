using System;

namespace Base
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.GetProduct();

            Console.ReadLine();
        }
    }

    public class Product
    {
        public int Id = 75;
        private string Name = "Tişört";
        private string CategoryName = "Defacto";

        public virtual void GetProduct()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("CategoryName: {0}", CategoryName);
        }
    }
    public class Person : Product
    {
        // base anahtar sözcüğü türetilmiş bir sınıf içerisinden temel sınıfın üyelerine erişmek için kullanılır.
        //Person class'ı Product class'ını base aldıktan sonra Product class'ı base anahtar sözcüğü ile çağırarak GetProduct() metodundaki metodu kullanmıştır.
        //Böylelikle Product Class'ı Person class'ı üzerinden GetProduct() metoduna erişimi sağlanmıştır.
        int Id = 100;
        public override void GetProduct()
        {
            base.GetProduct();
            Console.WriteLine("Personel ID: {0}", Id);
        }
    }
}