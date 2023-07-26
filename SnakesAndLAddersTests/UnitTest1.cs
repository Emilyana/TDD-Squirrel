using FluentAssertions;

namespace SnakesAndLAddersTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }



        [TestCase(0,1,1)]
        [TestCase(0,3,3)]
        [TestCase(4,3,7)]
        [TestCase(14,3,17)]
        public void Move_Should_Return_ExpectedField(int position, int movement, int expected)
        {
            var result = Move(position, movement);
            result.Should().Be(expected);
        }

        public static int Move(int position, int movement)
        {
            return position + movement;
        }


        [Test]
        public void ThrowDie_Should_Return_IntInRange1To6()
        {
            var result = ThrowDie();
            result.Should().BeOfType(typeof(int));
            result.Should().BeInRange(1, 6);
        }

        private int ThrowDie()
        {
            return 1;
        }
    }
}