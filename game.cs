class Game
{
    Parachute parachute = new Parachute();
    Words words = new Words();
    Player player = new Player();
    public void Play()
    {
        //sets the game to continue until stillAlive is false
        var stillAlive = true;
        var complete = false;
        //creates new lists to be used latter.
        List<char> guesses = new List<char>();
        List<char> letters = new List<char>();
        //gets the random word and makes the letters into a list.
        var word = words.RandomWord();
        letters = words.WordList(word);
        //sets the initial values for game
        int turn = 0;
        int fails = 0;

        while (stillAlive)
        {
            //gets the number of lines left
            int lines = parachute.Lines(fails);
            //checks to see if word is complete and displays the guessed letters
            complete = words.DisplayWord(guesses, letters);
            //displays the man with the parachute
            parachute.DisplayMan(lines);
            //asks for the player's guess and adds to the guesses List
            guesses = player.Guess(guesses);
            //checks the fail counter
            fails = player.Fails(turn, fails, letters, guesses);
            //increases the turn counter 
            turn = player.Turn(turn);
            //checks if the parachute man is still alive
            stillAlive = parachute.StillAlive(fails, complete);
        }
    }

    
}