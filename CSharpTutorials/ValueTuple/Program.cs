using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTuple
{
    class Program
    {
        //ValueTuple 8den fazla eleman içerebilir.
        static void Main(string[] args)
        {
            ValueTuple<int, string, string> person1 = (1, "Bill", "Gates");
            Console.WriteLine(person1.Item1); // returns 1
            Console.WriteLine(person1.Item2); // returns "Bill"
            Console.WriteLine(person1.Item3); // returns "Gates"

            (int, string, string) person2 = (1, "James", "Bond");
            Console.WriteLine(person2.Item1); // returns 1
            Console.WriteLine(person2.Item2); // returns "James"
            Console.WriteLine(person2.Item3); // returns "Bond"

            //Item1, Item2 vb. gibi varsayılan özellik isimlerine sahip olmak yerine özelliklere isimler atayabiliriz.
            (int Id, string FirstName, string LastName) person3 = (1, "Bill", "Gates");
            Console.WriteLine(person3.Id); // returns 1
            Console.WriteLine(person3.FirstName); // returns "Bill"
            Console.WriteLine(person3.LastName); // returns "Gates"

            //Ayrıca sağ taraftaki üye isimlerini aşağıdaki gibi değerlerle atayabiliriz.
            var person = (Id: 1, FirstName: "Bill", LastName: "Gates");

            /* Parametre olarak ValueTuple
             static void Main(string[] args)
	        {
		    DisplayTuple((1, "Bill", "Gates"));
	        }

	        static void DisplayTuple((int, string, string) person)
	        {
	        Console.WriteLine("{0}, {1}, {2}", person.Item1, person.Item2, person.Item3);
	        }


            Yöntemden döndürülen bir üye için üye adları belirleyebilirsiniz.

            static void Main(string[] args)
            {
            var person = GetPerson();
            Console.WriteLine("{0}, {1}, {2}", person.Id, person.FirstName, person.LastName);
            }

            static (int Id, string FirstName, string LastName) GetPerson() 
            {
            return (Id:1, FirstName: "Bill", LastName: "Gates");
            }




            Deconstruction

                static void Main(string[] args)
	        {
		        (int Id, string FirstName, string LastName)  = GetPerson();
		        Console.WriteLine("{0},{1}, {2}", Id, FirstName, LastName);
		
		        (var PersonId, var FName, var LName) = GetPerson(); // using var
		        Console.WriteLine("{0},{1}, {2}", PersonId, FName, LName);
		
	        	(var PId, var Name, _) = GetPerson(); //discard other members   ((Burada bir _ var o bütün elemanları getirirken last name i getirme komutu oluyor.)
	        	Console.WriteLine("{0},{1}", PId, Name);
	         }

	            static (int, string, string) GetPerson()
	        {
		        return (Id: 1, FirstName: "Bill", LastName: "Gates");
	        }








             */




            Console.ReadLine();
        }
    }
}
