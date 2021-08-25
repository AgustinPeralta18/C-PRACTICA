using System;

namespace Lab1Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAzar = DateTime.Now.Millisecond;
            int resultado = numAzar % 100 + 1;
            Console.WriteLine("El numero al azar es: ");
            Console.WriteLine(resultado);
        }
    }
}
