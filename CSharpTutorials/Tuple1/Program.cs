using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple1
{

    //Tuple kullanımı
            //Bir yöntemden ref veya out parametreleri kullanmadan birden çok değer döndürmek istediğinizde.
            //Tek bir parametre aracılığıyla bir yönteme birden çok değer iletmek istediğinizde.
            //Ayrı bir sınıf oluşturmadan bir veritabanı kaydını veya bazı değerleri geçici olarak tutmak istediğinizde.

    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, string, string> person = new Tuple<int, string, string>(1, "Steve", "Jobs");
            /*
             Yukarıdaki örnekte, Tuplebir kişinin kaydını tutan örneğini oluşturduk . 
             Her eleman için bir tip belirledik ve yapıcıya değerler ilettik. Her öğenin türünü belirtmek zahmetlidir. 
             C#, Tuple<T>aşağıda gösterildiği gibi her öğenin türünü belirtmeden örneğini döndüren statik bir yardımcı sınıf Tuple içerir .
             */
            var person1 = Tuple.Create(1, "Steve", "Jobs");
            //En fazla 8 adet eleman alır.
            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);

            //Tuple elemanlarına erişme
            Console.WriteLine(person.Item1); // returns 1

            Console.WriteLine(numbers.Rest); // returns (8)
            Console.WriteLine(numbers.Rest.Item1); // returns 8 (( Son eleman olduğu için böyle de yazılabilir)

            var numbers1 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));

            Console.WriteLine(numbers1.Rest.Item1); //returns (8, 9, 10, 11, 12, 13)
            Console.WriteLine(numbers1.Rest.Item1.Item1); //returns 8
            Console.WriteLine(numbers1.Rest.Item1.Item2); //returns 9

            //Bir yöntemin parametresi olarak kullanılabilir.
            /*
             

            static void Main(string[] args)
            {
                var person = Tuple.Create(1, "Steve", "Jobs");
                DisplayTuple(person);
            }

            static void DisplayTuple(Tuple<int, string, string> person)
            {
                Console.WriteLine($"Id = { person.Item1}");
                Console.WriteLine($"First Name = { person.Item2}");
                Console.WriteLine($"Last Name = { person.Item3}");
            }


            */


            //Dönüş türü olarak kullanılabilir.

            /*
           
                static void Main(string[] args)
            {
                var person = GetPerson();
            }

                static Tuple<int, string, string> GetPerson() 
            {
                return Tuple.Create(1, "Bill", "Gates");
            }

             */
        }
    }
}
