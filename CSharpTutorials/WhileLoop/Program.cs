using System;

namespace WhileLoop
{
    class Program
    {
        //while parantezinin içine sadece koşulumuzu yazıyoruz.
        static void Main(string[] args)
        {
            //for (int i = 0; i < 50; i++)
            //{
            //    Console.WriteLine("Serhat");
            //}

            bool Kosul = true;
            int Sayac = 1;
            while (Kosul)
            {
                if (Sayac<=10)
                {
                    Console.WriteLine("Serhat");
                }
                else
                {
                    Kosul=false;
                }
                Sayac++;
                
            }
        }
    }
}
