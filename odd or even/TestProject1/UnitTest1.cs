using NUnit;
using odd_or_even;
namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void IsEven()
        {
            int number = 4;
            bool result = number%2 == 0;
            Assert.True(result);
        }

        [Test]
        public void IsOdd()
        {
            int number = 7;
            bool result = number % 2 == 0;
            Assert.False(result);
        }

        [Test]
        public void IsEven2()
        {
            int number = 56;
            bool result = number % 2 == 0;
            Assert.True(result);
        }

        [Test]
        public void IsOdd2()
        {
            int number = 77;
            bool result = number % 2 == 0;
            Assert.False(result);
        }
    }
}