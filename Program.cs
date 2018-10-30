using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzPop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Fizz Buzz Pop the game!!");

            Console.WriteLine("\nWith your host David Sanders (Srum Master Level 5)");

            //Player Input
            Console.WriteLine("\nFirst things first.  Please tell me your name?");

            var user = Console.ReadLine();

            Console.WriteLine($"\nWelcome {user}");

            //Defaults
            string FirstNumber = "3";
            string SecondNumber = "5";
            string ThirdNumber = "7";

            string FirstWord = "FIZZ";
            string SecondWord = "BUZZ";
            string ThirdWord = "POP";

            Game.Directions(
                FirstNumber, 
                SecondNumber, 
                ThirdNumber, 
                FirstWord, 
                SecondWord, 
                ThirdWord
                );

            Console.WriteLine($"\n{user} would you like to customize the game and add your own words and multiples? yes/no");

            string answer = Console.ReadLine().ToLower();

            if(answer == "yes")
            {

                //Substituted Multiples
                Console.WriteLine("\nWhat should the first multiple be?");
                FirstNumber = Console.ReadLine().ToLower();

                Console.WriteLine("\nWhat should the second multiple be?");
                SecondNumber = Console.ReadLine().ToLower();

                Console.WriteLine("\nWhat should the third multiple be?");
                ThirdNumber = Console.ReadLine().ToLower();

                //Substituted Words
                Console.WriteLine("\nWhat should the first word be?");
                FirstWord = Console.ReadLine().ToLower();

                Console.WriteLine("\nWhat should the second word be?");
                SecondWord = Console.ReadLine().ToLower();

                Console.WriteLine("\nWhat should the third word be?");
                ThirdWord = Console.ReadLine().ToLower();


                //Display new directions
                Game.Directions(
                    FirstNumber,
                    SecondNumber,
                    ThirdNumber,
                    FirstWord,
                    SecondWord,
                    ThirdWord
                );
            }
            else if(answer == "no")
            {
                Console.WriteLine("\nIf it aint broken, dont fix it.  I like that!");
            }
            else
            {
                Console.WriteLine("\nI will take that as a no....");
            }


            //Start Game
            Console.WriteLine("\nAlright then, let's get started");
            var Input = "playing";

            do
            {
                Console.WriteLine("\nType below. (Done?, type 'end game')");
                Input = Console.ReadLine().ToLower();
                if(Input != "end game")
                {
                   Game.Play(
                        FirstNumber,
                        SecondNumber,
                        ThirdNumber,
                        FirstWord,
                        SecondWord,
                        ThirdWord,
                        Input
                    );
                }
            }
            while (Input != "end game");

            Console.Write("\nGame Over!");
            Console.Write("\nHave a great day!! Good Bye!!");
            Console.ReadKey(true);
        }
    }
}
