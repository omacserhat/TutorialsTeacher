using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new { Id = 1, FirstName = "Serhat", LastName = "OMAÇ" };
            //Bu örnek student adlı 3 özelliği içeren anonim türde bir değişken oluşturur.
            Console.WriteLine(student.Id);
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);
            //Anonimlere böyle erişilebilir.
            //Salt okunur oldukları için özelliklerin değeri değiştirilemez.
            //student.Id = 2; 

            //Anonim bir türün özelliği, başka bir anonim türü içerebilir.
            var student2 = new
            {
                Id = 1,
                FirstName = "James",
                LastName = "Bond",
                Address = new { Id = 1, City = "London", Country = "UK" }
            };
            //Ayrıca bir dizi anonim tür de oluşturabilirsiniz.
            var student3 = new[] 
            {
            new { Id = 1, FirstName = "James", LastName = "Bond" },
            new { Id = 2, FirstName = "Steve", LastName = "Jobs" },
            new { Id = 3, FirstName = "Bill", LastName = "Gates" }
            };
        }
    }
}
