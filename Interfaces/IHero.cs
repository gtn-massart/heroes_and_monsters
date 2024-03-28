
namespace heroes_and_monsters.Interfaces
{
    public interface IHero 
    {
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public int Health { get; set; }



        public int GetStrength();
        public int GetStamina();
        public int GetHealth();
    }


}
