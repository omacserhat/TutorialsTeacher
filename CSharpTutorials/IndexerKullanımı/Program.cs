using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerKullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            Insan insan = new Insan();
            insan[3] = "Serhat";
            insan[5] = "Fırat";

            Console.WriteLine(insan[3]);
            Console.WriteLine(insan[5]);

            Console.Read();
        }
    }

    class Insan
    {
        string[] Isimler = new string[10];

        public string this[int i]
        {
            get
            {
                return Isimler[i];
            }
            set
            {
                Isimler[i] = value;
            }
        }
    }

    class Ornek
    {

        public string this[int index]
        {
            get
            {
                return "";
            }
            set
            {

            }
        }

    }
}
