using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicVeVarNedir
{
    //var derleme aşamasında --- dynamic runtime aşamasında verilen değerin türüne bürünecektir.
    //dynamic kararları runtime'a bırakır, yazarken hata vermez.
    class Program
    {
        static void Main(string[] args)
        {
            //var a = 5;
            //a int davranışı sergileyecektir.(compile süresinde/development aşamasında)
            //dynamic _a = 5;
            //b nin hala dynamic olduğu gözlemlenecektir(Development aşamasında).
            //Ne zamanki uygulama derlenip çalıştırılır, o zaman dynamic ilgili değerin türüne bürünmüş olacaktır.
            //Console.WriteLine(_a.GetType());


            //dynamic keywordü runtime'da türü belirleyecektir fakat kararlı davranmayacaktır.
            dynamic x = "Serhat";
            Console.WriteLine(x.GetType());
            x = 3.14D;
            Console.WriteLine(x.GetType());


            Console.ReadLine();
        
            //Dynamic kullanım yerleri: Herhangi bir yerden gelen datanın türü bilinmiyorsa runtime'da dynamic ile karşılanabilir.
            //uzaktan gelen veriler var keywordü ile karşılanamaz.Çünkü var keywordü tanımlandığı esnada verinin atanmasını ister.
        
        }
    }
}
