using System;

namespace Strings

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть прізвище ім'я та побатькові");
            string input = Console.ReadLine();

            int firstIndex = input.IndexOf(" ");
            int secondIndex = input.IndexOf(" ", firstIndex + 1);

            string secondName1 = input.Remove(input.LastIndexOf(" ") + 1);
            string secondName = secondName1.Substring(secondName1.IndexOf(" ") + 1);
            string firstName = input.Remove(input.IndexOf(" ") + 1);
            string fatherName = input.Remove(0, secondIndex + 1);

            string firstNameFW = firstName.Remove(1);
            string secondNameFW = secondName.Remove(1);
            string fatherNameFW = fatherName.Remove(1);
            string lastWords = firstName.Substring(1);

            Console.WriteLine(firstNameFW.ToUpper() + lastWords + " " + secondNameFW.ToUpper() + "." + fatherNameFW.ToUpper() + ".");
            Console.ReadKey();
        }
    }
}