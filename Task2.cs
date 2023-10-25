using System;

public class Program
{
    public class Person
    {
        private int age;
        public string Name { get; set; }

        public Person(int age, string name)
        {
            this.age = age;
            Name = name;
        }

        public string Introduction()
        {
            return $"Hi, I'm {Name} and I'm {age} years old.";
        }
    }
    public static void Main(string[] args)
    {
        Person person = new Person(21, "Angel");
        string introductionMessage = person.Introduction();
        Console.WriteLine(introductionMessage);
    }
}