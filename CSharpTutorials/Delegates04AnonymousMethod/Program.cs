using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Anonim metodlar delegeler gibi bir metodun referansını tutmak yerine kod içerisinde metod varmış gibi kod bloğu yazmamızı sağlar.
Ancak anonim metodların normal metodlardan en büyük farkı kullanıldıkları kod bloğu dışarısından erişilememeleridir.


Anonim Yöntem Sınırlamaları
Git, ara veya devam et gibi atlama ifadesi içeremez.
Bir dış yöntemin ref veya out parametresine erişemez.
Güvenli olmayan koda sahip olamaz veya erişemez.
is operatörünün sol tarafında kullanılamaz.


Hatırlanacak noktalar :
Anonim yöntem, delege anahtar sözcüğü kullanılarak tanımlanabilir
Bir temsilciye anonim yöntem atanmalıdır.
Anonim yöntem, dış değişkenlere veya işlevlere erişebilir.
Anonim yöntem parametre olarak iletilebilir.
Anonim yöntem, olay işleyicileri olarak kullanılabilir.
 */

namespace Delegates04AnonymousMethod
{
    class Program
    {
        delegate void TestDelegate(string s);
        static void M(string s)
        {
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            // Normal delege ile metod'a referans
            TestDelegate testDelA = new TestDelegate(M);

            // String argüman alan ve anonim olan metod tanımı.
            // Aşağıdaki satıra dikkat edildiğinde referans edilen herhangi bir metod yoktur. 
            // Metod varmış gibi kod yazılıp daha sonra bu metoda erişim sağlanmıştır.
            TestDelegate testDelB = delegate (string s) { Console.WriteLine(s); };

            // delegeleri invoke edelim
            testDelA("Merhaba. Ben bir degeleyim ve M metoduna referans etmekteyim.");
            testDelB("Merhaba bende anonim metodum.");

            Console.WriteLine("Çıkmak için herhangi bir tuşa basınız.");
            Console.ReadKey();
        }
    }
}
