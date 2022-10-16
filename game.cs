class Game
{
    Parachute parachute = new Parachute();
    Word word = new Word();
    Player player = new Player();
    public void Play()
    {
        var stillAlive = true;
        var complete = false;
        List<char> guesses = new List<char>();
        List<char> letters = new List<char>();
        var Word = word.RandomWord();
        letters = word.WordList(Word);
        int lines = 4;
        int turn = 0;
        int fails = 0;
        while (stillAlive)
        {
            complete = word.DisplayWord(guesses, letters);
            parachute.DisplayMan(lines);
            guesses = player.Guess(guesses);
            fails = player.Fails(turn, fails, letters, guesses);
            turn = player.Turn(turn);


            stillAlive = parachute.StillAlive(fails, complete);
        }
    }

    
}