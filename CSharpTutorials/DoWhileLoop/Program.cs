using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //do-while önce bir kere döngüye girer ardından şarta bakar ama mutlaka bir kere döndürür.
            bool Kosul = false;
            do
            {
                Console.WriteLine("Serhat");
            } while (Kosul);

        }
    }
}
