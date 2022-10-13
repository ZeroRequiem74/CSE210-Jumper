class Player
{
    public string Guess()
    {
        Console.Write("Guess a letter [a-z]: ");
        string guess = Console.ReadLine() ?? "";
        return guess;
    }
}