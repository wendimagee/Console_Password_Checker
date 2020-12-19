using System;
using System.Linq;


namespace Deliverable1
{
    class Program
    {
        public static void Main(string[] args)
           {
              Console.WriteLine("Please enter a password that follows these rules:");
              Console.WriteLine("    Must have at least one uppercase letter");
              Console.WriteLine("    Must have at least one lowercase letter");
              Console.WriteLine("    Must be a minimum of 7 characters");
              Console.WriteLine("    Must be a maximum of 12 characters");
              Console.WriteLine("    Must include an exclamation point (!)");
              string password = Console.ReadLine();

            if (password.Length < 7 || password.Length > 12)
                {
                Console.WriteLine("Error");
                }
            else if (!password.Any(char.IsUpper))
                {
                Console.WriteLine("Error");
                }
            else if (!password.Any(char.IsLower))
                {
                Console.WriteLine("Error");
                }
            else if (!password.Contains("!"))
                {
                Console.WriteLine("Error");
                }
            else
                {
                Console.WriteLine("Password valid and accepted");
                }
        }
    }
}