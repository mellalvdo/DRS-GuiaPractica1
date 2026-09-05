namespace Ejercicio4_Polimorfismo;

/// <summary>
/// Clase base para demostrar polimorfismo mediante un método virtual.
/// </summary>
public class Animal
{
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido.");
    }
}
