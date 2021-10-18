using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsList
{
    class Program
    {
		//CollectionList içerisine belirlediğimiz tipte değerler alır
		//Arraylist kullanırken tip kontrölü yapılırdı, bunda öyle bir şeye gerek kalmıyor.
		public static void Main()
		{
			// adding elements using add() method
			var primeNumbers = new List<int>(); // int dizisi
			primeNumbers.Add(1);
			primeNumbers.Add(3);
			primeNumbers.Add(5);
			primeNumbers.Add(7);

			Console.WriteLine("No of elelemts: " + primeNumbers.Count); //eleman sayısı

			var cities = new List<string>(); //string dizisi
			cities.Add("New York");
			cities.Add("London");
			cities.Add("Mumbai");
			cities.Add("Chicago");
			cities.Add(null); // null is allowed elamandan sayılıyor ve eleman sayısına ekleniyor.

			Console.WriteLine("No of elelemts: " + cities.Count);//eleman sayısı

			// adding elements using collection initializer syntax
			var bigCities = new List<string>() { "New York", "London", "Mumbai", "Chicago" };  //string dizi

			Console.WriteLine("No of elelemts: " + bigCities.Count); //eleman sayısı

			var students = new List<Student>() {   //student dizisi
				new Student(){ Id = 1, Name="Bill"},
				new Student(){ Id = 2, Name="Steve"},
				new Student(){ Id = 3, Name="Ram"},
				new Student(){ Id = 4, Name="Abdul"}
			};

			Console.WriteLine("No of elelemts: " + students.Count); //eleman sayısı

			Console.ReadLine();
		}
	}

	class Student  //studen dizisi için gerekli Id ve İsim özellikleri
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}

