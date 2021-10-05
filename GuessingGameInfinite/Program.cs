
using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis kasutaja on mängu võitnud;
            //katsete arv on piiramatu;
            //programm genereerib juhuslikku numbrit ainult üks kord. 


            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            bool loopActive = true;
            int i = 0;

            while (loopActive)
            {
               
                Console.WriteLine("Arva ära, mis number on :)");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Oled mängu võitnud, palju õnne!");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale number, arva uuesti.");
                    Console.WriteLine($"Oled valet numbrit pakkunud {i} korda.");

                }
            }

            Console.WriteLine("Kena päeva!");



        }
    }
}