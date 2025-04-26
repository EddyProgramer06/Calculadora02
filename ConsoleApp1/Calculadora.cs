using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     public static class Calculadora
    {
        public static double Sumar(double a, double b)
        {
            return a + b;
        }
        public static double Restar(double a, double b)
        {
            return a - b;
        }
        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }
        public static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir entre cero.");
            }
            return a / b;
        }
    }
}
