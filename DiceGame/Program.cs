using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat
            //mõlemad mängijad viskavad täringuid
            //programm kontrollib kumb mängija viskas rohkem
            //mängija, kes viskab rohkem ongi võitja
            //programm kuulutab võitja

            Random rnd = new Random();

            string PlayerOne = "Caroly";
            string PlayerTwo = "Mirjam";

            int CarolyThrow = rnd.Next(1, 10);
            int MirjamThrow = rnd.Next(1, 10);

            Console.WriteLine($" {PlayerOne} threw {CarolyThrow};");
            Console.WriteLine($" {PlayerTwo} threw {MirjamThrow};");

            if (CarolyThrow > MirjamThrow)
            {
                Console.WriteLine($"{PlayerOne} wins");
            }
            else if (CarolyThrow < MirjamThrow)
            {
                Console.WriteLine($"{PlayerTwo} wins");
            }
            else
            {
                Console.WriteLine("Draw. lets them try again");
            }
        }
    }
}
