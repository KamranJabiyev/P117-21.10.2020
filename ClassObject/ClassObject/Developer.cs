using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Developer:Person
    {
        public int Experience;
        public string[] ProgrammingLanguages;
        public Developer(string name,string surname):base(name,surname)
        {

        }
    }
}
