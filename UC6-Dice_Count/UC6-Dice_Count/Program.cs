using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC6_Dice_Count
{
    internal class Program
    {        //Constant
             const int NO_PLAY = 0;
             const int LADDER = 1;
             const int FINAL = 100;

            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to the Snake & Ladder Game");
                Console.WriteLine("Start The Game");

                int F_PLYR_Postion = 0;//Taking position variable for starting position and assign it zero
                int S_PLYR_Postion = 0;//Taking position variable for starting position and assign it zero

               // int count = 0;
                Console.WriteLine("Postion assign from 0");

                while (F_PLYR_Postion <= FINAL && S_PLYR_Postion <= FINAL)
                {
                    //Taking die variable for dice number by using random
                    Random F_die = new Random();
                    Random S_die = new Random();
                    int F_Player_Die = die.Next(1, 7);  //simulating dice throw
                    int S_Player_Die = die.Next(1, 7);
                    Console.WriteLine($"Dice Thrown --> First Playe - {F_Player_Die} + Second Player - {S_Player_Die}");
                    //count++;

                    //Taking die variable for dice number by using rando
                    Random opt = new Random();
                    int option = opt.Next(0, 3);

                     if (option == NO_PLAY)
                     {
                         Console.WriteLine($"No play You are in same position == {F_PLYR_Postion}");
                         Console.WriteLine($"No play You are in same position == {S_PLYR_Postion}");
                     }
                     else if (option == LADDER)
                     {
                         F_PLYR_Postion += F_Player_Die;
                         S_PLYR_Postion += S_Player_Die;
                     
                         if (F_PLYR_Postion > 100 && S_PLYR_Postion)
                         {
                             F_PLYR_Postion -= F_Player_Die;
                             S_PLYR_Postion -= S_Player_Die;
                         }
                         Console.WriteLine($"Ladder The new status of the player = +{F_PLYR_Postion}");
                         Console.WriteLine($"Ladder The new status of the player = +{S_PLYR_Postion}");
                     }
                     
                     else
                     {
                         F_PLYR_Postion -= F_Player_Die;
                         S_PLYR_Postion -= S_Player_Die;
                         if (F_PLYR_Postion < 0 && S_PLYR_Postion < 0)
                         {
                             F_PLYR_Postion = 0;
                             S_PLYR_Postion = 0;
                         }
                         Console.WriteLine($"Ladder The new status of the player = -{F_PLYR_Postion}");
                         Console.WriteLine($"Ladder The new status of the player = -{S_PLYR_Postion}");
                     }
                         //Console.WriteLine($"Total Count Dice= {count}");
             