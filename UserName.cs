using System;


namespace WelcomeMessageApp
{
    public class UserName
    {
        public static string name()
        {
            Console.WriteLine("\nHello, what is your name?");
            string name = Console.ReadLine();
            return name;

        }
    }
}
