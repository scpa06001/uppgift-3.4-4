using System;

namespace uppgift_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in hur lång din låt är, skriv först hur många minuter och sekunder.");
            Console.WriteLine("Gränsen för din låt ska kunna vara  på radiostationen är att den ska vara under 4 min och 20 sek");           
            Console.WriteLine("Skriv i heltal");
            int minuter = int.Parse(Console.ReadLine()) * 60;
            Console.WriteLine("Skriv nu in sekunderna");
            int sekunder = int.Parse(Console.ReadLine());
            int gräns = 240 + 20;
            if (minuter + sekunder < 260)
            {
                Console.WriteLine("Din låt får vara med på radiostationen");
            }
            else
            {
                Console.WriteLine("Din låt får inte vara med på radiostationen, Den är för lång!");
            }
            Console.ReadKey();
        }
    }
}
