namespace Ejercicio1_Abstraccion;

/// <summary>
/// Representa una cuenta bancaria y oculta el manejo interno del saldo.
/// </summary>
public class CuentaBancaria
{
    private decimal saldo;

    public CuentaBancaria(decimal saldoInicial = 0)
    {
        saldo = saldoInicial >= 0 ? saldoInicial : 0;
    }

    public void Depositar(decimal monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("El monto a depositar debe ser mayor que cero.");
            return;
        }

        saldo += monto;
        Console.WriteLine($"Depósito realizado: ${monto:F2}");
    }

    public void Retirar(decimal monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("El monto a retirar debe ser mayor que cero.");
            return;
        }

        if (monto > saldo)
        {
            Console.WriteLine("No se puede realizar el retiro: fondos insuficientes.");
            return;
        }

        saldo -= monto;
        Console.WriteLine($"Retiro realizado: ${monto:F2}");
    }

    public decimal ObtenerSaldo()
    {
        return saldo;
    }
}
