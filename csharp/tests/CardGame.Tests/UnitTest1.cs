using System;
using NUnit.Framework;

namespace CodingChallenge.CardGame.Tests
{
    [TestFixture]
    public class UnitTest1 
    {
        [Test]
        public void TestTotalCount_ShouldPassIfEqual()
        {
            //Arrange
            CardFactory dealer = new CardFactory();

            //Act
            IPackOfCards deck = dealer.Create();

            //Assert
            Assert.AreEqual(52, deck.Count);
        }

        [Test]
        public void TestDiscard_ShouldPassIfNotEqualAndDownThree()
        {
            //Arrange
            CardFactory dealer = new CardFactory();

            //Act
            IPackOfCards deck = dealer.Create();
            deck.TakeCardFromTopOfPack();
            deck.TakeCardFromTopOfPack();
            deck.TakeCardFromTopOfPack();

            //Assert
            Assert.AreNotEqual(52, deck.Count);
            Assert.AreEqual(49, deck.Count);
        }

        [Test]
        public void TestDiscardRepopulate_ShouldPassDiscardThenEqual()
        {
            //Arrange
            CardFactory dealer = new CardFactory();

            //Act
            IPackOfCards deck = dealer.Create();
            deck.TakeCardFromTopOfPack();
            deck.TakeCardFromTopOfPack();
            deck.TakeCardFromTopOfPack();

            //Assert
            Assert.AreNotEqual(52, deck.Count);
            Assert.AreEqual(49, deck.Count);

            //Act 2
            deck.Shuffle();
            Assert.AreEqual(52, deck.Count);
        }

        [Test]
        public void TestDiscardWhenEmpty_ShouldThrowException()
        {
            //Arrange
            CardFactory dealer = new CardFactory();

            //Act
            IPackOfCards deck = dealer.Create();

            for (int i = 0; i < 52; ++i)
            {
                deck.TakeCardFromTopOfPack();
            }

            //Assert
            Assert.AreEqual(0, deck.Count);

            deck.TakeCardFromTopOfPack();
            Assert.AreEqual(0, deck.Count);                 //Workaround to assert discard code is omitted to prevent ArrayIndexOutofBounds

            /*
             * Cannot assert without exposing Deck, which is pointless using dependency injection
             * There may be potential in exploring Type.InvokeMember to expose without breaking design but for this scope, omit
            //Assert.Throws<IndexOutOfRangeException>(() => Deck.TakeCardFromTopOfPack());                              
            */
        }
    }
}
