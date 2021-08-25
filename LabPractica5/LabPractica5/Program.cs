using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPractica5
{
    class Program
    {
        static void Main(string[] args){
            Random azar = new Random();
            int numero;
            int aleatorio = azar.Next(1, 10000);
            int vidas = 30;

            do
            {
                Console.WriteLine("Intenta adivinar el numero");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero == aleatorio)
                {
                    Console.WriteLine("Correcto, acertaste");
                }
                else if (numero < aleatorio)
                {
                    Console.WriteLine("intenta con un numero mas alto");
                    vidas--;
                }
                else if (numero > aleatorio)
                {
                    Console.WriteLine("intenta con un numero mas bajo");
                    vidas--;
                }

            } while (numero != aleatorio && vidas > 0);
        }
    }
}
