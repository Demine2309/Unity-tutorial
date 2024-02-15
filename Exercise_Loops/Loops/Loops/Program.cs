#region Exercise 1
/*
 * Print the numbers from 1 to 15 once with a while loop and then again with a for-loop.
 * Change the code, so that the loops instead of counting up from 1 to 15 they count down from 15 to 1.
 */
Console.WriteLine("Exercise 1:");
Console.WriteLine("With while-loop...");
int i = 1;
while (i <= 15)
{
    Console.Write(i + "  ");
    i++;
}
i--;
Console.WriteLine("\nAfter change below code...");
while (i > 0)
{
    Console.Write(i + "  ");
    i--;
}
Console.WriteLine("Finished");
Console.WriteLine("With for-loop...");
for(int j = 1; j <= 15; j++)
{
    Console.Write(j + "  ");
}
Console.WriteLine("\nAfter change below code...");
for(int j = 15; j > 0; j--)
{
    Console.Write(j + "  ");
}
Console.WriteLine("Finished");
#endregion

#region Exercise 2
/*
 * Create an endless-loop, in which the user is prompted to enter a Command. When the user enters “quit” the program should break out of
 * the loop. If the user enters anything else it should print “Unknow Command”
 */
while(true)
{
    string userCommand = Console.ReadLine();
    if (userCommand == "quit")
        break;
    else
    {
        Console.WriteLine("Unknow Command");
        
    }
}
#endregion

#region Exercise 3
/*
 * Create a hitpoint-Variable and set it to 100. Now create an endless-loop. 
 * Within this loop the user should be able to enter numbers. The hitpoint-Variable should be reduced by this number.
 * When the hitpoints reach 0 print the message “Player died” and exit the loop.
 */
int health = 100;
while (true)
{
    int damamge = int.Parse(Console.ReadLine()); 

    health = health - damamge;
    if(health > 0)
        Console.WriteLine(health);
    else
    {
        Console.WriteLine("Player died");
        break;
    }
}
#endregion