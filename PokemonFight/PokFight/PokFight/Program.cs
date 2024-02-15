Console.WriteLine("Enter the name of the first Pokemon");
string pok1Name = Console.ReadLine();
Console.WriteLine("Enter the name of the second Pokemon");
string pok2Name = Console.ReadLine();


int pok1Hp = 100; 
int pok2Hp = 100;

Random rng = new Random();
int pok1Dmg = 0; 
int pok2Dmg = 0;

#region Turn1
Console.WriteLine("------------Turn 1------------");
pok1Dmg = rng.Next(10,21);
pok2Dmg = rng.Next(10, 21);

Console.WriteLine(pok1Name + " attacks " + pok2Name + " and deals " + pok1Dmg + " damage");
Console.WriteLine(pok2Name + " attacks " + pok1Name + " and deals " + pok2Dmg + " damage");

pok1Hp -= pok2Dmg;
pok2Hp -= pok1Dmg;

Console.WriteLine(pok1Name + ": " + pok1Hp);
Console.WriteLine(pok2Name + ": " + pok2Hp);
#endregion

#region Turn2
Console.WriteLine("------------Turn 2------------");
pok1Dmg = rng.Next(10, 21);
pok2Dmg = rng.Next(10, 21);

Console.WriteLine(pok1Name + " attacks " + pok2Name + " and deals " + pok1Dmg + " damage");
Console.WriteLine(pok2Name + " attacks " + pok1Name + " and deals " + pok2Dmg + " damage");

pok1Hp -= pok2Dmg;
pok2Hp -= pok1Dmg;

Console.WriteLine(pok1Name + ": " + pok1Hp);
Console.WriteLine(pok2Name + ": " + pok2Hp);
#endregion

#region Turn3
Console.WriteLine("------------Turn 3------------");
pok1Dmg = rng.Next(10, 21);
pok2Dmg = rng.Next(10, 21);

Console.WriteLine(pok1Name + " attacks " + pok2Name + " and deals " + pok1Dmg + " damage");
Console.WriteLine(pok2Name + " attacks " + pok1Name + " and deals " + pok2Dmg + " damage");

pok1Hp -= pok2Dmg;
pok2Hp -= pok1Dmg;

Console.WriteLine(pok1Name + ": " + pok1Hp);
Console.WriteLine(pok2Name + ": " + pok2Hp);
#endregion