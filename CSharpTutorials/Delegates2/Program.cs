using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Temsilci birden çok yönteme işaret edebilir.
//Birden çok yöntemi işaret eden bir temsilciye çok noktaya yayın temsilcisi denir.
//"+" veya "+=" operatörü, çağrı listesine bir işlev ekler ve "-" ve "-=" operatörü onu kaldırır.

//Toplama ve çıkarma operatörleri her zaman atamanın bir parçası olarak çalışır:
//del1 += del2; del1 = del1+del2'ye tam olarak eşdeğerdir; ve aynı şekilde çıkarma içinde geçerli.




namespace Delegates2
{
	public delegate void MyDelegate(string msg);

	public class Program
	{
		public static void Main()
		{
			MyDelegate del = ClassA.MethodA;
			del("Hello World");

			del = ClassB.MethodB;
			del("Hello World");

			del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
			del("Hello World");
			Console.ReadLine();
		}
	}

	public class ClassA
	{
		public static void MethodA(string message)
		{
			Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
		}
	}

	public class ClassB
	{
		public static void MethodB(string message)
		{
			Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
		}
	}
}