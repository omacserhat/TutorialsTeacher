using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 10, j = 20;

            //if (i + 1)
            //{
            //    Console.WriteLine("i is less than j");
            //}

            //if (i + j)
            //{
            //    Console.WriteLine("i is greater than j");
            //}

            // if koşullu ifade döndürmelidir. yukarıdaki örnekte hata verir

            int i = 10, j = 20;
            //ilk ife gider i eşit değildir j doğru ise içinden devam eder doğru değilse else iner ve yazdırır.
            if (i != j)
            {
                if (i < j)
                {
                    Console.WriteLine("i is less than j");
                }
                else if (i > j)
                {
                    Console.WriteLine("i is greater than j");
                }
            }
            else
                Console.WriteLine("i is equal to j");
            Console.ReadLine();

        }
    }
}
