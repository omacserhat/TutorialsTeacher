using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Predicate, Func ve Action delegeleri gibi temsilcidir. 
Bir dizi kriter içeren bir yöntemi temsil eder ve geçirilen parametrenin bu kriterleri karşılayıp karşılamadığını kontrol eder. 
Bir yüklem temsilci yöntemleri bir giriş parametresi almalı ve bir boolean - true veya false döndürmelidir.

Yüklem temsilcisi, aşağıda gösterildiği gibi Sistem ad alanında tanımlanır:

Yüklem imzası: public delege bool Predicate<in T>(T obj);

Diğer temsilci türleriyle aynı şekilde, Predicate herhangi bir yöntemle, anonim yöntemle veya lambda ifadesiyle de kullanılabilir.

ANONİM
public static void Main()
	{
		Predicate<string> isUpper = delegate(string s) { return s.Equals(s.ToUpper());};
    	bool result = isUpper("hello world!!");
		
		Console.Write(result);
	}
LAMBDA
public static void Main()
	{
		Predicate<string> isUpper = s => s.Equals(s.ToUpper());
    	bool result = isUpper("hello world!!");
		
		Console.Write(result);
	}


 */
namespace Delegates03Predicate
{
    class Program
    {
		public static void Main()
		{
			Predicate<string> isUpper = IsUpperCase;

			bool result = isUpper("HELLO WORLD!!");

			Console.WriteLine(result);
			Console.ReadLine();
		}

		public static bool IsUpperCase(string str)
		{
			//EQUALS karşılaştırma yapıyor.
			return str.Equals(str.ToUpper());
		}
	}
}
