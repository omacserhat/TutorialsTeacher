using System;

namespace enum2
{
	public class Program
	{
		//enum anahtar kelimesi kullanılarak doğrudan bir ad alanı sınıf veya yapı içinde tanımlanır. aşağıdaki şekilde oluştulur. 
		enum WeekDays
		{
			Monday,		//0
			Tuesday,	//1
			Wednesday,	//2
			Thursday,	//3
			Friday,		//4
			Saturday,	//5
			Sunday      //6
		}


		//değer 6 verildikten sonra değerden sonra ardışık ilerler. 
		//Her üyeye bir değer atanabilir.
	
		//	Electronics,    // 0
		//	Food,           // 1
		//	Automotive = 6, // 6
		//	Arts,           // 7
		//	BeautyCare,     // 8
		//	Fashion         // 9
	

	public static void Main()
		{
			Console.WriteLine(WeekDays.Friday);
			int day = (int)WeekDays.Friday;
			Console.WriteLine(day);

			var wd = (WeekDays)5;
			Console.WriteLine(wd);

			Console.WriteLine(WeekDays.Monday); // Monday
			Console.WriteLine(WeekDays.Tuesday); // Tuesday
			Console.WriteLine(WeekDays.Wednesday); // Wednesday
			Console.WriteLine(WeekDays.Thursday); // Thursday
			Console.WriteLine(WeekDays.Friday); // Friday
			Console.WriteLine(WeekDays.Saturday); // Saturday
			Console.WriteLine(WeekDays.Sunday); // Sunday

		}
	}
}
