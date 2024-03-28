
using System.Net.WebSockets;

namespace heroes_and_monsters.Classes
{
    internal abstract class Fighter
    {
        // Attributs
        private int _stamina {  get; set; } 
        private int _strength { get; set; }
        private int _health { get; set; }
        private int _gold { get; set; }
        private int _leather { get; set; }

        // Props
        public int Stamina { get; private set; }
        public int Strength { get; private set; }
        public int Health { get; private set; }

        
        public virtual int GetStrength()
        {
            Dice dice = new Dice();
            int[] arr = new int[4];
            int temp;

            for(int  i = 0; i <= 3; i++)
            {
                temp = dice.ThrowDice(dice.DiceSixFaces);
                arr[i] = temp;

                Console.Write($"{arr[i]} | ");
            }

            Array.Sort(arr);

            for(int i = 1; i < arr.Length; i++)
            {
                _strength += arr[i];
            }
            Console.WriteLine(_strength);
            return _strength;
        }

        public virtual int GetStamina()
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
            return _stamina;
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
