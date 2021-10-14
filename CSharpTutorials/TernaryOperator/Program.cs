using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Şarta bağlı değer döndüren bir operatördür.
            //Bir değişkene/metoda/property'e değer atarken, eğer ki bu değer şarta göre fark edecekse satır bazlı/tek satırda bu şart kontrolünü yaparak duruma göre değeri
            //döndürmemizi sağlayan kalıpsal bir operatördür.

            //Örnek   ...şart/durum... ? .....(burası true ise)..... : ......(burası false ise).......;    değer dönecektir ve tek satıra düşer işimiz if else'den daha maliyetsiz ve kullanışlı
            //Kural: Dönecek değerler aynı türde olmalıdır.


            bool medeniHal = true;
            string mesaj = medeniHal == true ?"Evlilere kampanya..":"Bekarlara kampanya.." ;
            Console.WriteLine(mesaj);


            int x = 10, y = 100;

            string result = x > y ? "x is greater than y" :
                                x < y ? "x is less than y" :
                                    x == y ? "x is equal to y" : "No result";


        }
    }
}
