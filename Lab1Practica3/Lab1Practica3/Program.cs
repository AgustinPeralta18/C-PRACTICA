using System;

namespace Lab1Practica3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dado = new Random();
            int aleatorio1 = dado.Next(1, 11);
            int aleatorio2 = dado.Next(11, 21);
            Console.WriteLine("Los numeros aleatorios son: "+aleatorio1+" "+aleatorio2);
        }
    }
}
