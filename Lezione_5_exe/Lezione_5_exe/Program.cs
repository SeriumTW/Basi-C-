using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione_5_exe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Salvare il progetto in codice binario!

            int numero1;
            int numero2;

            Console.WriteLine("Inserisci primo numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci secondo numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if ( numero1 > numero2)
            {
                Console.WriteLine("Il primo numero è maggiore del secondo numero ");
            }
            else if ( numero1 == numero2)
            {
                Console.WriteLine("Sono uguali");
            }
            else 
            {
                Console.WriteLine("Il secondo numero è maggiore del primo numero ");
            }

            Console.ReadKey();
        }
    }
}
