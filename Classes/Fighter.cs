
namespace heroes_and_monsters.Classes
{
    internal class Fighter
    {
        // Attributs
        private int _stamina {  get; set; } 
        private int _strength { get; set; }
        private int _health { get; set; }

        // Props
        public int Stamina 
        {
            get { return Stamina; }

            set 
            {
                try
                {
                    if (value < 0)
                    {
                        Stamina = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                
            } 
        
        }
    }
}
