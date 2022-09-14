using System;
using NUnit.Framework;

namespace CodingChallenge.ReversingString.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestReverse_PassIfEqual()
        {
            //Arrange
            string source = "FooBazQux";
            string actual = "";
            string expected = "xuQzaBooF";

            //Act
            actual = StringUtilities.Reverse(source);

            //Assert
            Assert.AreEqual(expected, actual);

            //Verify
            Console.WriteLine("The string [{0}] reversed as [{1}] : expected[{2}]", source, actual, expected);
        }

        [Test]
        [TestCase("FooBazQux", "xuQzaBooF")]
        [TestCase("Hello Bar", "raB olleH")]
        [TestCase("AnyLengthOfStringOrNumber1001001", "1001001rebmuNrOgnirtSfOhtgneLynA")]
        public void TestReverseMultiParam_ShouldPassIfEqual(string source, string expected)
        {
            //Arrange
            string actual = "";

            //Act and Assert
            Assert.AreEqual(expected, actual = StringUtilities.Reverse(source));

            //Verify
            Console.WriteLine("The string [{0}] reversed as [{1}] : expected[{2}]", source, actual, expected);
        }
    }
}
