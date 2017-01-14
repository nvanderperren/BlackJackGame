using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJackGame.Models
{
    public class BlackJackCard : Card
    {
        #region Properties

        public bool FaceUp { get; set; }

        public int Value => FaceUp ? Math.Min(10, (int) FaceValue) : 0;

        #endregion

        #region Constructors
        public BlackJackCard(Suit suit, FaceValue faceValue) : base(suit, faceValue)
        {
            FaceUp = false;
        }
        #endregion

        #region Methods
        public void TurnCard()
        {
            if (FaceUp)
            {
                FaceUp = false;
            }
            else
                FaceUp = true;
        } 
        #endregion
    }
}
