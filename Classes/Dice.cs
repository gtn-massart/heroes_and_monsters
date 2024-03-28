namespace heroes_and_monsters.Classes
{
    internal class Dice
    {
        Random rand = new Random();
        private int _diceSixFaces { get; }
        private int _diceFourFaces { get; }

        public int DiceSixFaces
        {
            get { return _diceSixFaces;}
        }

        public int ThrowDice(int diceType)
        {
            return rand.Next(1, diceType + 1);
        }
    }
}
