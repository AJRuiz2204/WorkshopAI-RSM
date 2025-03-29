using System;

namespace ArithmeticDemo.BasicMathOperations
{
    /// <summary>
    /// Proporciona operaciones de división como parte de las funciones aritméticas básicas.
    /// </summary>
    public class Division
    {
        /// <summary>
        /// Divide el primer entero por el segundo.
        /// </summary>
        /// <param name="a">El primer operando entero.</param>
        /// <param name="b">El segundo operando entero.</param>
        /// <returns>El resultado de la división; si el divisor es cero, retorna double.NaN.</returns>
        public static double DivisionOperation(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: División por cero");
                return double.NaN;
            }
            return (double)a / b;
        }
    }
}
