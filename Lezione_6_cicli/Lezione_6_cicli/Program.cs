using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione_6_cicli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ciclo ripetizione di istruzioni

            int numero;
            int i = 0;
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hai inserito il numero: " + numero);

            Console.WriteLine("I dieci numero successivi a  " + numero + " sono: ");
 
            // DO WHILE

            /*do
            {
                numero = numero + 1;
                Console.WriteLine(numero);
                i = i + 1;
            } while (i < 10);
            */


            //WHILE

            /*while (i < 10)
            {
                numero = numero + 1;
                Console.WriteLine(numero);
                i = i + 1;
            }*/

            //CICLO FOR

            for(i = 0; i < 20; i = i + 1)
            {
                numero = numero + 1;
                Console.WriteLine(numero);
            }


            Console.ReadKey();
        }
    }
}
