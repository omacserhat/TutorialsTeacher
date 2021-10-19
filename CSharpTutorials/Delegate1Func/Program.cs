using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1Func
{
    /*
    Func tipi, bir veya birden fazla(16 haneye kadar) parametre alabilen ve geriye T tipinde değer döndüren bir delege yapısıdır.
    Bu delege sayesinde, alacağı parametreler ve geriye döndüreceği değeri simgeleyen delegemizi tanımlayabilir ve 
    o tanımladığımız yapıdaki herhangi bir metodu bu delegeye işaretletebiliriz.

    örn : Func<string,string,bool> string tipte 2 parametre alan ve bool tipinde değer döndüren bir delege tanımlanmış oluyor. 

    Delege anahtar sözcüğünü kullanarak Func temsilcisine anonim bir yöntem atayabilirsiniz.

    Func<int> getRandomNumber = delegate()
                            {
                                Random rnd = new Random();
                                return rnd.Next(1, 100);
                            };

    Lambda İfadesi ile İşlev
    Func<int> getRandomNumber = () => new Random().Next(1, 100);

    Or 

    Func<int, int, int>  Sum  = (x, y) => x + y;



    Func, yerleşik temsilci türüdür.
    Func temsilci türü bir değer döndürmelidir.
    Func temsilci türü, sıfır ila 16 giriş parametresine sahip olabilir.
    Func temsilcisi, ref ve out parametrelerine izin vermiyor.
    Func temsilci türü, anonim bir yöntem veya lambda ifadesi ile kullanılabilir.


     */
    class Program
    {
         static Func<int, int, int> operation;

          public static int Sum(int x, int y)
          {
                return x + y;
          }

          public static void Main()
          {
                Func<int, int, int> add = Sum;

                int result = add(10, 10);

                Console.WriteLine(result);

            Console.ReadLine();
          }
        
    }
}
