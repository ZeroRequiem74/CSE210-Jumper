class Words
{
    private string RandomWord()
    {
        //array of words to randomly choose from.
        String[] words = new string[5] {"class", "semester", "computer", "engineering", "science"};
        Random rnd = new Random();
        //chooses random number between 0 and 4.
        int random = rnd.Next(0,5);
        //chooses the word set at random number in array and sends it out.
        string word = words[random];
        return word;
    }

    public List<char> WordList()
    {
        string word = RandomWord();
        //new List for letters in the word
        List<char> letters = new List<char>();

        //puts letters in the word into the list
        for (int i = 0; i < word.Length; i++)
        {
            letters.Add(word[i]);
        }

        return letters;
    }
    public bool DisplayWord(List<char> guesses, List<char> Word)
    {
        //to check if full word was found
        bool complete = false;
        int letters = 0;

        //goes through each letter of the word and sees if the letters were guessed
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
            //writes the letter if it was guessed else puts an underscore
            if (there)
            {
                Console.Write(Word[i]);

                //to check if all letters were found
                letters += 1;
            }
            else
            {
                Console.Write("_");
            }
        }
        Console.WriteLine("\n");

        //checks to see if all the letters were found
        if (letters == Word.Count)
        {
            complete = true;
        }
        return complete;
    }
}