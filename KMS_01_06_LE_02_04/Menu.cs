using System;

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
                Console.WriteLine("Alle Eintäge anzeigen, drücken Sie die (3): ");
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
                        string telephoneNumber = SelectInput.GetStringInput("Bitte geben Sie die Telefonnummer ein: ");
                        var person = new Person(firstName, lastName, age, telephoneNumber);
                 
                        break;

                    case 2:
                        Person.ShowAllPersons();
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
                Console.WriteLine("Alle Personen unter 18 Jahren, drücken Sie die (1): ");
                Console.WriteLine("Alle Personen über 30 Jahren, drücken Sie die (2): ");
                Console.WriteLine("Alle Person über 45 Jahren, drücken Sie die (3): ");
                Console.WriteLine("Zurück zum Hauptmenü, drücken Sie die (0): ");

                try
                {
                    selectSubMenu = Convert.ToInt32(Console.ReadLine());

                }catch(FormatException)
                {
                    Console.WriteLine("Ungültige Eingabe!");
                    continue;
                }
                switch(selectSubMenu)
                {
                    case 1:
                        Person.ShowAllUnderEightTeenYearsPersons();
                        break;

                    case 2:
                        Person.ShowAllUnderThirtyYearsPerson();

                        break;
                    case 3:
                        Person.ShowAllUnderFourtyFifeYearsPersons();

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