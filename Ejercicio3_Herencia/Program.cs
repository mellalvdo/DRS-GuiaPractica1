using System;

namespace Ejercicio3_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJERCICIO 3: HERENCIA SIMPLE ===\n");

            Coche miCoche = new Coche();

            // Arrancar() y Detener() se heredan de la clase Vehiculo.
            miCoche.Arrancar();
            miCoche.Conducir();
            miCoche.Detener();
        }
    }
}
