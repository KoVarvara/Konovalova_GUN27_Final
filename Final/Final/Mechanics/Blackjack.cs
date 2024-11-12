using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final.Items;

namespace Final.Mechanics
{
    public class Blackjack : CasinoGameBase
    {
        private List<Card> cards = new List<Card>();
        private Queue<Card> Deck = new Queue<Card>();
        private int _cardAmount;

        private void Shuffle() 
        {
            var rand = new Random();

            foreach (var c in cards)
            {
                List<Card> cards2 = new List<Card>();
                cards2.Insert(rand.Next(cards.Count), c);
                Deck.Enqueue(c);
            }
        }
        public Blackjack(int cardAmount) 
        {
            _cardAmount = cardAmount; 
        }
        public override void PlayGame() 
        {
            var playerCard1 = Deck.Dequeue();
            Console.WriteLine(playerCard1);
            var playerCard2 = Deck.Dequeue();
            Console.WriteLine(playerCard2);
            var computerCard1 = Deck.Dequeue();
            Console.WriteLine(computerCard1);
            var computeCard2 = Deck.Dequeue();
            Console.WriteLine(computeCard2);

        }
        protected override void FactoryMethod()
        {
      
            for (int i = 0; i <= _cardAmount; i++)
            {
                var rand = new Random();
                var newSuit = (Suits)rand.Next((int)Suits.clubs, (int)Suits.diamonds);
                var newCardValue = (CardValue)rand.Next((int)CardValue.Six, (int)CardValue.Ace);
                var newCard = new Card(newSuit, newCardValue);
                cards.Add(newCard);
            }

        }

    }
}
