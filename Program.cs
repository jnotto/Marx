using System;

// To do: Implement testing, static analysis and ci/cd.
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
            switch (feeling.ToUpper())
            {
                case "Y": Console.WriteLine("I am unsure of how a person can be doing 'yes', but I support you. :)");
                break;
                case "N": Console.WriteLine("You do not want to tell me how you are doing? I only wished to ensure your wellbeing. :(");
                break;
                default: Console.WriteLine("Your input is invalid. Respond appropriately or be reprimanded again. >:(");
                break;
            }

            Console.WriteLine("Are you ready?");
            var ready = Console.ReadLine();
            switch (ready.ToUpper())
            {
                default: Console.WriteLine("You have 10 seconds.");
                int length = 10;
                for (int seconds = 0; seconds < length; seconds++)
                {
                    Console.WriteLine(length - seconds + "\n");
                    System.Threading.Thread.Sleep(1000);
                }
                break;
            }
            Console.WriteLine("Input letters only with no punctuation. Press any key to start the quiz. \n");
            Console.ReadKey();

            int score = 0;

            Console.WriteLine("In what year did the United States gain independence?");
            Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
            Console.WriteLine("A. 1945");
            Console.WriteLine("B. 2000");
            Console.WriteLine("C. 1776");
            Console.WriteLine("D. 1860");
            var question1 = Console.ReadLine();
            switch (question1.ToUpper())
            {
                case "C": Console.WriteLine("CORRECT!");
                score++;
                break;
                default: Console.WriteLine("WRONG. \n The correct answer was C.");
                break;
            }

            Console.WriteLine("In what year will the world be plunged into nuclear war?");
            Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
            Console.WriteLine("A. 2012");
            Console.WriteLine("B. 2077");
            Console.WriteLine("C. 3001");
            Console.WriteLine("D. 2021");
            var question2 = Console.ReadLine();
            switch (question2.ToUpper())
            {
                case "B": Console.WriteLine("CORRECT!");
                score++;
                break;
                default: Console.WriteLine("WRONG. \n The correct answer was B.");
                break;
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Good job, maybe! I think?");
            Console.WriteLine($"You got {score}/10 correct! You might be a genius!");


        }
    }
}
