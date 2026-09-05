using Ejercicio5_HerenciaMultinivel;

Console.WriteLine("=== EJERCICIO 5: HERENCIA MULTINIVEL ===\n");

Perro perro = new Perro();

// Alimentar() se hereda de Mamifero.
perro.Alimentar();

// HacerSonido() se define originalmente en Animal y se sobrescribe en Perro.
perro.HacerSonido();

Console.WriteLine("\nJerarquía utilizada: Animal -> Mamifero -> Perro");
