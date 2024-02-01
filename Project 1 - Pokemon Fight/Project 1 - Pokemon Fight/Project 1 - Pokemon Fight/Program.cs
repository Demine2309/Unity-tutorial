//1.
Console.Write("Enter Pokemon1 Name: ");
string pokemon1 = Console.ReadLine();
Console.Write("Enter Pokemon2 Name: ");
string pokemon2 = Console.ReadLine();

//2.
int hp1 = 100, hp2 = 100;

//3.
Random random = new Random();

int dmg1, dmg2;

//4.
dmg1 = random.Next(10, 20);
dmg2 = random.Next(10, 20);
Console.WriteLine($"{pokemon1} attacks {pokemon2} and deals {dmg1} damage");
Console.WriteLine($"{pokemon2} attacks {pokemon1} and deals {dmg2} damage");
hp1 -= dmg2;
hp2 -= dmg1;
Console.WriteLine($"{pokemon1}: {hp1}HP");
Console.WriteLine($"{pokemon2}: {hp2}HP");

dmg1 = random.Next(10, 20);
dmg2 = random.Next(10, 20);
Console.WriteLine($"{pokemon1} attacks {pokemon2} and deals {dmg1} damage");
Console.WriteLine($"{pokemon2} attacks {pokemon1} and deals {dmg2} damage");
hp1 -= dmg2;
hp2 -= dmg1;
Console.WriteLine($"{pokemon1}: {hp1 - dmg2}HP");
Console.WriteLine($"{pokemon2}: {hp2 - dmg1}HP");
