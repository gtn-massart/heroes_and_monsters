namespace heroes_and_monsters.Classes
{
    internal class Dice
    {
        Random rand = new Random();
        private int _diceSixFaces { get; } = 6;
        private int _diceFourFaces { get; } = 4;

        public int DiceSixFaces
        {
            get { return (_diceSixFaces + 1);}
        }
        public int DiceFourFaces
        {
            get { return (_diceFourFaces + 1); }
        }

        public int ThrowDice(int diceType)
        {
            return rand.Next(1, diceType);
        }
    }
}
