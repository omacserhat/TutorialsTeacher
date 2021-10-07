using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keywords
{
    class Program
    {
        static void Main(string[] args)
        {

            // Access Modifier Keywords


            //public:herkesin erişebildiği.
            //internal class oluşturulduğunda otomatik gelen.
            //private özel erişim, yalnızca aynı sınıf ve aynı yapıdaki kodlar erişebilir.
            //protected korumalı değiştirici. aynı sınıftaki veya o sınıftan türetilen bir sınıftaki kodların türe veya üyelerine erişmesine izin verir.


            //Modifier Keywords


            //ABSTRACT :Karmaşıklığı yönetmek için kullanılır. Nesnenin diğer tüm nesne türlerinden ayıran temel özelliklerini belirtir 
            //ABSTRACT : örn: telefon--> arama , mesaj atma özellikleri 

            //ASYNC : içerisinde asenkron işlem yapılacak methodu belirtir.

            //CONST :Bir değişkenin değerinin program boyunca sabit olarak tutulması istendiğinde const (sabit) ifadesinden yararlanılır.
            //Tanımlandığı satırda değeri atanmalıdır.
            //Pi sayısı, ışık hızı gibi belirli değerlere sahip veriler kullanılarak bir program yazılacaksa, const yapısını kullanmak kolaylık sağlar

            //EVENT: event anahtar kelimesi delegate anahtar kelimesi ile tanımlanan bir değişkenin
            //olay olduğunu açıkca belirtmek ve yönetmek için kullanılan anahtar kelimedir.

            //new:bir türün yeni bir örneğini oluşturmak için kullanılır.
            //new yeni bir oluşturucu olarakta kullanılır.

            //OVERRİDE: "virtual" metotlarda kullanılırlar. Override yapısı ile miras aldığı metotları ezer.
            //Mevcut metodun yerine aynı isimli olan, diğer metodu çalıştırır.

            //PARTIAL :Partial class bize bir class' ı birden fazla class olarak bölmemize, constructor, değişken, property, metodları vs. düzenli bir şekilde ayrı ayrı oluşturmamızı sağlamaktadır.
            //Fiziksel olarak birden fazla parça ile oluşan partial class' lar, çalışma zamanında tek bir class olarak bütün elemanları içerisinde barındırmaktadır.

            //ReadOnly :Readonly tanımlı değişkeni salt okunur moduna getirmektedir.
            //Yani readonly olarak tanımlanan bir değişken sadece okunabilmektedir. Setleme işlemi değişkenin oluşturulduğu anda ya da oluşturulan sınıfın constructor metodu içerisinde yapılmaktadır.

            //SEALED : Sealed, sınıfların kalıtım işlemini engellemek için kullanılan bir anahtar kelimedir.
            //Sealed anahtar kelimesi bir sınıf için uygulanacak ise kalıtımı, bir üye için uygulanacak ise üyenin override edilmesini engellemektedir.

            //STATIC : İçinde buluduğu sınıftan nesne oluşturulmadan veya hiç bir nesneye referans olmadan kullanılabilen üyeler static olarak nitelendirilir.
            //Static olarak tanımlanan bir metoda program çalıştığı sürece erişilir, böylece sadece bir metot ile birden çok nesne çağırılır.

            //UNSAFE : Değiştiriciyi unsafe bir tür veya üye bildiriminde kullanabilirsiniz. Bu nedenle türün veya üyenin metinsel kapsamının tamamı güvenli olmayan bir bağlam olarak kabul edilir.

            //VIRTUAL: Virtual, metodlara uygulanan anahtar bir sözcüktür. Ve Virtual olarak tanımladığımız metodlarımızı, diğer class larda override edebiliriz.
            //Yani, kalıtıldığı(miras alındığı) sınıfta metodun gövdesini ( süslü parantezlerin içi) değiştirebileceğimiz anlamına gelir.

            //VOLATILE:volatile sözcüğü, bir alanın aynı anda yürütülen birden çok iş parçacığı tarafından değiştiril olabileceğini belirtir.
            //Derleyici, çalışma zamanı sistemi ve hatta donanım, performans nedeniyle bellek konumlarına okuma ve yazmaları yeniden düzenleyebilir.


            //Statement Keywords


            //if else - açıklamaya gerek yok
            //switch case - açıklamaya gerek yok
            //do : Do While Döngüsü, programlarımızın tanımladığımız koşul yapısı her ne olursa olsun en az bir kere çalışmasını sağlayan ve daha sonra koşul yapısını kontrol ederek işlemini tekrarlamayı amaçlayan bir sistemdir.
            //for : C# dilinde for döngüsü çok esnek bir yapıya sahip olup, neredeyse içerisinde döngü gerektiren tüm problemler bu komutla çözülebilir.
            //foreach : for döngüsü gibi yaygın kullanılan bir diğer döngü de foreach döngüsüdür.
            //foreach, dizi (array) ve koleksiyon (collection) tabanlı nesnelerin elemanları üzerinden ilerleyen, iterasyon gerçekleştirerek bu elemanlara erişip iş katmanınızı oluşturabileceğiniz bir döngüdür.
            //in
            //WHILE : While döngüsü, belirlenen komut bloğunu koşul sağlandığı sürece çalıştıran temel döngü yapılarından bir tanesidir. Bu döngü, basit bir kullanıma sahip olması sebebiyle tercih edilir.
            //BREAK : C# programlama dillerinde çoğu programlama dilinde kullanılan break komutu kullanılmaktadır. Break komutu döngüyü kırmak için yani döngüden çıkmak için kullanılan komut'tur.
            //Break komutu belirlenen koşulda istenilen yerden döngüden çıkmak istenildiğinde için yani döngünün akışını değiştirmek için kullanılır.
            //continue : Bu komuttan sonra yazılan komutlar çalıştırılmaz. continue komutu,break komutu gibi döngülerden başka yerlerde kullanılmıyor.
            //default
            //GOTO : Go To bir metod içerisinde bir işlemi yaptıktan sonra özellikle başka bir metoda gitmesini istersek kullanabiliriz.
            //Yada bir switch case içerisinde tek değere göre birden fazla case gezdirmemiz gerekirse
            //RETURN : Bu komut sayesinde metodlardan çıkabiliyoruz.
            //YIELD : yield anahtar sözcüğü, foreach bloğuna subroutine yani altyordam muamelesi yapan, güzel bir keyworddür. yield keywordü, aşağıda verilen üç fonksiyonu eğer foreach döngüsünde kullanılacaklarsa özdeş hale getirmiştir.
            //THROW : Throw anahtar sözcüğü program çalışması sırasında özel bir durumu ifade eder. Try Catch bloğunda kullanılır. Metot içerisinde iki tam sayının bölünmesi işlemini yaparken bölen değeri sıfır olarak belirledik. Hiç bir sayı sıfıra bölünemez ve bundan dolayı hata fırlatacaktır.
            //try catch
            //FINALLY
            //CHECKED UNCHECKED
            //FIXED
            //LOCK



            //Method Parameter Keywords // Yöntem Parametre Anahtar Kelimeleri


            //params
            //ref
            //out


            //Namespace Keywords // Ad Alanı anahtar kelimeleri


            //using
            //.operator
            //::operator
            //extern alias


            //Operator Keywords // Operatör Anahtar Kelimeleri

            //as
            //await
            //is
            //new
            //sizeof
            //typeof
            //stackalloc
            //checked
            //unchecked

            //Access Keywords // Anahtar Kelimelere erişim

            //base
            //this

            //Literal Keywords // Değişmez Anahtar Kelimeler

            //null
            //false
            //true
            //value
            //void

            //Type Keywords // Anahtar Kelimeleri Yazın

            //bool
            //byte
            //char
            //class
            //decimal
            //double
            //enum
            //float
            //int
            //long
            //sbyte
            //short
            //string
            //struct
            //uint
            //ulong
            //ushort

            //Contextual Keywords // İçeriğe Dayalı Anahtar Kelimeler

            //add
            //var
            //dynamic
            //global
            //set
            //value

            //Query Keywords // ANAHTAR KELİMELERİ SORGULA

            //from
            //where
            //select
            //group
            //into
            //orderby
            //join
            //let
            //in
            //on
            //equals
            //by
            //ascending
            //descending
            //descending

        }
    }
}
