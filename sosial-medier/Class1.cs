using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sosial_medier
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string RelationshipStatus { get; set; }
        public List<Person> Friends { get; set;}
        public Person(string name, int age, string relationshipStatus) {
        
            Name = name;
            Age = age;
            RelationshipStatus = relationshipStatus;
        }
        public void addFriend(Person friendToAdd)
        {
            Friends.Add(friendToAdd);
        }
        public void removeFriend(Person friendToRemove) 
        {  Friends.Remove(friendToRemove); }
    }
}
