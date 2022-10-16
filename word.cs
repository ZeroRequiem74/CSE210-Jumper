class Word
{
    public string RandomWord()
    {
        String[] words = new string[5] {"class", "semester", "computer", "engineering", "science"};
        Random rnd = new Random();
        int random = rnd.Next(1,6);
        string word = words[random];
        return word;
    }

    public List<char> WordList(string word)
    {
        List<char> letters = new List<char>();

        for (int i = 0; i < word.Length; i++)
        {
            letters.Add(word[i]);
        }

        return letters;
    }
    public bool DisplayWord(List<char> guesses, List<char> Word)
    {
        bool complete = false;
        int letters = 0;
        for (int i = 0; i < Word.Count; i++)
        {
            bool there = false;
            for (int j = 0; j < guesses.Count; j++)
            {
                if (guesses[j] == Word[i])
                {
                    there = true;
                }
            }
            if (there)
            {
                Console.Write(Word[i]);
                letters += 1;
            }
        }
        Console.WriteLine("\n");

        if (letters == Word.Count)
        {
            complete = true;
        }
        return complete;
    }
}