class Parachute
{
    public int Lines(int fails)
    {
        int lines = 4;
        lines -= fails;
        return lines;
    }

    public void DisplayMan(int lines)
    {
        if(lines > 3)
        {
            Console.WriteLine(" ___");
        }
        if(lines > 2)
        {
            Console.WriteLine("/___\\");
        }
        if(lines > 1)
        {
            Console.WriteLine("\\   /");
        }
        if(lines > 0)
        {
            Console.WriteLine(" \\ /");
            Console.WriteLine("  0");
            Console.WriteLine(" /|\\");
            Console.WriteLine(" / \\");
        }
        else
        {
            Console.WriteLine("  0");
            Console.WriteLine(" /|\\");
            Console.WriteLine(" / \\");
        }
    }
}