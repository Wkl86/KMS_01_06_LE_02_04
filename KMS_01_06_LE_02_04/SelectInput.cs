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
            while(!checkInput)
            {                       
                Console.WriteLine(input);
                inputUser = Console.ReadLine();
                if (!Regex.IsMatch(inputUser, "[^a-zA-Z0-9]+"))
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
            while(!checkInput)
            {
                Console.WriteLine(input);
                string inputUser = Console.ReadLine();
                try
                {
                    value = Convert.ToInt32(inputUser);
                    checkInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Geben Sie nur Ganzzahlen ein:");
                }
            }
            return value;
        }

    }
}