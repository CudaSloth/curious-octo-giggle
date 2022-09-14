using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.CardGame
{
    public class CardFactory : IPackOfCardsCreator
    {
        public CardFactory()
        {

        }

        public IPackOfCards Create()
        {
            Deck local = new Deck();
            return local;
        }
    }
}
