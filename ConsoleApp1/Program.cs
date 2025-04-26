using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ConsoleApp1;
namespace Cl;
class Program
{
    static void Main(string[] args)
    {
        double a, b;    
        Console.WriteLine("Bienvenido a la calculadora");
        Console.WriteLine("Ingrese el primer número:");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número:");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Seleccione la operación:");
        Console.WriteLine("samar restar multiplicar dividir");
        string operacion = Console.ReadLine();
        double resultado = 0;
        switch (operacion.ToLower())
        {
            case "sumar":
                Calculadora.Sumar(a, b);
                
                break;
            case "restar":
                Calculadora.Restar(a, b);
                break;
            case "multiplicar":
                Calculadora.Multiplicar(a, b);
                break;
            case "dividir":
                if (b == 0)
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                    return;
                }
                Calculadora.Dividir(a, b);  
                break;
            default:
                Console.WriteLine("Operación no válida.");
                return;
        }   

        Console.WriteLine($"El resultado de {operacion} {a} y {b} es: {resultado}");    
        Console.WriteLine("Presione cualquier tecla para salir...");
    }
}