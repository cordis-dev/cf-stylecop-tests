using System;

namespace Tests.csharp9
{
    public record NewPerson
    {
    public string LastName { get; }
    public string FirstName { get; }

    public NewPerson(string first, string last) => (FirstName, LastName) = (first, last);
    }

    public record Person(string FirstName, string LastName);

    public record Teacher(string FirstName, string LastName,
    string Subject)
    : Person(FirstName, LastName);

    public sealed record Student(string FirstName,
    string LastName, int Level)
    : Person(FirstName, LastName);

    public class RecordTypes
    {
        public void Test()
        {
            var person = new Person("Bill", "Wagner");

            var (first, last) = person;
            Console.WriteLine(first);
            Console.WriteLine(last);

            // with expression 
            Person brother = person with { FirstName = "Paul" };
        }
    }

}