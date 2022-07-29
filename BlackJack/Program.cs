public class BlackJack
{
    //This will be a simplified version of blackjack that only counts aces as 1s, and only keeps track of wins and losses.
    //You will also just try to get as close as possible to 21, while the computer does the same
    Random random;
   

    public BlackJack()
    {
        random = new Random();
    }

    /*
     * Generate a card number from 1-13
     * if the number is 10-13 change the value to 10
     * return the value of the card 
     */
    public int NewCard()
    {

    }

    /*
     * To Do- Write a method that continues to give the computer a new card until they are at or above 17. 
     * Return the final total of cards for the computer
     */
    public int ComputerRound()
    {
        
    }

    public int PlayerRound()
    {
        //Variable to save what the player decides
        string playerAnswer = "";

        //Get the player their first card
        int playerTotal = NewCard();

        //While the player does not answer stand (s) continue to do this code
        while(!playerAnswer.Equals("s"))
        {
            //Give the player a card and add it to their total
            playerTotal += NewCard();

            //Check to see if they busted
            if(playerTotal > 21)
            {
                //Tell the player they busted and answer "s" for them to finish their turn
                Console.WriteLine("Your total is " + playerTotal + ". You Bust.");
                playerAnswer = "s";
            }

            //if they did not bust,
            else
            {
                //Tell the player their new total and ask them if they would like to hit or stand. The way this is setup if they type anything but "s" it will be treated as though they typed "h"
                Console.WriteLine("Your total is " + playerTotal + ". Would you like to hit (h) or stand (s)?");
                playerAnswer = Console.ReadLine();
            }
        }

        //Once the player turn is done, return what the players final score is.
        return playerTotal;
    }

    /*
     * Checks the score between the player and computer to determine a winner. All outputs will either be "You Win", "You Lose", or "You Tie"
     * The player always loses if they are over 21. Otherwise the player with the higher score without going over 21 wins. If both scores are the same declare a tie.
     */
    public string Score(int player, int computer)
    {
        
    }

    static void Main(string[] args)
    {
        //Play infinate games
        while (true)
        {
            //Make a new blackjack game
            BlackJack jack = new BlackJack();
            
            //Player takes their turn to try and get the best score they can 
            int player = jack.PlayerRound();

            //Computer takes their turn to try and get the best score they can
            int computer = jack.ComputerRound();

            //Print the two scores and use the Score method to declare the outcome of the game.
            Console.WriteLine("You scored " + player + ", the computer scored " + computer + ".");
            Console.WriteLine(jack.Score(player, computer));
        }
    }
}
