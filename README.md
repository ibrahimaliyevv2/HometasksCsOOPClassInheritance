# HometasksCsOOPClassInheritance

Tapşırıqlar:
1.
1. Notebook class yaradın ve aşağıdakı xüsusiyyətləri olsun Name - məhsulun adını ifadə edən xüsusiyyət BrandName - 

Notebook -un  brand adı Price - 

Notebook -un qiyməti.
2.1-ci tapşırıqda yaratdığınız 

Notebook   class-ı istifadə edəcəksiniz.  Program.cs faylında bir metod yaradın, o metod parametr olaraq  

Notebook   array-i , double olaraq minPrice və maxPrice dəyərləri qəbul etsin ve göndərilən 

Notebook   array-də Price xüsusiyyətinin dəyəri gündərilən minPrice və maxPrice aralığında olan 

Notebook-lardan ibarət yeni bir array qaytarsın





3. Product class
 - No
 - Name
- Price
- Count

Book class - Productdan miras alır 
 - Genre 
 
No, Name ve Price dəyərləri təyin olunmadan Product obyekti yaradıla bilməz
Genre dəyəri təyin olunmadan Book yaradıla bilməz


Library class
 - Books - Book type-da array
 - AddBook() - parametr olaraq book type-da dəyər qəbul edib Books arayinə əlavə edir
 - GetFilteredBooks() -  parametr oalraq string value qəbul edir ve genre adı həmin string value olan Book-lardan ibarət array qaytarir
 - GetFiltererdBooks() - parametr olaraq minPrice və maxPrice dəyərləri qəbul edir və Price dəyəri minPrice və maxPrice aralığında olan Book-lardan ibarət array qaytarır




Proqram açılanda istifadəçidən kitabların sayını soruşmalıdır, daha sonra verilən say qədər kitab əlavə edilməsini istəməlidir.Kitabların Price, Count və No dəyərləri 0-dan kiçik ola bilməz.Eyni No dəyərində 2-ci bir book obyekti əlavə edilə bilməz.Library classından yaradacağınız Library obyektinin içindəki Books arrayindəki bütün kitabların No dəyərləri bir birindən fərqli olmalıdır. Kitabların adlarının uzunluqları 1-dən kiçik və 50-dən böyük ola bilməz,Genre adı isə 3-dən kiçik 20-dən böyük ola bilməz


Programa bütün kitabları console pəncərəsidən daxil etdikdən sonra proqram bizə seçim verməlidir, "filterlemek siteyirsinizmi? y/n" əgər n dəyəri seçilsə istifadəçiyə bütün kitabların infolarını console-da göstərməlidir, əgər y dəyəri seçilsə istifadəçiyə yeni bir seçim verməlidir: "1 - Genre adina gore , 2 - Qiymet intervalina gore" əgər istifadəçi bu seçimdə 1 dəyərini seçsə axtardığı janr (genre) adını daxil etməsi istənilməlidir.Və Genre dəyəri consoledan daxil edilmiş dəyərə bərabər olan bütün kitabların infolarını göstərməlidir.Əgər istifadəçi 2 deyerini seçərsə istifadəçidən minPrice və maxPrice dəyərlərini daxil etməsini istəməlidir və Price dəyəri daxil edilən minPrice və maxPrice aralığında olan bütün kitabların infolarını console pəncərəsində göstərməlidir.


4. Bu vaxtadək c# üzrə keçdiyimiz hər şeyi təkrarlayırsınız (dərslər və tapşırıqlar) əlavə olara C#-da array və string metodlarını araşdırmağınızı istəyirəm






Classwork Github  Link :https://github.com/Sunaljabili/BP202-ref-out


Classwork Tasks:
Task-1
 Array-deki En Boyuk ededle en kicik ededin yerini deyishen method yazın.
[-12, 23, 43, 54, 65, 76]=>[76,23,43,54,65,76];





Task-2
Verilmish array - de tekrar olunan ededlerin sayini cixardan method yazın.
