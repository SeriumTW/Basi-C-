using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1;
            float numero2;
            int somma;

            //numero con la virgola
            float risultato;
            float x;

            Console.WriteLine("Inserisci il primo numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32

            Console.WriteLine("Hai inserito correttamente il primo numero!");

            Console.WriteLine("Inserisci il secondo numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hai inserito correttamente il secondo numero numero!");

            risultato = numero1 + numero2;

            Console.WriteLine("La somma è: " + risultato);

            Console.WriteLine("Inseriscimi un numero con la virgola: ");
            x = Convert.ToSingle(Console.ReadLine()); //Convert.ToSingle:  ci da come risultato un float

            Console.WriteLine("Hai inserito: " + x);

            Console.ReadKey();

        }
    }
}
