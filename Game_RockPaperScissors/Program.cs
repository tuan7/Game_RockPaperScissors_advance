using System;

namespace Game_RockPaperScissors
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			Console.WriteLine("Enter 1 if you play alone with computer or enter 2 if you have more than 2 players?");
			string paticipant_type = Console.ReadLine();
			int paticipantType = int.Parse(paticipant_type);
			RockPaperScissors play = new RockPaperScissors();

			int a = 0;
			int b = 0;
			switch (paticipantType)
			{
				case 1:
					Console.WriteLine("Enter your name");
					string participant_a = Console.ReadLine();
					play.SetUserA(participant_a);
					play.SetUserB("Computer");
					for (int i = 1; i < 10; i++)//it will be 10 games
					{ 
						Console.WriteLine(play.GetUserA() + ": Enter 1 for paper, 2 for rock, 3 for scissors");

						string user_A_Input = play.ReadPassword(); //get user A input (hidden text by using def. ReadPassword instead "Console.ReadLine()")
						a = int.Parse(user_A_Input);

						Random rnd = new Random();
						b = rnd.Next(1, 4); //random number generater by computer
						play.SetUserA_val(a);
						play.SetUserB_val(b);
						play.StartGame();
					}
					break;
				case 2:
					Console.WriteLine("How many players?");
					string num_of_players = Console.ReadLine();
					int numOfPlayers = int.Parse(num_of_players);
					play.SetNumOfPlayers(numOfPlayers);
					int[] players = new int[play.numOfPlayers];
					int rounds = 0;
					for (int i = 1; i < players.Length; i++) //Count number of rounds
					{
						rounds = rounds + (players.Length - i);
					}
					Console.WriteLine("You have : " + rounds + " rounds each other");
					for (int j = 1; j <= rounds; j++) 
					{
						Console.WriteLine("Rounds: " + j);

						Console.WriteLine("Enter player's name 1");
						string participantA = Console.ReadLine();
						play.SetUserA(participantA);
						Console.WriteLine(play.GetUserA() + ": Enter 1 for paper, 2 for rock, 3 for scissors");
						string user_A_Input = play.ReadPassword(); //get user B input (hidden text by using def. ReadPassword instead "Console.ReadLine()")
						a = int.Parse(user_A_Input);

						Console.WriteLine("Enter player's name 2");
						string participantB = Console.ReadLine();
						play.SetUserB(participantB);
						Console.WriteLine(play.GetUserB() + ": Enter 1 for paper, 2 for rock, 3 for scissors");
						string user_B_Input = play.ReadPassword(); //get user B input (hidden text by using def. ReadPassword instead "Console.ReadLine()")
						b = int.Parse(user_B_Input);

						play.SetUserA_val(a);
						play.SetUserB_val(b);
						play.StartGame();
					}

					break;
			}

			Console.WriteLine("Game over!");
		}

	}
}


