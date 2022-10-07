using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3_Player_Check_Option
{
    internal class Program
    {
        public const int NO_PLAY = 1;
        public const int LADDER = 2;
        public const int SNAKE = 3;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake & Ladder Game");


            int position = 0;
            Console.WriteLine("start position is " + position);

            Random die = new Random(); //Crating random object of random class
            int dice = die.Next(1, 7);  //simulating dice throw
            Console.WriteLine($"Dice Thrown -->  {dice}");
            Console.WriteLine();

            Random opt = new Random();
            int option = opt.Next(1, 4);

            if (option == NO_PLAY)
            {
                Console.WriteLine("No play, You are in same position");            
            }
            else if (option == LADDER)
            {
                position = position + dice;
                Console.WriteLine($"(Ladder) the player is new position is + {position}");
            }
            else 
            {
                position = position - dice;
                Console.WriteLine($"(Snake) the player is new postion is  - {position}");
            }
            Console.ReadLine();
        }
    }
}
