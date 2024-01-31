using System;

//E) Regions
//Create a seperate Region for every Exercise in this Script.
#region MyRegion
//A) Combining strings
// Combine the two Variables firstName and lastname and save them into fullName.
// Hint: Don't forget the blank space between firstname and lastname
string firstName = "Robert";
string lastName = "Johansson";

string fullName = firstName + " " + lastName;//TODO
Console.WriteLine("A) " + fullName);




//B) Simplify Code
// Try to simplify the following codesnippets

int x = 5;
x += 2;

int y = 3;
y++;

int z = 2;
z *= 3;




//C) Using Braces
int hp = 100;
int armor = 3;
int damage = 10;
//Damage should be reduced by armor. So in this case the player should only receive 7 damage.
//However the math in this line is flawed.
//Try to fix it using Braces ( ).
hp = hp - (damage - armor);//TODO
Console.WriteLine("D) new HP: " + hp);




//D) Console.ReadLine()
//The player should be able to enter any word and the computer should then repeat the word which the player entered.

Console.WriteLine("D) Enter any word");
string input = Console.ReadLine();//TODO Read from the Console
Console.WriteLine(input);               //TODO: Print entered word again into the console

#endregion