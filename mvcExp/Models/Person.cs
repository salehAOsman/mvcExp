using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcExp.Models
{
    public class Person
    {
        //we use list instead of database we put it as static
        public static List<Person> People { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        
        //ctr + tab => constractor
        public Person(int age,string name)
        {
            Age = age;
            Name = name;
        }

    }
}