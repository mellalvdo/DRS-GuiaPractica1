# DRS - Guía Práctica 1

Universidad de El Salvador  
Ingeniería en Desarrollo de Software / Educación en Línea  
Asignatura: Desarrollo y Reutilización de Software  
Ciclo II/2026

## Pareja 17

| No. | Nombre completo | Correo institucional |
| ---: | --- | --- |
| 1 | Vilma Melissa Alvarado Parada | ap22024@ues.edu.sv |
| 2 | Lilian Sofia Tejada Villatoro | tv22008@ues.edu.sv |

## Descripción

Este repositorio contiene la solución de la Guía Práctica 1 sobre Programación Orientada a Objetos (POO) en C#. Los ejercicios demuestran los conceptos de abstracción, encapsulación, herencia y polimorfismo.

## Objetivo

Aplicar conceptos fundamentales de reutilización de software mediante Programación Orientada a Objetos, construyendo soluciones modulares, reutilizables y mantenibles.

## Ejercicios

1. **Abstracción de datos**: clase `CuentaBancaria` con saldo privado y operaciones controladas mediante métodos públicos.
2. **Encapsulación**: clase `Empleado` con atributos privados, propiedades y validación de datos.
3. **Herencia simple**: clases `Vehiculo` y `Coche`, donde `Coche` reutiliza los comportamientos definidos en `Vehiculo`.
4. **Polimorfismo**: clases `Animal`, `Perro` y `Gato`, utilizando sobrescritura de `HacerSonido()` y referencias de tipo `Animal`.
5. **Herencia multinivel**: jerarquía `Animal -> Mamifero -> Perro`, incluyendo métodos heredados y sobrescritos.

## Estructura del repositorio

```text
DRS-GuiaPractica1/
├── Ejercicio1_Abstraccion/
├── Ejercicio2_Encapsulacion/
├── Ejercicio3_Herencia/
├── Ejercicio4_Polimorfismo/
├── Ejercicio5_HerenciaMultinivel/
├── .gitignore
└── README.md
```

Cada ejercicio se encuentra en una carpeta independiente e incluye su archivo `.csproj`, las clases necesarias y un `Program.cs` para demostrar su funcionamiento.

## Requisitos

- .NET 8 SDK o una versión compatible.
- Visual Studio, Visual Studio Code, Rider o cualquier editor con soporte para C#.

## Ejecución

Cada ejercicio es un proyecto de consola independiente. Para ejecutar uno, se debe ingresar a su carpeta y utilizar `dotnet run`.

Ejemplo:

```bash
cd Ejercicio1_Abstraccion
dotnet run
```

Para ejecutar otro ejercicio, únicamente se cambia a la carpeta correspondiente.

## Conceptos de POO aplicados

### Abstracción

Permite ocultar los detalles internos de una clase y exponer únicamente las operaciones necesarias. En `CuentaBancaria`, el saldo no se modifica directamente desde fuera de la clase, sino mediante métodos como `Depositar()` y `Retirar()`.

### Encapsulación

Protege los datos de un objeto y controla cómo pueden ser consultados o modificados. En `Empleado`, los campos son privados y se accede a ellos mediante propiedades que aplican validaciones.

### Herencia

Permite crear nuevas clases a partir de clases existentes y reutilizar sus miembros. En el ejercicio 3, `Coche` hereda de `Vehiculo`; en el ejercicio 5 se utiliza una jerarquía de varios niveles.

### Polimorfismo

Permite trabajar con objetos de diferentes clases derivadas mediante una referencia común. En el ejercicio 4, una referencia de tipo `Animal` puede contener un `Perro` o un `Gato`, y cada objeto ejecuta su propia implementación de `HacerSonido()`.

## Conclusión

Los ejercicios muestran cómo los principios de Programación Orientada a Objetos facilitan la reutilización del software. El uso de clases, control de acceso, herencia y sobrescritura permite evitar duplicación de código y organizar responsabilidades de manera más clara, facilitando el mantenimiento y la extensión de los programas.
