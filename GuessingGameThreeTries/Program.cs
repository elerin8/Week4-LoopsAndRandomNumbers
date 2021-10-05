using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis kasutaja on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei suutnud kolme katsega numbrit ära arvata, siis mängu võidab arvuti.
            //programm genereerib juhuslikku numbrit ainult üks kord. 

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Arva ära, mis number on :)");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if(userNumber == cpuNumber)
                {
                    Console.WriteLine("Oled mängu võitnud, palju õnne!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale number, jäänud on {3-i} katset");
                }
                if(i == 3)
                {
                    Console.WriteLine($"Oled mängu kaotanud.");
                }
                Console.WriteLine("Kena päeva!");
            }
        }
    }
}