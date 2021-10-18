using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//veri performansı için kullanılır. maliyeti düşürür ve performanslı 

namespace StringBuilderNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = "Serhat";
            string soyisim = "OMAÇ";
            //Console.WriteLine(isim + soyisim);
            //StringBuilder, string birleştirme operasyonlarında + operatörüne nazaran yüksek maliyeti absorbe edebilmek için arka planda StringSegment algoritmasını ve bu algoritma ile
            //bizlere ilgili değerleri olabilecek en az maliyetle birleştirip döndüren sınıftır.

            StringBuilder builder = new StringBuilder();
            builder.Append(isim);
            builder.Append(" ");
            builder.Append(soyisim);

            Console.WriteLine(builder.ToString());
            

        }
    }
}
