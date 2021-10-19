using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //try bloğu: İstisnalara neden olabilecek herhangi bir şüpheli kod bir try { }bloğun içine yerleştirilmelidir.
            //Yürütme sırasında, bir istisna oluşursa, kontrolün akışı ilk eşleşen catchbloğa atlar.

            //catch bloğu:Catch bloğu, bir istisnayı günlüğe kaydetme ve denetleme gibi bazı eylemleri gerçekleştirebileceğiniz bir istisna işleyici bloğudur.
            //Catch bloğu, bir istisnanın ayrıntılarını alabileceğiniz istisna türünde bir parametre alır.

            //finally: Bir istisna oluşturulup oluşturulmadığına bakılmaksızın, final bloğu her zaman yürütülecektir.
            //Genellikle, kaynakları serbest bırakmak için, örneğin try bloğunda açılan herhangi bir akış veya dosya nesnelerini kapatmak için bir final bloğu kullanılmalıdır.

            try
            {
                Console.WriteLine("Enter a number: ");

                var num = int.Parse(Console.ReadLine());

                Console.WriteLine("Squre of {0} is {1}", num, num * num);
            }
            catch
            {
                Console.WriteLine("Error occurred.");
            }
            finally
            {
                Console.WriteLine("Re-try with a different number.");
            }
            Console.ReadLine();

            //catch aynı istisna tipine sahip birden fazla bloğa izin verilmez. catch temel istisna türüne sahip bir blok, son blok olmalıdır.

        }

    }
}

