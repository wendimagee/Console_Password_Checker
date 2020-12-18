using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;




namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a password that follows these rules:");
            Console.WriteLine("    Must have at least one uppercase letter");
            Console.WriteLine("    Must have at least one lowercase letter");
            Console.WriteLine("    Must be a minimum of 7 characters");
            Console.WriteLine("    Must be a maximum of 12 characters");
            Console.WriteLine("    Must include an exclamation point (!)");
            string password = Console.ReadLine();
        }
    }
}
