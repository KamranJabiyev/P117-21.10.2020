using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Vasif";
            //string surname = "Xammedov";
            //int age = 37;

            //string name1 = "Melek";
            //string surname1 = "Muxtarli";
            //int age1 = 23;

            //anonim object
            //var stu1 = new 
            //{ 
            //    name="Vasif",
            //    surname="Xammedov",
            //    age=37
            //};

            //var stu2 = new
            //{
            //    name = "Melek",
            //    surname = "Muxtarli",
            //    age = 23
            //};

            //Console.WriteLine(stu1.name+" "+stu1.surname);

            //instance - nusxe chixarmaq
            //Student s1 = new Student("Vasif","Xammedov",4000);
            //s1.Name = "Vasif";
            //s1.Surname = "Xammedli";
            //s1.Age = 37;

            //Student s2 = new Student("Melek","Muxtarli",3500);
            //s2.Name = "Melek";
            //s2.Surname = "Muxtarli";
            //s2.Age = 23;
            //s2.Payment = 3500;

            //Console.WriteLine(s1.Fullname());
            //Console.WriteLine(s2.Fullname());

            //Console.WriteLine(s1.FullInfo());
            //Console.WriteLine(s2.FullInfo());

            //Student s3 = new Student();
            Student s4 = new Student("Elgun", "Maqsudzade", 5000);
            Developer developer = new Developer();
            //Console.WriteLine(s4.Fullname());
        }
    }
}
