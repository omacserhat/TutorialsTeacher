using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullType
{ //null yapılabilir türler.
    class Program
    {
        static void Main(string[] args)
        {
            //Bir değer tipine boş değer atanamaz. Örneğin, int i = null size derleme zamanı hatası verecektir.
            //Nullable<int> i = null; //Yapılabilir tür

            Nullable<int> i = null;

            if (i.HasValue)
                Console.WriteLine(i.Value); // or Console.WriteLine(i)
            else
                Console.WriteLine("Null");
            Console.ReadLine();


        }
    }
}
