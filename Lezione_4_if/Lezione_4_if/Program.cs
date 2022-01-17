using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione_4_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;

            Console.WriteLine("Inserisci il primo numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("Il primo numero è maggiore del secondo numero.");
            }
            else if (numero1 == numero2) // == è uguale, = è assegnazione
            {
                Console.WriteLine("I dui numeri sono uguali.");
            }
            else
            {
                Console.WriteLine("Il secondo numero è maggiore del primo numero.");
            }

            Console.ReadKey();
        }
    }
}
