namespace ArithmeticDemo.BasicMathOperations
{
    // Defines a contract for binary arithmetic operations.
    public interface IBinaryOperation
    {
        int Operate(int a, int b);
    }

    // Implements multiplication as a specific binary operation.
    public class Multiplication : IBinaryOperation
    {
        public int Operate(int a, int b)
        {
            return a * b;
        }
    }
}
