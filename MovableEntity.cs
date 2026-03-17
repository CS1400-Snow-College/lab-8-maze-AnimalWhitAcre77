public class MovableEntity
{
    public int X { get; set; }
    public int Y { get; set; }
    public char Symbol { get; set; }
    public Screen parentScreen { get; set; }

    public MovableEntity(int x, int y, char symbol, Screen screen)
    {
        X = x;
        Y = y;
        Symbol = symbol;
        parentScreen = screen;
        parentScreen.Map[X, Y] = Symbol; // Draw initial position
    }

    public bool Move(int deltaX, int deltaY)
    {
        int newX = X + deltaX;
        int newY = Y + deltaY;

        if (!parentScreen.isWall(newX, newY))
        {
            if (parentScreen.Map[newX, newY] == '*')
            {
                return true; // Goal reached
            }
            
            parentScreen.Map[X, Y] = ' '; // Clear old position
            X = newX;
            Y = newY;
            parentScreen.Map[X, Y] = Symbol; // Draw at new position
        }

        return false;
    }
}