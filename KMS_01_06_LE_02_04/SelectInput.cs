using System;
using System.Text.RegularExpressions;

namespace KMS_01_06_LE_02_04
{
    public class SelectInput
    {
        public static string GetStringInput(string input)
        {
            string inputUser = "";
            bool checkInput = false;
            while (!checkInput)
            {
                Console.WriteLine(input);
                inputUser = Console.ReadLine();
                if (!Regex.IsMatch(inputUser, "[^a-zA-Z]+"))

                {
                    checkInput = true;
                }
                else
                {
                    Console.WriteLine("Bitte geben Sie nur Buchstaben ein!");
                }
            }
            return inputUser;

        }
        public static int GetIntInput(string input)
        {
            int value = 0;
            bool checkInput = false;

            while (!checkInput)
            {
                Console.WriteLine(input);
                try
                {
                    string inputUser = Console.ReadLine();
                    if (int.TryParse(inputUser, out int intValue))
                    {
                        value = intValue;
                        checkInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Geben Sie eine gültige Ganzzahl ein!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ungültige Eingabe!");

                }
            }
            return value;
        }
    }
}