using heroes_and_monsters.Interfaces;

namespace heroes_and_monsters.Classes
{
    internal class Dwarf : Fighter, IHero
    {
        public int _stamina { get; set; }
        public int _strength { get; set; }
        public int _health { get; set; }

        public int Stamina { get; private set; }
        public int Strength { get; private set; }
        public int Health
        {
            get
            {
                if (Stamina < 5)
                {
                    return _health = Stamina - 1;
                }
                else if (Stamina >= 5 && Stamina < 10)
                {
                    return _health = Stamina;
                }
                else if (Stamina >= 10 && Stamina < 10)
                {
                    return _health = Stamina + 1;
                }
                else
                {
                    return _health = Stamina + 2;
                }
            }

            private set
            {

            }
        }

        public int GetStrength()
        {
            Dice dice = new Dice();
            int[] arr = new int[4];
            //int strength = 0;
            int temp = 0;

            for (int i = 0; i <= 3; i++)
            {
                temp = dice.ThrowDice(dice.DiceSixFaces);
                arr[i] = temp;

                Console.Write($"{arr[i]} | ");
            }

            Array.Sort(arr);

            for (int i = 1; i < arr.Length; i++)
            {
                Strength += arr[i];
            }
            Console.WriteLine(Strength);
            return Strength;
        }

        public int GetStamina()
        {
            Dice dice = new Dice();
            int[] arr = new int[4];
            //int strength = 0;
            int temp = 0;

            for (int i = 0; i <= 3; i++)
            {
                temp = dice.ThrowDice(dice.DiceSixFaces);
                arr[i] = temp;

                Console.Write($"{arr[i]} | ");
            }

            Array.Sort(arr);

            for (int i = 1; i < arr.Length; i++)
            {
                Stamina += arr[i];
            }
            Console.WriteLine(Stamina);
            return Stamina;
        }
    }
}
