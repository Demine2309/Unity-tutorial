//---------------------------------Exercise 1--------------------------------------

//Move these three lines into a Function called "GreetPlayer" and call it
void GreetPlayer()
{
    Console.WriteLine("Hello user!");
    Console.WriteLine("I am happy you are here, how can I help you?");
    Console.WriteLine("Are you in need of a hug?");
}

GreetPlayer();

//Move this Part into a Function called "CheckInput" and call it
void CheckInput(string i)
{
    if (i == "yes")
    {
        Console.WriteLine("Silly you, I am a computer, I can't hug you.");
    }
    else if (i == "no")
    {
        Console.WriteLine("Ok, your loss.");
    }
    else
    {
        Console.WriteLine("Command not recognized.");
    }
}

string input = Console.ReadLine();
CheckInput(input);

//----------------------------Exercise 2--------------------------------------------
//Implement the RandomWeatherReport-Function, so that the following code can run.
//RandomWeatherReport should print randomly one of the following lines: 
//  * Sunny outside
//  * Rain rain rain
//  * Thunderstorm
void RandomWeatherReport()
{
    Random random = new Random();
    int n = random.Next(1, 3);

    if (n == 1)
        Console.WriteLine("Sunny outside");
    else if (n == 2)
        Console.WriteLine("Rain rain rain");
    else if (n == 3)
        Console.WriteLine("Thunderstorm");
}


Console.WriteLine("And the Weatherforecast for today is:");
RandomWeatherReport();
Console.WriteLine("That is all");

