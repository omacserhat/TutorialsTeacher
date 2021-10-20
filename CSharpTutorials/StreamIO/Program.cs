using System;

namespace StreamIO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             C#, dosyalar, bellek, ağ, yalıtılmış depolama vb. gibi farklı kaynaklardan okumak/yazmak için aşağıdaki standart IO (Giriş/Çıkış) sınıflarını içerir.

            Stream: System.IO.Stream , baytları (okuma, yazma vb.) kaynağa aktarmak için standart yöntemler sağlayan soyut bir sınıftır. 
            Bayt aktarmak için bir sarmalayıcı sınıf gibidir. Belirli bir kaynaktan bayt okuması/yazması gereken sınıflar, Stream sınıfını uygulamalıdır.

            Aşağıdaki sınıflar, belirli bir kaynaktan bayt Okuma/Yazma işlevselliği sağlamak için Stream sınıfını devralır:

            FileStream , bir .txt, .exe, .jpg veya başka bir dosya olsun, fiziksel bir dosyadan/dosyaya bayt okur veya yazar. FileStream, Stream sınıfından türetilmiştir.

            MemoryStream: MemoryStream, bellekte depolanan baytları okur veya yazar.

            BufferedStream: BufferedStream, belirli G/Ç işlemlerinin performansını iyileştirmek için diğer Akışlardan bayt okur veya yazar.

            NetworkStream: NetworkStream, bir ağ soketinden bayt okur veya yazar.

            PipeStream: PipeStream, farklı işlemlerden bayt okur veya yazar.

            CryptoStream: CryptoStream, veri akışlarını kriptografik dönüşümlere bağlamak içindir.


            Akış Okuyucular ve Yazarlar
            StreamReader : StreamReader, baytları kodlanmış bir değer kullanarak karakterlere dönüştürerek bir Akıştan karakterleri okumak için yardımcı bir sınıftır. FileStream, MemoryStream, vb. gibi farklı Akışlardan dizeleri (karakterleri) okumak için kullanılabilir.

            StreamWriter : StreamWriter, karakterleri baytlara dönüştürerek bir Stream'e dize yazmak için yardımcı bir sınıftır. FileStream, MemoryStream vb. gibi farklı Akışlara dizeler yazmak için kullanılabilir.

            BinaryReader : BinaryReader, baytlardan ilkel veri tipini okumak için bir yardımcı sınıftır.

            BinaryWriter : BinaryWriter ilkel türleri ikili olarak yazar.




            Hatırlanacak noktalar :
            Streamfarklı kaynaklardan bayt aktarmak için soyut bir sınıftır. Farklı kaynaklara bayt okuyan/yazan diğer tüm sınıflar için temel sınıftır.
            FileStream class, baytların fiziksel dosyaya okuma ve yazma işlevselliğini sağlar.
            Okuyucu ve yazar sınıfları, Akış sınıflarından (FileStream, MemoryStream vb.) baytları okumak için işlevsellik sağlar ve baytları uygun kodlamaya dönüştürür.
            StreamReaderbaytları dizelere dönüştürerek FileStream'den dize okumak için yardımcı bir yöntem sağlar. StreamWriter, dizeleri baytlara dönüştürerek FileStream'e dize yazmak için yardımcı bir yöntem sağlar.

             */
        }
    }
}
