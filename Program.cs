using heroes_and_monsters.Classes;

Console.WriteLine("*******************************************************************************");
Console.WriteLine("***************************** HEROES AND MONSTERS *****************************");
Console.WriteLine("*******************************************************************************");
Console.WriteLine();

Console.WriteLine("Veuillez choisir une classe de personnage.\n");
Console.WriteLine("1. Humain ( FOR+1 , END+1 )\n2. Nain ( END+2 )\n");


Fighter Hero = new Human();

Console.WriteLine("Lancez le dé pour définir votre FORCE.");