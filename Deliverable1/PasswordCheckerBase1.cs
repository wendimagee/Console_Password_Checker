namespace Deliverable1
{
    public static class PasswordCheckerBase1
    {
        public static string CheckPassword(string password)
        {
            //min 7 chars, max 12 chars
            if (password.Length < 7 || password.Length > 12)
                Console.WriteLine("Error");
            //No white space
            else if (password.Contains(" "))
                Console.WriteLine("Error");
            //At least 1 upper case letter
            else if (!password.Any(char.IsUpper))
                Console.WriteLine("Error");
            //At least 1 lower case letter
            else if (!password.Any(char.IsLower))
                Console.WriteLine("Error");
            //At least 1 !
            else if (!password.Contains("!"))
                Console.WriteLine("Error");
            else
                return "Password valid and accepted";


        }
    }
}