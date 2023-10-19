using System;
using System.Linq.Expressions;

namespace KMS_01_06_LE_02_04
{
    public class Menu
    {
        public static void Selects()
        {
            int select = 0;
            do
            {
                Console.WriteLine("Anlegen einer Person, drücken Sie die (1): ");
                Console.WriteLine("Alle Eintäge anzeigen, drücken Sie die (2): ");
                Console.WriteLine("Anzeigen nach dem Alter, drücken Sie die (3): ");
                Console.WriteLine("Beenden des Programmnes, drücken Sie die (0): ");
                try
                {
                    select = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ungültige Eingabe!");
                    continue;
                }
                switch (select)
                {
                    case 1:
                        string firstName = SelectInput.GetStringInput("Bitte geben Sie den Vornamen ein: ");
                        string lastName = SelectInput.GetStringInput("Bitte geben Sie den Nachnamen ein: ");
                        int age = SelectInput.GetIntInput("Bitte geben Sie das Alter ein: ");
                        int telephoneNumber = SelectInput.GetIntInput("Bitte geben Sie die Telefonnummer ein: ");
                        var person = new Person(firstName, lastName, age, telephoneNumber);
                        break;
                    case 2:
                        Person.ShowAllPersons(ageOf: 0, ageTo: 99);
                        break;
                    case 3:
                        DisplaySubMenu();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Falsche Eingabe");
                        continue;
                }
            } while (true);
        }
        public static void DisplaySubMenu()
        {
            int selectSubMenu = 0;
            do
            {
                Console.WriteLine("Alle Personen unter 18 Jahren bis 29 drücken Sie die (1): ");
                Console.WriteLine("Alle Personen über 30 Jahren bis 44 drücken Sie die (2): ");
                Console.WriteLine("Alle Person über 45 Jahren bis 60 drücken Sie die (3): ");
                Console.WriteLine("Zurück zum Hauptmenü, drücken Sie die (0): ");
                try
                {
                    selectSubMenu = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ungültige Eingabe!");
                    continue;
                }
                switch (selectSubMenu)
                {     
                    case 1:
                        Person.ShowAllPersons(ageOf: 18, ageTo:29);
                        break;
                    case 2:
                        Person.ShowAllPersons(ageOf: 30, ageTo: 44);
                        break;
                    case 3:
                        Person.ShowAllPersons(ageOf: 45, ageTo: 60);
                        break;
                    case 0:
                        Console.WriteLine("Zurück zum Hauptmenü");
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe!");
                        continue;
                }
            } while (selectSubMenu != 0);
        }
    }
}
