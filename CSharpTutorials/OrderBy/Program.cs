using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ogrenciler = new List<string> { "Fatih", "Cemil", "Emine", "Dursun", "Derya", "Ali" };
            Console.WriteLine("Sıralamadan önce ");
            foreach (string ogrenci in ogrenciler)
            {
                Console.Write(ogrenci + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            List<string> artanSiralama = ogrenciler.OrderByDescending(item => item).ToList();
            List<string> azalanSiralama = ogrenciler.OrderBy(item => item).ToList();
            Console.WriteLine("Azalan sıralama (Z-A) ");
            foreach (string lr in azalanSiralama)
            {
                Console.Write(lr + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Artan Sıralama (A-Z) ");
            foreach (string lr in artanSiralama)
            {
                Console.Write(lr + " ");
            }

            Console.ReadLine();
        }
    }
}