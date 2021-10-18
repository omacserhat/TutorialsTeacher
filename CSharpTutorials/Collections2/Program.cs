using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] Sayilar = new int[25];*/ //Diziler
                                             //Eleman sayısını önceden belirtmemiz gerekir.
                                             //Elemanları atamasak dahi bellekte yeri ayrılır.
                                             //Performans açısından zayıftır.
                                             //Eleman atarken veya okurken kod maliyeti.


            //Koleksiyonlar bunların tam tersidir.
            //Diziler tek tip değer alırken, koleksiyonlar obj alır.

            //ArrayList liste = new ArrayList();
            //liste.Add("Serhat");
            //liste.Add("Hümeyra");

            //InsertRange: arrayliste koleksiyon ekleme
            //arrayliste eleman eklemek Add
            //arrayliste eleman ekleme Insert
            //Contains: öğenin olup olmadığını kontrol et true false.
            //RemoveAt(): belirtilen dizideki öğeyi arraylistten kaldırır.
            //Sort():ArrayList öğesinin tüm öğelerini sıralar.
            //Reverse: Ters çevirir sırayı
            //Clear tüm öğeleri kaldırır
            //

            //ArrayList Properties  Capacity, Count, IsFixedSize, IsReadOnly, Item


            
                // adding elements using ArrayList.Add() method
                var arlist1 = new ArrayList();
                arlist1.Add(1);
                arlist1.Add("Bill");
                arlist1.Add(" ");
                arlist1.Add(true);
                arlist1.Add(4.5);
                arlist1.Add(null);

                // adding elements using object initializer syntax
                var arlist2 = new ArrayList()
                    {
                        2, "Steve", true, 4.5, null
                    };

                var arlist3 = new ArrayList()
                {
                    500,400,300,255,125,120
                };
                Console.WriteLine("ArrayList 1 Elements");

                for (int i = 0; i < arlist1.Count; i++)
                    Console.WriteLine(arlist1[i]);

                Console.WriteLine("ArrayList 2 Elements");

                for (int i = 0; i < arlist2.Count; i++)
                    Console.WriteLine(arlist2[i]);

            arlist3.Sort();
            for (int i = 0; i < arlist3.Count; i++)
                Console.WriteLine(arlist3[i]);


            Console.ReadLine();
        }
    }
}
