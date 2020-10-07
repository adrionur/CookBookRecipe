# CookBookRecipe
CookBookRecipeRest

Gençler burada Projeyi 2 bölümde inceleyeceğiz

1.si Rest API (.net core)
2.si de UI kısmı (Angular--herhalde en son sürümünü kullanırız)

Şimdi API kısmını da 2 kısımda düşünelim
User ve Recipe isminde 2 controller var

UserController ile CRUD işlemleri yapılabilecek. 
--Birkaç USER tipi olduğunu varsayarak işlem yapılacak (Kısaca AdminActionFilter gibi bir AOP yapısını düşünebiliriz)
--İşlem yapan kullanıcı admin değilse transactional iş yapamayacak abi.

Recipe de CRUD işlemleri yapacak
--Yine yukarıdaki gibi burada da Admin transactional işleri yapabilecek

--DB olarak şimdilik SQLite kullanalım. Beleş db bulursak ona geçeriz
--ORM olarak Entity Framework
--Buna Repo yazmak gerekecek onu servise DI ile bağlayacağız.

Şimdilik bu kadar. Ekleyeceğim...
