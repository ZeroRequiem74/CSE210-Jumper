class Player
{
    public List<char> Guess(List<char> guesses)
    {
        Console.Write("Guess a letter [a-z]: ");
        char guess = Console.ReadLine()[0];

        guesses.Add(guess);
        return guesses;
    }

    public int Turn(int turn)
    {
        return turn += 1;
    }

    public int Fails(int turn, int fails, List<char> word, List<char> guesses)
    {
        bool fail = true;
        for (int i = 0; i < word.Count; i++)
        {
            if (guesses[turn] == word[i])
            {
                fail = false;
            }
        }

        if (fail == true)
        {
            fails += 1;
        }
        return fails;
    }
}