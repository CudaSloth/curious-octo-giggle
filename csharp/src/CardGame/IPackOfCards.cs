using System.Collections.Generic;

namespace CodingChallenge.CardGame
{
    public interface IPackOfCards : IReadOnlyCollection<ICard>
    {
        void Shuffle();

        ICard TakeCardFromTopOfPack();
    }
}
