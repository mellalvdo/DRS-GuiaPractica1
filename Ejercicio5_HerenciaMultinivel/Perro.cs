namespace Ejercicio5_HerenciaMultinivel;

/// <summary>
/// Clase derivada de Mamifero que sobrescribe el comportamiento definido en Animal.
/// </summary>
public class Perro : Mamifero
{
    public override void HacerSonido()
    {
        Console.WriteLine("El perro dice: ¡Guau!");
    }
}
