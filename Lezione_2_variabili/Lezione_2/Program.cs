using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variabili numerici
            int variabile;

            //variabile stringa
            string parola;

            variabile = 10;

            parola = Console.ReadLine();
            Console.WriteLine( "Hai inserito la parola: " + parola);

            variabile = Convert.ToInt32(Console.ReadLine()); //int 32 bit
            Console.WriteLine("Hai inserito il numero: " + variabile);


            Console.ReadKey();

        }
    }
}
