using Ejercicio3_Herencia;

Console.WriteLine("=== EJERCICIO 3: HERENCIA SIMPLE ===\n");

Coche miCoche = new Coche();

// Los dos primeros métodos son heredados de Vehiculo.
miCoche.Arrancar();
miCoche.Conducir();
miCoche.Detener();
