using Ejercicio2_Encapsulacion;

Console.WriteLine("=== EJERCICIO 2: ENCAPSULACIÓN Y CONTROL DE ACCESO ===\n");

Empleado empleado = new Empleado("Carlos Hernández", 30);

Console.WriteLine($"Nombre: {empleado.Nombre}");
Console.WriteLine($"Edad: {empleado.Edad}");

Console.WriteLine("\nModificando la edad a un valor válido...");
empleado.Edad = 31;
Console.WriteLine($"Nueva edad: {empleado.Edad}");

Console.WriteLine("\nIntentando asignar una edad inválida...");
empleado.Edad = 120;
Console.WriteLine($"Edad después del intento: {empleado.Edad}");
