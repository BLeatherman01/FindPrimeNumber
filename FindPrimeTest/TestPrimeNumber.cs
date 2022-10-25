namespace FindPrimeTest
{
    public class TestPrimeNumber
    {
        [Theory]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(5, 11)]
        [InlineData(6, 13)]
        [InlineData(7, 17)]

        public void TestIfPrimeandLocation(int input, int expected)
        {
            //Arrange
            PrimeNumber fp = new PrimeNumber();

            //Act
            int actual = fp.GetPrime(input);

            //Asset
            Assert.Equal(expected, actual);
        }
    }
}
