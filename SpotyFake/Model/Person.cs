using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Model
{
    internal class Person
    {
       
        public string _name { get; set; }    
        public string _surname { get; set; }
        public string _birthday { get; set; }

        public Person() 
        { 
        }
        public Person(string name, string surname, string birthday)
        {
            _name = name;
            _surname = surname;
            _birthday = birthday;
        }
    }
}
