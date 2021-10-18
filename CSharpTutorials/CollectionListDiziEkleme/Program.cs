using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionListDiziEkleme
{
    class Program
    {

		//numbers.Remove(10); // ilk 10 sırayı kaldırır

		//numbers.RemoveAt(2); //0'dan itibaren sayarak 2. elemanı kaldırır.
        static void Main(string[] args)
        {
			IList<int> intList1 = new List<int>();
			intList1.Add(10);
			intList1.Add(20);
			intList1.Add(30);
			intList1.Add(40);

			List<int> intList2 = new List<int>();
			intList2.Add(50);
			intList2.Add(60);

			intList2.AddRange(intList1);


			Console.WriteLine(intList2.Count); // Eleman Sayısını yazdırdım.
			intList2.Sort();  // Sıraladım. (Küçükten Büyüğe)

			intList2.ForEach(item => Console.WriteLine(item));  //Ekrana yazdırmanın bir kısa yolu daha.

			foreach (var item in intList2)  //Elemanları ekrana yazdırdım
            {
				Console.WriteLine(item);
            }

			Console.ReadLine();
		}
    }
}
