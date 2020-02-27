
using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var person = new Person();

            person.Name = "Ivan";

            person.Age = 29;

            var secondPerson = new Person()
            {
                Name = "Ico",
                Age = 25

            };

            var thirdPerson = new Person()
            {
                Name = "Stamat",
                Age = 43
            };
        }
    }
}
