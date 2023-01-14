using System;
namespace Rock_Paper_Scissors
{
	public class RPS
	{
		public static void Game()
		{
			string playerChoice;
			string computerChoice;

            int playerCounter = 0; //Keeps player scores
            int computerCounter = 0; //Keeps computer scores
            Random rand = new Random();

			int i = 0;
			while (i == 0)
			{
				Console.WriteLine("Welcome to Rock, Paper and Scissor");
				Console.WriteLine();
				Console.WriteLine("Use r to select Rock, p to select Paper, s to select Scissor \n");
				Console.WriteLine("press q to quit\n");

                playerChoice = Console.ReadLine().ToLower();
				Console.Clear();
				Console.WriteLine();
				int computerNumChoice = rand.Next(1, 4);

				try
				{
					if (computerNumChoice == 1)
					{
						computerChoice = "r";
						Console.WriteLine($"Computer choice is rock");
						Console.WriteLine();
					}
					else if (computerNumChoice == 2)
					{
						computerChoice = "p";
						Console.WriteLine($"Computer choice is paper");
						Console.WriteLine();
					}
					else
					{
						computerChoice = "s";
						Console.WriteLine($"Computer choice is scissor");
						Console.WriteLine();
					}
					if (playerChoice == computerChoice)
					{
						Console.WriteLine("It's a tie\n");
					}
					else if (playerChoice == "r" && computerChoice == "s" || playerChoice == "s" && computerChoice == "p" || playerChoice == "p" && computerChoice == "r")
					{
						Console.WriteLine("=================\n=================\n====You won!!====\n=================\n=================\n");
						playerCounter++;
						Console.WriteLine();
					}
					else if (playerChoice == "q")
					{
                        Console.WriteLine($"The final scores is Player: {playerCounter} : Computer: {computerCounter}");
                        Thread.Sleep(1000);
                        i++;
					}
					else
					{
						Console.WriteLine("Computer won! and it's laughing at you\n");
						computerCounter++;
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("Bad input!");
				}
                Console.WriteLine($"The scores is Player: {playerCounter} : Computer: {computerCounter}\n");
            }
		}
	}
}
