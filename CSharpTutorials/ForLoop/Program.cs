using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 ile 40 arasındaki çift sayıları toplayarak ekrana yazdıran program
            int toplamSonuc = 0;
            
            for (int i = 0; i <= 40; i++)
            {
                if (i % 2 == 0)
                {
                    
                    toplamSonuc += i;
                    
                }
              
                Console.WriteLine("Toplam Sonuç :"+ toplamSonuc);
            }

        }
    }
}
