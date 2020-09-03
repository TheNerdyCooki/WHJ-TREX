using System;

namespace C__Tuto
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Change The Appearance Of The Console

            Console.Title = "C# TUTO";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;
            Console.WindowWidth = 150;
            
            //Get A Conversation Going 

            Console.WriteLine("Who Are You?");
            string userName = Console.ReadLine();

            Console.WriteLine("Cool Name " + userName);
            Console.WriteLine("My name is ST-ISDFOKS, I am a sentient AI sent from the future to tell you that to save the world you should learn CS.");
            Console.WriteLine("What is your RHT Number");

            int userRHT = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Wait a minute " + userRHT + " and your name is " + userName +  " you must be him/her/them");

            Console.WriteLine("Ok Now Hurry Up And Tell Me Your Birth D\nA\nY...........");
            Console.ReadKey();
        }
    }
}
