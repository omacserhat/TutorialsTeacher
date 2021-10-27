using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Serhat's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            
            var stats = book.GetStatistics();
            Console.WriteLine($"En Büyük Sayı: {stats.High}");
            Console.WriteLine($"En Küçük Sayı: {stats.Low}");
            Console.WriteLine($"Sayıların ortalaması: {stats.Average:N1}");

        }
    }
}
