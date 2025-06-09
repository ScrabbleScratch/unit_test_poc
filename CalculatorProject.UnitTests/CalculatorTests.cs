namespace CalculatorProject.UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_WhenCalled_ReturnsSum()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Add(1, 2);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }
    }
}
