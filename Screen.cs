public class Screen
{
    public int Width { get; set; }
    public int Height { get; set; }
    public char[,] Map { get; set; }

    public Screen(int width, int height)
    {
        Width = width;
        Height = height;
        
        Map = new char[Width, Height];

        string[] mapText = File.ReadAllLines("map.txt");
        for (int y=0; y<height; y++)
        {
            for (int x=0; x<width; x++)
            {
                Map[x, y] = mapText[y][x];
            }
        }
    }

    public void PrintScreen()
    {
        Console.SetCursorPosition(0, 0); // Overwrite instead of clear to avoid flickering

        for (int y=0; y<Height; y++)
        {
            for (int x=0; x<Width; x++)
            {
                Console.Write(Map[x, y]);
            }
            Console.WriteLine();
        }

        Console.CursorVisible = false; // hide cursor for better experience
    }

    public bool isWall(int x, int y)
    {
        if (x < 0 || x >= Width || y < 0 || y >= Height)
            return true; // Treat out of bounds as walls
        else
            return Map[x, y] == '#';
    }
}