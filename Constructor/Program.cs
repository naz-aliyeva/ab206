

/*
 
 
 Human classiniz olur
Constructorunun 3 overloadi olur (bos; name; name, surname) qebul edir
Name
Surname
Age
fieldleri var.
ShowFullData()
GetFullName() methodlari var


Human class:
============
string Name
string Surname;
byte Age (encapsulation)


User class:
===========
- UserName - istifadəçinin istifadəçi adını ifadə edir
- Password - İstifadəçinin şifrə dəyərini ifadə edir




User classi Human'dan miras alir. Name, Surname, UserName dəyəri təyin olunmamış User obyekti yaradıla bilinməməlidir.UserName dəyərinin uzunluğu minimum 6, maksimum 25 ola bilər.
Password dəyərinin uzunluğu minimum 8 , maksimum 25 ola bilər.


Daha sonra User type-da olan obyekt yaradın, bunun üçün username və password dəyərlərini console-dan qəbul edin.*/




namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Nezrin", "Eliyeva ");


            human.age = 10;
            human.ShowFullData();
        }


    }
}
