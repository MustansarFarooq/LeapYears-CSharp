using System;
					
public class Program
{
	public static void Main()
	{
	
		Console.WriteLine("With reference to leap years, what would you like to do : \n\n 1: Find the next leap year \n 2: Find when the previous leap year was \n 3: Find whether or not the nth year is a leap year or not \n\n Input option 1,2, or 3\n\n");
		int option = Convert.ToInt32(Console.ReadLine());
		if(option == 1)
		{
			Console.WriteLine("Please enter the current year : ");
			int currentYear = Convert.ToInt32(Console.ReadLine());
			int[] next4Years = {currentYear+1,currentYear+2,currentYear+3,currentYear+4};
			for(int i =0; i<4; i++)
			{
				if((next4Years[i] % 4) == 0)
				{
					Console.WriteLine("The next leap year is " + next4Years[i]);
					Console.ReadLine();
				}

			}
		}
		
				if(option == 2)
		{
			Console.WriteLine("Please enter the current year : ");
			int currentYear = Convert.ToInt32(Console.ReadLine());
			int[] previous4Years = {currentYear-1,currentYear-2,currentYear-3,currentYear-4};
			for(int i =0; i<4; i++)
			{
				if((previous4Years[i] % 4) == 0)
				{
					Console.WriteLine("The previous leap year was " + previous4Years[i]);
					Console.ReadLine();
				}

			}
		}
		
		if(option == 3)
		{
			Console.WriteLine("Please enter the nth year : ");
			int n = Convert.ToInt32(Console.ReadLine());
			if(n  %4 == 0)
			{
				Console.WriteLine(n + " is a leap year");
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine(n+" is a leap year");
				Console.ReadLine();
			}

		}
		
	}
}