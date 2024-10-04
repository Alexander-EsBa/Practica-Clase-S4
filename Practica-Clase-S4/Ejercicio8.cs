using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Clase_S4
{
    internal class Ejercicio8
    {
        // Clase para representar un empleado
        public class Empleado
        {
            public string Nombre { get; set; }
            public decimal Sueldo { get; set; }

            public Empleado(string nombre)
            {
                Nombre = nombre;
            }
        }

        // Método principal que organiza el ingreso y la impresión de sueldos por turnos
        public static void GestionarSueldosEmpleados()
        {
            // Dos vectores para almacenar los empleados de cada turno
            Empleado[] turnoManana = new Empleado[4]; // 4 empleados para el turno de la mañana
            Empleado[] turnoTarde = new Empleado[4];  // 4 empleados para el turno de la tarde

            Console.WriteLine("Ingreso de sueldos para el turno de la mañana:");
            IngresarSueldos(turnoManana);

            Console.WriteLine("\nIngreso de sueldos para el turno de la tarde:");
            IngresarSueldos(turnoTarde);

            Console.WriteLine("\n--- Sueldos del turno de la mañana ---");
            MostrarSueldos(turnoManana);

            Console.WriteLine("\n--- Sueldos del turno de la tarde ---");
            MostrarSueldos(turnoTarde);
        }

        // Método para ingresar los sueldos de los empleados
        private static void IngresarSueldos(Empleado[] empleados)
        {
            for (int i = 0; i < empleados.Length; i++)
            {
                Console.Write($"Ingrese el nombre del empleado {i + 1}: ");
                string nombre = Console.ReadLine();

                Console.Write($"Ingrese el sueldo de {nombre}: ");
                decimal sueldo = Convert.ToDecimal(Console.ReadLine());

                empleados[i] = new Empleado(nombre) { Sueldo = sueldo };  // Asigna nombre y sueldo
            }
        }

        // Método para mostrar los sueldos de los empleados
        private static void MostrarSueldos(Empleado[] empleados)
        {
            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine($"{empleado.Nombre}: {empleado.Sueldo:C}");  // Formato de moneda
            }
            Console.ReadKey();
        }
    }
}
