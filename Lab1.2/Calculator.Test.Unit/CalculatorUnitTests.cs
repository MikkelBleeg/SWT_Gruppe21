using System;
using Calculator;
using NUnit.Framework;


namespace Calculator.Test.Unit
{
    [TestFixture]
    [Author("Troels Jensen")] //Edited by Team ???
    public class CalculatorUnitTests
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        [TestCase(3, -2, 5)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyNunmbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }


        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
		[TestCase(9, 0.5, 3.0)]
        public void Power_RaiseNumbers_ResultIsCorrect(double x, double exp, double result)
        {
            Assert.That(_uut.Power(x, exp), Is.EqualTo(result));
        }

        [TestCase(2, 4, 0.5)]
        [TestCase(10, 2, 5)]
        [TestCase(2, -4, -0.5)]
        [TestCase(-2, -4, 0.5)]
        [TestCase(-2, 4, -0.5)]
        [TestCase(5, 0.5, 10)]
        [TestCase(10, 0.5, 20)]
        public void Divide_DivisorNotZero_ResultCorrect(double dividend, double divisor, double result)
        {
            Assert.That(_uut.Divide(dividend, divisor), Is.EqualTo(result));
        }

        [Test]
        public void Divide_DivideByZero_Throws_DivideByZeroException()
        {
            Assert.That(() => _uut.Divide(10, 0),
                Throws.TypeOf<DivideByZeroException>().With.Property("ErrorMsg").EqualTo("You can't divide by zero"));
        }

        [TestCase(10, 3, 1)]
        [TestCase(10, 9, 1)]
        [TestCase(-10, -3, -1)]
        [TestCase(10, -3, 1)]
        public void Modulus_ModulusBy_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Modulus(a, b), Is.EqualTo(result));
        }
        [Test]
        public void Modulus_DivideByZero_Throws_DivideByZeroException()
        {
            Assert.That(() => _uut.Modulus(10, 0),
                Throws.TypeOf<DivideByZeroException>().With.Property("ErrorMsg").EqualTo("You can't divide by zero"));
        }
    }
}
