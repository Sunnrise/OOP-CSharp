namespace AnonymousTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new
            {
                Name = "Alperen",
                Age= 24
            };
            WritePerson(person);

            void WritePerson(dynamic person)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
                Console.WriteLine(person.GetType().FullName);
            }

            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            Console.WriteLine(person.GetType().FullName);
        }
    }
}
