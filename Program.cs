using heroes_and_monsters.Classes;
using heroes_and_monsters.Interfaces;

Console.WriteLine("*******************************************************************************");
Console.WriteLine("***************************** HEROES AND MONSTERS *****************************");
Console.WriteLine("*******************************************************************************");
Console.WriteLine();

IHero hero = null;
while (true)
{
	Console.WriteLine("Veuillez choisir une classe de personnage.\n");
	Console.WriteLine("1. Humain ( FOR+1 , END+1 )\n2. Nain ( END+2 )\n");

	char choice = Console.ReadKey().KeyChar;

	if(choice == '1')
	{
		hero = new Human();
		break;
	}
	else if(choice == '2') 
	{
		hero = new Dwarf();
        break;
    }

    Console.WriteLine("\nERREUR : Veuillez entrer un choix valide\n");
}

Console.WriteLine($"\n{hero}");

Console.WriteLine("\nLancez le dé pour définir votre FORCE.");
// TODO Lancer fonction qui défini la force

Console.WriteLine("\nLancez le dé pour définir votre ENDURANCE.");
// TODO Lancer fonction qui défini la endurance