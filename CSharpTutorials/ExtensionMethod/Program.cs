using ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    /*
    Extension Method: Uzantı yöntemleri adından da anlaşılacağı gibi ek yöntemlerdir. 
    Uzantı yöntemleri, orijinal sınıfı, yapıyı veya arabirimi değiştirmeden, türetmeden veya yeniden derlemeden ek yöntemler eklemenize olanak tanır. 
    Uzantı yöntemleri, kendi özel sınıfınıza, .NET çerçeve sınıflarına veya üçüncü taraf sınıflarına veya arabirimlerine eklenebilir.

    Aşağıdaki örnekte, --- IsGreaterThan() --- int değişkeninin değeri sağlanan tamsayı parametresinden büyükse true değerini döndüren int türü için bir uzantı yöntemidir.

    int i = 10;

    bool result = i.IsGreaterThan(100); //returns false 


    Hatırlanacak noktalar :
    1-Uzantı yöntemleri, başlangıçta sınıfa dahil edilmeyen ek özel yöntemlerdir.
    2-Uzantı yöntemleri özel, .NET Framework veya üçüncü taraf sınıflara, yapılara veya arabirimlere eklenebilir.
    3-Uzantı yönteminin ilk parametresi, bu anahtar sözcüğünden önce, uzantı yönteminin uygulanabilir olduğu türden olmalıdır .
    4-Uzantı yöntemleri, uzantı yönteminin ad alanını dahil ederek uygulamanın herhangi bir yerinde kullanılabilir.


     */
    //Uzantı yöntemi, aslında statik bir sınıfta tanımlanan özel bir statik yöntemdir. Uzantı yöntemi tanımlamak için öncelikle statik bir sınıf tanımlayın.

    //Örneğin aşağıdaki örnekte namespace IntExtensionsaltında bir sınıf oluşturduk ExtensionMethods.
    //IntExtensions sınıfı, int veri türü için geçerli olan tüm uzantı yöntemlerini içerecektir. (Ad alanı ve sınıf için herhangi bir ad kullanabilirsiniz.)

    public static void Main()
{
        int i = 10;

        bool result = i.IsGreaterThan(100);

        Console.WriteLine("Result: {0}", result);
        Console.ReadLine();
    }
}

namespace ExtensionMethods
{
    public static class IntExtensions
    {
        //Normal bir statik yöntem ile bir uzantı yöntemi arasındaki tek fark:
        //uzantı yönteminin ilk parametresinin, işlecinin gideceği türü belirtmesi ve önünde this anahtar sözcüğü olmasıdır.
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}