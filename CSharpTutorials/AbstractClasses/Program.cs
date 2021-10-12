using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//C# Abstract Class, Abstract (Soyut) sınıfları kullanarak, nesne üretirken bir şablon oluşturmak istememizdir diyebiliriz.
//Yani bir sınıf üzerinde bulunan özellikleri kullanarak yeni bir sınıf türetmek istediğimiz zaman,
//içerisinde bulunan bazı temel yapıları yeniden oluşturmak için override (aşırı yükleme) işlemini uygular ve sınıf yapılarına göre özel bir hale getiririz.
//Interfaces+Virtual birleşimi diyebiliriz.

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();

            Console.ReadLine();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
