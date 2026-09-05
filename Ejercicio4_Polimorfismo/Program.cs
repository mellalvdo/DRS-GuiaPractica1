using System;

namespace Ejercicio4_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJERCICIO 4: POLIMORFISMO ===\n");

            // Las referencias son de tipo Animal, pero apuntan a objetos distintos.
            Animal animal1 = new Perro();
            Animal animal2 = new Gato();

            animal1.HacerSonido();
            animal2.HacerSonido();

            Console.WriteLine("\nRecorriendo diferentes animales mediante una referencia común:");

            Animal[] animales = { new Perro(), new Gato() };

            foreach (Animal animal in animales)
            {
                animal.HacerSonido();
            }
        }
    }
}
