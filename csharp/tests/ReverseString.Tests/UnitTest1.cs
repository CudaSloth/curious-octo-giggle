using System;
using NUnit.Framework;

namespace CodingChallenge.ReversingString.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            //Arrange
            string a = "FooBazQux";
            string answer = "";
            string expected = "xuQzaBooF";

            //Act
            answer = StringUtilities.Reverse(a);

            //Assert
            Assert.AreEqual(expected, answer);

            Console.WriteLine("The string [{0}] reversed as [{1}] : expected[{2}]", a, answer, expected);
        }
    }
}
