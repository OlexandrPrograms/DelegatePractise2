namespace DelegatePractise2
{
    public delegate T OperationsDelegate<T>(T a, T b);

    internal class Program
    {
        static void Main(string[] args)
        {

            Func<int, int, int> Add = (a, b) => a + b;
            Func<int, int, int> Minus = (a, b) => a - b;
            Func<int, int, int> Multiply = (a, b) => a * b;

            Console.WriteLine(Add.Invoke(5, 3));
            Console.WriteLine(Minus.Invoke(5, 3));
            Console.WriteLine(Multiply.Invoke(5, 3));
        }
    }
}
