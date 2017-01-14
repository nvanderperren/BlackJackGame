using System;
using System.Collections.Generic;

namespace BlackJackGame.Models
{
    public class Hand
    {
        #region Fields
        private IList<BlackJackCard> _cards;
        #endregion

        #region Properties
        public int NrOfCards => _cards.Count;
        public int Value => CalculateValue();

        public IEnumerable<BlackJackCard> Cards => _cards;

        #endregion
        #region Constructors

        public Hand()
        {
            _cards = new List<BlackJackCard>();
        }

        #endregion
        #region Methods
        public void AddCard(BlackJackCard card)
        {
            _cards.Add(card);
        }

        public int CalculateValue()
        {
            int total = 0;
            bool ace = false;
            foreach (BlackJackCard c in _cards)
            {
                total += c.Value;
                if (c.FaceValue == FaceValue.Ace)
                    ace = true;
            }
            if (ace && (total + 10 <= 21))
                total += 10;
            return total;
        }

        public void TurnAllCardsFaceUp()
        {
            foreach (BlackJackCard c in _cards)
                if (!c.FaceUp)
                    c.TurnCard();
        }


        #endregion



    }

    

}
