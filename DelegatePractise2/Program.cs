namespace DelegatePractise2
{
    public delegate T OperationsDelegate<T>(T a, T b);

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate(5, 3, Add);
            Calculate(5, 3, Minus);
            Calculate(5, 3, Multiply);
        }

        static T Calculate<T>(T a, T b, OperationsDelegate<T> operation)
        {
            return operation(a, b);
        }

        static T Add<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }

        static T Minus<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x - y;
        }

        static T Multiply<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x * y;
        }
    }
}
