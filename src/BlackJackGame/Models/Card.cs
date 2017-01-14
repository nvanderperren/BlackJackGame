namespace BlackJackGame.Models
{
    public class Card
    {
        #region Properties
        public FaceValue FaceValue { get; set; }
        public Suit Suit { get; set; }
        #endregion

        #region Constructors
        public Card(Suit suit, FaceValue faceValue)
        {
            Suit = suit;
            FaceValue = faceValue;
        } 
        #endregion
    }
}
