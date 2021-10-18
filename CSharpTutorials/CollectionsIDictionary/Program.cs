using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsIDictionary
{
    class Program
    {
		/*
				Sözlük Özellikleri
		Dictionary<TKey, TValue> anahtar/değer çiftlerini saklar.
		Ad System.Collections.Genericalanı altında gelir .
		IDictionary<TKey, TValue> arabirimini uygular .
		Anahtarlar benzersiz olmalıdır ve boş olamaz.
		Değerler boş veya yinelenen olabilir.
		Değerlere, dizin oluşturucuda ilişkili anahtar iletilerek erişilebilir, örn. myDictionary[key]
		Öğeler, KeyValuePair<TKey, TValue> nesneleri olarak depolanır .
		 */

		public static void Main()
		{
			IDictionary<int, string> numberNames = new Dictionary<int, string>();
			numberNames.Add(1, "One"); //Add() yöntemini kullanarak anahtar/değer ekleme
			numberNames.Add(3, "Three");
			numberNames.Add(2, "Two");

			foreach (KeyValuePair<int, string> kvp in numberNames)
				Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

			//koleksiyon başlatıcı sözdizimini kullanarak bir sözlük oluşturma
			var cities = new Dictionary<string, string>(){
			{"UK","London, Manchester, Birmingham"},
			{"USA","Chicago, New York, Washington"},
			{"India","Mumbai, New Delhi, Pune"}
		};

			foreach (var kvp in cities)
				Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
			Console.ReadLine();
		}
	}
}
