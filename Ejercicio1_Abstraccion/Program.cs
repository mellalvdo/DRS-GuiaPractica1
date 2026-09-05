using Ejercicio1_Abstraccion;

Console.WriteLine("=== EJERCICIO 1: ABSTRACCIÓN DE DATOS ===\n");

CuentaBancaria cuenta = new CuentaBancaria(500m);
Console.WriteLine($"Saldo inicial: ${cuenta.ObtenerSaldo():F2}");

cuenta.Depositar(250m);
Console.WriteLine($"Saldo después del depósito: ${cuenta.ObtenerSaldo():F2}");

cuenta.Retirar(100m);
Console.WriteLine($"Saldo después del retiro: ${cuenta.ObtenerSaldo():F2}");

Console.WriteLine("\nIntento de retiro mayor al saldo disponible:");
cuenta.Retirar(1000m);

Console.WriteLine($"\nSaldo final: ${cuenta.ObtenerSaldo():F2}");
