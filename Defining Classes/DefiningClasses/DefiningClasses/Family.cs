using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {

        private HashSet<Person> members;

        public Family()
        {
            this.members = new HashSet<Person>();
        }

        public void AddMember(Person member)
        {
            this.members.Add(member);
        }

        public Person GetOldestMember()
        {

            Person oldestMember = this.members.OrderByDescending(p => p.Age).FirstOrDefault();

            return oldestMember;
           
        }

        public HashSet<Person> GetPersonAbove30()
        {
           
           var getPeopleAbove30 = this.members.Where(p => p.Age > 30).OrderBy(p => p.Name).ToHashSet();

            return getPeopleAbove30;
        }
    }
}
