using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerKullanımı2
{

    //Indexer özel tanımlı bir property'dir ve sadece class içerisinde tanımlanabilir. Tanımlandığı class'a indexlenebilir özelliği kazandırır.
    //Array işlemlerinde kullandığımız [ ] operatörünü tanımlamış olduğumuz bir class'ı diziymiş gibi işlemler yapabilmek içinde kullanabiliriz.
    //Indexer ref ve out parametrelerine izin vermez.

    public class Program
            {
                public static void Main()
                {
                    StringDataStore strStore = new StringDataStore();

                    strStore[0] = "One";
                    strStore[1] = "Two";
                    strStore[2] = "12Three";
                    strStore[3] = "123Four";
                    strStore[4] = "O123ne";
                    strStore[5] = "Tw123o";
                    strStore[6] = "Th123ree";
                    strStore[7] = "Fo121233ur";
                    strStore[8] = "On123123e";
                    strStore[9] = "Tw123123o";
                    
                    

            for (int i = 0; i < 10; i++)
                        Console.WriteLine(strStore[i]);

                        Console.ReadLine();
                }
            }

        public class StringDataStore
        {

            private string[] strArr = new string[10]; // internal data storage

            public StringDataStore()
            {

            }

            public string this[int index]
            {

            //Indexer yapısı propertylere çok benzer.Tek fark this[] sözcüğündedir.
            //Indexerımızın parametresine gönderdiğimiz int tipindeki değer, sayilar dizisinde o değere karşılık gelen indeks numaralı elemana gidecektir.
            //Gerekli get ve set işlemini o indekste yapacaktır.Indexer’a isim vermeyiz.Bu şekilde oluşturulurlar.
            get
            {
                    if (index < 0 || index >= strArr.Length)
                        throw new IndexOutOfRangeException("Cannot store more than 10 objects");

                    return strArr[index];
                }

                set
                {
                    if (index < 0 || index >= strArr.Length)
                        throw new IndexOutOfRangeException("Cannot store more than 10 objects");

                    strArr[index] = value;
                }
            }
        }
    
}

