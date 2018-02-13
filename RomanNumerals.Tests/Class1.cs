using NUnit.Framework;
using RomanNumerals.App;

namespace RomanNumerals.Tests
{
    [TestFixture]
    public class NumveralConversionTests
    {
        [Test]
        public void When_1_is_entered_the_conversion_is_I()
        {
            //Arrange
            var number = 1;
            var numberConverter = new NumberConverter(); 

            //Act
            var result = numberConverter.Parse(number); 

            //Assert
            Assert.AreEqual("I", result);
        }

        [Test]
        public void When_5_is_entered_the_conversion_is_V()
        {
            var number = 5;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("V", result);
        }

        [Test]
        public void When_9_is_entered_the_conversion_is_IX()
        {
            var number = 9;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("IX", result);
        }

        [Test]
        public void When_12_is_entered_the_conversion_is_XII()
        {
            var number = 12;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("XII", result);
        }

        [Test]
        public void When_16_is_entered_the_conversion_is_XVI()
        {
            var number = 16;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("XVI", result);
        }

        [Test]
        public void When_29_is_entered_the_conversion_is_XXIX()
        {
            var number = 29;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("XXIX", result);
        }

        [Test]
        public void When_44_is_entered_the_conversion_is_XLIV()
        {
            var number = 44;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("XLIV", result);
        }

        [Test]
        public void When_45_is_entered_the_conversion_is_XLV()
        {
            var number = 45;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("XLV", result);
        }

        [Test]
        public void When_68_is_entered_the_conversion_is_LXVIII()
        {
            var number = 68;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("LXVIII", result);
        }

        [Test]
        public void When_83_is_entered_the_conversion_is_LXXXIII()
        {
            var number = 83;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("LXXXIII", result);
        }

        [Test]
        public void When_97_is_entered_the_conversion_is_XCVII()
        {
            var number = 97;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("XCVII", result);
        }

        [Test]
        public void When_99_is_entered_the_conversion_is_XCIX()
        {
            var number = 99;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("XCIX", result);
        }

        [Test]
        public void When_500_is_entered_the_conversion_is_D()
        {
            var number = 500;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("D", result);
        }

        [Test]
        public void When_501_is_entered_the_conversion_is_DI()
        {
            var number = 501;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("DI", result);
        }

        [Test]
        public void When_649_is_entered_the_conversion_is_DCXLIX()
        {
            var number = 649;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("DCXLIX", result);
        }

        [Test]
        public void When_798_is_entered_the_conversion_is_DCCXCVIII()
        {
            var number = 798;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("DCCXCVIII", result);
        }

        [Test]
        public void When_891_is_entered_the_conversion_is_DCCCXCI()
        {
            var number = 891;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("DCCCXCI", result);
        }

        [Test]
        public void When_1000_is_entered_the_conversion_is_M()
        {
            var number = 1000;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("M", result);
        }

        [Test]
        public void When_1004_is_entered_the_conversion_is_MIV()
        {
            var number = 1004;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("MIV", result);
        }

        [Test]
        public void When_1006_is_entered_the_conversion_is_MVI()
        {
            var number = 1006;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("MVI", result);
        }

        [Test]
        public void When_1023_is_entered_the_conversion_is_MXXIII()
        {
            var number = 1023;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("MXXIII", result);
        }

        [Test]
        public void When_2014_is_entered_the_conversion_is_MMXIV()
        {
            var number = 2014;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("MMXIV", result);
        }

        [Test]
        public void When_3999_is_entered_the_conversion_is_MMMCMXCIX()
        {
            var number = 3999;
            var numberConverter = new NumberConverter();

            var result = numberConverter.Parse(number);

            Assert.AreEqual("MMMCMXCIX", result);
        }
    }
}
