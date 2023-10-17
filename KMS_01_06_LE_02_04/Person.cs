using System;
using System.Collections.Generic;


namespace KMS_01_06_LE_02_04
{
    public class Person
    {
        string firstName;
        string lastName;
        int age;
        string telephonNumber;


        public static List<Person> AllPersons = new List<Person>();
        public static List<Person> UnderEighteen = new List<Person>();
        public static List<Person> UnderThirty = new List<Person>();
        public static List<Person> OverFourtyFife = new List<Person>();


        public Person(string firstName, string lastName, int age, string telephonNumber)
        {
            if (AllPersons.Count < 10)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
                this.telephonNumber = telephonNumber;
                AllocationByAge();
                AllPersons.Add(this);
            }
            else
            {
                Console.WriteLine("Die maximale Anzahl von Personen wurde erreicht.");
            }
        }

        public void AllocationByAge()

        {
            if (age < 18)
            {
                UnderEighteen.Add(this);
            }
            else if ( age < 30)
            {
                UnderThirty.Add(this);
            }
            else if (age > 45)
            {
                OverFourtyFife.Add(this);
            }
        }


        public static void ShowAllPersons()
        {
            foreach (var person in AllPersons)
            {
                Console.WriteLine($"Vorname: {person.firstName}, Nachname: {person.lastName}, Alter: {person.age}, Telefonnummer: {person.telephonNumber}");
            }
        }

        public static void ShowAllUnderEightTeenYearsPersons()
        {
            foreach (var person in UnderEighteen)
            {
                Console.WriteLine($"Vorname: {person.firstName}, Nachname: {person.lastName}, Alter: {person.age}, Telefonnummer: {person.telephonNumber}");
            }
        }

        public static void ShowAllUnderThirtyYearsPerson()
        {
            foreach (var person in UnderThirty)
            {
                Console.WriteLine($"Vorname: {person.firstName}, Nachname: {person.lastName}, Alter: {person.age}, Telefonnummer: {person.telephonNumber}");
            }
        }

        public static void ShowAllUnderFourtyFifeYearsPersons()
        {
            foreach (var person in OverFourtyFife)
            {
                Console.WriteLine($"Vorname: {person.firstName}, Nachname: {person.lastName}, Alter: {person.age}, Telefonnummer: {person.telephonNumber}");
            }
        }

    }




    }

