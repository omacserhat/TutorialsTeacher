using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<A> m1 = new MyClass<A>();
            MyClass<D> m2 = new MyClass<D>();

        }
    }

    //Base class buradaki parametreye bir kısıtlama getirmeyi sağlar.

    class MyClass<T> where T : A  //class verirsek hepsi çalışır.
    {
        T t;

        public void X()
        {

        }
    }

    class A
    {
        
    }

    class B:A
    {
            
    }

    class C:B
    {

    }

    class D
    {

    }
}
