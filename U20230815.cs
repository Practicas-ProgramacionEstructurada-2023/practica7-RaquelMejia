using System;

namespace MyApp// Note: actual namespace depends on the project name.\
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Variable boleana para poder hacer el ciclo con las opcionesjhjn
            bool salir = false;

            do
            {
                Console.WriteLine("\n**********************");
                Console.WriteLine("Menu de Opciones:");
                Console.WriteLine("1. Opcion 1: Suma de Numeros Pares e Impares en un Rango");
                Console.WriteLine("2. Opcion 2: Adivina el numero secreto (entre 1 y 10)");
                Console.WriteLine("3. Opcion 3: Tablas de multiplicar ");
                Console.WriteLine("4. Salir");
                Console.WriteLine("**********************");

                Console.Write("Seleccione una opcion: ");
                string? opcion =Convert.ToString(Console.ReadLine());

                switch (opcion)
                {
                    case "1":
                        NumeroParImpar();
                        break;
                    case "2":
                        NumeroSecreto();
                    break;

                    case "3":
                        TablaMultiplicar();
                    break;

                case "4":
                    Console.WriteLine("Saliendo del programa........");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opcion no valida. Intente de nuevo.");
                    break;    
                }

                Console.WriteLine(); //Salto de linea para separar las iteraciones del menu

            } while (!salir);
            Console.ReadLine();
        }// Fin main

        static void NumeroParImpar()
        {
             Console.WriteLine("\n****Suma de Numeros Pares e Impares en un Rango***\n");
                    Console.WriteLine("Ingrese un numero entero positivo: ");

                    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                    {
                        int sumaPares = 0;
                        int sumaImpares = 0;

                        for (int i = 1; i <= n; i++)
                        {
                            if (i % 2 == 0)
                            {
                                sumaPares += i; //Si es par, suma al acumulador de pares
                            }
                            else
                            {
                                sumaImpares += i; //Si es impar, suma al acumulador de impares
                            }
                        }

                        Console.WriteLine("\nLa suma de los numeros pares en el rango es: " + sumaPares);
                        Console.WriteLine("La suma de los numeros impares en el rango es: " + sumaImpares);
                    }

                    else
                    {
                        Console.WriteLine("Debe ingresar un numero entero positivo valido.");
                    }
        } //Fin de NumparImpar

        static void NumeroSecreto(){
            //se llama la funcion Random para que se pueda usar en los numeros secretos aleatoriamente
                    Random random = new();
                    //la variable numeroSecreto es igual a un rango del 1 al 11 porque en c# cuenta tambien el 0
                    int numeroSecreto = random.Next(1, 11);
                    int intentos = 0;
                    int intentoUsuario;

                    Console.WriteLine("\n****Adivina el numero secreto (entre 1 y 10)***");

                    while (true)
                    {
                        intentos++;

                        Console.Write("\nIngrese tu intento: ");
                        if (int.TryParse(Console.ReadLine(), out intentoUsuario) && intentoUsuario > 0 && intentoUsuario < 11)
                        {
                            if (intentoUsuario == numeroSecreto)
                            {
                                Console.WriteLine("¡Felicitaciones! Adivinaste el numero secreto el cual es " + numeroSecreto + " y fue adivinado en " + intentos + " intentos.");
                                break;
                            }
                            else 
                            {
                                Console.WriteLine("Intenta de nuevo.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ingresa un numero valido.");
                        }
                    } 
        } //Fin NumeroSecreto

        static void TablaMultiplicar()
        {
            Console.WriteLine("\n*****Tabla de multiplicar****");
            Console.WriteLine("\nIngresa un numero para ver su tabla de multiplicar: ");
            int numero;
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("\nTabla de multiplicar del " + numero + ":");
                
                //Utilizamos un bucle for para imprimir la tabla de multiplicar del numero ingresado
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    Console.WriteLine(numero + " x " + i + " = " + resultado);
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
            }
        } // Fin TablaMultiplicar

    }
}
