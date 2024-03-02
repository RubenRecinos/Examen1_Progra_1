using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Ejercicio 1 Factorial de Un Numero.");
            Console.WriteLine("2. Ejercicio 2 Calculos Matematicos.");
            Console.WriteLine("3. Ejercicio 3 Tabla de Multiplicar");
            Console.WriteLine("4. Ejercicio 4 Adivina el Numero Secreto");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción:");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Ejercicio1();
                    break;
                case "2":
                    Ejercicio2();
                    break;
                case "3":
                    Ejercicio3();
                    break;
                case "4":
                    Ejercicio4();
                    break;
                case "5":
                    Console.WriteLine("Cerrando el Programa");
                    return;
                default:
                    Console.WriteLine("Ingrese una Opcion Valida");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void Ejercicio1()
    {
        Console.WriteLine("\nEjercicio 1 Factorial de Un numero.\n");
        {
            Console.WriteLine("Ingrese un Numero");
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("El Factorial de " + num + " Es " + factorial);
            Console.ReadLine();
        }
    }

    static void Ejercicio2()
    {
        Console.WriteLine("\nEjercicio 2 Opciones Matematicas\n");
        {
            double num1, num2, resultado;
            int opciones;

            do
            {
                Console.WriteLine("Seleccione una Opcion");
                Console.WriteLine("1. Suma.");
                Console.WriteLine("2. Resta.");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir.");
                Console.WriteLine("5. Salir.");
                opciones = int.Parse(Console.ReadLine());

                switch (opciones)
                {
                    case 1:
                        Console.WriteLine("Opcion Sumar");
                        Console.WriteLine("Ingrese el Primer Numero");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el Segundo Numero");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        resultado = num1 + num2;
                        Console.WriteLine("El Resultado de la Suma es:" + resultado);
                        break;

                    case 2:
                        Console.WriteLine("Opcion Restar");
                        Console.WriteLine("Ingrese el Primer Numero");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el Segundo Numero");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        resultado = num1 - num2;
                        Console.WriteLine("El Resultado de la Resta es:" + resultado);
                        break;

                    case 3:
                        Console.WriteLine("Opcion Multiplicar");
                        Console.WriteLine("Ingrese el Primer Numero");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el Segundo Numero");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        resultado = num1 * num2;
                        Console.WriteLine("El Resultado de la Multiplicacion es:" + resultado);
                        break;

                    case 4:
                        Console.WriteLine("Opcion Dividir");
                        Console.WriteLine("Ingrese el Primer Numero");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el Segundo Numero");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        resultado = num1 / num2;
                        Console.WriteLine("El Resultado de la Division es:" + resultado);
                        break;
                }

                Console.ReadLine();

            } while ((opciones > 0) && (opciones <= 4));
        }
    }

    static void Ejercicio3()
    {
        Console.WriteLine("\nEjercicio 3 Tablas Matematicas\n");
        Console.WriteLine("Ingrese un número para generar su tabla de multiplicar:");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Tabla de multiplicar del " + numero + ":");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine(numero + " x " + i + " = " + resultado);
        }

    }

    static void Ejercicio4()
    {
        Console.WriteLine("\nAdivina Adivinador un Numero del 1 al 100\n");
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);

            Console.WriteLine("Intenta Adivinar el Numero");
            Console.WriteLine("Pista: el Numero esta entre el 1 y el 100");

            int intentos = 0;
            int intentoUsuario;

            do
            {
                Console.Write("Introduce El Numero que Creas:");
                intentoUsuario = Convert.ToInt32(Console.ReadLine());
                intentos++;

                if (intentoUsuario < numeroSecreto)
                {
                    Console.WriteLine("El Numero es Mayor");
                }
                else if (intentoUsuario > numeroSecreto)
                {
                    Console.WriteLine("El Numero es Menor");
                }
                else
                {
                    Console.WriteLine("Has Encontrado el One Piece En: " + intentos + " intentos.");
                }


            } while (intentoUsuario != numeroSecreto);
        }

        Console.ReadLine();

    }
}
