using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Items
{
    public struct Card
    {
        private readonly Suits _cardSuit { get; }
        private readonly CardValue _cardValue { get; }

        public Card (Suits suit, CardValue cardValue)
        {
            _cardSuit = suit;
            _cardValue = cardValue;
        }

    }
}
