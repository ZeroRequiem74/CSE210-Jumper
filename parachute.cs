class Parachute
{
    public int Lines(int fails)
    {
        //initial count of four lines but one is subtracted for each fail.
        int lines = 4;
        lines -= fails;
        return lines;
    }

    public void DisplayMan(int lines)
    {
        //If no wrong guesses the top line is displayed
        if(lines > 3)
        {
            Console.WriteLine(" ___");
        }
        //If one or less wrong guesses the second line is displayed
        if(lines > 2)
        {
            Console.WriteLine("/___\\");
        }
        //If two or less wrong guesses the third line is displayed
        if(lines > 1)
        {
            Console.WriteLine("\\   /");
        }
        //If three or less wrong guesses the man is displayed
        if(lines > 0)
        {
            Console.WriteLine(" \\ /");
            Console.WriteLine("  0");
            Console.WriteLine(" /|\\");
            Console.WriteLine(" / \\");
            Console.WriteLine("\n");
            Console.WriteLine("^^^^^");
        }
        //If four wrong guesses the dead man is displayed
        else
        {
            Console.WriteLine("  X");
            Console.WriteLine(" /|\\");
            Console.WriteLine(" / \\");
            Console.WriteLine("^^^^^");
        }
    }

    public bool StillAlive(int fails, bool complete)
    {
        //If player makes 4 wrong guesses or completes the word game ends.
        bool stillAlive = true;
        if (fails == 4)
        {
            stillAlive = false;
        }
        if (complete)
        {
            stillAlive = false;
        }
        return stillAlive;
    }
}