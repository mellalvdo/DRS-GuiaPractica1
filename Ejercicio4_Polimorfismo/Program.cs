using Ejercicio4_Polimorfismo;

Console.WriteLine("=== EJERCICIO 4: POLIMORFISMO ===\n");

// Las variables son de tipo Animal, pero contienen objetos de clases derivadas.
Animal animal1 = new Perro();
Animal animal2 = new Gato();

animal1.HacerSonido();
animal2.HacerSonido();

Console.WriteLine("\nRecorriendo diferentes animales mediante la misma referencia base:");
Animal[] animales = { new Perro(), new Gato() };

foreach (Animal animal in animales)
{
    animal.HacerSonido();
}
