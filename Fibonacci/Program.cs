using System;

namespace _02exFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rij van Fibonnaci");
            Console.WriteLine("Geef het volgnummer op van het getal dat moet berekend worden");
            int volgnr = int.Parse(Console.ReadLine());
            Console.WriteLine("Het getal is {0}", BerekenFibonacciZonderArray(volgnr));
            Console.ReadLine();
        }

        private static int BerekenFibonacciZonderArray(int volgNummer)
        {
            int getal1 = 0;
            int getal2 = 1;
            int getal = 0;
            switch (volgNummer)
            {
                case 0:
                    getal = getal1;
                    break;
                case 1:
                    getal = getal2;
                    break;
                default:
                    {
                        for (int i = 3; i <= volgNummer; i++)
                        {
                            getal = getal1 + getal2;
                            getal1 = getal2;
                            getal2 = getal;
                        }
                        break;
                    }
            }
            return getal;
        }
    }
}
