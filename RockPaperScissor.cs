using System;
class RockPaperScissor
{
	static void Main()
	{
		Console.WriteLine("Enter");
		int rock = 1;
		int paper = 2;
		int scissor = 3;
		int enter = int.Parse(Console.ReadLine());
		
		Random rnd = new Random();
        int r = rnd.Next(1, 4);   
		
		if(r == enter)
		
			Console.WriteLine("Enter again");
		
		if(r == 2 && enter == 1)
		Console.WriteLine("You lose");
		
		if(r == 1 && enter == 3)
		Console.WriteLine("You lose");
		
		else
		Console.WriteLine("Try again");
	}
}