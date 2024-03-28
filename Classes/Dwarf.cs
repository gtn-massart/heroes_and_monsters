using heroes_and_monsters.Interfaces;

namespace heroes_and_monsters.Classes
{
    internal class Dwarf : Fighter, IHero
    {
        public int _stamina { get; set; }
        public int _strength { get; set; }
        public int _health { get; set; }

        public int Stamina
        {
            get
            {
                return _stamina;
            }
            set { }
        }
        public int Strength
        {
            get
            {
                return _strength;
            }
            set
            {

            }
        }
        public int Health { get { return _health; } set { } }
    

        public int GetStrength()
        {
            Dice dice = new Dice();
            int[] arr = new int[4];
            //int strength = 0;
            int temp;

            for (int i = 0; i <= 3; i++)
            {
                temp = dice.ThrowDice(dice.DiceSixFaces);
                arr[i] = temp;

                Console.Write($"{arr[i]} | ");
            }

            Array.Sort(arr);

            for (int i = 1; i < arr.Length; i++)
            {
                _strength += arr[i];
            }
            Console.WriteLine(_strength);
            return _strength;
        }

        public int GetStamina()
        {
            Dice dice = new Dice();
            int[] arr = new int[4];
            int temp;

            for (int i = 0; i <= 3; i++)
            {
                temp = dice.ThrowDice(dice.DiceSixFaces);
                arr[i] = temp;

                Console.Write($"{arr[i]} | ");
            }

            Array.Sort(arr);

            for (int i = 1; i < arr.Length; i++)
            {
                _stamina += arr[i];
            }
            Console.WriteLine(_stamina);
            return _stamina + 2;
        }

        public int GetHealth()
        {
            if (Stamina < 5)
            {
                return _health = Stamina - 1;
            }
            else if (Stamina >= 5 && Stamina < 10)
            {
                return _health = Stamina;
            }
            else if (Stamina >= 10 && Stamina < 15)
            {
                return _health = Stamina + 1;
            }
            else
            {
                return _health = Stamina + 2;
            }
        }
    }
}
