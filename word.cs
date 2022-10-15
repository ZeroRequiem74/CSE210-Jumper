class Word
{
    public string RandomWord()
    {
        string word = "class";
        return word;
    }

    public Array WordArray(string word)
    {
        char[] letters = new char[word.Length];

        for (int i = 0; i < word.Length; i++)
        {
            letters[i] = word[i];
        }

        return letters;
    }
}