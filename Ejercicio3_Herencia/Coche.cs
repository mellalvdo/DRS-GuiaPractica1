namespace Ejercicio3_Herencia;

/// <summary>
/// Clase derivada que reutiliza el comportamiento de Vehiculo y agrega Conducir().
/// </summary>
public class Coche : Vehiculo
{
    public void Conducir()
    {
        Console.WriteLine("El coche está siendo conducido.");
    }
}
