using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics

// Generic’ler tasarlandığımız interface, class, metod yada parametrelerin (argümanların) belirli bir tip için değil bir şablon yapısına uyan her tip için çalışmasını sağlayan bir yapıdır.
//Yazılım parçacıkları içerisinde tekrar kullanılabilir kod yazmamıza yardımcı olarak kod tekrarını önler.
//Kaliteli ve daha yönetilebilir kod yazmamıza olanak sağlar.
//Programcıya kod üzerinde daha güçlü esnek bir kontrol sağlar.
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("İstanbul");
            sehirler.Add("İstanbul");
            sehirler.Add("İstanbul"); 
            sehirler.Add("İstanbul");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            Console.WriteLine(sehirler2.Count);



            Console.ReadLine();
        }

        class MyList<T> //Generic Class budur.
        {

            T[] _array;
            T[] _tempArray;

            public MyList()
            {
                
                _array = new T[0];
              
            }

            public void Add(T item)
            {
                _tempArray = _array;
                _array = new T[_array.Length + 1];
                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _array[i] = _tempArray[i];
                }
                _array[_array.Length - 1] = item;
            }

            public int Count
            {
                get { return _array.Length; }
            }

        }
    }
}
