using System;

namespace examen1
{
    public class Persoana
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }

        public int Age => DateTime.Now.Year - YearOfBirth;

        public Persoana(string firstName, string lastName, int yearOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
        }
    }

    class Program
    {
        static void Main()
        {
            Persoana persoanaEx = new Persoana("Daniela", "Giorgiana", 2004);

            Console.WriteLine($"Nume: {persoanaEx.FirstName}");
            Console.WriteLine($"Prenume: {persoanaEx.LastName}");
            Console.WriteLine($"Anul nasterii: {persoanaEx.YearOfBirth}");
            Console.WriteLine($"Varsta: {persoanaEx.Age} ani");
        }
    }
}