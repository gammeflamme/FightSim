using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name of player 1 :");
            Fighter player1 = new Fighter();
            player1.name = Console.ReadLine();
            Console.WriteLine("enter name of player 2 :");
            Fighter player2 = new Fighter();
            player2.name = Console.ReadLine();



            while(player1.IsAlive() && player2.IsAlive())
            {
                player2.Hurt(player1.Attack());
                player1.Hurt(player2.Attack());


            }
            if (player1.IsAlive())
            {
                Console.WriteLine("Congrats " + player1.name);

            }
            else if (player2.IsAlive())
            {
                Console.WriteLine("Congrats " + player2.name);

            }
            else
            {
                Console.WriteLine("Good job you both died");

            }
        }
    }
}
