using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in ett heltal");
            string heltal = Console.ReadLine();
            for (int I = 0; I < heltal.Length; I++)
            {
                string tecken = heltal[I].ToString();
                int siffra = int.Parse(tecken);
                int printer = siffra + 1;
                if (siffra + 1 >= 10)
                    printer = siffra - 9;
                Console.Write(printer);
            }
        }
    }
}
