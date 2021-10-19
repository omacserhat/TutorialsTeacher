using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates3
{

    //Genel Delegeler.
    public delegate T add<T>(T param1, T param2);

    class Program
    {
            public static void Main()
            {
                add<int> sum = Sum;

                Console.WriteLine(sum(10, 20));

                add<string> conct = Concat;

                Console.WriteLine(conct("Hello", " World!!"));
            }

            public static int Sum(int val1, int val2)
            {
                return val1 + val2;
            }

            public static string Concat(string str1, string str2)
            {
                return str1 + str2;
            }
        
    }
}
/*
Temsilci, imzayı tanımlayan referans türü veri türüdür.
Temsilci türü değişkeni, temsilci ile aynı imzaya sahip herhangi bir yönteme başvurabilir.
Sözdizimi: [erişim değiştirici] temsilci [dönüş türü] [temsilci adı]([parametreler])
Hedef yöntemin imzası, temsilci imzasıyla eşleşmelidir.
Temsilciler, normal bir işlev veya Invoke() yöntemi gibi çağrılabilir.
Temsilciye "+" veya "+=" operatörü kullanılarak birden çok yöntem atanabilir ve "-" veya "-=" operatörü kullanılarak kaldırılabilir. Çok noktaya yayın temsilcisi denir.
Çok noktaya yayın temsilcisi bir değer döndürürse, son atanan hedef yöntemden değeri döndürür.
Delege, C#'da bir olay ve anonim yöntemler bildirmek için kullanılır.
 
 
 */