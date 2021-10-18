using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHashtable
{

    /*
        Hashtable anahtar/değer çiftlerini saklar.
        Ad System.Collectionalanı altında gelir .
        Idictionary arayüzünü uygular .
        Anahtarlar benzersiz olmalıdır ve boş olamaz.
        Değerler boş veya yinelenen olabilir.
        Değerlere, dizin oluşturucuda ilişkili anahtar iletilerek erişilebilir, örn. myHashtable[key]
        Öğeler DictionaryEntry nesneleri olarak depolanır .
     */
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach (DictionaryEntry kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.WriteLine();
          
            //creating a Hashtable using collection-initializer syntax
            var cities = new Hashtable(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };

            string citiesOfUK = (string)cities["UK"]; //cast to string
            string citiesOfUSA = (string)cities["USA"]; //cast to string

            Console.WriteLine(citiesOfUK);
            Console.WriteLine(citiesOfUSA);

            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key

            if (!cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }

            Console.WriteLine("---After updating values---");

            foreach (DictionaryEntry de in cities)
                Console.WriteLine("key: {0}, Value: {1}", de.Key, de.Value);

            Console.ReadLine();
        }
    }
}
