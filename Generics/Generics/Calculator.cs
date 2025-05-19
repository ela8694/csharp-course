using System.Numerics;

namespace Generics
{
    public class Calculator<T> where T : INumber<T>
    {
        public T Add(T a, T b) => a + b;

        public T Subtract(T a, T b) => a - b;

        public T Multiply(T a, T b) => a * b;

        public T Divide(T a, T b) => b != T.Zero ? a / b : throw new DivideByZeroException();
    }
}
