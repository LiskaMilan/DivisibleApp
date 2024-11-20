namespace DivisibleConsoleApp.Tests
{
    public class DivisibleTests
    {
        [Test]
        public void GetNumber_ReturnsFoo_DivisibleBy2()
        {
            // Arrange
            var input = 6;

            // Act
            var result = Program.GetOutput(input);

            // Assert
            Assert.AreEqual("foo", result);
        }

        [Test]
        public void GetNumber_ReturnsFoofuu_DivisibleBy4()
        {
            // Arrange
            var input = 4;

            // Act
            var result = Program.GetOutput(input);

            // Assert
            Assert.AreEqual("foofuu", result);
        }

        [Test]
        public void GetNumber_ReturnsNumber_NotDivisibleBy2or4()
        {
            var input = 7;

            // Act
            var result = Program.GetOutput(input);

            // Assert
            Assert.AreEqual("7", result);
        }
    }
}