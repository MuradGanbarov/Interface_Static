//TASk 2

using Interface_Static_Task2.Extension;

namespace Interface_Static_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write digit for testing method IsOdd and IsEven");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Is{number} odd? {number.IsOdd()}");
            Console.WriteLine($" Is {number} even? {number.IsEven()}");

            Console.WriteLine("Write word with digit for testing HasDigit method.");
            string text = Console.ReadLine();
            Console.WriteLine($"Does '{text}' have a digit? {text.HasDigit()}");

            Console.WriteLine("Password should be minimum 8 letters and 1 digit. You can testing this method, too");
            string password = Console.ReadLine();
            Console.WriteLine($"Is '{password}' a valid password? {password.CheckPassword}\n");


            Console.WriteLine("For usual word should be started with upper letter and then continue with small letter\nYou can testing Capitalize method if see anything wrong in this condition");
            string textToCapitalize = Console.ReadLine();
            Console.WriteLine($"Capitalize: {textToCapitalize.Capitalize()}");

        }
    }
}