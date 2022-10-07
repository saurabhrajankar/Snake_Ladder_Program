using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC7_Play_Game_With_2_Player
{
    internal class Program
    {
        const int NO_PLAY = 1;
        const int LADDER = 2;
        const int FINAL = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake & Ladder Game");
            Console.WriteLine("Start The Game");

            int position1 = 0;
            int position2 = 0;
            int count = 0;

            Console.WriteLine("Postion assign from 0");

            while (position1 != FINAL && position2 != FINAL)
            {
                Random die = new Random();
                int dice = die.Next(1, 7);
                Console.WriteLine($"Dice Thrown -->  {dice}");
                count++;

                Random ss = new Random();
                int player = ss.Next(1, 3);
                if (player == 1)
                {
                    //Taking die variable for dice number by using rando
                    Console.WriteLine("Player 1 turn");
                    Random opt = new Random();
                    int option = opt.Next(1, 3);

                    if (option == NO_PLAY)
                    {
                        Console.WriteLine($"No play You are in same position == {position1}");
                    }
                    else if (option == LADDER)
                    {
                        position1 += dice;
                        if (position1 > 100)
                        {
                            position1 -= dice;
                        }
                        Console.WriteLine($"Ladder The new status of the player = +{position1}");
                    }
                    else
                    {
                        position1 -= dice;
                        if (position1 < 0)
                        {
                            position1 = 0;
                        }
                        Console.WriteLine($"Snake The new status of the player = - {position1}");
                    }

                }

                else if (player == 2)
                {
                    Console.WriteLine("Player 2");
                    //Taking die variable for dice number by using rando
                    Random opt = new Random();
                    int option = opt.Next(0, 3);

                    if (option == NO_PLAY)
                    {
                        Console.WriteLine($"No play You are in same position == {position2}");
                    }
                    else if (option == LADDER)
                    {
                        position2 += dice;
                        if (position2 > 100)
                        {
                            position2 -= dice;
                        }
                        Console.WriteLine($"Ladder The new status of the player = +{position2}");
                    }
                    else
                    {
                        position2 -= dice;
                        if (position2 < 0)
                        {
                            position2 = 0;
                        }
                        Console.WriteLine($"Snake The new status of the player = - {position2}");
                    }
                }
            }
            { 
                Console.WriteLine("Player 1 position is " + position1);
                Console.WriteLine("Player 2 position is " + position2);
                // checking for winner
                if (position1 > position2)
                {
                    Console.WriteLine("greetings! Player 1 won this Game ");
                }
                else
                {
                    Console.WriteLine("greetings! Player 2 won this Game ");


                }
                Console.WriteLine($"Total Count Dice= {count}");
                Console.ReadLine();
            
            }
        }
    }
}
