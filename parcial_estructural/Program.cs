using System;

namespace parcial_estructural
{
    class Program
    {
        static void Main(string[] args)
        {
            const int est =2;
            int [] resultadobinario = new int[50];
            string linea;
            int x =0;
            int y = 0;
            Console.Write("Ingrese cualquier Numero:");
            linea = Console.ReadLine();
            int z = 0;
            int a = 0;
             x = int.Parse(linea);
            z = 1;
            while ((x >= est))
            {
                y = x % est;
                resultadobinario[z] = y;
                z = z + 1;
                x = x / est;
            }
            resultadobinario [z] = x;
            
            for (a = z; a >= 1;a += -1)
            {
                Console.Write(resultadobinario[a] + " ");
            }

            Console.Read();
        }
    }
}
