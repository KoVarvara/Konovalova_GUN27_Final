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

        private void Shuffle(Card card) //не очень поняла, как сюда передать из FactoryMethod карты - прямо целым списком List cards?
        {
            Deck.Enqueue(card);
        }
        public Blackjack(int cardAmount) //в тз сказано, принимает на вход число карт - число из List card? запуталась
        {

        }
        public override void PlayGame() //из тз не поняла назначение этого метода
        {

        }
        protected override void FactoryMethod()
        {
            var rand = new Random();
            var newSuit = rand.Next(1,4);   
            var newCardValue = rand.Next(6,11);     
            //var newCard = new Card(newSuit, newCardValue);  //*здесь ошибка, ругается на newCardValue - не могу понять, почему
            //cards.Add(newCard);
        }

    }
}
