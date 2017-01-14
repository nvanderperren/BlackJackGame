using System.Collections.Generic;
using BlackJackGame.Models;

namespace BlackJackGame.Tests.Models.DeckStubs
{
    public class EqualValuesDeck : Deck
    {
        public EqualValuesDeck()
        {
            _cards = new List<BlackJackCard>
            {
                //dealer  
                new BlackJackCard(Suit.Clubs, FaceValue.Seven),
                new BlackJackCard(Suit.Clubs, FaceValue.Eight),

                //player                 
                new BlackJackCard(Suit.Hearts, FaceValue.Seven),
                new BlackJackCard(Suit.Hearts, FaceValue.Eight)

            };

        }
                       
       
    }
}