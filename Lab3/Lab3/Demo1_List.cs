using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Person
    {
        public int age;
        public string firstname;
        public string lastname;
        public override string ToString()
        {
            return $"first name : {firstname} and lastname : {lastname}";
        }
    }
    internal class Demo1_List
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>()
        {
            new Person() { age = 10, firstname = "le tan", lastname = "dai"},
            new Person() { age = 15, firstname = "huynh tran",lastname = "van trong" },
            new Person() { age = 20, firstname = "le the", lastname = "bao" },
            new Person() { age = 30, firstname = "truong quoc", lastname = "cuong" }
        };
            Console.WriteLine($"item in list is conclude {list.Count} item");
            foreach (Person p in list)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
