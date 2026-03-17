// Ammon Whitaker 3/17/26 Lab #8 maze game

Console.Clear();

Screen grid = new(29, 6);
MovableEntity player = new(0, 0, '@', grid);


grid.PrintScreen();
while (true)
{
    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        int deltaX = 0;
        int deltaY = 0;

        switch (keyInfo.Key)
        {
            case ConsoleKey.W:
                deltaY = -1;
                break;
            case ConsoleKey.S:
                deltaY = 1;
                break;
            case ConsoleKey.A:
                deltaX = -1;
                break;
            case ConsoleKey.D:
                deltaX = 1;
                break;
        }

        if (player.Move(deltaX, deltaY))
        {
            Console.SetCursorPosition(0, grid.Height + 1);
            Console.WriteLine("Congratulations! You've reached the goal!");
            break;
        }
        grid.PrintScreen();
    }
}