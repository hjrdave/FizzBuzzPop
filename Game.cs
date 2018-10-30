using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzPop
{
    public static class Game
    {
        
        public static void Directions(
            string Input1, 
            string Input2, 
            string Input3, 
            string Input4, 
            string Input5, 
            string Input6)

        {
              
        string FirstNumber = Input1;
        string SecondNumber = Input2;
        string ThirdNumber = Input3;

        string FirstWord = Input4;
        string SecondWord = Input5;
        string ThirdWord = Input6;
            
            
            Console.WriteLine("\nGame Rules are now...");
            Console.WriteLine($"\n{FirstNumber} = {FirstWord}");
            Console.WriteLine($"{SecondNumber} = {SecondWord}");
            Console.WriteLine($"{ThirdNumber} = {ThirdWord}");

            Console.WriteLine($"{FirstNumber} and {SecondNumber} = {FirstWord} {SecondWord}");
            Console.WriteLine($"{FirstNumber} and {ThirdNumber} = {FirstWord} {ThirdWord}");
            Console.WriteLine($"{SecondNumber} and {ThirdNumber} = {SecondWord} {ThirdWord}");
            Console.WriteLine($"{FirstNumber},{SecondNumber}, and {ThirdNumber} = {FirstWord} {SecondWord} {ThirdWord}");

        }
        public static void Substitutions()
        {
            
            //Subsituted Multiples
            Console.WriteLine("\nWhat should the first multiple be?");
            string FirstNumber = Console.ReadLine().ToLower();

            Console.WriteLine("\nWhat should the second multiple be?");
            string SecondNumber = Console.ReadLine().ToLower();

            Console.WriteLine("\nWhat should the third multiple be?");
            string ThirdNumber = Console.ReadLine().ToLower();

            //Substituted Words
            Console.WriteLine("\nWhat should the first word be?");
            string FirstWord = Console.ReadLine().ToLower();

            Console.WriteLine("\nWhat should the second word be?");
            string SecondWord = Console.ReadLine().ToLower();

            Console.WriteLine("\nWhat should the third word be?");
            string ThirdWord = Console.ReadLine().ToLower();

            Console.WriteLine("\nThe New Game Rules are...");
            Console.WriteLine($"\n{FirstNumber} = {FirstWord}");
            Console.WriteLine($"{SecondNumber} = {SecondWord}");
            Console.WriteLine($"{ThirdNumber} = {ThirdWord}");

            Console.WriteLine($"{FirstNumber} and {SecondNumber} = {FirstWord} {SecondWord}");
            Console.WriteLine($"{FirstNumber} and {ThirdNumber} = {FirstWord} {ThirdWord}");
            Console.WriteLine($"{SecondNumber} and {ThirdNumber} = {SecondWord} {ThirdWord}");
            Console.WriteLine($"{FirstNumber},{SecondNumber}, and {ThirdNumber} = {FirstWord} {SecondWord} {ThirdWord}");
        }

            public static void Play(
                    string Input1,
                    string Input2,
                    string Input3,
                    string Input4,
                    string Input5,
                    string Input6,
                    string PlayerInput
                )  
            {
            
            try
            {
                int FirstNumber = Int32.Parse(Input1);
                int SecondNumber = Int32.Parse(Input2);
                int ThirdNumber = Int32.Parse(Input3);

                string FirstWord = Input4;
                string SecondWord = Input5;
                string ThirdWord = Input6;
                int x = Int32.Parse(PlayerInput);

                
                if (x % FirstNumber == 0 && x % SecondNumber != 0 && x % ThirdNumber != 0)//Multiples of three return Fizz
                {
                    Console.WriteLine(FirstWord);
                }
                else if (x % FirstNumber != 0 && x % SecondNumber == 0 && x % ThirdNumber != 0)//Multiples of five return Buzz
                {
                    Console.WriteLine(SecondWord);
                }
                else if (x % FirstNumber != 0 && x % SecondNumber != 0 && x % ThirdNumber == 0)//Multiples of seven return Pop
                {
                    Console.WriteLine(ThirdWord);
                }
                else if (x % FirstNumber == 0 && x % SecondNumber == 0 && x % ThirdNumber != 0)//Multiples of three and five return Fizz Buzz
                    {
                    Console.WriteLine(FirstWord + ' ' + SecondWord);
                }
                else if (x % FirstNumber == 0 && x % SecondNumber != 0 && x % ThirdNumber == 0)//Multiples of Three and Seven Return Fizz Pop
                {
                    Console.WriteLine(FirstWord + ' ' + ThirdWord);
                }
                else if(x % FirstNumber != 0 && x % SecondNumber == 0 && x % ThirdNumber == 0)//Multiples of Five and Seven Return Buzz Pop
                {
                    Console.WriteLine(SecondWord + ' ' + ThirdWord);
                }
                else if(x % FirstNumber == 0 && x % SecondNumber == 0 && x % ThirdNumber == 0)//Multiples of Three, Five and Seven Return Fizz Buzz Pop
                {
                    Console.WriteLine(FirstWord + ' ' + SecondWord + ' ' + ThirdWord);
                }
                else//Normal numbers return themselves
                {
                    Console.WriteLine(x);
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine(" Not an Applicable Input");
            }
        }
    }
}


