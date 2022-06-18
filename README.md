## C# Yazılım Kavramları

>Compile: 
>Sadece editör de o an açık olan sayfayı derler.

 >Build:
 >En son yapılan build işleminden sonra üzerinde değişiklik yapılan tüm dosyaları derler.

>Rebuild:
>Herhangi bir durumu dikkate almaksızın projenin tamamını yeniden derler. Tüm proje yeniden derleneceğinden Build işlemine göre daha uzun sürecektir ancak build ile derleme sırasında oluşan hataları rebuild ile çözebilirsiniz.

>Clean: 
>Derleme sonrasında oluşan geçici ve kalıcı tüm dosyalar temizlenir. Bir sonraki derleme işleminde temiz bir başlangıç yapılır. Genellikle proje kodları bir başkasına gönderilmek istenildiğinde hem proje boyutunu ufaltmak hemde gereksiz dosyalardan kurtulmak adına tercih edilir.

>Deployment(Dağıtım):
>Bilgisayar bilimlerinde bu anlam “yazılımı dağıtmak, yaymak, sahaya yerleştirmek” gibi anlamlara gelir. Her yazılım sistemi kendine özgü olduğundan dolayı projelerin canlı ortama deploy edilmesi farklı aşamalar gerektirebilir

## GENEL KAVRAMLAR

>DEVOPS:
>Yazılım üreten takım ile yazılımı sunuculara yerleştiren, ayağa kaldıran, sunucuların hayatta ve sağlıklı olmasından sorumlu takım arasında yaşanan problemleri en aza indirgeyerek müşteri memnuniyetini sağlamak.

>HANGFIRE:
>Arka planda çalışacak olan bazı işler yaratıp, yürütmeyi ve yönetmeyi sağlayan açık kaynaklı bir kütüphane.

>VueJS:
>İnteraktif web arayüzleri oluşturmak ve aynı zamanda tek sayfa web uygulamaları geliştirilmiş için kullanınlan açık kaynak kodlu bir Java Script kütüphanesidir.

## GitHub

>GitHub
>Ortak Proje Yönetim Alanı.

## GitHub Kavramları:

>Working Directory: 
>Çalışma dizinini yani klasörünü ifade eder. Projenize ait dosya ve klasörleri barındıran klasördür.

>Stage Area:
>Geçiş bölgesidir. Git sisteminde projenizin kopyasını almak istediğinizde doğrudan depoya gönderilmez. Önce Stage Area adı verilen bir geçiş bölgesine gönderilir. 

>Repository: 
>Projenize ait kopyaların yani yedeklerin tutulduğu depodur. Git'in çalışma yapısına göre projenize ait almış olduğunuz kopyalar doğrudan depoya gönderilmez. Önce Stage Area adı verilen bir geçiş bölgesine   gönderilir. Daha sonra farklı bir komutla depoya eklenir.

>Add: 
>Proje klasöründe yapılan değişiklikleri Stage Area yani geçiş bölgesine ekleme işlemidir. 

>Commit: 
>Stage Area'da bulunan değişikliklerin Repository yani depoya eklenmesi işlemidir. Daha net bir ifadeyle projenize ait yedek alma işleminin gerçekleştirilmesidir. 

>Checkout: 
>Proje geliştirme sürecinde aldığımız yedekler yani sürümler arası geçiş yapma işlemi için kullanılır. Örneğin; bir Java projesi geliştiriyoruz ve "Sürüm 1", "Sürüm 2", "Sürüm 3" adında 3 tane yedeğimiz olsun. İşte bu sürümler arası geçiş yapabilmek için checkout komutu kullanılır. Belirtilen sürüme tamamiyle geçiş yapabildiğimiz gibi o sürüme ait herhangi bir dosyayı geri getirme imkânımız da bulunmaktadır. 

>Push: 
>Projenize ait değişikliklerin uzak sunucuya bildirilmesi işlemidir. Github, Gitlab gibi servisler Git ile birlikte çalışma özelliğine sahipler. Yani bilgisayarınızda oluşturduğunuz bir projeyi Git ile birlikte geliştirirseniz, push komutunu kullandığınız takdirde projenizde yer alan dosya ve klasörleri uzak sunucuya göndermiş olursunuz. 

>Branch: 
>Türkçesi dal demektir. Git sisteminin size sunduğu en büyük kolaylıklardan biri branch yani dallarla çalışabilmenizdir. Projenin ana dalı master olarak isimlendirilir. Siz master adı verilen bu ana daldan, yeni bir branch(dal) oluşturup proje geliştirmeye bu şekilde devam edebilirsiniz. Bu şekilde bir yol izlediğiniz takdirde yapacağınız işlemler master(ana dal)'ı etkilemez. Daha sonra yaptığınız değişiklikleri master ile birleştirme imkanına sahipsiniz. Bu sistem sayesinde bir projede birden fazla ekip üyesi kendi branch(dal)'larını oluşturup, projenin kendilerine düşen kısmını master'ı etkilemeyecek şekilde bitirip, en son aşamada branch ile master'ı birleştirme imkânına sahiptir. 

>Master: 
>Yukarıda da bahsettiğim gibi projenin ana dalıdır. 

>Merge: 
>Türkçe'si birleştirmek demektir. Oluşturulan bir branch ile projenin ana dalı olan Master branch'ını birleştirmeye yarar. 

>Status: 
>Projeye ait dosya ve klasörlerin mevcut durumunu listeler. Yani proje klasörü ile geçiş bölgesi ve depo arasında farklılıklar olup olmadığını size bildirir.


## KARIŞIK BİLGİLER

### DoD -> Definition of Done (DoD) Nedir?

Definition of Done (DoD) Product Backlog Item’ların (PBI) istenen kalitede teslim edilmesi için belirlenen aktiviteler listesi ve takım tarafından bir işin tamamlanmış olarak kabul edilmesi için yapılması gereken adımlardır.

Definition of Done (DoD) Product Backlog Item’ların (PBI) istenen kalitede teslim edilmesi için belirlenen aktiviteler listesi ve takım tarafından bir işin tamamlanmış olarak kabul edilmesi için yapılması gereken adımlardır. Scrum içersinde Sprint’lerdeki hedef çalışır durumda canlıya atılmaya hazır yazılım teslimatları üretmektir. Bu anlamda DoD, canlıya atılmaya hazır bitmiş yazılımı üretmek için yapılması gereken standart aksiyonları belirlemelidir.

Örneklemek gerekir ise, ihtiyaca göre standart bir DoD örneği aşağıda bulunabilir:

> DOD Adımları Kontrol

* Analiz	        Evet
* Dizayn	        Evet
* Kodlama	        Evet
* Code Review	    Evet
* Fonksiyonel Test	Evet
* KKT	            Hayır
* Dokümantasyon	    Hayır

# ŞİFRELEMELER

### Base64String Nedir? 

>İkili verileri temel 64 basamakları olarak kodlayan belirtilen dizeyi, eşdeğer 8 bitlik işaretsiz bir tamsayı dizisine dönüştürür.

### HashCode Nedir?

>HashCode , değişken uzunluklu veri kümelerini, sabit uzunluklu veri kümelerine haritalamak amacıyla kullanılan hash algoritması sonucu ortaya çıkan koddur.

## C# ile md5 şifreleme

### MD5:
>Md5 aslında bir şifreleme algoritması değildir. Tasarlanma amacı dosya ve verilerin hash’ini -parmak izini- çıkarmaktır. 
Yani siz ister tek bir kelimeyi, isterseniz de 5 gb büyüklüğünde bir veriyi md5 ile şifreleyin sonuç olarak 128 bit uzunluğunda bir değer üretilir.

>Md5 algoritması tek yönlü çalışan bir şifreleme tekniğidir. Yani şifrelenen veriye decrypt yapılarak verinin ilk haline ulaşmak mümkün değildir.

>MD5 Şifreleme Nerelerde Kullanılır?

* İnternetten indirdiğiniz bir cd/dvd imajıyla birlikte genellikle birde Md5 hash değeri verilir. Bu şekilde dosyanın sorunsuz inip inmediği kontrol edilebilir.
* İki tane verinin içeriğine bakmadan aynı olup olmadığı karşılaştırılabilir.
* Veritabanı ki şifre alanları şifrelenerek saklanabilir.
* Büyük veritabanlarında çeşitli matematiksel hesaplamalarla verinin bulunduğu konum tespit edilebilir.

### Hash ve Encrypt&Decrypt Farkı

>Hash Functionlar, Şifreleme (Encryption)’dan farklı olarak MD5, SHA1, SHA2, BSD, CHECKSUM  gibi farklı isimler ile adlandırılabilen, geri dönüşü olmayan, yani tek yönlü çıktılar veren yapılardır. Asıl amacı, ilgili datanın bir yerden bir yere taşınması değil, eşlenik bir datanın orijinali ile aynı olduğuna dair bir onayın alınmasıdır. Örneğin Passwordler başka bir yerde okunmayan, sadece doğruluğu onaylanan alanlardır. Aynı Passwordler için, aynı Hash kodunun üretilmesi gerekmektedir. Hash kodların farklı olması durumunda, yanlış password’ün girildiği anlaşılır. 

>“Hash” fonksiyonları güvenlikten ziyade, hız için yaratılmışlardır.
