using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kodun akışında belirli bir şarta göre yönlendirme yapmanızı (farklı algoritma çalıştırmamızı/ farklı operasyon gerçekleştirmemizi/ tetiklememizi) sağlayan yapılanmadır.
            //Switch Case yapılanması sadece bir değişkenin değerini sadece eşitlik durumlarını kontrol ederken kullanılabilir.
            //Sadece eşitlik durumu check edilecekse o zaman switch kullanılabilir.
            //kontrol edilen değerin türü ne ise case bloklarındada aynı türde değerler kontrol edilmelidir.

            string adi = "Serhat";
            switch (adi)
            {
                case "Sezer":
                    Console.WriteLine("Adı sezerdir.");
                    break;

                case "Serhat":
                    Console.WriteLine("Adı serhattır..");
                    break;

                case "Sezgin":
                    Console.WriteLine("Adı sezgindir.");
                    break;

                case "Fırat":
                    Console.WriteLine("Adı fırattır.");
                    break;

                default:
                    Console.WriteLine("Hiçbiri değil.");
                    break;
                    //hiçbir eşitliğe uymuyorsa default bloğu tetiklenir.

            }

            var x = 125;

            Console.Write(isOdd(x) ? "Even value" : "Odd value");

            static bool isOdd(int x)
            {
                switch (x % 2)
                {
                    case 0:
                        return true;
                    case 1:
                        return false;
                }

                return false;
            }

        }
    }
}
