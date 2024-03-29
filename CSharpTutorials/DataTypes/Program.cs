﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Farklı veri türlerinin değişkenleri
            string stringVar = "Hello World!!";
            int intVar = 100;
            float floatVar = 10.2f;
            char charVar = 'A';
            bool boolVar = true;

            //int i = 15616511651; //error verir long olması gerek

            //byte            0 to 255
            //sbyte          -128 to 127
            //short          -32,768 to 32,767
            //ushort          0 to 65,535
            //int            -2,147,483,648 to 2,147,483,647
            //uint            0 to 4,294,967,295
            //long           -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            //ulong           0 to 18,446,744,073,709,551,615
            //float          -3.402823e38 to 3.402823e38
            //double         -1.79769313486232e308 to 1.79769313486232e308
            //decimal         (+ or -)1.0 x 10e-28 to 7.9 x 10e28
            //char             Any valid character, e.g. a,*, \x0058 (hex), or\u0058 (Unicode)
            //bool             	True or False
            //object
            //string
            //DateTime        Tarihler   -->   0:00:00am 1/1/01 to 11:59:59pm 12 / 31 / 9999

            //int   i = 345;
            //Int32 i = 345;   2side aynı anlama gelir


            //-----------------------------------------STRING KISMI-------------------------------------------


            string ch = "S";
            char harf1 = 'M';

            Console.WriteLine(ch);
            Console.WriteLine(harf1);


            char[] chars = { 'H', 'e', 'l', 'l', 'o' };

            string str1 = new string(chars);
            String str2 = new String(chars);

            foreach (char c in str1)
            {
                Console.WriteLine(c);
            }

            string text = "This is a \"string\" in C#.";
            string str = "xyzdef\\rabc";
            string path = "\\\\mypc\\ shared\\project";

            Console.WriteLine(text);
            Console.WriteLine(str);
            Console.WriteLine(path);


        
            string email = @"test@test.com";


            Console.WriteLine(email);


            //+ operatörü ile birden fazla dizi birleştirilebilir.
            string name = "Mr." + "James " + "Bond" + ", Code: 007";

            string firstName = "James";
            string lastName = "Bond";
            string code = "007";

            string agent = "Mr." + firstName + " " + lastName + ", Code: " + code;

            Console.WriteLine(name);
            Console.WriteLine(agent);


            //String Interpolation -- Dize enterpolasyonu, dizeleri birleştirmenin daha iyi bir yoludur. Dize değişkenlerini statik dizelerle birleştirmek için + işaretini kullanırız.
            //string firstName = "James";
            //string lastName = "Bond";
            //string code = "007";

            //string fullName = $"Mr. {firstName} {lastName}, Code: {code}";

            //----------------------------DATE TIME-----------------------------------------------

            //DateTime dt = new DateTime(); // varsayılan değeri atar 01/01/0001 00:00:00

            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();
            Console.WriteLine(dt1);

            //assign year, month, day
            DateTime dt2 = new DateTime(2015, 12, 31);
            Console.WriteLine(dt2);

            //assign year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
            Console.WriteLine(dt3);

            //assign year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);
            Console.WriteLine(dt4);



            DateTime currentDateTime = DateTime.Now;
            DateTime todaysDate = DateTime.Today;
            DateTime currentDateTimeUTC = DateTime.UtcNow;

            DateTime maxDateTimeValue = DateTime.MaxValue;
            DateTime minDateTimeValue = DateTime.MinValue;

            //statil alanlar : Yapı statik alanlar, özellik ve yöntemi içermektedir. Aşağıdaki örnek, önemli statik alanları ve özellikleri gösterir.

            Console.WriteLine($"Current DateTime {currentDateTime}"); //geçerli tarih ve saati döndürür
            Console.WriteLine($"Today's DateTime {todaysDate}");// bugünün tarihini döndürür
            Console.WriteLine($"Current DateTime UTC Timezone {currentDateTimeUTC}"); // geçerli UTC tarih ve saatini döndürür

            Console.WriteLine($"Max DateTime Value {maxDateTimeValue}"); //DateTime'ın maksimum değerini döndürür
            Console.WriteLine($"Min DateTime Value {minDateTimeValue}");//DateTime'ın minimum değerini döndürür


            //TimeSpan, zamanı gün, saat, dakika, saniye ve milisaniye cinsinden temsil etmek için kullanılan bir yapıdır.

            DateTime dt = new DateTime(2015, 12, 31);

            TimeSpan ts = new TimeSpan(25, 20, 55);

            DateTime newDate = dt.Add(ts);

            Console.WriteLine(newDate);//1/1/2016 1:20:55 AM

            //İki tarihin çıkarılması, TimeSpan ile sonuçlanır.
            DateTime dt10 = new DateTime(2015, 12, 31);
            DateTime dt20 = new DateTime(2016, 2, 2);
            TimeSpan result = dt20.Subtract(dt10);//33.00:00:00
            Console.WriteLine(result);



            //Yapı aşırı yükler +, -, ==, =,>, <, <=,> = operatörler tarihleri toplama, çıkarma ve karşılaştırma dışarı kolaylaştırmak için. Bunlar tarihlerle çalışmayı kolaylaştırır.

            //DateTime dt1 = new DateTime(2015, 12, 20);
            //DateTime dt2 = new DateTime(2016, 12, 31, 5, 10, 20);
            //TimeSpan time = new TimeSpan(10, 5, 25, 50);

            //Console.WriteLine(dt2 + time);
            //Console.WriteLine(dt2 - dt1);
            //Console.WriteLine(dt1 == dt2);
            //Console.WriteLine(dt1 != dt2);
            //Console.WriteLine(dt1 > dt2);
            //Console.WriteLine(dt1 < dt2);
            //Console.WriteLine(dt1 >= dt2);
            //Console.WriteLine(dt1 <= dt2);


            //geçerli bir tarih dizesi olup olmadığı

            //var str = "5/12/2020";
            //DateTime dt;

            //var isValidDate = DateTime.TryParse(str, out dt);
            //if (isValidDate)
            //    Console.WriteLine(dt);
            //else
            //    Console.WriteLine($"{str} is not a valid date string");

            Console.ReadLine();
        }
    }
}
