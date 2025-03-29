namespace ArithmeticDemo.BasicMathOperations
{
    /// <summary>
    /// Proporciona operaciones de resta como parte de las funciones aritméticas básicas.
    /// </summary>
    public class Subtraction
    {
        /// <summary>
        /// Resta el segundo número entero del primero.
        /// </summary>
        /// <param name="a">El primer operando entero.</param>
        /// <param name="b">El segundo operando entero.</param>
        /// <returns>La diferencia entre los dos números.</returns>
        public static int SubtractionOperation(int a, int b)
        {
            int number1 = a;
            int number2 = b;
            int result = number1 - number2;
            return result;
        }
    }
}
