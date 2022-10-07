using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2_Roll_The_Die
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Position = 0;
            Console.WriteLine("WELCOME TO SNAKE AND LADDER PROGRAME");
            Console.WriteLine($"You are at Starting Position:: {Position}");

            //Roll_the_die_to_get_a_number
            Random random = new Random();
            int die = random.Next(1, 7);
            Console.WriteLine($"You are at Starting Position:: {die}");
            Console.ReadLine();
        }
    }
}
