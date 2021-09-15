using System;

namespace RandomNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int RNG = rnd.Next(1, 11);//number 1 kuni 10

            Console.WriteLine($"Sinu juhuslik number on {RNG}");

            //programm kontrollib, kas genereeritud number on suurem kui 5
            //kui genereeritud number on suurem, kui 5, programm kuvab 
            //"juhuslik number on {myRandomNumber}, see on suurem kui 5"
            //kui genereeritud number on väiksem, kui 5, programm kuvab
            //"juhuslik number on {myRandomNumber}, see on väiksem kui 5"
            //kui genereeritud number on 5, programm kuvab
            //"juhuslik number on 5"

            if (RNG > 5)
            {
                Console.WriteLine($"Juhuslik number on {RNG} see on suurem kui 5");
            }
            else if (RNG < 5)
            {
                Console.WriteLine($"Juhuslik number on {RNG} see on väiksem kui 5");
            }
            else
            {
                Console.WriteLine("Juhuslik number on 5");
            }
        }
    }
}
