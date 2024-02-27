//Catdungeon
Console.WriteLine(@"You find yourself in a damp cellar, the ground beneath you is cold and moist.
Beneath the flickering light of a lamp you can see a wooden chest and a wooden door.

a) Try to open the door
b) Try to open the chest");

string input = Console.ReadLine();

Console.Clear();
if (input == "a")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(@"As you try to open the door you break your wrist and die.

THE END.");
    Console.ForegroundColor = ConsoleColor.White;
}
else if (input == "b")
{
    Console.WriteLine(@"You open the chest and a sweet little kitten jumps out of it.
It has a key hanging around its neck and jumps into your lap.");

    Thread.Sleep(2000);
    Console.WriteLine(@"
 |\__/,|   (`\
 |_ _  |.--.) )
 ( T   )     /
(((^_(((/(((_/
");

    Console.WriteLine(@"
a) Pet the sweet kitten
b) Take the key from its necklace");

    input = Console.ReadLine();

    Console.Clear();
    if (input == "a")
    {
        Console.WriteLine(@"You pet the sweet kitten and it starts to purr.
You feel happy inside.Everything is fine.");
    }
    else if (input == "b")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@"You try to take the necklace from the kitten.
It scratches you and you die.");
        Console.ForegroundColor = ConsoleColor.White;
    }
}