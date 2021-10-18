using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListNedir
{

    /* 
    1) Girilen kayıtları sıralı olarak tutar.
    2) Her yeni eleman eklendiğinde içinde bulunduğu tabloyu yeniden sıralar.
     */

    class Program
    {
        static void Main(string[] args)
        {
            //Liste oluştur.
            SortedList<int,string> liste = new SortedList<int,string>();
            liste.Add(34, "İstanbul");
            liste.Add(01, "Adana");
            liste.Add(16, "Bursa");
            //Değerlerimizi yazdırmak için ICollection tipine atama yap.
           

            foreach (var item in liste)
            {
                Console.WriteLine("Key:{0}, Value:{1}", item.Key, item.Value);
            }
         

            Console.ReadLine();
        }


    }
}
