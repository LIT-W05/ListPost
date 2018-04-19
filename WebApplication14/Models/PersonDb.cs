using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication14.Models
{
    public static class PersonDb
    {
        private static List<Person> _people = new List<Person>();
        private static int _id = 1;

        public static IEnumerable<Person> GetAll()
        {
            return _people;
        }

        public static void Add(Person person)
        {
            person.Id = _id;
            _id++;
            _people.Add(person);
        }

        public static void Update(Person person)
        {
            int index = _people.FindIndex(p => p.Id == person.Id);
            _people[index] = person;
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }

        public override string ToString()
        {
            return $"{Id}: {FirstName} {LastName} - {Age}";
        }
    }
}