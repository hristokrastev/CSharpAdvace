using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Family listOfPeople = new Family();

            for (int i = 0; i < n; i++)
            {
                var persons = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var name = persons[0];

                var age = int.Parse(persons[1]);

                Person member = new Person(name, age);

                listOfPeople.AddMember(member); 

            }

            Console.WriteLine(string.Join(Environment.NewLine, listOfPeople.GetPersonAbove30()));

        }
    }
}
