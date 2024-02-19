#region Exercise 1: Micro Exercises
/*
 * Create the following Functions
 * a) MultiplyByTwo - Function
 * Create a function, which takes a float as a parameter. It should then multiply it by 2 and return the result of this calculation.
 * b) Square - Function
 * Create a function which takes a float as a parameter.
 * It should then square the parameter (calculate x times x) and return the result of this calculation.
 * c) IsNumInRange - Function
 * Create a Function that checks if a float is between two numbers.
 * i.e.
 * int num = 10;
 * //Checks if number is between 1 and 50
 * bool isInRange = IsNumInRange(num, 1, 50);
 */
// a)
int num = 14;
Console.WriteLine(MultiplyByTwo(num)); 
Console.WriteLine(Square(num));
Console.WriteLine(IsNumInRange(num, 1, 50));

float MultiplyByTwo(float num)
{
    return num * 2;
}
// b)
float Square(float num)
{
    return num * num;
}
// c)
bool IsNumInRange(float num, int a, int b)
{
    if (num >= a && num <= b)
        return true;
    else
        return false;
}
#endregion

#region Exercise 2: Number Guessing
/*
 * a) Guess numbers
 * Create a random number and let the player enter numbers in the console.
 * The player should be able to enter numbers until he finds the generated random number.
 * The Program should give the player a hint if his number was too low or too high
 * The Console-Output could look like this:
 * Guess the number I'm thinking of (1 to 10)
 * 1
 * Too low
 * 5
 * Too high
 * 4
 * Too high
 * 3
 * You Answer was correct
 * b) Determine Guess-Count
 * Put the code responsible for the whole game into a separate function. This function 
 * should then return the number of guesses it took the player to find the random number.
 * The game should be started like this:
 * int guessCount = GuessingGame();
 */
// a) 
Random random = new Random();
int targetNum = random.Next(1, 10);
bool isDone = false;
int guessCount = 0;

Console.WriteLine("Guess the number I'm thinking of (1 to 10)");

while (true && isDone == false)
{
    int inputNum = int.Parse(Console.ReadLine());
    GuessNumber(inputNum, targetNum);
    guessCount++;
}

Console.WriteLine(GuessingGame());

void GuessNumber(int inputNum, int targetNum)
{
    if (inputNum > targetNum)
    {
        Console.WriteLine("Too high");
    }
    else if (inputNum < targetNum)
        Console.WriteLine("Too low");
    else
    {
        Console.WriteLine("Your Answer was correct");
        isDone = true;
    }
}
// b)
int GuessingGame()
{
    return guessCount;
}
#endregion

#region Exercise 3: Working with Arrays
/*
 * Create an Array with 10 random numbers.
 * a) Calculate sum of an array
 * Create a function which can take a int-Array as parameter.
 * This function should then calculate the sum of all values within the array and return it.
 * The function should then be called like this:
 * int sum = SumOfArray(myIntArray);
 * b) Find highest value within array
 * Create another function which takes an array as a parameter. This function should find the highest value within the array and return it.
 * int highestValue = FindHighestValueOfArray(myIntArray);
 */
// a)
Random randomNum = new Random();

int[] myArray = new int[10];

for(int i = 0;i < myArray.Length; i++)
{
    myArray[i] = randomNum.Next(1, 10);
}

int SumOfArray(int[] array)
{
    int result = 0;
    foreach(int item in array)
    {
        result += item;
    }

    return result;
}

int FindHighestValueOfArray(int[] array)
{
    int highestValue = array[0];

    for(int i = 1; i < array.Length; i++)
    {
        if(highestValue < array[i])
        {
            highestValue = array[i];
        }
    }

    return highestValue;
}

int sum = SumOfArray(myArray);
Console.WriteLine(sum);
int highestValue = FindHighestValueOfArray(myArray);
Console.WriteLine(highestValue);

foreach(int i in myArray)
{
    Console.Write(i + "  ");
}
#endregion