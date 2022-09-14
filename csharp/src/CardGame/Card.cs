using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.CardGame
{
    internal class Card : ICard
    {
        public Suit Suit { get; }

        public Value Value { get; }

        public bool Equals(ICard other)
        {
            return (this.Suit, this.Value) == (other.Suit, other.Value);
        }

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }
    }
}
