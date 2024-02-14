//Exercise If-Statements

Console.WriteLine("-----------------1) Choose your Path -----------------");

Console.WriteLine("Where do you want to go?");
Console.WriteLine("a: Left into the spooky castle");
Console.WriteLine("b: Straight ahead into the spooky wood");
Console.WriteLine("c: Right into the Rainbow Wonderland");
string input1 = Console.ReadLine();
//a) React to Player-Input
//Create if-Statements that react to the users input.
//It could i.e. respond to decision a:
//"You went into the castle and got spooked by ghosts"
if (input1 == "a")
    Console.WriteLine("You went into the castle and got spooked by ghosts");


//b) Handle invalid input
//When the player enters anything different than a||b or c
//he should get the message: "Invalid input!"
if(input1 != "a" && input1 != "b" && input1 != "c")
    Console.WriteLine("Invalid input!");

Console.WriteLine("-----------------2) Find the Bug-----------------");
//Here we have a Damage-Calculation, where the player can be invulnerable
//If the player is invulnerable he should not receive any damage.
//Currently the player receives damage even if he is invulnerable. Find and fix the bug!

int playerHp = 100;
int damage = 10;

bool isPlayerInvulnerable = true;
bool playerHasArmor = false;

Console.WriteLine("Player HP before attack: " + playerHp);
if (isPlayerInvulnerable == true)
{
    Console.WriteLine("No damage received!");
}
else
{
    if (playerHasArmor == true)
    {
        playerHp -= damage / 2;
    }
    else if (playerHasArmor == false)
    {
        playerHp -= damage;
    }
}
Console.WriteLine("Player HP after attack: " + playerHp);



Console.WriteLine("-----------------3) Puzzle Game-----------------");

Console.WriteLine("Which position would you like to put the left lever into [up|down]");
string leftLeverState = Console.ReadLine();
Console.WriteLine("Which position would you like to put the center lever into [up|down]");
string centerLeverState = Console.ReadLine();
Console.WriteLine("Which position would you like to put the right lever into [up|down]");
string rightLeverState = Console.ReadLine();

//a) There is only one correct solution to the puzzle:
//Left Lever: up
//Center Lever: down
//Right Lever: up

//If the player sets the levers this way he should get the message:
//"The door that blocked your way opens. You are free to continue your adventure."
if(leftLeverState == "up" && rightLeverState == "up" && centerLeverState == "down")
{
    Console.WriteLine("The door that blocked your way opens. You are free to continue your adventure.");
}

//b) Dangerous Situations
//Left Lever: up
//Center Lever: down
//Right Lever: down

//Left Lever: down
//Center Lever: down
//Right Lever: up

//If the player sets the levers in one of these ways he should get the message:
//"Oh no! A trapdoor beneath you opens and you fall to your death :("
else if((leftLeverState == "up" && rightLeverState == "down" && centerLeverState == "down") || (leftLeverState == "down" && rightLeverState == "up" && centerLeverState == "down"))
{
    Console.WriteLine("Oh no! A trapdoor beneath you opens and you fall to your death :(");
}


//c) Handle remaining Situations
//If the player sets the levers in any other way, he should get the message:
//"Nothing happens"
else
{
    Console.WriteLine("Nothing happens");
}