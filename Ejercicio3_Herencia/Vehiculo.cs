namespace Ejercicio3_Herencia;

/// <summary>
/// Clase base que contiene comportamientos comunes de un vehículo.
/// </summary>
public class Vehiculo
{
    public void Arrancar()
    {
        Console.WriteLine("El vehículo ha arrancado.");
    }

    public void Detener()
    {
        Console.WriteLine("El vehículo se ha detenido.");
    }
}
