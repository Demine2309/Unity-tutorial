﻿//A) Bugfixing
//Look at the following Code and check its output. 2+3 is normally not 23. Pretty strange right...
//Try to figure out why it happens and fix it

string num1 = "2";
int intNum1 = int.Parse(num1);
string num2 = "3";
int intNum2 = int.Parse(num2);
int sum = intNum1 + intNum2;
Console.WriteLine("A) " + sum);


//B) Simple Calculator
//The Player should be able to input two Values which are multiplied
//and then the result should be output

Console.WriteLine("Enter first Number");
int input1 = int.Parse(Console.ReadLine());//TODO: Player should be able to enter a number. Hint: you need to conert it! 
Console.WriteLine("Enter second Number");
int input2 = int.Parse(Console.ReadLine());//TODO: Player should be able to enter a number.
int result = input1 * input2;
Console.WriteLine("B) " + input1 + "*" + input2 + "=" + result);



//C) Random Damage
//Change the Code, so that the players deals
//between 10 and 15 damage to the enemy

int enemyHp = 100;
Random rng = new Random();
int dmg = rng.Next(10,15);
enemyHp -= dmg;
Console.WriteLine("C) You dealt " + dmg + " to the enemy. It now has " + enemyHp + "hp left.");