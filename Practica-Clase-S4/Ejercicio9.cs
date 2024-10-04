using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Clase_S4
{
    internal class Ejercicio9
    {
        // Método principal que organiza el ingreso y la suma de elementos
        public static void GestionarVector()
        {
            Console.Write("Ingrese la cantidad de elementos del vector: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] vector = new int[n];  // Crear el vector de n elementos
            IngresarElementos(vector);

            int sumaTotal = SumarElementos(vector);
            Console.WriteLine($"\nLa suma de todos los elementos del vector es: {sumaTotal}");
            Console.ReadKey();
        }

        // Método para ingresar los elementos del vector
        private static void IngresarElementos(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"Ingrese el elemento {i + 1}: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Método para sumar los elementos del vector
        private static int SumarElementos(int[] vector)
        {
            int suma = 0;
            foreach (int elemento in vector)
            {
                suma += elemento;  // Sumar cada elemento del vector
            }
            return suma;
        }
    }
}
