namespace Fundamentals.Tests
{
    public class AccessModifiersTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(1 == 1);
        }
        
        [Fact]
        public void Test2()
        {
            Assert.True(2 == 1);
        }
        
        [Fact]
        public void Test3()
        {
            var internalC = new Internal();
        }
    }
}