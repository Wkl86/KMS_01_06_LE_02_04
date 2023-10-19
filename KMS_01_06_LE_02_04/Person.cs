using System;
using System.Collections.Generic;

namespace KMS_01_06_LE_02_04
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public int telephoneNumber;

        public static List<Person> allPersons = new List<Person>();

        public Person(string firstName, string lastName, int age, int telephoneNumber)
        {
            if (allPersons.Count < 10)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
                this.telephoneNumber = telephoneNumber;
                allPersons.Add(this);
            }
            else
            {
                Console.WriteLine("Die maximale Anzahl von Personen wurde erreicht.");
            }
        }

        public static void ShowAllPersons(int ageOf, int ageTo)
        {
            foreach (var person in allPersons)
            {
                if (person.age < ageOf && person.age < ageTo)
                {
                    Console.WriteLine($"Vorname: {person.firstName}, Nachname: {person.lastName}, Alter: {person.age}, Telefonnummer: {person.telephoneNumber}");
                }
                else if (person.age  >= ageOf && person.age < ageTo)
                {
                    Console.WriteLine($"Vorname: {person.firstName}, Nachname: {person.lastName}, Alter: {person.age}, Telefonnummer: {person.telephoneNumber}");
                }
                else if (person.age >= ageOf && person.age <= ageTo)
                {
                    Console.WriteLine($"Vorname: {person.firstName}, Nachname: {person.lastName}, Alter: {person.age}, Telefonnummer: {person.telephoneNumber}");
                }

            }
        }
    }
}
