using System;

namespace LabPractica4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random azar = new Random();
            int numero;
            int aleatorio = azar.Next(10, 40);
           
            int vidas = 3; 

            do{
                Console.WriteLine("Intenta adivinar el numero");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero == aleatorio){
                    Console.WriteLine("Correcto, acertaste");
                }
                else if (numero < aleatorio){
                    Console.WriteLine("intenta con un numero mas alto");
                    vidas--;
                }
                else if (numero > aleatorio){
                    Console.WriteLine("intenta con un numero mas bajo");
                    vidas--;
                }

            } while (numero != aleatorio && vidas > 0);
            
            


            
        }
    }
}
