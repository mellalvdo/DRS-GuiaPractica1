namespace Ejercicio5_HerenciaMultinivel;

/// <summary>
/// Clase intermedia que hereda de Animal y agrega un comportamiento propio.
/// </summary>
public class Mamifero : Animal
{
    public void Alimentar()
    {
        Console.WriteLine("El mamífero está siendo alimentado.");
    }
}
