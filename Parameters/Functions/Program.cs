//Exercise 1
//Try to simplify the following Code by creating a Function "RollDice".
//This Function should have a Parameter which specifies how many sides the dice has

Random rng = new Random();
int diceRoll = rng.Next(1,21);

void RollDice(int diceRoll)
{
    if(diceRoll >= 1 && diceRoll <= 7)
        Console.WriteLine("You rolled a 6-sided dice: " + diceRoll);
    else if(diceRoll >= 1 && diceRoll <= 9)
        Console.WriteLine("You rolled a 8-sided dice: " + diceRoll);
    else if (diceRoll >= 1 && diceRoll <= 11)
        Console.WriteLine("You rolled a 10-sided dice: " + diceRoll);
    else if (diceRoll >= 1 && diceRoll <= 21)
        Console.WriteLine("You rolled a 21-sided dice: " + diceRoll);
}

RollDice(diceRoll);
//Exercise 2
//Write a Function which can print string-arrays to the console.
//Use it to print both arrays.
string[] childrenList = new string[] { "Bob Jr.", "Lisa", "Minerva" };
string[] grownUpsList = new string[] { "Bob", "Annie", "Mary" };

void Print(string[] text)
{
    foreach(string item in text) Console.Write(item + "  ");
    Console.WriteLine();    
}

Print(childrenList);
Print(grownUpsList);

//Exercise 3
//Write a Greet-Function with two parameters: name, age
//The Function should greet the user in different ways based on their age:
//
//if age < 18: "Hey Timmy, how are you?"
//if age >= 18: "Hello Robert, how are you?"
//
//Bonus: Add an optional parameter for the Title.
//i.e.: Hello Dr. Robert, how are you?
string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

void Greet(string name, int age)
{
    if (age < 18)
        Console.WriteLine($"Hey {name}, how are you?");
    else
        Console.WriteLine($"Hello {name}, how are you?");
}

Greet(name, age);