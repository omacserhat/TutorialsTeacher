using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Action delege türü hiçbir parametre almayan ve değer döndürmeyen metodları temsil eder. 
Adından da anlaşılacağı üzere bir fonksiyonu değil bir eylemi(action) temsil etmektedirler.
 

Anonim Değer Atanabilir:

        Action<int> printActionDel = delegate(int i)
									{
										Console.WriteLine(i);
									};

   		printActionDel(10);

Lambda ifadesi:

static void Main(string[] args)
{

    Action<int> printActionDel = i => Console.WriteLine(i);
       
    printActionDel(10);
}


    Action ve Func Delegelerinin Avantajları

    1-Temsilcileri tanımlamak kolay ve hızlı.
    2-Kodu kısaltır.
    3-Uygulama boyunca uyumlu tip.


 */


namespace Delegates02Action
{
    class Program
    {
        public delegate void Print(int val);//uzun yolu

        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            Action<int> printActionDel = ConsolePrint;// action kullanılmış kısa yolu
            printActionDel(10);//bunlar kısa yolu

            Print prnt = ConsolePrint;
            prnt(10);
            Console.ReadLine();
        }
    }
}

