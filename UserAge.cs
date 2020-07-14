using System;


namespace WelcomeMessageApp
{
    public class UserAge
    {
        public static int age()
        {
            Console.WriteLine("\nOne more info please..... \nIn what year were you born?");
            int age = 2020 - Int32.Parse(Console.ReadLine());

            return age;

        }
    }
}
