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
            for (int i = 0; i < 52; ++i)
            {
                if(i % 2 == 0)
                {
                    _buffer1.Add(_deck.ElementAt(i));
                    //Console.WriteLine("Even element added to Buffer1!   Card[{0}] DeckCount: {1}  Buffer1Count: {2}", _buffer1.ElementAt(_buffer1.Count - 1).ToString(), _deck.Count, _buffer1.Count);
                }
                if(i % 2 == 1)
                {
                    _buffer2.Add(_deck.ElementAt(i));
                    //Console.WriteLine("Odd element added to Buffer2!   Card[{0}] DeckCount: {1}  Buffer2Count: {2}", _buffer2.ElementAt(_buffer2.Count - 1).ToString(), _deck.Count, _buffer2.Count);
                }
            }
            _deck.Clear();

            /*Console.WriteLine("==========PRE SORT======================================================================");
            for(int i = 0; i < 26; ++i)
            {
                Console.WriteLine("Buffer1 at element [{0}] = {1}  Suit: {2}  Value: {3}", i, _buffer1.ElementAt(i).ToString(), _buffer1.ElementAt(i).Suit, _buffer1.ElementAt(i).Value);
            }
            for (int i = 0; i < 26; ++i)
            {
                Console.WriteLine("Buffer2 at element [{0}] = {1}  Suit: {2}  Value: {3}", i, _buffer2.ElementAt(i).ToString(), _buffer2.ElementAt(i).Suit, _buffer2.ElementAt(i).Value);
            }*/

            //Shuffle buffers
            for (int k = 0; k < 26; ++k)
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

            /*Console.WriteLine("==========POST SORT======================================================================");
            for (int i = 0; i < 26; ++i)
            {
                Console.WriteLine("Buffer1 at element [{0}] = {1}  Suit: {2}  Value: {3}", i, _buffer1.ElementAt(i).ToString(), _buffer1.ElementAt(i).Suit, _buffer1.ElementAt(i).Value);
            }
            for (int i = 0; i < 26; ++i)
            {
                Console.WriteLine("Buffer2 at element [{0}] = {1}  Suit: {2}  Value: {3}", i, _buffer2.ElementAt(i).ToString(), _buffer2.ElementAt(i).Suit, _buffer2.ElementAt(i).Value);
            }*/

            //Join deck
            for (int i = 0; i < 26; ++i)
            {
                _deck.Add(_buffer1.ElementAt(i));
            }
            for (int i = 0; i < _buffer2.Count; ++i)
            {
                _deck.Add(_buffer2.ElementAt(i));
            }
            _buffer1.Clear();
            _buffer2.Clear();

            //Last Shuffle
            for (int j = 0; j < 52; ++j)
            {
                int i = rnd.Next(_deck.Count);

                Card t = _deck.ElementAt(i);

                _deck.RemoveAt(i);

                _deck.Add(t);
            }

            /*Console.WriteLine("==========MAIN DECK POST SORT======================================================================");
            for (int i = 0; i < _deck.Count; ++i)
            {
                Console.WriteLine("DeckMain at element [{0}] = {1}  Suit: {2}  Value: {3}", i, _deck.ElementAt(i).ToString(), _deck.ElementAt(i).Suit, _deck.ElementAt(i).Value);
            }*/
        }

        public ICard TakeCardFromTopOfPack() => throw new NotImplementedException();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}
