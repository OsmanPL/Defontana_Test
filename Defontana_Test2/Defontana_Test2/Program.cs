using System;

namespace Defontana_Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int v1 = 0, v2 = 0;

                Console.Write("Ingrese el Valor 1: ");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Ingrese el Valor 2: ");
                v2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int temp = 0;
                if (v1 >= v2)
                {
                    temp = v2;
                    v2 = v1;
                    v1 = temp;
                }
                String texto = "";
                for (int i = v1; i <= v2; i++)
                {
                    texto += Convert.ToString(i);
                }

                int cantidad = texto.Length - texto.Replace("1", "").Length;
                Console.WriteLine("Cantidad de 1's: " + cantidad);
                Console.Write("¿Quiere Continuar S/N?: ");
                if (Console.ReadLine().ToLower().Equals("n"))
                {
                    break;
                }
                Console.WriteLine();
            }
            
        }
    }
}
