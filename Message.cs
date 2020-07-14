using System;


namespace WelcomeMessageApp
{
    public class OutputMessage
    {
        public static string message()
        {
            string message = $"\nWelcome {UserName.name()}, you are {UserAge.age()} years old. \nDon't worry my dear, you are doing well!!";
            return message;

        }
    }
}
