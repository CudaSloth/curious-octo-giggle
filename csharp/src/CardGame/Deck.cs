using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.CardGame
{
    internal class Deck : IPackOfCards
    {
        private List<Card> _deck = null;
        public int Count { get { return _deck.Count; } }

        public Deck()
        {
            _deck = new List<Card>();
        }

        public bool Populate()
        {
            int total_iter = 0;
            for(int suit_iter = 0; suit_iter < 4; ++suit_iter)
            {
                for(int val_iter = 0; val_iter < 13; ++val_iter)
                {
                    _deck.Add(new Card((Suit)suit_iter, (Value)val_iter));
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

        public void Shuffle()
        {
            List<Card> _buffer1 = new List<Card>();
            List<Card> _buffer2 = new List<Card>();
            Random rnd = new Random();

            //Split deck
            foreach(Card c in _deck)
            {
                if(_deck.Count % 2 == 0)
                {
                    _buffer1.Add(c);
                    _deck.Remove(c);
                }
                else
                {
                    _buffer2.Add(c);
                    _deck.Remove(c);
                }
            }

            //Shuffle buffers
            foreach(Card c in _buffer1)
            {
                int i = rnd.Next(_buffer1.Count);
                int j = rnd.Next(_buffer2.Count);

                Card t = _buffer1.ElementAt(i);
                Card t1 = _buffer2.ElementAt(j);

                _buffer1.RemoveAt(i);
                _buffer2.RemoveAt(j);

                _buffer1.Add(t);
                _buffer2.Add(t1);
            }

            //Join deck
            foreach (Card c in _buffer1)
            {
                _deck.Add(c);
                _buffer1.Remove(c);
            }
            foreach (Card c in _buffer2)
            {
                _deck.Add(c);
                _buffer2.Remove(c);
            }

            //Last Shuffle
            foreach (Card c in _deck)
            {
                int i = rnd.Next(_deck.Count);

                Card t = _deck.ElementAt(i);

                _deck.RemoveAt(i);

                _deck.Add(t);
            }
        }

        public ICard TakeCardFromTopOfPack() => throw new NotImplementedException();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}
