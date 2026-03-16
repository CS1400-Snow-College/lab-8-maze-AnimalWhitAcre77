using System.IO;

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
        for (int y=0; y<Height; y++)
        {
            for (int x=0; x<Width; x++)
            {
                Console.Write(Map[x, y]);
            }
            Console.WriteLine();
        }
    }
}