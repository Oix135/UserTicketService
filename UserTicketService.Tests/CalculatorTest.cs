using NUnit.Framework;

namespace UserTicketService.Tests
{
    public class CalculatorTest
    {
        [TestFixture]
        public class CalculatorTests
        {
            [Test]
            public void AdditionalMustReturnCorrectValue()
            {
                var calculatorTest = new Calculator();
                Assert.That(calculatorTest.Additional(10, 5), Is.EqualTo(15));
            }
            [Test]
            public void SubtractionMustReturnCorrectValue()
            {
                var calculatorTest = new Calculator();
                Assert.That(calculatorTest.Subtraction(10, 5), Is.EqualTo(5));
            }
            [Test]
            public void MiltiplicationMustReturnCorrectValue()
            {
                var calculatorTest = new Calculator();
                Assert.That(calculatorTest.Miltiplication(10, 5), Is.EqualTo(50));
            }
            [Test]
            public void DivisionMustReturnCorrectValue()
            {
                var calculatorTest = new Calculator();
                Assert.That(calculatorTest.Division(10, 5), Is.EqualTo(2));
            }
        }
    }
}
