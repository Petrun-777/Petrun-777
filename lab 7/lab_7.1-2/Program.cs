using System;
using System.Collections.Generic;

namespace Petrun
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> PersonNumbers { get; set; }
        public Person(string name, int age, IEnumerable<string> personNumbers)
        {
            Name = name;
            Age = age;
            PersonNumbers = personNumbers;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> List = new List<Person>
            {
                new Person("Amanda", 9, new List<string>() { "1", "2" }),
                new Person("Anton", 10, new List<string>() { "3", "4" }),
                new Person("Basia", 11, new List<string>() { "5", "6" }),
                new Person("Me", 12, new List<string>() { "7", "8" }),
                new Person("Ivan", 13, new List<string>() { "9", "10" })
            };
            foreach (var Person in List)
            {
                Console.WriteLine("\n Name: " + Person.Name + " " + "Age: " + Person.Age);
            }
            Console.WriteLine("\n Using the AddRange");
            List.AddRange(new List<Person>() {
            new Person("You", 14, new List<string>() { "11", "12" }),
            new Person("Oleg", 15, new List<string>() { "13", "14" })});
            foreach (var Person in List)
            {
                Console.WriteLine("\n Name: " + Person.Name + " " + "Age: " + Person.Age);
            }
            foreach (var item in List)
            {
                Console.WriteLine("\n {0} have this number:", item.Name);
                foreach (var number in item.PersonNumbers)
                {
                    Console.WriteLine(" {0}", number);
                }
            }
        }
    }
}
