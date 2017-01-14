using BlackJackGame.Models;
using Xunit;

namespace BlackJackGame.Tests.Models
{

    public class HandTest
    {
        private Hand _aHand;

        public HandTest()
        {
            _aHand = new Hand();
        }

        [Fact]
        public void NewHand_HasNoCards()
        {
            Assert.Equal(0, _aHand.NrOfCards);
        }

        [Fact]
        public void AddCard_EmptyHand_ResultsInHandWithOneCard()
        {
            _aHand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Four));
            Assert.Equal(1, _aHand.NrOfCards);


        }

        [Fact]
        public void AddCard_AHandWithCards_AddsACard()
        {
            _aHand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Four));
            _aHand.AddCard(new BlackJackCard(Suit.Diamonds, FaceValue.Four));
            Assert.Equal(2, _aHand.NrOfCards);
        }

        [Fact]
        public void TurnAllCardsFaceUp_TurnsAllCardsFaceUp()
        {
            BlackJackCard card = new BlackJackCard(Suit.Hearts, FaceValue.Ace);
            card.TurnCard();
            _aHand.AddCard(card);
            _aHand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Two));
            _aHand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Two));
            _aHand.TurnAllCardsFaceUp();
            foreach (BlackJackCard c in _aHand.Cards)
                Assert.True(c.FaceUp);
        }

        [Fact]
        public void Value_EmptyHand_IsZero()
        {
            Assert.Equal(0, _aHand.NrOfCards);
        }

        [Fact]
        public void Value_HandWith6and5_Is11()
        {
            //card1
            BlackJackCard card = new BlackJackCard(Suit.Clubs, FaceValue.Five);
            card.TurnCard();
            _aHand.AddCard(card);

            //card2
            card = new BlackJackCard(Suit.Clubs, FaceValue.Six);
            card.TurnCard();
            _aHand.AddCard(card);

            Assert.Equal(11, _aHand.CalculateValue());
        }

        [Fact]
        public void Value_HandWith5AndKing_Is15()
        {
            //card1
            BlackJackCard card = new BlackJackCard(Suit.Clubs, FaceValue.Five);
            card.TurnCard();
            _aHand.AddCard(card);

            //card2
            card = new BlackJackCard(Suit.Clubs, FaceValue.King);
            card.TurnCard();
            _aHand.AddCard(card);

            Assert.Equal(15, _aHand.CalculateValue());
        }

        [Fact]
        public void Value_HandWithCardsFacingDown_DoesNotAddValuesOfCardsFacingDown()
        {
            //card1
            BlackJackCard card = new BlackJackCard(Suit.Clubs, FaceValue.Five);
            card.TurnCard();
            _aHand.AddCard(card);

            //card2
            card = new BlackJackCard(Suit.Clubs, FaceValue.King);
            _aHand.AddCard(card);

            Assert.Equal(5, _aHand.CalculateValue());

        }

        [Fact]
        public void Value_HandWithAceAndNotExceeding21_TakesAceAs11()
        {
            BlackJackCard card = new BlackJackCard(Suit.Clubs, FaceValue.Ace);
            card.TurnCard();
            _aHand.AddCard(card);
            Assert.Equal(11, _aHand.CalculateValue());
        }

        [Fact]
        public void ValueHandWithAceAndExceeding21_TakesAceAs1()
        {
            _aHand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Ace));
            _aHand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Nine));
            _aHand.AddCard(new BlackJackCard(Suit.Diamonds, FaceValue.Nine));
            _aHand.TurnAllCardsFaceUp();

            Assert.Equal(19, _aHand.CalculateValue());



        }
    }
}
