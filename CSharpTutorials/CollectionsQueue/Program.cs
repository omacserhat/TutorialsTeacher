using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsQueue
{
    class Program
    {
        /*
            Queue<T> FIFO (İlk Giren İlk Çıkar) koleksiyonudur.
            System.Collection.GenericAd alanı altında gelir .
            Queue<T>belirtilen türdeki öğeleri içerebilir. Derleme zamanı tür denetimi sağlar ve genel olduğu için kutulama-kutudan çıkarma gerçekleştirmez.
            Elemanlar Enqueue()yöntem kullanılarak eklenebilir . Koleksiyon başlatıcı sözdizimi kullanılamaz.
            Öğeler Dequeue()ve Peek()yöntemleri kullanılarak alınabilir . Bir indeksleyiciyi desteklemez.
         */

        /*
            Count: Kuyruktaki toplam öğe sayısını döndürür.
            Enqueue(T):Kuyruğa bir öğe ekler.
            Dequeue : Kuyruğun başından bir öğe döndürür ve onu kuyruktan kaldırır.
            Peek(T): Kuyruktan ilk öğeyi kaldırmadan döndürür.
            Contains(T): Bir öğenin kuyrukta olup olmadığını kontrol eder
            Clear():Tüm öğeleri kuyruktan kaldırır. 
         */

        static void Main(string[] args)
        {

            Queue<string> strQ = new Queue<string>();
            strQ.Enqueue("H");
            strQ.Enqueue("e");
            strQ.Enqueue("l");
            strQ.Enqueue("l");
            strQ.Enqueue("o");

            

            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5

            while (strQ.Count > 0)
                Console.WriteLine(strQ.Dequeue()); //prints Hello

            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 0



            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            Console.WriteLine(callerIds.Contains(2)); //true
            Console.WriteLine(callerIds.Contains(10)); //false


            Console.ReadLine();

        }
    }
}
