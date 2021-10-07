using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitlyTypedVarriable
{
    class Program
    {
        static void Main(string[] args)
        {
           // int i = 100; // açıkça yazılan değişken
           // var j = 100; // örtülü yazılan değişken sağ taraftaki değere bakılarak int olarak derlenecektir.

           // ----------------------------

           // int k = 10;
           // var l = k + 1; // int olarak derle

           // -------------------------------

            var i = 10;
            Console.WriteLine("Type of i is {0}", i.GetType());

            var str = "Hello World!!";
            Console.WriteLine("Type of str is {0}", str.GetType());

            var dbl = 100.50d;
            Console.WriteLine("Type of dbl is {0}", dbl.GetType());

            var isValid = true;
            Console.WriteLine("Type of isValid is {0}", isValid.GetType());

            var ano = new { name = "Steve" };
            Console.WriteLine("Type of ano is {0}", ano.GetType());

            var arr = new[] { 1, 10, 20, 30 };
            Console.WriteLine("Type of arr is {0}", arr.GetType());

            var file = new FileInfo("MyFile");
            Console.WriteLine("Type of file is {0}", file.GetType());
            Console.ReadLine();


            // var i;     Derleme zamanı hatası: Örtülü olarak yazılan değişkenler başlatılmalıdır
            // i = 100;


            // var i = 100, j = 200, k = 300; // Hata: tek bir ifadede var değişkenleri bildirilemez

            // Aşağıdakiler de geçerlidir
            // var i = 100;
            // var j = 200;
            // var k = 300;


            //void Display(var param) //Compile-time error  fonksiyon parametreleri için kullanılamaz.
            //{
            //    Console.Write(param);
            //}


            //for ve foreach döngülerinde kullanılabilir.
            //for(var i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //LINQ sorgularıyla da kullanılabilir.


        }
    }
}
