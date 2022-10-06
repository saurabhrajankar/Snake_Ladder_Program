﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC6_Dice_Count
{
    internal class Program
    {//Constant
        const int NO_PLAY = 0;
        const int LADDER = 1;
        const int FINAL = 99;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake & Ladder Game");
            Console.WriteLine("Start The Game");

            int position = 0;//Taking position variable for starting position and assign it zero
            int count=0;
            Console.WriteLine("Postion assign from 0");

            while (position <= FINAL)
            {
                //Taking die variable for dice number by using random
                Random die = new Random();
                int dice = die.Next(1, 7);  //simulating dice throw
                Console.WriteLine($"Dice Thrown -->  {dice}");
                count++;

                //Taking die variable for dice number by using rando
                Random opt = new Random();
                int option = opt.Next(0, 3);

                if (option == NO_PLAY)
                {
                    Console.WriteLine($"No play You are in same position == {position}");
                }
                else if (option == LADDER)
                {
                    position += dice;
                    if (position > 100)
                    {
                        position -= dice;
                    }
                    Console.WriteLine("Ladder The new status of the player :" + position);
                }
                else
                {
                    position -= dice;
                    if (position < 0)
                    {
                        position = 0;
                    }
                    Console.WriteLine($"Snake The new status of the player = - {position}");

                }

            }
            Console.WriteLine($"Total Count Dice= {count}");
            Console.ReadLine();
    }   }
}
