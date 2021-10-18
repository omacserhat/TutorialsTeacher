using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack<T> Özellikleri
            //Stack<T> Son Giren İlk Çıkar koleksiyonudur.
            //System.Collection.GenericAd alanı altında gelir .
            //Stack<T> belirtilen türdeki öğeleri içerebilir.Derleme zamanı tür denetimi sağlar ve genel olduğu için kutulama-kutudan çıkarma gerçekleştirmez.
            //Elemanlar Push()yöntem kullanılarak eklenebilir.Koleksiyon başlatıcı sözdizimi kullanılamaz.
            //Öğeler Pop()ve Peek()yöntemleri kullanılarak alınabilir.Bir indeksleyiciyi desteklemez.


            //Push: Yığının en üstüne bir öğe ekler.
            //Peek:	Yığından en üstteki öğeyi döndürür.
            //Pop: Yığının en üstündeki öğeleri kaldırır ve döndürür.
            //Contains: Yığında bir öğenin olup olmadığını kontrol eder.
            //Clear: Tüm öğeleri yığından kaldırır.




            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);

            while (myStack.Count > 0)
                Console.Write(myStack.Pop() + ",");

            Console.WriteLine();
            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);
            Console.ReadLine();
        }
    }
}
