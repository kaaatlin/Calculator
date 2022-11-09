using NUnit.Framework;

namespace Calculator.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Additional_Is_Right()
        {
            Calculator calcTest = new Calculator();
            Assert.That(calcTest.Additional(30,40), Is.EqualTo(70));
        }

        [Test]
        public void Substraction_Is_Right()
        {
            Calculator calcTest = new Calculator();
            Assert.That(calcTest.Subtraction(30, 40), Is.EqualTo(-10));
        }

        [Test]
        public void Miltiplication_Is_Right()
        {
            Calculator calcTest = new Calculator();
            Assert.True(calcTest.Miltiplication(0, 40) == 0);
        }

        [Test]
        public void Division_Is_Right()
        {
            Calculator calcTest = new Calculator();
            Assert.True(calcTest.Division(5, 5) == 1);
        }

        [Test]
        public void Division_Get_Exception()
        {
            Calculator calcTest = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calcTest.Division(5, 0));
        }

        [Test]
        public void DivisionGetExpectedValue()
        {
            Calculator divis = new Calculator();
            Assert.True(divis.Division(0, 5) == 0);
        }
    }
}