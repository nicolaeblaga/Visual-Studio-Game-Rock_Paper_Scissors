using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RockPaperScissors
    {
        private int win;
        private int lose;
        private int tie;
        private Random random;

        public RockPaperScissors()
        {
            random = new Random();
        }

        public void Play()
        {
            string userInput;
            userInput = correctInput();
            string comInput;

            while (userInput != "Q")
            {
                Console.WriteLine("You choose {0}", ConvertToWord(userInput));
                Console.ReadLine();

                comInput = getComInput();
                Console.WriteLine("The computer choose: {0} ", ConvertToWord(comInput));
                Console.ReadLine();

                Winner(userInput, comInput);
                printScore();

                Console.Clear();
                userInput = correctInput();
            }
        }

        private string ConvertToWord(string choice)
        {
            if (choice == "R")
                return "Rock";
            else if (choice == "S")
                return "Scissors";
            else
                return "Paper";
        }

        private void printScore()
        {
            Console.WriteLine("Your score is: ========= ");
            Console.WriteLine();
            Console.WriteLine("You have tie: {0}", tie);
            Console.WriteLine("You won: {0}", win);
            Console.WriteLine("You lost: {0}", lose);
            Console.WriteLine();
            Console.WriteLine("Press enter to continue: ");
            Console.ReadLine();
        }

        private void Winner(string userInput, string comInput)
        {
            if(userInput == comInput)
            {
                tie++;
                Console.WriteLine("It is a tie. You both choose {0}.", ConvertToWord(userInput));
            }
            else if ((userInput == "R" && comInput == "S") || (userInput == "P" && comInput == "R") || (userInput == "S" && comInput == "P"))
            {
                win++;
                Console.WriteLine("You won, congratulations !!!");
            }
            else
            {
                lose++;
                Console.WriteLine("You lost. Better luck next time.");
            }
            Console.ReadLine();
        }

        private string getComInput()
        {
            int choice;
            choice = random.Next(1, 4);

            if (choice == 1)
                return "R";
            else if (choice == 2)
                return "P";
            else
                return "S";
        }

        private string correctInput()
        {
            while (true)
            {
                Console.Write("Choose from {R}ock, {P}aper, {S}cissors or {Q}uit: ");
                string choice = Console.ReadLine();

                if (choice == "R" || choice == "P" || choice == "S" || choice == "Q")
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("You did not type a correct choice !!!");
                }
            }
        }

        
    }
}
