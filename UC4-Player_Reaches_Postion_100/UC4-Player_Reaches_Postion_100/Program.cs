using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4_Player_Reaches_Postion_100
{
    internal class Program
    {
        //Constant
        const int NO_PLAY = 0;
        const int LADDER = 1;
        
       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake & Ladder Game");
            Console.WriteLine("Start The Game");

            int position = 0;//Taking position variable for starting position and assign it zero
            Console.WriteLine("Postion assign from 0");

            while (position <= 100)
            {
                //Taking die variable for dice number by using random
                Random die = new Random();
                int dice = die.Next(1, 7);  //simulating dice throw
                Console.WriteLine($"Dice Thrown -->  {dice}");

                //Taking die variable for dice number by using rando
                Random opt = new Random();
                int option = opt.Next(0,3);
                
               
                if (option == NO_PLAY)
                {

                    Console.WriteLine($"No play You are in same position == {position}");

                }
                else if (option == LADDER)
                {
                    position += dice;
                    Console.WriteLine($"Ladder The new status of the player = + {position}");
                }
                else 
                {
                    position -= dice;
                    if (position<0)
                        position = 0;
                    Console.WriteLine($"Snake The new status of the player = - {position}");
                }
               
            }
            Console.ReadLine();
    }   }
}
