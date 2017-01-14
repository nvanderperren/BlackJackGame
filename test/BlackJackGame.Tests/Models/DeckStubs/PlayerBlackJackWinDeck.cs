using System.Collections.Generic;
using BlackJackGame.Models;

namespace BlackJackGame.Tests.Models.DeckStubs
{
    public class PlayerBlackJackWinDeck : Deck
    {
        public PlayerBlackJackWinDeck()
        {
            _cards = new List<BlackJackCard>
            {
                //dealer                 
                new BlackJackCard(Suit.Clubs, FaceValue.Seven),
                new BlackJackCard(Suit.Clubs, FaceValue.Eight),
                
                //player                 
                new BlackJackCard(Suit.Clubs, FaceValue.Ace),
                new BlackJackCard(Suit.Clubs, FaceValue.Ten),

                //dealer                 
                new BlackJackCard(Suit.Hearts, FaceValue.Ten),
            };
        }
    }
}