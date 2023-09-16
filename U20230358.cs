using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine("Menú de Opciones:");
            Console.WriteLine("1. Calcular promedio de notas");
            Console.WriteLine("2. Identificar si un número es par o impar");
            Console.WriteLine("3. Listar números descendentes desde 100-90");
            Console.WriteLine("4. Imprimir apellidos en mayúscula y nombres en minúscula");
            Console.WriteLine("5. Calcular la edad a partir de la fecha de nacimiento");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CalcularPromedioNotas();
                    break;
                case 2:
                    IdentificarParImpar();
                    break;
                case 3:
                    ListarNumerosDescendentes();
                    break;
                case 4:
                    ImprimirNombresApellidos();
                    break;
                case 5:
                    CalcularEdad();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }

        static void CalcularPromedioNotas()
    {
        Console.Write("Ingrese la primera nota: ");
        double nota1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la tercera nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        double promedio = (nota1 + nota2 + nota3) / 3;

        if (promedio >= 6)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Aprobado");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Reprobado");
            Console.ResetColor();
        }
    }

    static void IdentificarParImpar()
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("El número es par.");
        }
        else
        {
            Console.WriteLine("El número es impar.");
        }
    }

    static void ListarNumerosDescendentes()
    {
        Console.WriteLine("Números descendentes desde 100-90:");
        for (int i = 100; i >= 90; i--)
        {
            Console.WriteLine(i);
        }
    }

    static void ImprimirNombresApellidos()
    {
        Console.Write("Ingrese el primer nombre: ");
        string primerNombre = Console.ReadLine();
        
        Console.Write("Ingrese el segundo nombre: ");
        string segundoNombre = Console.ReadLine();
        
        Console.Write("Ingrese el primer apellido: ");
        string primerApellido = Console.ReadLine();
        
        Console.Write("Ingrese el segundo apellido: ");
        string segundoApellido = Console.ReadLine();

        string apellidosMayuscula = (primerApellido + " " + segundoApellido).ToUpper();
        string nombresMinuscula = (primerNombre + " " + segundoNombre).ToLower();

        Console.WriteLine("Apellidos en mayúscula: " + apellidosMayuscula);
        Console.WriteLine("Nombres en minúscula: " + nombresMinuscula);
    }

    static void CalcularEdad()
    {
        Console.Write("Ingrese su fecha de nacimiento (AAAA-MM-DD): ");
        DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());
        DateTime fechaActual = DateTime.Now;

        int edad = fechaActual.Year - fechaNacimiento.Year;

        if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
        {
            edad--;
        }

        Console.WriteLine("Tienes " + edad + " años.");
    }
    }
    
}