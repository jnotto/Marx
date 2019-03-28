using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The current time is " + DateTime.Now);
            Console.WriteLine("How do you feel? Y/N");
            var feeling = Console.ReadLine();
            switch (feeling)
            {
                case "Y": Console.WriteLine("I am unsure of how a person can be doing 'yes', but I support you. :)");
                break;
                case "N": Console.WriteLine("You do not want to tell me how you are doing? I only wished to ensure your wellbeing. :(");
                break;
                default: Console.WriteLine("Your input is invalid. Respond appropriately or be reprimanded again. >:(");~
                break;
            }
        }
    }
}
