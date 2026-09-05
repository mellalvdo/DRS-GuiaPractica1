namespace Ejercicio4_Polimorfismo;

public class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El perro dice: ¡Guau!");
    }
}
