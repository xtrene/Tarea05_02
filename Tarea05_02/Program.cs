using System;

namespace Tarea05_02
{
    class Program
    {
        static  Random alea = new Random();
         static public int generaNumero (int n1, int n2)
        {
            int resultado = alea.Next(n1, n2);
            return resultado;
        }

        static void Main(string[] args)
        {

            Console.Write("¿Cuántos números quieres generar? :");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[cantidad];

            for (int i=0; i < cantidad; i++)
            {
                Console.Write("Límite inferior para números aleatorios: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Límite superior para números aleatorios: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                numeros[i] = generaNumero(num1, num2);
                Console.WriteLine("Número generado correctamente...");


            }

            Console.WriteLine("_________________________________________________");
            Console.WriteLine("Números generados:");
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write(" "+ numeros[i] +" ");
            }

            Console.ReadKey();

        }
    }
}
