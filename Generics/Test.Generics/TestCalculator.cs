using Generics;

namespace Test.Generics;

public class CalculatorTest
{
    private readonly Calculator<int> _intCalculator;
    private readonly Calculator<double> _doubleCalculator;

    public CalculatorTest()
    {
        _intCalculator = new Calculator<int>();
        _doubleCalculator = new Calculator<double>();
    }


    [Fact]
    public void AddIntegers_ReturnCorrectResult()
    {
        int num1 = 1;
        int num2 = 2;

        int result = _intCalculator.Add(num1, num2);

        Assert.Equal(3, result);
    }

    [Fact]
    public void SubtractDouble_ReturnCorrectResult()
    {
        double num1 = 5.2;
        double num2 = 2;

        double result = _doubleCalculator.Subtract(num1, num2);

        Assert.Equal(3.2, result);
    }

    [Fact]
    public void MultiplyIntegers_ReturnCorrectResult()
    {
        int num1 = 5;
        int num2 = 10;

        int result = _intCalculator.Multiply(num1, num2);
        Assert.Equal(50, result);
    }

    [Fact]
    public void DivideIntegers_ByZero_ThrowsDivideZeroException()
    {
        int num1 = 5;
        int num2 = 0;

        Assert.Throws<DivideByZeroException>(() => _intCalculator.Divide(num1, num2)); 
    }

    [Fact]
    public void DivideDouble_ByZero_ThrowsDivideZeroException()
    {
        double num1 = 8.1;
        double num2 = 0;

        Assert.Throws<DivideByZeroException>(() => _doubleCalculator.Divide(num1, num2));
    }
}
