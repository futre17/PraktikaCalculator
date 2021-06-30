using PraktikaCalculator;
using NUnit.Framework;

namespace PraktikaCalculator.Tests
{
    
    public class PLUSTests
    {

        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 7)]
        [TestCase(-7, -2, -9)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            //ARRANGE
            var calc = new PLUS();
           
            //ACT
            double actualResult = calc.Calculate(firstValue, secondValue);

            //ASSERT
            Assert.AreEqual(expected, actualResult);
        }
    }

    public class MINUSTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(4, 3, 1)]
        [TestCase(-7, -2, -5)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            //ARRANGE
            var calc = new MINUS();

            //ACT
            double actualResult = calc.Calculate(firstValue, secondValue);

            //ASSERT
            Assert.AreEqual(expected, actualResult);
        }
    }

    public class DIVITIONTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(4, 4, 1)]
        [TestCase(-8, -2, 4)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            //ARRANGE
            var calc = new DIVITION();

            //ACT
            double actualResult = calc.Calculate(firstValue, secondValue);

            //ASSERT
            Assert.AreEqual(expected, actualResult);
        }
    }

    public class MULTIPLYTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(4, 4, 16)]
        [TestCase(-8, -3, 24)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            //ARRANGE
            var calc = new MULTIPLY();

            //ACT
            double actualResult = calc.Calculate(firstValue, secondValue);

            //ASSERT
            Assert.AreEqual(expected, actualResult);
        }
    }

    public class TGTests
    {
        [TestCase(0, 0)]
        [TestCase(225, -2.53211499233434)]
        [TestCase(100, -0.587213915156929)]
        public void CalculateTest(double firstValue, double expected)
        {
            //ARRANGE
            var calc = new TG();

            //ACT
            double actualResult = calc.Calculate(firstValue);

            //ASSERT
            Assert.AreEqual(expected, actualResult);
        }
    }

    public class СTGTests
    {
        [TestCase(1, 0.642092615934331)]
        [TestCase(225, -0.394926771899133)]
        [TestCase(100, -1.70295691942647)]
        public void CalculateTest(double firstValue, double expected)
        {
            //ARRANGE
            var calc = new CTG();

            //ACT
            double actualResult = calc.Calculate(firstValue);

            //ASSERT
            Assert.AreEqual(expected, actualResult);
        }
    }
}
