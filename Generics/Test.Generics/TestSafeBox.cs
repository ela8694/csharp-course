using Generics;

namespace Test.Generics
{
    public class TestSafeBox
    {
        [Fact]
        public void SafeBox_ShouldReturnString()
        {
            SafeBox<string> safebox = new SafeBox<string>("test");
            Assert.Equal("test", safebox.Value);
        }

        [Fact]
        public void SafeBox_ShouldThrowIfNull()
        {
            Assert.Throws<ArgumentNullException>(() => new SafeBox<string>(null));
        }
    }
}
