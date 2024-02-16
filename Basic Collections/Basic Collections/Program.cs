#region Exercise 1
/*
 * a) Declare an Integer-Array which can contain 20 values. Then use a For-Loop to set all those values to random numbers between 1 and 100.
 * b) Do the same with an Integer-List.
 */
Random randomNumber = new Random();

// a)
int[] myArray = new int[20];

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = randomNumber.Next(1, 100);
}
foreach (int i in myArray)
{
    Console.Write(i + " ");
}

Console.WriteLine();

// b)
List<int> myList = new List<int>();
for (int i = 0; i < 20; i++)
{
    myList.Add(randomNumber.Next(1, 100));
}
foreach (int i in myList)
{
    Console.Write(i + " ");
}

Console.WriteLine();
#endregion

#region Exercise 2
/*
 * a) Declare a String-List and read Text from the console in an Endless-Loop.
 * Whenever the player enters something add it to the List.
 * b) When the player enters the string “stop” print every item in the list in the reversed order.
 * i.e. the player enters:
 * Bob
 * Cat
 * Monkey
 * Stop 
 * You program should output:
 * Monkey
 * Cat
 * Bob
 * c) In addition the Program should sort the List and output the sorted list too.
 */

// a)
List<string> stringList = new List<string>();
while (true)
{
    string input = Console.ReadLine();
    if (input == "stop")
    {
        stringList.Sort();

        foreach(string i in stringList)
        {
            Console.Write(i + " ");
        }
    }
    else
    {
        stringList.Add(input);
    }
}
#endregion