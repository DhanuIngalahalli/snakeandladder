using System;

public class Program
{


	public static void Main()
	{
		int player = 0, position = 0, snakeposition = 0, loose, win, dice = 0;

		//Player Position at O position
		Console.WriteLine("Player position " + player);


		while (player != 100)
		{
			//rollling the die to get the die value
			Random random = new Random();
			int rollDic = random.Next(1, 7);
			dice = dice + 1;

			//checking whether the player ladder, snake or no play
			Random random2 = new Random();
			int check = random2.Next(0, 3);

			switch (check)
			{
				case 0:
					//Console.WriteLine ("NO PLAY");
					//player=100;
					break;
				case 1:
					player = player + rollDic;
					Console.WriteLine("position :" + player);
					break;
				case 2:
					player = player - rollDic;
					snakeposition = player - rollDic;
					//Console.WriteLine ("Player got Snake and his position "+player);
					break;

			}


			if (player == 100)
			{
				player = 100;
				win = player;
				Console.WriteLine();
				Console.WriteLine("win score is " + win);
			}
			else if (player >= 101)

			{
				player = 100;
				loose = position;
				Console.WriteLine();
				Console.WriteLine("loose score is: " + loose);
			}

			// Console.WriteLine ( "Player Loose the game ");
		}
		Console.WriteLine();
		Console.WriteLine("Number of time dice " + dice);

	}
}

