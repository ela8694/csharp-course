using Generics;

namespace Test.Generics
{
    public class TestPrinter
    {
        // TODO: Add more tests for Printer
        [Fact]
        public void PrintItem_ShouldReturn()
        {
            var printer = new Printer();
            var output = new StringWriter();
            Console.SetOut(output);

            var date = new DateTime(2024, 1, 1);
            printer.PrintItem(date);

            var result = output.ToString().Trim();

            Assert.Equal("1/1/2024 00:00:00", result);
        }

        [Fact]
        public void GetOrDefault_ShouldReturnDefaultIfNull()
        {
            var printer = new Printer();
            string result = printer.GetOrDefault<string>(null);
            Assert.Null(result);
        }

        [Fact]
        public void GetOrDefault_ShouldReturnGivenValue()
        {
            var printer = new Printer();
            int result = printer.GetOrDefault(10);
            Assert.Equal(10, result);
        }
    }
}
