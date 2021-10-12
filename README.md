# OGRENDIKLERIM
## COGUNLUKLA C# VE YAZILIMCI KAVRAMLARI ICERMEKTEDIR.


## C# Yazýlým Kavramlarý

>Compile: 
>Sadece editör de o an açýk olan sayfayý derler.

*Build:En son yapýlan build iþleminden sonra üzerinde deðiþiklik yapýlan tüm dosyalarý derler.

*Rebuild:Herhangi bir durumu dikkate almaksýzýn projenin tamamýný yeniden derler. Tüm proje yeniden derleneceðinden Build iþlemine göre daha uzun sürecektir ancak build ile derleme sýrasýnda oluþan hatalarý rebuild ile çözebilirsiniz.

*Clean:Derleme sonrasýnda oluþan geçici ve kalýcý tüm dosyalar temizlenir. Bir sonraki derleme iþleminde temiz bir baþlangýç yapýlýr. Genellikle proje kodlarý bir baþkasýna gönderilmek istenildiðinde hem proje boyutunu ufaltmak hemde gereksiz dosyalardan kurtulmak adýna tercih edilir.

>Deployment(Daðýtým):
>Bilgisayar bilimlerinde bu anlam “yazýlýmý daðýtmak, yaymak, sahaya yerleþtirmek” gibi anlamlara gelir. Her yazýlým sistemi kendine özgü olduðundan dolayý projelerin canlý ortama deploy edilmesi farklý aþamalar gerektirebilir.

## GENEL KAVRAMLAR

>DEVOPS:
>Yazýlým üreten takým ile yazýlýmý sunuculara yerleþtiren, ayaða kaldýran, sunucularýn hayatta ve saðlýklý olmasýndan sorumlu takým arasýnda yaþanan problemleri en aza indirgeyerek müþteri memnuniyetini saðlamak.

>HANGFIRE:
>Arka planda çalýþacak olan bazý iþler yaratýp, yürütmeyi ve yönetmeyi saðlayan açýk kaynaklý bir kütüphane.

>VueJS:
>Ýnteraktif web arayüzleri oluþturmak ve ayný zamanda tek sayfa web uygulamalarý geliþtirilmiþ için kullanýnlan açýk kaynak kodlu bir Java Script kütüphanesidir.

## GitHub

>GitHub
>Ortak Proje Yönetim Alaný.

## GitHub Kavramlarý:

>Working Directory: 
>Çalýþma dizinini yani klasörünü ifade eder. Projenize ait dosya ve klasörleri barýndýran klasördür.

>Stage Area:
>Geçiþ bölgesidir. Git sisteminde projenizin kopyasýný almak istediðinizde doðrudan depoya gönderilmez. Önce Stage Area adý verilen bir geçiþ bölgesine gönderilir. 

>Repository: 
>Projenize ait kopyalarýn yani yedeklerin tutulduðu depodur. Git'in çalýþma yapýsýna göre projenize ait almýþ olduðunuz kopyalar doðrudan depoya gönderilmez. Önce Stage Area adý verilen bir geçiþ bölgesine gönderilir. Daha sonra farklý bir komutla depoya eklenir.

>Add: 
>Proje klasöründe yapýlan deðiþiklikleri Stage Area yani geçiþ bölgesine ekleme iþlemidir. 

>Commit: 
>Stage Area'da bulunan deðiþikliklerin Repository yani depoya eklenmesi iþlemidir. Daha net bir ifadeyle projenize ait yedek alma iþleminin gerçekleþtirilmesidir. 

>Checkout: 
>Proje geliþtirme sürecinde aldýðýmýz yedekler yani sürümler arasý geçiþ yapma iþlemi için kullanýlýr. Örneðin; bir Java projesi geliþtiriyoruz ve "Sürüm 1", "Sürüm 2", "Sürüm 3" adýnda 3 tane yedeðimiz olsun. Ýþte bu sürümler arasý geçiþ yapabilmek için checkout komutu kullanýlýr. Belirtilen sürüme tamamiyle geçiþ yapabildiðimiz gibi o sürüme ait herhangi bir dosyayý geri getirme imkânýmýz da bulunmaktadýr. 

>Push: 
>Projenize ait deðiþikliklerin uzak sunucuya bildirilmesi iþlemidir. Github, Gitlab gibi servisler Git ile birlikte çalýþma özelliðine sahipler. Yani bilgisayarýnýzda oluþturduðunuz bir projeyi Git ile birlikte geliþtirirseniz, push komutunu kullandýðýnýz takdirde projenizde yer alan dosya ve klasörleri uzak sunucuya göndermiþ olursunuz. 

>Branch: 
>Türkçesi dal demektir. Git sisteminin size sunduðu en büyük kolaylýklardan biri branch yani dallarla çalýþabilmenizdir. Projenin ana dalý master olarak isimlendirilir. Siz master adý verilen bu ana daldan, yeni bir branch(dal) oluþturup proje geliþtirmeye bu þekilde devam edebilirsiniz. Bu þekilde bir yol izlediðiniz takdirde yapacaðýnýz iþlemler master(ana dal)'ý etkilemez. Daha sonra yaptýðýnýz deðiþiklikleri master ile birleþtirme imkanýna sahipsiniz. Bu sistem sayesinde bir projede birden fazla ekip üyesi kendi branch(dal)'larýný oluþturup, projenin kendilerine düþen kýsmýný master'ý etkilemeyecek þekilde bitirip, en son aþamada branch ile master'ý birleþtirme imkânýna sahiptir. 

>Master: 
>Yukarýda da bahsettiðim gibi projenin ana dalýdýr. 

>Merge: 
>Türkçe'si birleþtirmek demektir. Oluþturulan bir branch ile projenin ana dalý olan Master branch'ýný birleþtirmeye yarar. 

>Status: 
>Projeye ait dosya ve klasörlerin mevcut durumunu listeler. Yani proje klasörü ile geçiþ bölgesi ve depo arasýnda farklýlýklar olup olmadýðýný size bildirir.
