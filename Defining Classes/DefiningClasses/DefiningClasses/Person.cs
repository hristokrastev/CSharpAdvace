using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Person
    {

        private string name = "No name";
        private int age = 1;
        
        public string Name
        {
            get; set;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        public Person()
        {
            this.Name = name;
            this.Age = 1;
        }

        public Person(int age)
            : this()
        {
            this.Age = age;
        }

        public Person(string name, int age)
            : this(age)
        {
            this.Name = name;

        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Age}";
        }
    }
}
