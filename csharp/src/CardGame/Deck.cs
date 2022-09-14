using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.CardGame
{
    public class Deck : IPackOfCards
    {
        private Card[] _deck = null;
        public int Count { get; }

        public Deck()
        {
            _deck = new Card[52];
        }

        public bool Populate()
        {
            int total_iter = 0;
            for(int suit_iter = 0; suit_iter < 4; ++suit_iter)
            {
                for(int val_iter = 0; val_iter < 13; ++val_iter)
                {
                    _deck[total_iter] = new Card((Suit)suit_iter, (Value)val_iter);
                    //Console.WriteLine("Card Added! Iterators - Suit: {0} Value: {1}", suit_iter, val_iter);
                    //Console.WriteLine("Literals - Card: {0} Suit: {1} Value: {2}", _deck[total_iter], _deck[total_iter].Suit.ToString(), _deck[total_iter].Value.ToString());
                    total_iter++;
                }
            }
            return true;
        }

        public IEnumerator<ICard> GetEnumerator()
        {
            foreach(Card c in _deck)
            {
                if(c == null)
                {
                    break;
                }
                yield return c;
            }
        }

        public void Shuffle() => throw new NotImplementedException();
        public ICard TakeCardFromTopOfPack() => throw new NotImplementedException();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}
