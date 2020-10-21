using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public Person(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Fullname()
        {
            return $"{Name} {Surname}";
        }
    }
}
