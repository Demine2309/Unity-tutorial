
int playerXPos = 9;
int playerYPos = 9;

while (true)
{
    Console.Clear();
    for (int y = 0; y < 10; y++)
    {
        for (int x = 0; x < 10; x++)
        {
            if (x == playerXPos && y == playerYPos)
                Console.Write("☺");
            else
                Console.Write("_");
        }
        //Start new Line
        Console.WriteLine();
    }

    char input = Console.ReadKey().KeyChar;
    switch(input)
    {
        case 'a':
            playerXPos--;
            break;
        case 'd':
            playerXPos++;
            break;
        case 'w':
            playerYPos--;
            break;
        case 's':
            playerYPos++;
            break;
    }
}