using System.Collections.Generic;
using BlackJackGame.Models;

namespace BlackJackGame.Tests.Models.DeckStubs
{
    public class PlayerWinsDealerBurnsDeck : Deck
    {
        public PlayerWinsDealerBurnsDeck()
        {
            _cards = new List<BlackJackCard>
            {
                //dealer                 
                new BlackJackCard(Suit.Clubs, FaceValue.Seven),
                new BlackJackCard(Suit.Hearts, FaceValue.Seven),
                
                //player                 
                new BlackJackCard(Suit.Clubs, FaceValue.Nine),
                new BlackJackCard(Suit.Hearts, FaceValue.Nine),

                //dealer
                new BlackJackCard(Suit.Clubs, FaceValue.Ten)


            };
        }
    }
}