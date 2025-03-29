namespace ArithmeticDemo.BasicMathOperations
{
    public interface IAdditionOperation
    {
        int Add(int a, int b);
    }

    public class Addition : IAdditionOperation
    {
        public int Add(int a, int b) => a + b;
    }
}
