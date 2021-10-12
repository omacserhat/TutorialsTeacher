# OGRENDIKLERIM
## COGUNLUKLA C# VE YAZILIMCI KAVRAMLARI ICERMEKTEDIR.


## C# Yazılım Kavramları

>Compile: 
>Sadece edit�r de o an a��k olan sayfay� derler.

 >Build:
 >En son yap�lan build i�leminden sonra �zerinde de�i�iklik yap�lan t�m dosyalar� derler.

>Rebuild:
>Herhangi bir durumu dikkate almaks�z�n projenin tamam�n� yeniden derler. T�m proje yeniden derlenece�inden Build i�lemine g�re daha uzun s�recektir ancak build ile derleme s�ras�nda olu�an hatalar� rebuild ile ��zebilirsiniz.

>Clean: 
>Derleme sonras�nda olu�an ge�ici ve kal�c� t�m dosyalar temizlenir. Bir sonraki derleme i�leminde temiz bir ba�lang�� yap�l�r. Genellikle proje kodlar� bir ba�kas�na g�nderilmek istenildi�inde hem proje boyutunu ufaltmak hemde gereksiz dosyalardan kurtulmak ad�na tercih edilir.

>Deployment(Da��t�m):
>Bilgisayar bilimlerinde bu anlam �yaz�l�m� da��tmak, yaymak, sahaya yerle�tirmek� gibi anlamlara gelir. Her yaz�l�m sistemi kendine �zg� oldu�undan dolay� projelerin canl� ortama deploy edilmesi farkl� a�amalar gerektirebilir.

## GENEL KAVRAMLAR

>DEVOPS:
>Yaz�l�m �reten tak�m ile yaz�l�m� sunuculara yerle�tiren, aya�a kald�ran, sunucular�n hayatta ve sa�l�kl� olmas�ndan sorumlu tak�m aras�nda ya�anan problemleri en aza indirgeyerek m��teri memnuniyetini sa�lamak.

>HANGFIRE:
>Arka planda �al��acak olan baz� i�ler yarat�p, y�r�tmeyi ve y�netmeyi sa�layan a��k kaynakl� bir k�t�phane.

>VueJS:
>�nteraktif web aray�zleri olu�turmak ve ayn� zamanda tek sayfa web uygulamalar� geli�tirilmi� i�in kullan�nlan a��k kaynak kodlu bir Java Script k�t�phanesidir.

## GitHub

>GitHub
>Ortak Proje Y�netim Alan�.

## GitHub Kavramlar�:

>Working Directory: 
>�al��ma dizinini yani klas�r�n� ifade eder. Projenize ait dosya ve klas�rleri bar�nd�ran klas�rd�r.

>Stage Area:
>Ge�i� b�lgesidir. Git sisteminde projenizin kopyas�n� almak istedi�inizde do�rudan depoya g�nderilmez. �nce Stage Area ad� verilen bir ge�i� b�lgesine g�nderilir. 

>Repository: 
>Projenize ait kopyalar�n yani yedeklerin tutuldu�u depodur. Git'in �al��ma yap�s�na g�re projenize ait alm�� oldu�unuz kopyalar do�rudan depoya g�nderilmez. �nce Stage Area ad� verilen bir ge�i� b�lgesine g�nderilir. Daha sonra farkl� bir komutla depoya eklenir.

>Add: 
>Proje klas�r�nde yap�lan de�i�iklikleri Stage Area yani ge�i� b�lgesine ekleme i�lemidir. 

>Commit: 
>Stage Area'da bulunan de�i�ikliklerin Repository yani depoya eklenmesi i�lemidir. Daha net bir ifadeyle projenize ait yedek alma i�leminin ger�ekle�tirilmesidir. 

>Checkout: 
>Proje geli�tirme s�recinde ald���m�z yedekler yani s�r�mler aras� ge�i� yapma i�lemi i�in kullan�l�r. �rne�in; bir Java projesi geli�tiriyoruz ve "S�r�m 1", "S�r�m 2", "S�r�m 3" ad�nda 3 tane yede�imiz olsun. ��te bu s�r�mler aras� ge�i� yapabilmek i�in checkout komutu kullan�l�r. Belirtilen s�r�me tamamiyle ge�i� yapabildi�imiz gibi o s�r�me ait herhangi bir dosyay� geri getirme imk�n�m�z da bulunmaktad�r. 

>Push: 
>Projenize ait de�i�ikliklerin uzak sunucuya bildirilmesi i�lemidir. Github, Gitlab gibi servisler Git ile birlikte �al��ma �zelli�ine sahipler. Yani bilgisayar�n�zda olu�turdu�unuz bir projeyi Git ile birlikte geli�tirirseniz, push komutunu kulland���n�z takdirde projenizde yer alan dosya ve klas�rleri uzak sunucuya g�ndermi� olursunuz. 

>Branch: 
>T�rk�esi dal demektir. Git sisteminin size sundu�u en b�y�k kolayl�klardan biri branch yani dallarla �al��abilmenizdir. Projenin ana dal� master olarak isimlendirilir. Siz master ad� verilen bu ana daldan, yeni bir branch(dal) olu�turup proje geli�tirmeye bu �ekilde devam edebilirsiniz. Bu �ekilde bir yol izledi�iniz takdirde yapaca��n�z i�lemler master(ana dal)'� etkilemez. Daha sonra yapt���n�z de�i�iklikleri master ile birle�tirme imkan�na sahipsiniz. Bu sistem sayesinde bir projede birden fazla ekip �yesi kendi branch(dal)'lar�n� olu�turup, projenin kendilerine d��en k�sm�n� master'� etkilemeyecek �ekilde bitirip, en son a�amada branch ile master'� birle�tirme imk�n�na sahiptir. 

>Master: 
>Yukar�da da bahsetti�im gibi projenin ana dal�d�r. 

>Merge: 
>T�rk�e'si birle�tirmek demektir. Olu�turulan bir branch ile projenin ana dal� olan Master branch'�n� birle�tirmeye yarar. 

>Status: 
>Projeye ait dosya ve klas�rlerin mevcut durumunu listeler. Yani proje klas�r� ile ge�i� b�lgesi ve depo aras�nda farkl�l�klar olup olmad���n� size bildirir.
