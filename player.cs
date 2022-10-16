class Player
{
    public List<char> Guess(List<char> guesses)
    {
        //asks player to guess a letter
        Console.WriteLine("Guess a letter [a-z]: ");
        char guess = Console.ReadLine()[0];

        //puts guess into the guesses List and returns the List.
        guesses.Add(guess);
        return guesses;
    }

    public int Turn(int turn)
    {
        //keeps track of the turns
        return turn += 1;
    }

    public int Fails(int turn, int fails, List<char> word, List<char> guesses)
    {
        bool fail = true;

        //if the last guess was in the word it sets fail to false to indicate that it was not an incorrect guess
        for (int i = 0; i < word.Count; i++)
        {
            if (guesses[turn] == word[i])
            {
                fail = false;
            }
        }

        //if guess was incorrect it increases fail counter by one.
        if (fail == true)
        {
            fails += 1;
        }
        return fails;
    }
}