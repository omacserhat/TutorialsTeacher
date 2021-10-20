using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectWhere
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 55, 64, 21, 35, 99, 28, 65, 27, 62, 100 };

            var kucuk =
                from s in sayilar
                where s < 50
                select s;

            Console.WriteLine("50 den küçük sayılar");
            foreach (var k in kucuk)
            {
                Console.WriteLine(k);
            }
            Console.ReadLine();
        }
    }
}
