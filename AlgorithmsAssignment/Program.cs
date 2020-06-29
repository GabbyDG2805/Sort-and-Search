//CMP1127M Assessment 03
//by Gabriella Di Gregorio 15624188

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment03
{
    //Die Class contains a Method to generate a random number
    class Die
    {
        static Random r = new Random();

        public int Roll()
        {
            return r.Next(1, 6 + 1);
        }
    }
    //Player Class holds the name and score
    class Player
    {
        public string name;
        public int score = 0;
    }
    //Game Class contains most of program
    class Game
    {
        //two player objects created
        Player player1 = new Player();
        Player player2 = new Player();

        //die object created
        Die dice = new Die();

        //string created outside of methods so can be widely used
        public string playAgain;

        //Method created for assigning player names so that it can be called separately from the game-type methods
        public void Names()
        {
            Console.Write("\nPlease enter Player1's name: ");
            player1.name = Console.ReadLine();

            Console.Write("Please enter Player2's name: ");
            player2.name = Console.ReadLine();
        }

        //the two game types have been created as methods so they can be selected based on user input
        public void MatchPlay()
        {
            Console.WriteLine("First to 5!");

            //loops until a player score reaches 5
            do
            {
                Console.WriteLine("\n{0}, its your turn to roll.", player1.name);

                Console.WriteLine("\nFirst 3 die:");

                //list collection created to store the results of the dice rolls
                List<int> threeRolls = new List<int>();

                //this will loop through, allowing the player to roll 3 times, and display each roll
                for (int roll = 0; roll < 3; roll++)
                {

                    Console.WriteLine("{0}, press enter to roll your die.", player1.name);
                    Console.ReadKey();

                    threeRolls.Add(dice.Roll());
                    Console.WriteLine("You have rolled a {0}", threeRolls[roll]);

                }
                //converts list to an array
                int[] firstThree = threeRolls.ToArray();
                //sorts the array of rolled number from smallest to largest
                Array.Sort(firstThree);
                Console.WriteLine("Your highest number rolled in your first 3 was a {0}", firstThree[2]);

                Console.WriteLine("\nSecond two die:");

                //same again for the next two die
                List<int> twoRolls = new List<int>();

                for (int roll = 0; roll < 2; roll++)
                {

                    Console.WriteLine("{0}, press enter to roll your die.", player1.name);
                    Console.ReadKey();

                    twoRolls.Add(dice.Roll());
                    Console.WriteLine("You have rolled a {0}", twoRolls[roll]);

                }
                int[] secondTwo = twoRolls.ToArray();
                Array.Sort(secondTwo);
                Console.WriteLine("Your highest number rolled in your second two was a {0}", secondTwo[1]);

                Console.WriteLine("\nLast dice:");

                Console.WriteLine("{0}, press enter to roll your die.", player1.name);
                Console.ReadKey();

                //lists and arrays aren't necessary for the last dice, simply saves the result as an int
                int lastOne = dice.Roll();
                Console.WriteLine("You have rolled a {0}", lastOne);

                //the highest rolls are added and stored as an int for the round total
                int roundTotal = firstThree[2] + secondTwo[1] + lastOne;
                Console.WriteLine("\nYour total for this round is {0}", roundTotal);

                //same again for player 2
                Console.WriteLine("\n{0}, its your turn to roll.", player2.name);

                Console.WriteLine("\nFirst 3 die:");

                List<int> threeRolls2 = new List<int>();

                for (int roll = 0; roll < 3; roll++)
                {

                    Console.WriteLine("{0}, press enter to roll your die.", player2.name);
                    Console.ReadKey();

                    threeRolls2.Add(dice.Roll());
                    Console.WriteLine("You have rolled a {0}", threeRolls2[roll]);

                }
                int[] firstThree2 = threeRolls2.ToArray();
                Array.Sort(firstThree2);
                Console.WriteLine("Your highest number rolled in your first 3 was a {0}", firstThree2[2]);

                Console.WriteLine("\nSecond two die:");

                List<int> twoRolls2 = new List<int>();

                for (int roll = 0; roll < 2; roll++)
                {

                    Console.WriteLine("{0}, press enter to roll your die.", player2.name);
                    Console.ReadKey();

                    twoRolls2.Add(dice.Roll());
                    Console.WriteLine("You have rolled a {0}", twoRolls2[roll]);

                }
                int[] secondTwo2 = twoRolls2.ToArray();
                Array.Sort(secondTwo2);
                Console.WriteLine("Your highest number rolled in your second two was a {0}", secondTwo2[1]);

                Console.WriteLine("\nLast dice:");

                Console.WriteLine("{0}, press enter to roll your die.", player2.name);
                Console.ReadKey();

                int lastOne2 = dice.Roll();
                Console.WriteLine("You have rolled a {0}", lastOne2);

                int roundTotal2 = firstThree2[2] + secondTwo2[1] + lastOne2;
                Console.WriteLine("\nYour total for this round is {0}", roundTotal2);


                //decides round winner by comparing the round total, and updates the player score accordingly (each won round increases player score by 1)
                if (roundTotal > roundTotal2)
                {
                    player1.score++;
                    Console.WriteLine("\n{0} wins this round", player1.name);
                }
                if (roundTotal2 > roundTotal)
                {
                    player2.score++;
                    Console.WriteLine("\n{0} wins this round", player2.name);
                }
                else if (roundTotal == roundTotal2)
                {
                    player1.score++;
                    player2.score++;
                    Console.WriteLine("\nThis round was a draw.");
                }
                Console.WriteLine("\n{0}'s current score is: {1}", player1.name, player1.score);
                Console.WriteLine("{0}'s current score is: {1}", player2.name, player2.score);

            } while ((player1.score != 5) && (player2.score != 5));
            
            if(player1.score == 5)
            {
                Console.WriteLine("\nCongratulations {0}, you have won the game!", player1.name);
            }
            else if (player2.score == 5)
            {
                Console.WriteLine("\nCongratulations {0}, you have won the game!", player2.name);
            }

            //players have the option to play again after each game, error handled by repeating question until correct input given
            do
            {
                Console.Write("\nWould you to play again? (Y/N): ");
                playAgain = Console.ReadLine();

            } while ((playAgain != "Y") && (playAgain != "y") && (playAgain != "N") && (playAgain != "n"));
        }

        public void ScorePlay()
        {
            //this game type requires the rounds to be counted, and so starts at round 1
            int roundNum = 1;
            
            Console.WriteLine("Highest total score after 5 rounds!");

            //loops until the round number reaches 5 (5 loops)
            do
            {
                Console.WriteLine("\nRound {0}", roundNum);
                Console.WriteLine("\n{0}, its your turn to roll.", player1.name);

                Console.WriteLine("\nFirst 3 die:");

                //same as Match Play Method to store the rolled numbers
                List<int> threeRolls = new List<int>();

                for (int roll = 0; roll < 3; roll++)
                {

                    Console.WriteLine("{0}, press enter to roll your die.", player1.name);
                    Console.ReadKey();

                    threeRolls.Add(dice.Roll());
                    Console.WriteLine("You have rolled a {0}", threeRolls[roll]);

                }
                int[] firstThree = threeRolls.ToArray();
                Array.Sort(firstThree);
                Console.WriteLine("Your highest number rolled in your first 3 was a {0}", firstThree[2]);

                Console.WriteLine("\nSecond two die:");

                List<int> twoRolls = new List<int>();

                for (int roll = 0; roll < 2; roll++)
                {

                    Console.WriteLine("{0}, press enter to roll your die.", player1.name);
                    Console.ReadKey();

                    twoRolls.Add(dice.Roll());
                    Console.WriteLine("You have rolled a {0}", twoRolls[roll]);

                }
                int[] secondTwo = twoRolls.ToArray();
                Array.Sort(secondTwo);
                Console.WriteLine("Your highest number rolled in your second two was a {0}", secondTwo[1]);

                Console.WriteLine("\nLast dice:");

                Console.WriteLine("{0}, press enter to roll your die.", player1.name);
                Console.ReadKey();

                int lastOne = dice.Roll();
                Console.WriteLine("You have rolled a {0}", lastOne);

                //except, the round total is now the total of the 3 higest rolls
                int roundTotal = firstThree[2] + secondTwo[1] + lastOne;
                Console.WriteLine("\nYour total for this round is {0}", roundTotal);

                Console.WriteLine("\n{0}, its your turn to roll.", player2.name);

                Console.WriteLine("\nFirst 3 die:");

                List<int> threeRolls2 = new List<int>();

                for (int roll = 0; roll < 3; roll++)
                {

                    Console.WriteLine("{0}, press enter to roll your die.", player2.name);
                    Console.ReadKey();

                    threeRolls2.Add(dice.Roll());
                    Console.WriteLine("You have rolled a {0}", threeRolls2[roll]);

                }
                int[] firstThree2 = threeRolls2.ToArray();
                Array.Sort(firstThree2);
                Console.WriteLine("Your highest number rolled in your first 3 was a {0}", firstThree2[2]);

                Console.WriteLine("\nSecond two die:");

                List<int> twoRolls2 = new List<int>();

                for (int roll = 0; roll < 2; roll++)
                {

                    Console.WriteLine("{0}, press enter to roll your die.", player2.name);
                    Console.ReadKey();

                    twoRolls2.Add(dice.Roll());
                    Console.WriteLine("You have rolled a {0}", twoRolls2[roll]);

                }
                int[] secondTwo2 = twoRolls2.ToArray();
                Array.Sort(secondTwo2);
                Console.WriteLine("Your highest number rolled in your second two was a {0}", secondTwo2[1]);

                Console.WriteLine("\nLast dice:");

                Console.WriteLine("{0}, press enter to roll your die.", player2.name);
                Console.ReadKey();

                int lastOne2 = dice.Roll();
                Console.WriteLine("You have rolled a {0}", lastOne2);

                int roundTotal2 = firstThree2[2] + secondTwo2[1] + lastOne2;
                Console.WriteLine("\nYour total for this round is {0}", roundTotal2);

                //this adds the round total to the player score after each loop (5 rounds)
                player1.score += roundTotal;
                player2.score += roundTotal2;

                Console.WriteLine("\n{0}'s current score is: {1}", player1.name, player1.score);
                Console.WriteLine("{0}'s current score is: {1}", player2.name, player2.score);

                //increases the round number by one after each loop
                roundNum++;

            } while (roundNum != 5); //the loop stops after 5 rounds

            //the winner is decided by comparing the player scores after all 5 rounds have completed
            if (player1.score > player2.score)
            {
                Console.WriteLine("\nCongratulations {0}, you have won the game!", player1.name);
            }
            if (player1.score < player2.score)
            {
                Console.WriteLine("\nCongratulations {0}, you have won the game!", player2.name);
            }
            else if(player1.score == player2.score)
            {
                Console.WriteLine("This game was a draw!");
            }
            do
            {
                Console.Write("\nWould you to play again? (Y/N): ");
                playAgain = Console.ReadLine();

            } while ((playAgain != "Y") && (playAgain != "y") && (playAgain != "N") && (playAgain != "n"));
        }
    }
    class Program
    {
        //Program Class contains Main Method
        public static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the 'Going to Boston' Dice Game!");

            //created game object
            Game game = new Game();

            //calls the name method so the players can enter their names and only have to do it once until they exit the program
            game.Names();

            //runs the relevant game-type method based on user input
            string playType;
            //error handled by repeating question until correct input given
            do
            {
                Console.Write("Would you like Match play or Score play? M/S: ");
                playType = Console.ReadLine();

            } while ((playType != "M") && (playType != "m") && (playType != "S") && (playType != "s"));

                if ((playType == "M") || (playType == "m"))
                {
                    game.MatchPlay();
                }
                if ((playType == "S") || (playType == "s"))
                {
                    game.ScorePlay();
                }
                else
                {
                    Console.WriteLine("ERROR: Please enter 'M' or 'S'");
                }

                //if the players want to play again, runs the game-type Method that was initially chosen. If not, players are prompted to exit the application
                if (((game.playAgain == "Y") || (game.playAgain == "y")) && ((playType == "M") || (playType == "m")))
                {
                    game.MatchPlay();
                }
                if (((game.playAgain == "Y") || (game.playAgain == "y")) && ((playType == "S") || (playType == "s")))
                {
                    game.ScorePlay();
                }
                if((game.playAgain == "N")||(game.playAgain == "n"))
                {
                    Console.WriteLine("Press enter to exit the game.");                    
                }
                else
                {
                    Console.WriteLine("ERROR: Please enter 'Y' or 'N'");
                }
                        
            Console.ReadKey();
        }
    }
}
