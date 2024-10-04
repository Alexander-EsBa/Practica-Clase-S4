using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Clase_S4
{
    internal class Ejercicio7
    {

        // Clase para representar un operario
        public class Operario
        {
            public string Nombre { get; set; }
            public decimal Sueldo { get; set; }

            public Operario(string nombre)
            {
                Nombre = nombre;
            }
        }

        // Método principal que guarda y muestra los sueldos
        public static void GuardarYSueldosOperarios()
        {
            Operario[] operarios = new Operario[5];  // Vector para almacenar los 5 operarios
            IngresarSueldos(operarios);
            MostrarSueldos(operarios);
        }

        // Método para ingresar los sueldos de los operarios
        private static void IngresarSueldos(Operario[] operarios)
        {
            for (int i = 0; i < operarios.Length; i++)
            {
                Console.Write($"Ingrese el nombre del operario {i + 1}: ");
                string nombre = Console.ReadLine();

                Console.Write($"Ingrese el sueldo de {nombre}: ");
                decimal sueldo = Convert.ToDecimal(Console.ReadLine());

                operarios[i] = new Operario(nombre) { Sueldo = sueldo };  // Asigna nombre y sueldo
            }
        }

        // Método para mostrar los sueldos de los operarios
        private static void MostrarSueldos(Operario[] operarios)
        {
            Console.WriteLine("\nLista de sueldos de los operarios:");
            foreach (Operario operario in operarios)
            {
                Console.WriteLine($"{operario.Nombre}: {operario.Sueldo:C}");  // Formato de moneda
            }
            Console.ReadKey();
        }
    }
}
