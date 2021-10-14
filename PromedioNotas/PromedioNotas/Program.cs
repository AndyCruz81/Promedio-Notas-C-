using System;

namespace PromedioNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreEstudiante;
            int clases;

            Console.Write("Digite su nombre: ");
            nombreEstudiante = Console.ReadLine();

            Console.WriteLine($"{Environment.NewLine}{nombreEstudiante} ¿Cuántas clases llevas?");
            clases = Convert.ToInt32(Console.ReadLine());

            float[] notas = new float[clases];
            float suma = 0;
            float mayor = 0;

            for (int i=0; i< notas.Length; i++)
            {
                Console.Write($"Digite la nota para la clase {i + 1}: ");

                notas[i] = (float)Convert.ToDouble(Console.ReadLine());

                suma += notas[i];

                if (i == 0)
                {
                    mayor = notas[i];
                }
                else
                {
                    if (notas[i] > mayor)
                    {
                        mayor = notas[i];
                    }
                }
            }

            float promedio = suma / notas.Length;

            Console.WriteLine(Environment.NewLine + "Su promedio de notas es : " + promedio);
            Console.WriteLine($"Su nota más alta es {mayor}");

        }
    }
}
