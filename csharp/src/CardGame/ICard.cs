using System;

namespace CodingChallenge.CardGame
{
    public interface ICard : IEquatable<ICard>
    {
        Suit Suit { get; }

        Value Value { get; }
    }
}
