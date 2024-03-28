using heroes_and_monsters.Interfaces;

namespace heroes_and_monsters.Classes
{
    internal class Wolf : Fighter, IEnemy
    {
        public int _stamina { get; set; }
        public int _strength { get; set; }
        public int _health { get; set; }
    }
}
