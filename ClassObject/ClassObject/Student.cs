using System;

namespace ClassObject
{
    //inheretance,extends - miras almaq,toreme
    class Student:Person
    {
        //fields
        public double Payment;

        //constructor - class adi ile eyni adda methoddur.Return type olmur.Ayriliqda chagrila bilmir.
        //Object instance alinanda ilk ishe dushen metodddur.
        public Student():base("test","testov")
        {
            Console.WriteLine("Bir telebe daha yaradildi");
        }

        public Student(string name, string surname):this()
        {
            Name = name;
            Surname = surname;
        }
        public Student(string name,string surname,double payment):this(name,surname)
        {
            Payment = payment;
        }

        

        public string FullInfo()
        {
            return $"{Fullname()} - {Payment}";
        }

        public void Test()
        {
            Console.WriteLine();
        }

    }
}
