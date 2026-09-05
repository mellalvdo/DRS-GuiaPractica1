namespace Ejercicio2_Encapsulacion;

/// <summary>
/// Representa un empleado cuyos datos son controlados mediante propiedades.
/// </summary>
public class Empleado
{
    private string nombre = string.Empty;
    private int edad;

    public string Nombre
    {
        get => nombre;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("El nombre no puede estar vacío.");
                return;
            }

            nombre = value;
        }
    }

    public int Edad
    {
        get => edad;
        set
        {
            if (value <= 0 || value >= 100)
            {
                Console.WriteLine("La edad debe ser mayor que 0 y menor que 100.");
                return;
            }

            edad = value;
        }
    }

    public Empleado(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
}
